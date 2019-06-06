namespace SharpPython
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
            this.BtnRunPython = new System.Windows.Forms.Button();
            this.BtnDrawSVG = new System.Windows.Forms.Button();
            this.PictureSVGRender = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListChecked = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSVGRender)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnRunPython
            // 
            this.BtnRunPython.Location = new System.Drawing.Point(12, 783);
            this.BtnRunPython.Name = "BtnRunPython";
            this.BtnRunPython.Size = new System.Drawing.Size(108, 41);
            this.BtnRunPython.TabIndex = 0;
            this.BtnRunPython.Text = "RunPython";
            this.BtnRunPython.UseVisualStyleBackColor = true;
            this.BtnRunPython.Click += new System.EventHandler(this.BtnRunPython_Click);
            // 
            // BtnDrawSVG
            // 
            this.BtnDrawSVG.Location = new System.Drawing.Point(131, 783);
            this.BtnDrawSVG.Name = "BtnDrawSVG";
            this.BtnDrawSVG.Size = new System.Drawing.Size(108, 41);
            this.BtnDrawSVG.TabIndex = 1;
            this.BtnDrawSVG.Text = "DrawSVG";
            this.BtnDrawSVG.UseVisualStyleBackColor = true;
            this.BtnDrawSVG.Click += new System.EventHandler(this.BtnDrawSVG_Click);
            // 
            // PictureSVGRender
            // 
            this.PictureSVGRender.Location = new System.Drawing.Point(259, 31);
            this.PictureSVGRender.Name = "PictureSVGRender";
            this.PictureSVGRender.Size = new System.Drawing.Size(1047, 793);
            this.PictureSVGRender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureSVGRender.TabIndex = 2;
            this.PictureSVGRender.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 85);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1333, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // ListChecked
            // 
            this.ListChecked.FormattingEnabled = true;
            this.ListChecked.Location = new System.Drawing.Point(12, 118);
            this.ListChecked.Name = "ListChecked";
            this.ListChecked.Size = new System.Drawing.Size(227, 649);
            this.ListChecked.TabIndex = 9;
            this.ListChecked.SelectedIndexChanged += new System.EventHandler(this.ListChecked_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 836);
            this.Controls.Add(this.ListChecked);
            this.Controls.Add(this.PictureSVGRender);
            this.Controls.Add(this.BtnRunPython);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnDrawSVG);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Pic2Text";
            ((System.ComponentModel.ISupportInitialize)(this.PictureSVGRender)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRunPython;
        private System.Windows.Forms.Button BtnDrawSVG;
        private System.Windows.Forms.PictureBox PictureSVGRender;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        public System.Windows.Forms.CheckedListBox ListChecked;
    }
}

