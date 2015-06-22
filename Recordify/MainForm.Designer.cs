namespace Recordify
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRecord = new System.Windows.Forms.ToolStripButton();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.btnPause = new System.Windows.Forms.ToolStripButton();
            this.btnPlay = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSaveUncompressed = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSaveCompressed = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.recordingWoker = new System.ComponentModel.BackgroundWorker();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRecord,
            this.btnStop,
            this.btnPause,
            this.btnPlay,
            this.toolStripSeparator1,
            this.btnSaveUncompressed,
            this.toolStripSeparator2,
            this.btnSaveCompressed,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(697, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnRecord
            // 
            this.btnRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnRecord.Image")));
            this.btnRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(23, 22);
            this.btnRecord.Text = "toolStripButton1";
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnStop
            // 
            this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(23, 22);
            this.btnStop.Text = "toolStripButton2";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(23, 22);
            this.btnPause.Text = "toolStripButton5";
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(23, 22);
            this.btnPlay.Text = "toolStripButton3";
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSaveUncompressed
            // 
            this.btnSaveUncompressed.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSaveUncompressed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSaveUncompressed.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveUncompressed.Image")));
            this.btnSaveUncompressed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveUncompressed.Name = "btnSaveUncompressed";
            this.btnSaveUncompressed.Size = new System.Drawing.Size(117, 22);
            this.btnSaveUncompressed.Text = "Save Uncompressed";
            this.btnSaveUncompressed.Click += new System.EventHandler(this.btnSaveUncompressed_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSaveCompressed
            // 
            this.btnSaveCompressed.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSaveCompressed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSaveCompressed.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveCompressed.Image")));
            this.btnSaveCompressed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveCompressed.Name = "btnSaveCompressed";
            this.btnSaveCompressed.Size = new System.Drawing.Size(114, 22);
            this.btnSaveCompressed.Text = "Compress and Save";
            this.btnSaveCompressed.Click += new System.EventHandler(this.btnSaveCompressed_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // recordingWoker
            // 
            this.recordingWoker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.recordingWoker_DoWork);
            this.recordingWoker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.recordingWoker_ProgressChanged);
            this.recordingWoker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.recordingWoker_RunWorkerCompleted);
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 476);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(697, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // previewBox
            // 
            this.previewBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewBox.Location = new System.Drawing.Point(0, 49);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(697, 427);
            this.previewBox.TabIndex = 3;
            this.previewBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 498);
            this.Controls.Add(this.previewBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Recordify";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRecord;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ToolStripButton btnPause;
        private System.Windows.Forms.ToolStripButton btnPlay;
        private System.Windows.Forms.ToolStripButton btnSaveCompressed;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSaveUncompressed;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.ComponentModel.BackgroundWorker recordingWoker;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox previewBox;
    }
}

