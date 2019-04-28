namespace TaskManager
{
    partial class TaskManager
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KillerButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диспетчерЗадачToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.системныйЖурналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CPULabel = new System.Windows.Forms.Label();
            this.CPUTotal = new System.Windows.Forms.Label();
            this.MEMLabel = new System.Windows.Forms.Label();
            this.MemTotal = new System.Windows.Forms.Label();
            this.PriorityBbutton = new System.Windows.Forms.Button();
            this.contextListViewMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextListViewMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 507);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Process Name";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "CPU";
            this.columnHeader4.Width = 76;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Memory";
            this.columnHeader5.Width = 178;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Description";
            this.columnHeader6.Width = 338;
            // 
            // KillerButton
            // 
            this.KillerButton.Location = new System.Drawing.Point(689, 545);
            this.KillerButton.Name = "KillerButton";
            this.KillerButton.Size = new System.Drawing.Size(99, 23);
            this.KillerButton.TabIndex = 1;
            this.KillerButton.Text = "Kill process";
            this.KillerButton.UseVisualStyleBackColor = true;
            this.KillerButton.Click += new System.EventHandler(this.KillerButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главнаяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.диспетчерЗадачToolStripMenuItem,
            this.системныйЖурналToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.главнаяToolStripMenuItem.Text = "Главная";
            // 
            // диспетчерЗадачToolStripMenuItem
            // 
            this.диспетчерЗадачToolStripMenuItem.Name = "диспетчерЗадачToolStripMenuItem";
            this.диспетчерЗадачToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.диспетчерЗадачToolStripMenuItem.Text = "Диспетчер задач";
            // 
            // системныйЖурналToolStripMenuItem
            // 
            this.системныйЖурналToolStripMenuItem.Name = "системныйЖурналToolStripMenuItem";
            this.системныйЖурналToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.системныйЖурналToolStripMenuItem.Text = "Системный журнал";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItem_Click);
            // 
            // CPULabel
            // 
            this.CPULabel.AutoSize = true;
            this.CPULabel.Location = new System.Drawing.Point(12, 550);
            this.CPULabel.Name = "CPULabel";
            this.CPULabel.Size = new System.Drawing.Size(67, 13);
            this.CPULabel.TabIndex = 3;
            this.CPULabel.Text = "CPU usage: ";
            // 
            // CPUTotal
            // 
            this.CPUTotal.AutoSize = true;
            this.CPUTotal.Location = new System.Drawing.Point(98, 550);
            this.CPUTotal.Name = "CPUTotal";
            this.CPUTotal.Size = new System.Drawing.Size(36, 13);
            this.CPUTotal.TabIndex = 4;
            this.CPUTotal.Text = "0,00%";
            // 
            // MEMLabel
            // 
            this.MEMLabel.AutoSize = true;
            this.MEMLabel.Location = new System.Drawing.Point(200, 550);
            this.MEMLabel.Name = "MEMLabel";
            this.MEMLabel.Size = new System.Drawing.Size(92, 13);
            this.MEMLabel.TabIndex = 5;
            this.MEMLabel.Text = "Available memory:";
            // 
            // MemTotal
            // 
            this.MemTotal.AutoSize = true;
            this.MemTotal.Location = new System.Drawing.Point(310, 550);
            this.MemTotal.Name = "MemTotal";
            this.MemTotal.Size = new System.Drawing.Size(36, 13);
            this.MemTotal.TabIndex = 6;
            this.MemTotal.Text = "0,00%";
            // 
            // PriorityBbutton
            // 
            this.PriorityBbutton.Location = new System.Drawing.Point(568, 545);
            this.PriorityBbutton.Name = "PriorityBbutton";
            this.PriorityBbutton.Size = new System.Drawing.Size(100, 23);
            this.PriorityBbutton.TabIndex = 7;
            this.PriorityBbutton.Text = "Change priority";
            this.PriorityBbutton.UseVisualStyleBackColor = true;
            this.PriorityBbutton.Click += new System.EventHandler(this.PriorityBbutton_Click);
            // 
            // contextListViewMenuStrip
            // 
            this.contextListViewMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextListViewMenuStrip.Name = "contextListViewMenuStrip";
            this.contextListViewMenuStrip.Size = new System.Drawing.Size(181, 48);
            this.contextListViewMenuStrip.Tag = "";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Убить";
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.PriorityBbutton);
            this.Controls.Add(this.MemTotal);
            this.Controls.Add(this.MEMLabel);
            this.Controls.Add(this.CPUTotal);
            this.Controls.Add(this.CPULabel);
            this.Controls.Add(this.KillerButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TaskManager";
            this.Text = "Task Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextListViewMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button KillerButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem диспетчерЗадачToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem системныйЖурналToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label CPULabel;
        private System.Windows.Forms.Label CPUTotal;
        private System.Windows.Forms.Label MEMLabel;
        private System.Windows.Forms.Label MemTotal;
        private System.Windows.Forms.Button PriorityBbutton;
        private System.Windows.Forms.ContextMenuStrip contextListViewMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

