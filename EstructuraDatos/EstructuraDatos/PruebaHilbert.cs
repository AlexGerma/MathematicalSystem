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

namespace EstructuraDatos
{
    public partial class PruebaHilbert : Form
    {
        public PruebaHilbert()
        {
            InitializeComponent();
        }
        private bool DoRefresh;
        private float LastX, LastY;
        private Bitmap HilbertImage;
        private void btnGo_Click(object sender, EventArgs e)
        {
            int depth = int.Parse(txtDepth.Text);
            if (depth > 8)
            {
                if (MessageBox.Show("A large depth may take a long time to draw (and will be mostly black anyway). Do you want to continue?",
                    "Continue?", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }

            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            // See if we should refresh as we draw.
            DoRefresh = chkRefresh.Checked;

            // Get the parameters.
            float total_length, start_x, start_y, start_length;

            // See how big we can make the curve.
            if (picCanvas.ClientSize.Height < picCanvas.ClientSize.Width)
            {
                total_length = (float)(0.9 * picCanvas.ClientSize.Height);
            }
            else
            {
                total_length = (float)(0.9 * picCanvas.ClientSize.Width);
            }

            start_x = (picCanvas.ClientSize.Width - total_length) / 2;
            start_y = (picCanvas.ClientSize.Height - total_length) / 2;

            // Compute the side length for this level.
            start_length = (float)(total_length / (Math.Pow(2, depth) - 1));

            HilbertImage = new Bitmap(picCanvas.ClientSize.Width, picCanvas.ClientSize.Height);
            picCanvas.Image = HilbertImage;

            using (Graphics gr = Graphics.FromImage(HilbertImage))
            {
                // Draw the curve.
                gr.Clear(picCanvas.BackColor);
                LastX = (int)start_x;
                LastY = (int)start_y;
                Hilbert(gr, depth, start_length, 0);
            }

            // Display the result.
            picCanvas.Refresh();
            this.Cursor = Cursors.Default;
        }

        // Draw a Hilbert curve.
        private void Hilbert(Graphics gr, int depth, float dx, float dy)
        {
            if (depth > 1) Hilbert(gr, depth - 1, dy, dx);
            DrawRelative(gr, dx, dy);
            if (depth > 1) Hilbert(gr, depth - 1, dx, dy);
            DrawRelative(gr, dy, dx);
            if (depth > 1) Hilbert(gr, depth - 1, dx, dy);
            DrawRelative(gr, -dx, -dy);
            if (depth > 1) Hilbert(gr, depth - 1, -dy, -dx);

            if (DoRefresh) picCanvas.Refresh();
        }
        private void DrawRelative(Graphics gr, float dx, float dy)
        {
            gr.DrawLine(Pens.Black, LastX, LastY, LastX + dx, LastY + dy);
            LastX = LastX + dx;
            LastY = LastY + dy;
        }

        private void linkGuardaImagen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                }
                picCanvas.Image.Save(sfd.FileName, format);
            }
        }

        private void button1_Click(object sender, EventArgs e)=>this.Close();
        

        

      
        

        

        
    }
}
