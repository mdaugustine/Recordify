using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using AviFile;

namespace Recordify
{
    enum Status
    {
        Stopped,
        Paused,
        Recording,
        Playback
    };

    public partial class MainForm : Form
    {
        Boolean recording;
        Status status;
        List<Bitmap> frames;

        public MainForm()
        {
            InitializeComponent();
            recordingWoker.WorkerReportsProgress = true;
            recordingWoker.WorkerSupportsCancellation = true;
            frames = new List<Bitmap>();
            btnStop.Enabled = false;
            btnPause.Enabled = false;
            btnPlay.Enabled = false;
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            //bitmaps.Clear();
            frames.Clear();
            status = Status.Recording;
            recording = true;
            btnRecord.Enabled = false;
            btnStop.Enabled = true;
            btnPlay.Enabled = false;
            //btnPause.Enabled = true;

            recordingWoker.RunWorkerAsync();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            status = Status.Stopped;
            recording = false;
            btnRecord.Enabled = true;
            btnStop.Enabled = false;
            btnPause.Enabled = false;
            btnPlay.Enabled = true;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            status = Status.Paused;
            recording = false;
            btnRecord.Enabled = true;
            btnStop.Enabled = false;
            btnPause.Enabled = false;
            btnPlay.Enabled = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            status = Status.Playback;
            statusLabel.Text = status.ToString();
            statusStrip1.Refresh();

            if (frames.Count > 0)
            {
                for (int i = 0; i < frames.Count; i++)
                {
                    previewBox.Image = frames[i];
                    previewBox.Refresh();
                    statusLabel.Text = "Playing Frame " + i;
                    statusStrip1.Refresh();
                    System.Threading.Thread.Sleep(40);
                }
            }
        }

        private void recordingWoker_DoWork(object sender, DoWorkEventArgs e)
        {
            statusLabel.Text = status.ToString();
            //statusStrip1.Refresh();

            BackgroundWorker worker = sender as BackgroundWorker;

            /*
            List<Bitmap> bitmaps = new List<Bitmap>();

            using (Bitmap bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                Screen.PrimaryScreen.Bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bmpScreenshot))
                {
                    while(recording)
                    {
                        g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);
                        bitmaps.Add(bmpScreenshot);
                        previewBox.Image = bmpScreenshot;
                    }
                }
            }

            e.Result = bitmaps;
            */

            Bitmap bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics g = Graphics.FromImage(bmpScreenshot);
            g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);

            List<Bitmap> bitmaps = new List<Bitmap>();

            while(recording)
            {
                bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                g = Graphics.FromImage(bmpScreenshot);
                g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);
                bitmaps.Add(bmpScreenshot);
                previewBox.Image = bmpScreenshot;
                //previewBox.Refresh();
            }

            e.Result = bitmaps;

            /*
            AviManager aviManager = new AviManager(@"..\..\testdata\new.avi", false);
            VideoStream aviStream = aviManager.AddVideoStream(true, 25, bitmaps[0]);

            for (int i = 1; i < bitmaps.Count; i++)
            {
                aviStream.AddFrame(bitmaps[i]);
                statusLabel.Text = "Compressing: " + i + "/" + (bitmaps.Count - 1);
            }

            aviManager.Close();
            */
        }

        private void recordingWoker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //frames = frames.Concat((List<Bitmap>)e.Result).ToList();
            frames = (List<Bitmap>)e.Result;

            statusLabel.Text = status.ToString();
            statusStrip1.Refresh();
        }

        private void btnSaveCompressed_Click(object sender, EventArgs e)
        {
            AviManager aviManager = new AviManager(@"..\..\testdata\new.avi", false);
            VideoStream aviStream = aviManager.AddVideoStream(true, 25, frames[0]);

            for (int i = 1; i < frames.Count; i++)
            {
                aviStream.AddFrame(frames[i]);
                statusLabel.Text = "Compressing: " + i + "/" + (frames.Count - 1);
                statusStrip1.Refresh();
            }

            aviManager.Close();

            frames.Clear();
            status = Status.Stopped;
        }

        private void btnSaveUncompressed_Click(object sender, EventArgs e)
        {
            AviManager aviManager = new AviManager(@"..\..\testdata\new.avi", false);
            VideoStream aviStream = aviManager.AddVideoStream(false, 25, frames[0]);

            for (int i = 1; i < frames.Count; i++)
            {
                aviStream.AddFrame(frames[i]);
                statusLabel.Text = "Compressing: " + i + "/" + (frames.Count - 1);
                statusStrip1.Refresh();
            }

            aviManager.Close();

            frames.Clear();
            status = Status.Stopped;
        }

        private void recordingWoker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }
    }
}
