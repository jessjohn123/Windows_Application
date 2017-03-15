using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class2_Graphics
{
    public partial class Form1 : Form
    {
        List<Point> list = new List<Point>();

        public Form1()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.ResizeRedraw, true);

            //this.DoubleBuffered = true;

        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.PageUnit = GraphicsUnit.Inch;

            Rectangle rect = new Rectangle(0,0,300,300);

            //Rectangle rect = graphicsPanel1.ClientRectangle;

            Pen pen = new Pen(Color.FromArgb(255, 0, 0));
            pen.Width = 10.0f;

            //Brush brush = new SolidBrush(Color.Blue);
            Brush brush = new LinearGradientBrush(rect, Color.Blue, Color.Black, LinearGradientMode.Vertical);

            //e.Graphics.DrawLine(Pens.Black, 0, 0, 500, 500);

            //e.Graphics.FillEllipse(brush, rect); 
            //e.Graphics.DrawEllipse(pen, rect);
            //e.Graphics.FillRectangle(brush, rect);
            e.Graphics.DrawRectangle(pen, rect);
            
            //e.Graphics.DrawImage(Properties.Resources.chess_boxing, new Rectangle(10, 10, 100, 70));

            Font font = new Font("Times New Roman", 21);

            //// Draw Hello Worlds
            for (int i = 0; i < list.Count; i++)
            {
                e.Graphics.DrawString("Hello World!", font, Brushes.Gold, list[i]);
            }


            //font.Dispose();
            //pen.Dispose();
            //brush.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            dlg.Color = graphicsPanel1.BackColor;

            if(DialogResult.OK == dlg.ShowDialog())
            {
                graphicsPanel1.BackColor = dlg.Color;
            }
        }

        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                list.Add(e.Location);

                numericUpDown1.Value = list.Count;
                textBox1.Text = list.Count.ToString();

                graphicsPanel1.Invalidate();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list.Clear();

            graphicsPanel1.Invalidate();
        }
    }
}
