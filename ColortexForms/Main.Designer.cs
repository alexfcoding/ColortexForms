namespace ColortexForms
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.BtnRunPython = new System.Windows.Forms.Button();
            this.PictureRenderer = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListProcessImg = new System.Windows.Forms.CheckedListBox();
            this.BtnResize = new System.Windows.Forms.Button();
            this.ListSourceImg = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pythonPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSavePath = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureRenderer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnRunPython
            // 
            this.BtnRunPython.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnRunPython.Location = new System.Drawing.Point(11, 1298);
            this.BtnRunPython.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnRunPython.Name = "BtnRunPython";
            this.BtnRunPython.Size = new System.Drawing.Size(185, 162);
            this.BtnRunPython.TabIndex = 0;
            this.BtnRunPython.Text = "Convert selected";
            this.BtnRunPython.UseVisualStyleBackColor = true;
            this.BtnRunPython.Click += new System.EventHandler(this.BtnRunPython_Click);
            // 
            // PictureRenderer
            // 
            this.PictureRenderer.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PictureRenderer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureRenderer.Location = new System.Drawing.Point(449, 113);
            this.PictureRenderer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PictureRenderer.Name = "PictureRenderer";
            this.PictureRenderer.Size = new System.Drawing.Size(1971, 1214);
            this.PictureRenderer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureRenderer.TabIndex = 2;
            this.PictureRenderer.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ListProcessImg);
            this.groupBox1.Controls.Add(this.BtnResize);
            this.groupBox1.Controls.Add(this.ListSourceImg);
            this.groupBox1.Controls.Add(this.BtnRunPython);
            this.groupBox1.Location = new System.Drawing.Point(22, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(416, 1471);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 668);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Processed images:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Source images:";
            // 
            // ListProcessImg
            // 
            this.ListProcessImg.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListProcessImg.FormattingEnabled = true;
            this.ListProcessImg.Location = new System.Drawing.Point(11, 698);
            this.ListProcessImg.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ListProcessImg.Name = "ListProcessImg";
            this.ListProcessImg.ScrollAlwaysVisible = true;
            this.ListProcessImg.Size = new System.Drawing.Size(391, 579);
            this.ListProcessImg.TabIndex = 13;
            this.ListProcessImg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListProcessImg_MouseClick);
            this.ListProcessImg.SelectedIndexChanged += new System.EventHandler(this.ListProcessImg_SelectedIndexChanged);
            // 
            // BtnResize
            // 
            this.BtnResize.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnResize.Location = new System.Drawing.Point(207, 1298);
            this.BtnResize.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnResize.Name = "BtnResize";
            this.BtnResize.Size = new System.Drawing.Size(198, 162);
            this.BtnResize.TabIndex = 12;
            this.BtnResize.Text = "Resize";
            this.BtnResize.UseVisualStyleBackColor = true;
            this.BtnResize.Click += new System.EventHandler(this.BtnResize_Click);
            // 
            // ListSourceImg
            // 
            this.ListSourceImg.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListSourceImg.Location = new System.Drawing.Point(11, 52);
            this.ListSourceImg.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ListSourceImg.Name = "ListSourceImg";
            this.ListSourceImg.ScrollAlwaysVisible = true;
            this.ListSourceImg.Size = new System.Drawing.Size(391, 579);
            this.ListSourceImg.TabIndex = 10;
            this.ListSourceImg.UseCompatibleTextRendering = true;
            this.ListSourceImg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListSourceImg_MouseClick);
            this.ListSourceImg.SelectedIndexChanged += new System.EventHandler(this.ListChecked_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(2444, 42);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 34);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(60, 34);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(68, 34);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // pythonPath
            // 
            this.pythonPath.Location = new System.Drawing.Point(583, 57);
            this.pythonPath.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pythonPath.Name = "pythonPath";
            this.pythonPath.Size = new System.Drawing.Size(739, 29);
            this.pythonPath.TabIndex = 14;
            this.pythonPath.Text = "C:\\Users\\Александр\\AppData\\Local\\Programs\\Python\\Python37-32\\python.exe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Python path:";
            // 
            // btnSavePath
            // 
            this.btnSavePath.Location = new System.Drawing.Point(1337, 55);
            this.btnSavePath.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSavePath.Name = "btnSavePath";
            this.btnSavePath.Size = new System.Drawing.Size(180, 41);
            this.btnSavePath.TabIndex = 16;
            this.btnSavePath.Text = "Save config";
            this.btnSavePath.UseVisualStyleBackColor = true;
            this.btnSavePath.Click += new System.EventHandler(this.btnSavePath_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2444, 1543);
            this.Controls.Add(this.btnSavePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pythonPath);
            this.Controls.Add(this.PictureRenderer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Main";
            this.Text = "ColortexForms";
            ((System.ComponentModel.ISupportInitialize)(this.PictureRenderer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRunPython;
        private System.Windows.Forms.PictureBox PictureRenderer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        public System.Windows.Forms.CheckedListBox ListSourceImg;
        private System.Windows.Forms.Button BtnResize;
        public System.Windows.Forms.CheckedListBox ListProcessImg;
        private System.Windows.Forms.TextBox pythonPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSavePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

