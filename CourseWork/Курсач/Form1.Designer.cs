namespace TaskManager
{
    partial class Taskmanager
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tags = new System.Windows.Forms.Label();
            this.Performer = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.tbTags = new System.Windows.Forms.TextBox();
            this.tbPerformer = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Ivory;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.GridColor = System.Drawing.Color.OrangeRed;
            this.dataGridView1.Location = new System.Drawing.Point(135, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(614, 280);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "toolStripMenuItem4";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem5.Text = "toolStripMenuItem5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Tags);
            this.groupBox1.Controls.Add(this.Performer);
            this.groupBox1.Controls.Add(this.Title);
            this.groupBox1.Controls.Add(this.Data);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Clear);
            this.groupBox1.Controls.Add(this.Save);
            this.groupBox1.Controls.Add(this.tbTags);
            this.groupBox1.Controls.Add(this.tbPerformer);
            this.groupBox1.Controls.Add(this.tbTitle);
            this.groupBox1.Controls.Add(this.tbData);
            this.groupBox1.Location = new System.Drawing.Point(755, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 254);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // Tags
            // 
            this.Tags.AutoSize = true;
            this.Tags.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tags.ForeColor = System.Drawing.Color.DarkBlue;
            this.Tags.Location = new System.Drawing.Point(121, 149);
            this.Tags.Name = "Tags";
            this.Tags.Size = new System.Drawing.Size(40, 17);
            this.Tags.TabIndex = 10;
            this.Tags.Text = "Tags";
            // 
            // Performer
            // 
            this.Performer.AutoSize = true;
            this.Performer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Performer.ForeColor = System.Drawing.Color.DarkBlue;
            this.Performer.Location = new System.Drawing.Point(118, 113);
            this.Performer.Name = "Performer";
            this.Performer.Size = new System.Drawing.Size(71, 17);
            this.Performer.TabIndex = 9;
            this.Performer.Text = "Performer";
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Title.ForeColor = System.Drawing.Color.DarkBlue;
            this.Title.Location = new System.Drawing.Point(121, 76);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(35, 17);
            this.Title.TabIndex = 8;
            this.Title.Text = "Title";
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Data.ForeColor = System.Drawing.Color.DarkBlue;
            this.Data.Location = new System.Drawing.Point(118, 43);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(38, 17);
            this.Data.TabIndex = 7;
            this.Data.Text = "Data";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(75, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search";
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Clear.ForeColor = System.Drawing.Color.Orange;
            this.Clear.Location = new System.Drawing.Point(107, 202);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(82, 43);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Save.ForeColor = System.Drawing.Color.Orange;
            this.Save.Location = new System.Drawing.Point(6, 202);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(84, 43);
            this.Save.TabIndex = 4;
            this.Save.Text = "Search";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbTags
            // 
            this.tbTags.Location = new System.Drawing.Point(6, 146);
            this.tbTags.Name = "tbTags";
            this.tbTags.Size = new System.Drawing.Size(100, 20);
            this.tbTags.TabIndex = 3;
            // 
            // tbPerformer
            // 
            this.tbPerformer.Location = new System.Drawing.Point(6, 110);
            this.tbPerformer.Name = "tbPerformer";
            this.tbPerformer.Size = new System.Drawing.Size(100, 20);
            this.tbPerformer.TabIndex = 2;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(6, 73);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(100, 20);
            this.tbTitle.TabIndex = 1;
            // 
            // tbData
            // 
            this.tbData.HideSelection = false;
            this.tbData.Location = new System.Drawing.Point(6, 40);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(100, 20);
            this.tbData.TabIndex = 0;
            this.tbData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, -1);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip2.Size = new System.Drawing.Size(117, 28);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTaskToolStripMenuItem,
            this.outToolStripMenuItem,
            this.removeTaskToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(134, 280);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addTaskToolStripMenuItem
            // 
            this.addTaskToolStripMenuItem.AutoSize = false;
            this.addTaskToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.addTaskToolStripMenuItem.ForeColor = System.Drawing.Color.Orange;
            this.addTaskToolStripMenuItem.Name = "addTaskToolStripMenuItem";
            this.addTaskToolStripMenuItem.Size = new System.Drawing.Size(134, 60);
            this.addTaskToolStripMenuItem.Text = "Add Task";
            this.addTaskToolStripMenuItem.Click += new System.EventHandler(this.addTaskToolStripMenuItem_Click_1);
            // 
            // outToolStripMenuItem
            // 
            this.outToolStripMenuItem.AutoSize = false;
            this.outToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.outToolStripMenuItem.ForeColor = System.Drawing.Color.Orange;
            this.outToolStripMenuItem.Name = "outToolStripMenuItem";
            this.outToolStripMenuItem.Size = new System.Drawing.Size(134, 60);
            this.outToolStripMenuItem.Text = "Out";
            this.outToolStripMenuItem.Click += new System.EventHandler(this.outToolStripMenuItem_Click_1);
            // 
            // removeTaskToolStripMenuItem
            // 
            this.removeTaskToolStripMenuItem.AutoSize = false;
            this.removeTaskToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.removeTaskToolStripMenuItem.ForeColor = System.Drawing.Color.Orange;
            this.removeTaskToolStripMenuItem.Name = "removeTaskToolStripMenuItem";
            this.removeTaskToolStripMenuItem.Size = new System.Drawing.Size(134, 60);
            this.removeTaskToolStripMenuItem.Text = "Remove Task";
            this.removeTaskToolStripMenuItem.Click += new System.EventHandler(this.removeTaskToolStripMenuItem_Click_1);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.AutoSize = false;
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.Orange;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(134, 60);
            this.editToolStripMenuItem.Text = "Edit Task";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // Taskmanager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 289);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip1);
            this.MinimizeBox = false;
            this.Name = "Taskmanager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Task Manager";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Tags;
        private System.Windows.Forms.Label Performer;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox tbTags;
        private System.Windows.Forms.TextBox tbPerformer;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}
