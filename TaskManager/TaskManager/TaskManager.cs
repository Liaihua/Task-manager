using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Management.Instrumentation;

namespace TaskManager
{
    public partial class TaskManager : Form
    {
        Thread thread;
        delegate void newdelegate();

        Dictionary<int, Process> processes = Process.GetProcesses().ToDictionary(s => s.Id);

        PerformanceCounter CPUCount = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        
        //bool work = true;
        public TaskManager()
        {
            InitializeComponent();
            listView1.ContextMenuStrip = contextListViewMenuStrip;
            thread = new Thread(Show_Processes);
            thread.Start();
        }

        public void Show_Processes()
        {
            newdelegate del = new newdelegate(MainShowingThread);
            while (!listView1.IsDisposed)
            {
                //это тупо, надо повесить обработчик события закрытия окна
                try
                {
                    listView1?.Invoke(del);
                    Thread.Sleep(1000);
                }

                catch (Exception e)
                { }
            }
            del -= MainShowingThread;
        }

        Dictionary<int, ListViewItem> ListViewProcesses = new Dictionary<int, ListViewItem>();

        void MainShowingThread()
        {
            //listView1.Items.Clear();
            

            listView1.BeginUpdate();
            foreach (var process in processes)
            {
                if (!ListViewProcesses.ContainsKey(process.Key))
                {

                    ListViewItem ps = new ListViewItem(process.Key.ToString());
                    ps.Tag = process.Value.Id;
                    ps.SubItems.Add(process.Value.ProcessName.ToString());

                    ps.SubItems.Add(GetCPU(process.Value));
                    ps.SubItems.Add(new PerformanceCounter("Process", "Working Set - Private", process.Value.ProcessName).NextValue() / 1024 + " КГБ");

                    listView1?.Items.Add(ps);
                    ListViewProcesses.Add(process.Key, ps);
                }
                else
                {
                    ListViewProcesses[process.Key].SubItems[2].Text = GetCPU(process.Value).ToString();
                    ListViewProcesses[process.Key].SubItems[3].Text = (new PerformanceCounter("Process", "Working Set - Private", process.Value.ProcessName).NextValue() / 1024 + " КГБ");
                }
            }
            
            //listView1.Update();

            var deleted = ListViewProcesses.Where(s => !processes.ContainsKey(s.Key)).ToArray();

            foreach (var dictprocess in deleted)
            {
                listView1.Items.Remove(dictprocess.Value);
                ListViewProcesses.Remove(dictprocess.Key);
            }

            CPUTotal.Text = CPUCount.NextValue().ToString();
            MemTotal.Text = GetTotalMemory().ToString();
            listView1.EndUpdate();
        }

        private string GetCPU(Process process)
        {
            using (PerformanceCounter performance = new PerformanceCounter("Process", "% Processor Time", process.ProcessName))
            {
                return performance.NextValue() + "%";
            }
        }

        private string GetTotalMemory()
        {
            using (PerformanceCounter performance = new PerformanceCounter("Memory", "Available Bytes"))
            {
                return (int)(performance.NextValue()/1024) + "Кб";
            }
        }

        private void KillProcess(int ProcessId)
        {
            if (ListViewProcesses.ContainsKey(ProcessId))
            {
                var ToDelete = Process.GetProcessById(ProcessId);
                ToDelete.Kill();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //work = false;
            listView1.Dispose();
        }

        private void KillerButton_Click(object sender, EventArgs e)
        {
            Process RestInPeace = Process.GetProcessById(int.Parse(listView1.SelectedItems[0].Tag.ToString()));
            
            KillProcess(RestInPeace.Id);
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PriorityBbutton_Click(object sender, EventArgs e)
        {
            Process ChangedProcess = Process.GetProcessById(int.Parse(listView1.SelectedItems[0].Tag.ToString()));

        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process RestInPeace = Process.GetProcessById(int.Parse(listView1.SelectedItems[0].Tag.ToString()));
            
            KillProcess(RestInPeace.Id);
        }
    }
}
