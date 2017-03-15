using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class1_Intro
{
    public partial class Form1 : Form
    {
        int i1;
        Point p1;
        Button b1 = new Button();

        public Form1()
        {
            InitializeComponent();

            //bool b1 = true;

            //int i1 = 10;
            //string s1 = i1.ToString();
            //int i2 = int.Parse(s1);
            

            //decimal d1 = 10.3m;

            i1 = 10;

            p1.X = 10;

            b1.Text = "my button";
            b1.Location = new Point(10, 10);
            panel1.Controls.Add(b1);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }






    }
}
