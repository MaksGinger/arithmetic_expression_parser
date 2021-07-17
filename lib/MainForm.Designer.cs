namespace Lab3_Yakovlev_Tree
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageTask = new System.Windows.Forms.TabPage();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label4 = new System.Windows.Forms.Label();
            this.expBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CreateTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TaskTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DestructTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageExit = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageTask.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPageExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAbout);
            this.tabControl1.Controls.Add(this.tabPageTask);
            this.tabControl1.Controls.Add(this.tabPageExit);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(566, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.pictureBox1);
            this.tabPageAbout.Controls.Add(this.label3);
            this.tabPageAbout.Controls.Add(this.label2);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 29);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbout.Size = new System.Drawing.Size(558, 405);
            this.tabPageAbout.TabIndex = 0;
            this.tabPageAbout.Text = "О программе";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(542, 359);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Задание:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(551, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Лабороторную выполнил Яковлев Максимилиан гр. 6104, Вариант 27.1\r\n";
            // 
            // tabPageTask
            // 
            this.tabPageTask.Controls.Add(this.treeView2);
            this.tabPageTask.Controls.Add(this.label5);
            this.tabPageTask.Controls.Add(this.btnDelete);
            this.tabPageTask.Controls.Add(this.btnShow);
            this.tabPageTask.Controls.Add(this.treeView1);
            this.tabPageTask.Controls.Add(this.label4);
            this.tabPageTask.Controls.Add(this.expBox);
            this.tabPageTask.Controls.Add(this.menuStrip1);
            this.tabPageTask.Location = new System.Drawing.Point(4, 29);
            this.tabPageTask.Name = "tabPageTask";
            this.tabPageTask.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTask.Size = new System.Drawing.Size(558, 405);
            this.tabPageTask.TabIndex = 1;
            this.tabPageTask.Text = "Задание";
            this.tabPageTask.UseVisualStyleBackColor = true;
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(382, 57);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(121, 337);
            this.treeView2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(355, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Дерево после обработки:";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(11, 156);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 26);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Очистить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(11, 327);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(96, 31);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Показать";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(168, 57);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 337);
            this.treeView1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 80);
            this.label4.TabIndex = 2;
            this.label4.Text = "Выражение:\r\n(можно в инфиксной\r\nсо скобками или без,\r\nпостфиксной, \r\nпрефиксной ф" +
    "ормах)";
            // 
            // expBox
            // 
            this.expBox.Location = new System.Drawing.Point(11, 124);
            this.expBox.Name = "expBox";
            this.expBox.Size = new System.Drawing.Size(143, 26);
            this.expBox.TabIndex = 1;
            this.expBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.expBox_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateTreeToolStripMenuItem,
            this.TaskTreeToolStripMenuItem,
            this.DestructTreeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(552, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CreateTreeToolStripMenuItem
            // 
            this.CreateTreeToolStripMenuItem.Name = "CreateTreeToolStripMenuItem";
            this.CreateTreeToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.CreateTreeToolStripMenuItem.Text = "Создание дерева";
            this.CreateTreeToolStripMenuItem.Click += new System.EventHandler(this.CreateTreeToolStripMenuItem_Click);
            // 
            // TaskTreeToolStripMenuItem
            // 
            this.TaskTreeToolStripMenuItem.Name = "TaskTreeToolStripMenuItem";
            this.TaskTreeToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.TaskTreeToolStripMenuItem.Text = "Обработка дерева";
            this.TaskTreeToolStripMenuItem.Click += new System.EventHandler(this.TaskTreeToolStripMenuItem_Click);
            // 
            // DestructTreeToolStripMenuItem
            // 
            this.DestructTreeToolStripMenuItem.Name = "DestructTreeToolStripMenuItem";
            this.DestructTreeToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.DestructTreeToolStripMenuItem.Text = "Разрушение дерева";
            this.DestructTreeToolStripMenuItem.Click += new System.EventHandler(this.DestructTreeToolStripMenuItem_Click);
            // 
            // tabPageExit
            // 
            this.tabPageExit.Controls.Add(this.btnExit);
            this.tabPageExit.Controls.Add(this.btnCancel);
            this.tabPageExit.Controls.Add(this.label1);
            this.tabPageExit.Location = new System.Drawing.Point(4, 29);
            this.tabPageExit.Name = "tabPageExit";
            this.tabPageExit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExit.Size = new System.Drawing.Size(558, 405);
            this.tabPageExit.TabIndex = 2;
            this.tabPageExit.Text = "Выход";
            this.tabPageExit.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(31, 270);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 36);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Да";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(461, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 36);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Нет";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы действительно хотите выйти из программмы?";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 435);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Лабороторная работа 3";
            this.tabControl1.ResumeLayout(false);
            this.tabPageAbout.ResumeLayout(false);
            this.tabPageAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageTask.ResumeLayout(false);
            this.tabPageTask.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPageExit.ResumeLayout(false);
            this.tabPageExit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.TabPage tabPageTask;
        private System.Windows.Forms.TabPage tabPageExit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CreateTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TaskTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DestructTreeToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox expBox;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Label label5;
    }
}

