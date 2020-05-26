namespace SenkiSaveEditor
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtSt5 = new System.Windows.Forms.TextBox();
            this.lblSt5 = new System.Windows.Forms.Label();
            this.txtSt4 = new System.Windows.Forms.TextBox();
            this.lblSt4 = new System.Windows.Forms.Label();
            this.txtSt3 = new System.Windows.Forms.TextBox();
            this.lblSt3 = new System.Windows.Forms.Label();
            this.txtSt2 = new System.Windows.Forms.TextBox();
            this.lblSt2 = new System.Windows.Forms.Label();
            this.txtSt1 = new System.Windows.Forms.TextBox();
            this.lblSt1 = new System.Windows.Forms.Label();
            this.txtSt0 = new System.Windows.Forms.TextBox();
            this.lblSt0 = new System.Windows.Forms.Label();
            this.txtGe10 = new System.Windows.Forms.TextBox();
            this.lblGe10 = new System.Windows.Forms.Label();
            this.txtGe9 = new System.Windows.Forms.TextBox();
            this.lblGe9 = new System.Windows.Forms.Label();
            this.txtGe8 = new System.Windows.Forms.TextBox();
            this.lblGe8 = new System.Windows.Forms.Label();
            this.txtGe7 = new System.Windows.Forms.TextBox();
            this.lblGe7 = new System.Windows.Forms.Label();
            this.txtGe6 = new System.Windows.Forms.TextBox();
            this.lblGe6 = new System.Windows.Forms.Label();
            this.txtGe5 = new System.Windows.Forms.TextBox();
            this.lblGe5 = new System.Windows.Forms.Label();
            this.txtGe4 = new System.Windows.Forms.TextBox();
            this.lblGe4 = new System.Windows.Forms.Label();
            this.txtGe3 = new System.Windows.Forms.TextBox();
            this.lblGe3 = new System.Windows.Forms.Label();
            this.txtGe2 = new System.Windows.Forms.TextBox();
            this.lblGe2 = new System.Windows.Forms.Label();
            this.txtGe1 = new System.Windows.Forms.TextBox();
            this.lblGe1 = new System.Windows.Forms.Label();
            this.txtGe0 = new System.Windows.Forms.TextBox();
            this.lblGe0 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstChar = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(662, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.saveAsToolStripMenuItem.Text = "Save &as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(190, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(639, 446);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtSt5);
            this.tabPage1.Controls.Add(this.lblSt5);
            this.tabPage1.Controls.Add(this.txtSt4);
            this.tabPage1.Controls.Add(this.lblSt4);
            this.tabPage1.Controls.Add(this.txtSt3);
            this.tabPage1.Controls.Add(this.lblSt3);
            this.tabPage1.Controls.Add(this.txtSt2);
            this.tabPage1.Controls.Add(this.lblSt2);
            this.tabPage1.Controls.Add(this.txtSt1);
            this.tabPage1.Controls.Add(this.lblSt1);
            this.tabPage1.Controls.Add(this.txtSt0);
            this.tabPage1.Controls.Add(this.lblSt0);
            this.tabPage1.Controls.Add(this.txtGe10);
            this.tabPage1.Controls.Add(this.lblGe10);
            this.tabPage1.Controls.Add(this.txtGe9);
            this.tabPage1.Controls.Add(this.lblGe9);
            this.tabPage1.Controls.Add(this.txtGe8);
            this.tabPage1.Controls.Add(this.lblGe8);
            this.tabPage1.Controls.Add(this.txtGe7);
            this.tabPage1.Controls.Add(this.lblGe7);
            this.tabPage1.Controls.Add(this.txtGe6);
            this.tabPage1.Controls.Add(this.lblGe6);
            this.tabPage1.Controls.Add(this.txtGe5);
            this.tabPage1.Controls.Add(this.lblGe5);
            this.tabPage1.Controls.Add(this.txtGe4);
            this.tabPage1.Controls.Add(this.lblGe4);
            this.tabPage1.Controls.Add(this.txtGe3);
            this.tabPage1.Controls.Add(this.lblGe3);
            this.tabPage1.Controls.Add(this.txtGe2);
            this.tabPage1.Controls.Add(this.lblGe2);
            this.tabPage1.Controls.Add(this.txtGe1);
            this.tabPage1.Controls.Add(this.lblGe1);
            this.tabPage1.Controls.Add(this.txtGe0);
            this.tabPage1.Controls.Add(this.lblGe0);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(631, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Characters";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtSt5
            // 
            this.txtSt5.Location = new System.Drawing.Point(512, 351);
            this.txtSt5.Name = "txtSt5";
            this.txtSt5.Size = new System.Drawing.Size(66, 20);
            this.txtSt5.TabIndex = 34;
            // 
            // lblSt5
            // 
            this.lblSt5.AutoSize = true;
            this.lblSt5.Location = new System.Drawing.Point(509, 335);
            this.lblSt5.Name = "lblSt5";
            this.lblSt5.Size = new System.Drawing.Size(42, 13);
            this.lblSt5.TabIndex = 33;
            this.lblSt5.Text = "Unk36:";
            // 
            // txtSt4
            // 
            this.txtSt4.Location = new System.Drawing.Point(512, 300);
            this.txtSt4.Name = "txtSt4";
            this.txtSt4.Size = new System.Drawing.Size(66, 20);
            this.txtSt4.TabIndex = 32;
            // 
            // lblSt4
            // 
            this.lblSt4.AutoSize = true;
            this.lblSt4.Location = new System.Drawing.Point(509, 284);
            this.lblSt4.Name = "lblSt4";
            this.lblSt4.Size = new System.Drawing.Size(34, 13);
            this.lblSt4.TabIndex = 31;
            this.lblSt4.Text = "Luck:";
            // 
            // txtSt3
            // 
            this.txtSt3.Location = new System.Drawing.Point(512, 246);
            this.txtSt3.Name = "txtSt3";
            this.txtSt3.Size = new System.Drawing.Size(66, 20);
            this.txtSt3.TabIndex = 30;
            // 
            // lblSt3
            // 
            this.lblSt3.AutoSize = true;
            this.lblSt3.Location = new System.Drawing.Point(509, 230);
            this.lblSt3.Name = "lblSt3";
            this.lblSt3.Size = new System.Drawing.Size(50, 13);
            this.lblSt3.TabIndex = 29;
            this.lblSt3.Text = "Defense:";
            // 
            // txtSt2
            // 
            this.txtSt2.Location = new System.Drawing.Point(512, 197);
            this.txtSt2.Name = "txtSt2";
            this.txtSt2.Size = new System.Drawing.Size(66, 20);
            this.txtSt2.TabIndex = 28;
            // 
            // lblSt2
            // 
            this.lblSt2.AutoSize = true;
            this.lblSt2.Location = new System.Drawing.Point(509, 181);
            this.lblSt2.Name = "lblSt2";
            this.lblSt2.Size = new System.Drawing.Size(41, 13);
            this.lblSt2.TabIndex = 27;
            this.lblSt2.Text = "Attack:";
            // 
            // txtSt1
            // 
            this.txtSt1.Location = new System.Drawing.Point(512, 145);
            this.txtSt1.Name = "txtSt1";
            this.txtSt1.Size = new System.Drawing.Size(66, 20);
            this.txtSt1.TabIndex = 26;
            // 
            // lblSt1
            // 
            this.lblSt1.AutoSize = true;
            this.lblSt1.Location = new System.Drawing.Point(509, 129);
            this.lblSt1.Name = "lblSt1";
            this.lblSt1.Size = new System.Drawing.Size(42, 13);
            this.lblSt1.TabIndex = 25;
            this.lblSt1.Text = "Cosmo:";
            // 
            // txtSt0
            // 
            this.txtSt0.Location = new System.Drawing.Point(512, 98);
            this.txtSt0.Name = "txtSt0";
            this.txtSt0.Size = new System.Drawing.Size(66, 20);
            this.txtSt0.TabIndex = 24;
            // 
            // lblSt0
            // 
            this.lblSt0.AutoSize = true;
            this.lblSt0.Location = new System.Drawing.Point(509, 82);
            this.lblSt0.Name = "lblSt0";
            this.lblSt0.Size = new System.Drawing.Size(43, 13);
            this.lblSt0.TabIndex = 23;
            this.lblSt0.Text = "Energy:";
            // 
            // txtGe10
            // 
            this.txtGe10.Location = new System.Drawing.Point(352, 300);
            this.txtGe10.Name = "txtGe10";
            this.txtGe10.Size = new System.Drawing.Size(118, 20);
            this.txtGe10.TabIndex = 22;
            // 
            // lblGe10
            // 
            this.lblGe10.AutoSize = true;
            this.lblGe10.Location = new System.Drawing.Point(349, 284);
            this.lblGe10.Name = "lblGe10";
            this.lblGe10.Size = new System.Drawing.Size(42, 13);
            this.lblGe10.TabIndex = 21;
            this.lblGe10.Text = "Unk28:";
            // 
            // txtGe9
            // 
            this.txtGe9.Location = new System.Drawing.Point(352, 246);
            this.txtGe9.Name = "txtGe9";
            this.txtGe9.Size = new System.Drawing.Size(118, 20);
            this.txtGe9.TabIndex = 20;
            // 
            // lblGe9
            // 
            this.lblGe9.AutoSize = true;
            this.lblGe9.Location = new System.Drawing.Point(349, 230);
            this.lblGe9.Name = "lblGe9";
            this.lblGe9.Size = new System.Drawing.Size(42, 13);
            this.lblGe9.TabIndex = 19;
            this.lblGe9.Text = "Unk24:";
            // 
            // txtGe8
            // 
            this.txtGe8.Location = new System.Drawing.Point(352, 197);
            this.txtGe8.Name = "txtGe8";
            this.txtGe8.Size = new System.Drawing.Size(118, 20);
            this.txtGe8.TabIndex = 18;
            // 
            // lblGe8
            // 
            this.lblGe8.AutoSize = true;
            this.lblGe8.Location = new System.Drawing.Point(349, 181);
            this.lblGe8.Name = "lblGe8";
            this.lblGe8.Size = new System.Drawing.Size(42, 13);
            this.lblGe8.TabIndex = 17;
            this.lblGe8.Text = "Unk20:";
            // 
            // txtGe7
            // 
            this.txtGe7.Location = new System.Drawing.Point(352, 145);
            this.txtGe7.Name = "txtGe7";
            this.txtGe7.Size = new System.Drawing.Size(118, 20);
            this.txtGe7.TabIndex = 16;
            // 
            // lblGe7
            // 
            this.lblGe7.AutoSize = true;
            this.lblGe7.Location = new System.Drawing.Point(349, 129);
            this.lblGe7.Name = "lblGe7";
            this.lblGe7.Size = new System.Drawing.Size(43, 13);
            this.lblGe7.TabIndex = 15;
            this.lblGe7.Text = "Unk1C:";
            // 
            // txtGe6
            // 
            this.txtGe6.Location = new System.Drawing.Point(352, 98);
            this.txtGe6.Name = "txtGe6";
            this.txtGe6.Size = new System.Drawing.Size(118, 20);
            this.txtGe6.TabIndex = 14;
            // 
            // lblGe6
            // 
            this.lblGe6.AutoSize = true;
            this.lblGe6.Location = new System.Drawing.Point(349, 82);
            this.lblGe6.Name = "lblGe6";
            this.lblGe6.Size = new System.Drawing.Size(42, 13);
            this.lblGe6.TabIndex = 13;
            this.lblGe6.Text = "Unk18:";
            // 
            // txtGe5
            // 
            this.txtGe5.Location = new System.Drawing.Point(196, 351);
            this.txtGe5.Name = "txtGe5";
            this.txtGe5.Size = new System.Drawing.Size(118, 20);
            this.txtGe5.TabIndex = 12;
            // 
            // lblGe5
            // 
            this.lblGe5.AutoSize = true;
            this.lblGe5.Location = new System.Drawing.Point(193, 335);
            this.lblGe5.Name = "lblGe5";
            this.lblGe5.Size = new System.Drawing.Size(42, 13);
            this.lblGe5.TabIndex = 11;
            this.lblGe5.Text = "Unk14:";
            // 
            // txtGe4
            // 
            this.txtGe4.Location = new System.Drawing.Point(196, 300);
            this.txtGe4.Name = "txtGe4";
            this.txtGe4.Size = new System.Drawing.Size(118, 20);
            this.txtGe4.TabIndex = 10;
            // 
            // lblGe4
            // 
            this.lblGe4.AutoSize = true;
            this.lblGe4.Location = new System.Drawing.Point(193, 284);
            this.lblGe4.Name = "lblGe4";
            this.lblGe4.Size = new System.Drawing.Size(42, 13);
            this.lblGe4.TabIndex = 9;
            this.lblGe4.Text = "Unk10:";
            // 
            // txtGe3
            // 
            this.txtGe3.Location = new System.Drawing.Point(196, 246);
            this.txtGe3.Name = "txtGe3";
            this.txtGe3.Size = new System.Drawing.Size(118, 20);
            this.txtGe3.TabIndex = 8;
            // 
            // lblGe3
            // 
            this.lblGe3.AutoSize = true;
            this.lblGe3.Location = new System.Drawing.Point(193, 230);
            this.lblGe3.Name = "lblGe3";
            this.lblGe3.Size = new System.Drawing.Size(43, 13);
            this.lblGe3.TabIndex = 7;
            this.lblGe3.Text = "Unk0C:";
            // 
            // txtGe2
            // 
            this.txtGe2.Location = new System.Drawing.Point(196, 197);
            this.txtGe2.Name = "txtGe2";
            this.txtGe2.Size = new System.Drawing.Size(118, 20);
            this.txtGe2.TabIndex = 6;
            // 
            // lblGe2
            // 
            this.lblGe2.AutoSize = true;
            this.lblGe2.Location = new System.Drawing.Point(193, 181);
            this.lblGe2.Name = "lblGe2";
            this.lblGe2.Size = new System.Drawing.Size(61, 13);
            this.lblGe2.TabIndex = 5;
            this.lblGe2.Text = "Accessible:";
            // 
            // txtGe1
            // 
            this.txtGe1.Location = new System.Drawing.Point(196, 145);
            this.txtGe1.Name = "txtGe1";
            this.txtGe1.Size = new System.Drawing.Size(118, 20);
            this.txtGe1.TabIndex = 4;
            // 
            // lblGe1
            // 
            this.lblGe1.AutoSize = true;
            this.lblGe1.Location = new System.Drawing.Point(193, 129);
            this.lblGe1.Name = "lblGe1";
            this.lblGe1.Size = new System.Drawing.Size(40, 13);
            this.lblGe1.TabIndex = 3;
            this.lblGe1.Text = "Status:";
            // 
            // txtGe0
            // 
            this.txtGe0.Location = new System.Drawing.Point(196, 98);
            this.txtGe0.Name = "txtGe0";
            this.txtGe0.Size = new System.Drawing.Size(118, 20);
            this.txtGe0.TabIndex = 2;
            // 
            // lblGe0
            // 
            this.lblGe0.AutoSize = true;
            this.lblGe0.Location = new System.Drawing.Point(193, 82);
            this.lblGe0.Name = "lblGe0";
            this.lblGe0.Size = new System.Drawing.Size(21, 13);
            this.lblGe0.TabIndex = 1;
            this.lblGe0.Text = "ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstChar);
            this.groupBox1.Location = new System.Drawing.Point(6, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select character";
            // 
            // lstChar
            // 
            this.lstChar.FormattingEnabled = true;
            this.lstChar.Location = new System.Drawing.Point(9, 23);
            this.lstChar.Name = "lstChar";
            this.lstChar.Size = new System.Drawing.Size(153, 303);
            this.lstChar.TabIndex = 2;
            this.lstChar.SelectedIndexChanged += new System.EventHandler(this.lstChar_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(631, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Game";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Work in progress...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Open a SAVEDATA file. (File -> Open or Ctrl+O)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 514);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Senki Savedata Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtGe1;
        private System.Windows.Forms.Label lblGe1;
        private System.Windows.Forms.TextBox txtGe0;
        private System.Windows.Forms.Label lblGe0;
        private System.Windows.Forms.TextBox txtGe2;
        private System.Windows.Forms.Label lblGe2;
        private System.Windows.Forms.TextBox txtGe3;
        private System.Windows.Forms.Label lblGe3;
        private System.Windows.Forms.TextBox txtGe4;
        private System.Windows.Forms.Label lblGe4;
        private System.Windows.Forms.TextBox txtSt5;
        private System.Windows.Forms.Label lblSt5;
        private System.Windows.Forms.TextBox txtSt4;
        private System.Windows.Forms.Label lblSt4;
        private System.Windows.Forms.TextBox txtSt3;
        private System.Windows.Forms.Label lblSt3;
        private System.Windows.Forms.TextBox txtSt2;
        private System.Windows.Forms.Label lblSt2;
        private System.Windows.Forms.TextBox txtSt1;
        private System.Windows.Forms.Label lblSt1;
        private System.Windows.Forms.TextBox txtSt0;
        private System.Windows.Forms.Label lblSt0;
        private System.Windows.Forms.TextBox txtGe10;
        private System.Windows.Forms.Label lblGe10;
        private System.Windows.Forms.TextBox txtGe9;
        private System.Windows.Forms.Label lblGe9;
        private System.Windows.Forms.TextBox txtGe8;
        private System.Windows.Forms.Label lblGe8;
        private System.Windows.Forms.TextBox txtGe7;
        private System.Windows.Forms.Label lblGe7;
        private System.Windows.Forms.TextBox txtGe6;
        private System.Windows.Forms.Label lblGe6;
        private System.Windows.Forms.TextBox txtGe5;
        private System.Windows.Forms.Label lblGe5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListBox lstChar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

