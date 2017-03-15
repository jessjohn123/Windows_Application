using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class6_ModalDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            dlg.Color = panel1.BackColor;

            if(DialogResult.OK == dlg.ShowDialog())
            {
                panel1.BackColor = dlg.Color;
            }
        }

        private void modalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModalDialog dlg = new ModalDialog();

            dlg.FormTitle = this.Text;
            dlg.Color = panel1.BackColor;

            dlg.Apply += dlg_Apply;

            if(DialogResult.OK == dlg.ShowDialog())
            {
                this.Text = dlg.FormTitle;
                panel1.BackColor = dlg.Color;
            }
        }

        void dlg_Apply(object sender, ApplyEventArgs e)
        {
            this.Text = e.FormTitle;
            panel1.BackColor = e.Color;
        }


        public void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = button.Text;

            //if(button1.Equals(sender))
            //{
            //    textBox1.Text = "button1";
            //}

            //if(button2.Equals(sender))
            //{
            //    textBox1.Text = "button2";
            //}

            //if(button3.Equals(sender))
            //{
            //    textBox1.Text = "button3";
            //}
        }
    }
}
