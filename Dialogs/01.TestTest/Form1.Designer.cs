namespace _01.TestTest
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
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatFullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorFullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 29);
            this.fileToolStripMenuItem.Text = "file";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.openToolStripMenuItem.Text = "open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.saveToolStripMenuItem.Text = "save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.closeToolStripMenuItem.Text = "close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 126);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(761, 312);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatFullToolStripMenuItem,
            this.formatTextToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // formatFullToolStripMenuItem
            // 
            this.formatFullToolStripMenuItem.Name = "formatFullToolStripMenuItem";
            this.formatFullToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.formatFullToolStripMenuItem.Text = "FormatFull";
            this.formatFullToolStripMenuItem.Click += new System.EventHandler(this.formatFullToolStripMenuItem_Click);
            // 
            // formatTextToolStripMenuItem
            // 
            this.formatTextToolStripMenuItem.Name = "formatTextToolStripMenuItem";
            this.formatTextToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.formatTextToolStripMenuItem.Text = "FormatText";
            this.formatTextToolStripMenuItem.Click += new System.EventHandler(this.formatTextToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorBackToolStripMenuItem,
            this.colorFullToolStripMenuItem,
            this.colorTextToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // colorBackToolStripMenuItem
            // 
            this.colorBackToolStripMenuItem.Name = "colorBackToolStripMenuItem";
            this.colorBackToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.colorBackToolStripMenuItem.Text = "ColorBack";
            this.colorBackToolStripMenuItem.Click += new System.EventHandler(this.colorBackToolStripMenuItem_Click);
            // 
            // colorFullToolStripMenuItem
            // 
            this.colorFullToolStripMenuItem.Name = "colorFullToolStripMenuItem";
            this.colorFullToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.colorFullToolStripMenuItem.Text = "ColorFull";
            this.colorFullToolStripMenuItem.Click += new System.EventHandler(this.colorFullToolStripMenuItem_Click);
            // 
            // colorTextToolStripMenuItem
            // 
            this.colorTextToolStripMenuItem.Name = "colorTextToolStripMenuItem";
            this.colorTextToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.colorTextToolStripMenuItem.Text = "ColorText";
            this.colorTextToolStripMenuItem.Click += new System.EventHandler(this.colorTextToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatFullToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorFullToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorTextToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

