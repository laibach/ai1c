using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AllInOneCase
{
    public partial class AIOC : Form
    {
        public static bool mouseIsDown = false;
        public static Point firstPoint;

        public Object O2S = null;
        public String O2S_Type = "";

        public AIOC()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
            mouseIsDown = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                // Get the difference between the two points
                int xDiff = firstPoint.X - e.Location.X;
                int yDiff = firstPoint.Y - e.Location.Y;

                // Set the new point
                int x = this.Location.X - xDiff;
                int y = this.Location.Y - yDiff;
                this.Location = new Point(x, y);
            }
        }

        private void AnimateIcon()
        {
            int endx = this.Size.Width + 30;
            int endy = this.Size.Height + 30;
            int endx1 = this.Size.Width;
            int endy1 = this.Size.Height;
            bool done = false;

            while (done == false)
            {
                done = true;
                if (this.Size.Width < endx)
                {
                    this.Location = new Point(this.Location.X - 1, this.Location.Y);
                    this.Size = new Size(this.Size.Width + 1, this.Size.Height);
                    done = false;
                }
                if (this.Size.Height < endy)
                {
                    this.Size = new Size(this.Size.Width, this.Size.Height + 1);
                    this.Location = new Point(this.Location.X, this.Location.Y - 1);
                    done = false;
                }
                this.Refresh();
                System.Threading.Thread.Sleep(2);
            }

            done = false;
            while (done == false)
            {
                done = true;
                if (this.Size.Width > endx1)
                {
                    this.Location = new Point(this.Location.X + 1, this.Location.Y);
                    this.Size = new Size(this.Size.Width - 1, this.Size.Height);
                    done = false;
                }
                if (this.Size.Height > endy1)
                {
                    this.Size = new Size(this.Size.Width, this.Size.Height - 1);
                    this.Location = new Point(this.Location.X, this.Location.Y + 1);
                    done = false;
                }
                this.Refresh();
                System.Threading.Thread.Sleep(2);
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            AnimateIcon();

            ChooseCase cc = new ChooseCase();
            cc.StartModus = "Case auswählen";

            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy; // Okay
                cc.Object2Store = e.Data.GetData(DataFormats.Text);
                // MessageBox.Show("Text: " + e.Data.GetData(DataFormats.Text).ToString() );
            }

            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy; // Okay
                cc.Object2Store = e.Data.GetData(DataFormats.Bitmap);
                // e.Effect = DragDropEffects.None; // Unknown data, ignore it
                // MessageBox.Show("Bitmap");
            }

            if (e.Data.GetDataPresent(DataFormats.CommaSeparatedValue))
            {
                e.Effect = DragDropEffects.Copy;
                cc.Object2Store = e.Data.GetData(DataFormats.CommaSeparatedValue);
                cc.Object2Store_Type = "CSV";
                // MessageBox.Show("CSV: " + e.Data.GetData(DataFormats.Text).ToString());
            }

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                cc.Object2Store = e.Data.GetData(DataFormats.FileDrop);
                cc.Object2Store_Type = "FileList";
            }

            if (e.Data.GetDataPresent(DataFormats.Html))
            {
                e.Effect = DragDropEffects.Copy;
                cc.Object2Store = e.Data.GetData(DataFormats.Html);
                cc.Object2Store_Type = "Html";
            }

            if (e.Data.GetDataPresent(DataFormats.Rtf))
            {
                e.Effect = DragDropEffects.Copy;
                cc.Object2Store = e.Data.GetData(DataFormats.Rtf);
                cc.Object2Store_Type = "Rtf";
            }

            if (e.Data.GetDataPresent(DataFormats.WaveAudio))
            {
                e.Effect = DragDropEffects.Copy;
                cc.Object2Store = e.Data.GetData(DataFormats.WaveAudio);
                cc.Object2Store_Type = "WaveAudio";
            }

            if (cc.Object2Store_Type != "")
                cc.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AIOC_DragEnter(object sender, DragEventArgs e)
        {
            testForStuff(e);
        }

        private void testForStuff(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy; // Okay
                O2S = e.Data.GetData(DataFormats.Text);
                O2S_Type = "Text";
            }
            
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy; // Okay
                O2S = e.Data.GetData(DataFormats.Bitmap);
                O2S_Type = "Bitmap";
                // e.Effect = DragDropEffects.None; // Unknown data, ignore it
                // MessageBox.Show("Bitmap");
            }

            if (e.Data.GetDataPresent(DataFormats.CommaSeparatedValue))
            {
                e.Effect = DragDropEffects.Copy;
                O2S = e.Data.GetData(DataFormats.CommaSeparatedValue);
                O2S_Type = "CSV";
                // MessageBox.Show("CSV: " + e.Data.GetData(DataFormats.Text).ToString());
            }

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                O2S = e.Data.GetData(DataFormats.FileDrop);
                O2S_Type = "FileList";
            }

            if (e.Data.GetDataPresent(DataFormats.Html))
            {
                e.Effect = DragDropEffects.Copy;
                O2S = e.Data.GetData(DataFormats.Html);
                O2S_Type = "Html";
            }

            if (e.Data.GetDataPresent(DataFormats.Rtf))
            {
                e.Effect = DragDropEffects.Copy;
                O2S = e.Data.GetData(DataFormats.Rtf);
                O2S_Type = "Rtf";
            }

            if (e.Data.GetDataPresent(DataFormats.WaveAudio))
            {
                e.Effect = DragDropEffects.Copy;
                O2S = e.Data.GetData(DataFormats.WaveAudio);
                O2S_Type = "WaveAudio";
            }
        }

        private void einfuegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnimateIcon();

            ChooseCase cc = new ChooseCase();
            cc.StartModus = "Case auswählen";

            if (Clipboard.ContainsText())
            {
                cc.Object2Store = Clipboard.GetText();
                cc.Object2Store_Type = "Text";
                // MessageBox.Show(Clipboard.GetText());
            }
            else if (Clipboard.ContainsData(DataFormats.Bitmap))
            {
                cc.Object2Store = Clipboard.GetImage();
                cc.Object2Store_Type = "Bitmap";
                // MessageBox.Show("Bitmap");
            }
            else if (Clipboard.ContainsFileDropList())
            {
                cc.Object2Store = Clipboard.GetFileDropList();
                cc.Object2Store_Type = "FileList";
            }
            else if (Clipboard.ContainsImage())
            {
                cc.Object2Store = Clipboard.GetImage();
                cc.Object2Store_Type = "Image";
                // MessageBox.Show("Image");
            }
            else if (Clipboard.ContainsAudio())
            {
                cc.Object2Store = Clipboard.GetAudioStream();
                cc.Object2Store_Type = "AudioStream";
                // MessageBox.Show("Audio");
            }

            if (cc.Object2Store_Type != "")
                cc.Show();
        }

        private void casesVerwaltenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseCase cc = new ChooseCase();
            cc.StartModus = "Case verwalten";
            cc.Show();
        }

        private void AIOC_DoubleClick(object sender, EventArgs e)
        {
            doTheDoubleClick();
        }

        private void doTheDoubleClick()
        {
            HideKlammer();
        }

        private void HideKlammer()
        {
            this.ShowInTaskbar = false;
            this.notifyIcon1.Visible = true;
            this.Visible = false;
        }

        private void AIOC_Resize(object sender, EventArgs e)
        {
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            showKlammer();
        }

        private void showKlammer()
        {
            this.ShowInTaskbar = false;
            this.notifyIcon1.Visible = false;
            this.Visible = true;
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            contextMenuStripAIOC.Show(MousePosition);
        }

        private void contextMenuStripAIOC_MouseLeave(object sender, EventArgs e)
        {
            // Wenn im Tray
            if (this.notifyIcon1.Visible == true)
            {
                contextMenuStripAIOC.Close();
            }
        }

        private void symbolAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (symbolAnzeigenToolStripMenuItem.Text == "Symbol verstecken")
                HideKlammer();
            else
                showKlammer();
        }

        private void contextMenuStripAIOC_Opening(object sender, CancelEventArgs e)
        {
            if (this.Visible == true)
            {
                symbolAnzeigenToolStripMenuItem.Text = "Symbol verstecken";
                // symbolAnzeigenToolStripMenuItem.Visible = false;
            }
            else
            {
                symbolAnzeigenToolStripMenuItem.Text = "Symbol anzeigen";
                // symbolAnzeigenToolStripMenuItem.Visible = true;
            }
        }

    }
}
