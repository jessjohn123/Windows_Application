using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class2_DLL;

namespace Class2_ProjectFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = Properties.Resources.AppTitle;

            panel1.BackgroundImage = Properties.Resources.Lion;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;

            Class1 c = new Class1();
            c.MyProperty = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button was clicked!");
        }


    }
}
