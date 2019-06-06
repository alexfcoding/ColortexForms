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
            this.ListSourceImg = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnPreview = new System.Windows.Forms.Button();
            this.BtnResize = new System.Windows.Forms.Button();
            this.ListProcessImg = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSVGRender)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnRunPython
            // 
            this.BtnRunPython.Location = new System.Drawing.Point(6, 699);
            this.BtnRunPython.Name = "BtnRunPython";
            this.BtnRunPython.Size = new System.Drawing.Size(101, 41);
            this.BtnRunPython.TabIndex = 0;
            this.BtnRunPython.Text = "Convert selected";
            this.BtnRunPython.UseVisualStyleBackColor = true;
            this.BtnRunPython.Click += new System.EventHandler(this.BtnRunPython_Click);
            // 
            // BtnDrawSVG
            // 
            this.BtnDrawSVG.Location = new System.Drawing.Point(6, 750);
            this.BtnDrawSVG.Name = "BtnDrawSVG";
            this.BtnDrawSVG.Size = new System.Drawing.Size(101, 41);
            this.BtnDrawSVG.TabIndex = 1;
            this.BtnDrawSVG.Text = "DrawSVG";
            this.BtnDrawSVG.UseVisualStyleBackColor = true;
            this.BtnDrawSVG.Click += new System.EventHandler(this.BtnDrawSVG_Click);
            // 
            // PictureSVGRender
            // 
            this.PictureSVGRender.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PictureSVGRender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureSVGRender.Location = new System.Drawing.Point(245, 33);
            this.PictureSVGRender.Name = "PictureSVGRender";
            this.PictureSVGRender.Size = new System.Drawing.Size(1076, 790);
            this.PictureSVGRender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureSVGRender.TabIndex = 2;
            this.PictureSVGRender.TabStop = false;
            this.PictureSVGRender.Click += new System.EventHandler(this.PictureSVGRender_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListProcessImg);
            this.groupBox1.Controls.Add(this.BtnResize);
            this.groupBox1.Controls.Add(this.BtnPreview);
            this.groupBox1.Controls.Add(this.ListSourceImg);
            this.groupBox1.Controls.Add(this.BtnDrawSVG);
            this.groupBox1.Controls.Add(this.BtnRefresh);
            this.groupBox1.Controls.Add(this.BtnRunPython);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 797);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // ListSourceImg
            // 
            this.ListSourceImg.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListSourceImg.Location = new System.Drawing.Point(6, 33);
            this.ListSourceImg.MultiColumn = true;
            this.ListSourceImg.Name = "ListSourceImg";
            this.ListSourceImg.ScrollAlwaysVisible = true;
            this.ListSourceImg.Size = new System.Drawing.Size(215, 304);
            this.ListSourceImg.TabIndex = 10;
            this.ListSourceImg.UseCompatibleTextRendering = true;
            this.ListSourceImg.SelectedIndexChanged += new System.EventHandler(this.ListChecked_SelectedIndexChanged);
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
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(120, 699);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(101, 41);
            this.BtnRefresh.TabIndex = 10;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnPreview
            // 
            this.BtnPreview.Location = new System.Drawing.Point(6, 652);
            this.BtnPreview.Name = "BtnPreview";
            this.BtnPreview.Size = new System.Drawing.Size(215, 41);
            this.BtnPreview.TabIndex = 11;
            this.BtnPreview.Text = "Preview";
            this.BtnPreview.UseVisualStyleBackColor = true;
            this.BtnPreview.Click += new System.EventHandler(this.BtnPreview_Click);
            // 
            // BtnResize
            // 
            this.BtnResize.Location = new System.Drawing.Point(120, 750);
            this.BtnResize.Name = "BtnResize";
            this.BtnResize.Size = new System.Drawing.Size(101, 41);
            this.BtnResize.TabIndex = 12;
            this.BtnResize.Text = "Resize";
            this.BtnResize.UseVisualStyleBackColor = true;
            this.BtnResize.Click += new System.EventHandler(this.BtnResize_Click);
            // 
            // ListProcessImg
            // 
            this.ListProcessImg.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListProcessImg.FormattingEnabled = true;
            this.ListProcessImg.Location = new System.Drawing.Point(6, 343);
            this.ListProcessImg.MultiColumn = true;
            this.ListProcessImg.Name = "ListProcessImg";
            this.ListProcessImg.ScrollAlwaysVisible = true;
            this.ListProcessImg.Size = new System.Drawing.Size(215, 304);
            this.ListProcessImg.TabIndex = 13;
            this.ListProcessImg.SelectedIndexChanged += new System.EventHandler(this.ListProcessImg_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 836);
            this.Controls.Add(this.PictureSVGRender);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Pic2Text";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureSVGRender)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Button BtnRefresh;
        public System.Windows.Forms.CheckedListBox ListSourceImg;
        private System.Windows.Forms.Button BtnPreview;
        private System.Windows.Forms.Button BtnResize;
        public System.Windows.Forms.CheckedListBox ListProcessImg;
    }
}

