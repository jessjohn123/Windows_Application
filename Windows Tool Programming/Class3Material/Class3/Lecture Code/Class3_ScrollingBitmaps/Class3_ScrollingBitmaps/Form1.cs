using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class3_ScrollingBitmaps
{
    public partial class Form1 : Form
    {
        Bitmap bitmap = Properties.Resources._default;

        public Form1()
        {
            InitializeComponent();

            // Set DPI
            Graphics g = panel1.CreateGraphics();
            bitmap.SetResolution(g.DpiX, g.DpiY);
            g.Dispose();

            panel1.AutoScrollMinSize = bitmap.Size;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Calc where normally drawn if not scrolled
            Point offset = new Point(0, 0);

            // Add AutoScrollPosition
            offset.X += panel1.AutoScrollPosition.X;
            offset.Y += panel1.AutoScrollPosition.Y;

            
            
            e.Graphics.DrawImage(bitmap, offset);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            // Get the default mouse location
            Point offset = e.Location;

            // Subtract AutoScrollPoistion
            offset.X -= panel1.AutoScrollPosition.X;
            offset.Y -= panel1.AutoScrollPosition.Y;

            toolStripStatusLabel1.Text = offset.ToString();

            
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if(DialogResult.OK == dlg.ShowDialog())
            {
                bitmap = new Bitmap(dlg.FileName);

                // Set DPI
                Graphics g = panel1.CreateGraphics();
                bitmap.SetResolution(g.DpiX, g.DpiY);
                g.Dispose();

                panel1.AutoScrollMinSize = bitmap.Size;

                panel1.Invalidate();
            }
        }
    }
}
