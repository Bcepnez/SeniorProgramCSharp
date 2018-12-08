namespace _3D_Reconstruction_from_UAV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uAVToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pointCloudToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveOutputDataToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uAVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointCloudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developerDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tab1Show = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.showArea = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogUAV = new System.Windows.Forms.SaveFileDialog();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.clickToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1079, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveOutputDataToFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uAVToolStripMenuItem1,
            this.pointCloudToolStripMenuItem1});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // uAVToolStripMenuItem1
            // 
            this.uAVToolStripMenuItem1.Name = "uAVToolStripMenuItem1";
            this.uAVToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.uAVToolStripMenuItem1.Text = "UAV";
            this.uAVToolStripMenuItem1.Click += new System.EventHandler(this.uAVToolStripMenuItem1_Click);
            // 
            // pointCloudToolStripMenuItem1
            // 
            this.pointCloudToolStripMenuItem1.Name = "pointCloudToolStripMenuItem1";
            this.pointCloudToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.pointCloudToolStripMenuItem1.Text = "Point Cloud";
            this.pointCloudToolStripMenuItem1.Click += new System.EventHandler(this.pointCloudToolStripMenuItem1_Click);
            // 
            // saveOutputDataToFileToolStripMenuItem
            // 
            this.saveOutputDataToFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uAVToolStripMenuItem,
            this.pointCloudToolStripMenuItem});
            this.saveOutputDataToFileToolStripMenuItem.Name = "saveOutputDataToFileToolStripMenuItem";
            this.saveOutputDataToFileToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.saveOutputDataToFileToolStripMenuItem.Text = "Save Output Data to File";
            // 
            // uAVToolStripMenuItem
            // 
            this.uAVToolStripMenuItem.Name = "uAVToolStripMenuItem";
            this.uAVToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.uAVToolStripMenuItem.Text = "UAV";
            this.uAVToolStripMenuItem.Click += new System.EventHandler(this.uAVToolStripMenuItem_Click);
            // 
            // pointCloudToolStripMenuItem
            // 
            this.pointCloudToolStripMenuItem.Name = "pointCloudToolStripMenuItem";
            this.pointCloudToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.pointCloudToolStripMenuItem.Text = "Point Cloud";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licenceToolStripMenuItem,
            this.developerDataToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // licenceToolStripMenuItem
            // 
            this.licenceToolStripMenuItem.Name = "licenceToolStripMenuItem";
            this.licenceToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.licenceToolStripMenuItem.Text = "License";
            this.licenceToolStripMenuItem.Click += new System.EventHandler(this.licenceToolStripMenuItem_Click);
            // 
            // developerDataToolStripMenuItem
            // 
            this.developerDataToolStripMenuItem.Name = "developerDataToolStripMenuItem";
            this.developerDataToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.developerDataToolStripMenuItem.Text = "Developer Data";
            this.developerDataToolStripMenuItem.Click += new System.EventHandler(this.developerDataToolStripMenuItem_Click);
            // 
            // clickToolStripMenuItem
            // 
            this.clickToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineToolStripMenuItem});
            this.clickToolStripMenuItem.Name = "clickToolStripMenuItem";
            this.clickToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.clickToolStripMenuItem.Text = "Click";
            this.clickToolStripMenuItem.Click += new System.EventHandler(this.clickToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Point Cloud Data files (*.csv)|*.csv";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1079, 664);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tab1Show);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1071, 635);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tab1Show
            // 
            this.tab1Show.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab1Show.Location = new System.Drawing.Point(9, 4);
            this.tab1Show.Margin = new System.Windows.Forms.Padding(4);
            this.tab1Show.Name = "tab1Show";
            this.tab1Show.Size = new System.Drawing.Size(1046, 622);
            this.tab1Show.TabIndex = 1;
            this.tab1Show.Text = "";
            this.tab1Show.TextChanged += new System.EventHandler(this.tab1Show_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1071, 635);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.showArea);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1063, 627);
            this.splitContainer1.SplitterDistance = 161;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // showArea
            // 
            this.showArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showArea.Location = new System.Drawing.Point(0, 0);
            this.showArea.Margin = new System.Windows.Forms.Padding(4);
            this.showArea.Name = "showArea";
            this.showArea.Size = new System.Drawing.Size(161, 627);
            this.showArea.TabIndex = 0;
            this.showArea.Text = "";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 627);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "Point Cloud Data files (*.csv)|*.csv|All file (*.*)|*.*";
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.lineToolStripMenuItem.Text = "Line";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 692);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "3D Reconstruction from UAV with LIDAR";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox showArea;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developerDataToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.RichTextBox tab1Show;
        private System.Windows.Forms.ToolStripMenuItem clickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveOutputDataToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uAVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointCloudToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogUAV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem uAVToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pointCloudToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
    }
}

