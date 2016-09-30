namespace fileManager
{
    partial class frmFileManager
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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBackupNow = new System.Windows.Forms.TabPage();
            this.tabBackupLater = new System.Windows.Forms.TabPage();
            this.btnSelectSource = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.btnSelectDest = new System.Windows.Forms.Button();
            this.btnBackupNow = new System.Windows.Forms.Button();
            this.btnRemember = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabBackupNow.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(606, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentationToolStripMenuItem,
            this.fAQsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.documentationToolStripMenuItem.Text = "&Documentation";
            this.documentationToolStripMenuItem.Click += new System.EventHandler(this.documentationToolStripMenuItem_Click);
            // 
            // fAQsToolStripMenuItem
            // 
            this.fAQsToolStripMenuItem.Name = "fAQsToolStripMenuItem";
            this.fAQsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.fAQsToolStripMenuItem.Text = "FA&Qs";
            this.fAQsToolStripMenuItem.Click += new System.EventHandler(this.fAQsToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBackupNow);
            this.tabControl1.Controls.Add(this.tabBackupLater);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(606, 227);
            this.tabControl1.TabIndex = 4;
            // 
            // tabBackupNow
            // 
            this.tabBackupNow.Controls.Add(this.btnRemember);
            this.tabBackupNow.Controls.Add(this.btnBackupNow);
            this.tabBackupNow.Controls.Add(this.label1);
            this.tabBackupNow.Controls.Add(this.txtDest);
            this.tabBackupNow.Controls.Add(this.btnSelectDest);
            this.tabBackupNow.Controls.Add(this.lblSource);
            this.tabBackupNow.Controls.Add(this.txtSource);
            this.tabBackupNow.Controls.Add(this.btnSelectSource);
            this.tabBackupNow.Location = new System.Drawing.Point(4, 22);
            this.tabBackupNow.Name = "tabBackupNow";
            this.tabBackupNow.Padding = new System.Windows.Forms.Padding(3);
            this.tabBackupNow.Size = new System.Drawing.Size(598, 201);
            this.tabBackupNow.TabIndex = 0;
            this.tabBackupNow.Text = "Backup Now!";
            this.tabBackupNow.UseVisualStyleBackColor = true;
            // 
            // tabBackupLater
            // 
            this.tabBackupLater.Location = new System.Drawing.Point(4, 22);
            this.tabBackupLater.Name = "tabBackupLater";
            this.tabBackupLater.Padding = new System.Windows.Forms.Padding(3);
            this.tabBackupLater.Size = new System.Drawing.Size(598, 201);
            this.tabBackupLater.TabIndex = 1;
            this.tabBackupLater.Text = "Backup Later";
            this.tabBackupLater.UseVisualStyleBackColor = true;
            // 
            // btnSelectSource
            // 
            this.btnSelectSource.Location = new System.Drawing.Point(515, 53);
            this.btnSelectSource.Name = "btnSelectSource";
            this.btnSelectSource.Size = new System.Drawing.Size(75, 23);
            this.btnSelectSource.TabIndex = 0;
            this.btnSelectSource.Text = "...";
            this.btnSelectSource.UseVisualStyleBackColor = true;
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(8, 53);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(501, 20);
            this.txtSource.TabIndex = 1;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(8, 37);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(114, 13);
            this.lblSource.TabIndex = 2;
            this.lblSource.Text = "Backup This Location:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Save To This Location:";
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(8, 97);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(501, 20);
            this.txtDest.TabIndex = 4;
            // 
            // btnSelectDest
            // 
            this.btnSelectDest.Location = new System.Drawing.Point(515, 97);
            this.btnSelectDest.Name = "btnSelectDest";
            this.btnSelectDest.Size = new System.Drawing.Size(75, 23);
            this.btnSelectDest.TabIndex = 3;
            this.btnSelectDest.Text = "...";
            this.btnSelectDest.UseVisualStyleBackColor = true;
            // 
            // btnBackupNow
            // 
            this.btnBackupNow.Location = new System.Drawing.Point(422, 158);
            this.btnBackupNow.Name = "btnBackupNow";
            this.btnBackupNow.Size = new System.Drawing.Size(168, 23);
            this.btnBackupNow.TabIndex = 6;
            this.btnBackupNow.Text = "Backup Now!";
            this.btnBackupNow.UseVisualStyleBackColor = true;
            // 
            // btnRemember
            // 
            this.btnRemember.Location = new System.Drawing.Point(11, 158);
            this.btnRemember.Name = "btnRemember";
            this.btnRemember.Size = new System.Drawing.Size(168, 23);
            this.btnRemember.TabIndex = 7;
            this.btnRemember.Text = "Remember These Locations";
            this.btnRemember.UseVisualStyleBackColor = true;
            this.btnRemember.Click += new System.EventHandler(this.btnRemember_Click);
            // 
            // frmFileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 317);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmFileManager";
            this.Text = "File Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabBackupNow.ResumeLayout(false);
            this.tabBackupNow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQsToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBackupNow;
        private System.Windows.Forms.TabPage tabBackupLater;
        private System.Windows.Forms.Button btnRemember;
        private System.Windows.Forms.Button btnBackupNow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Button btnSelectDest;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnSelectSource;
    }
}

