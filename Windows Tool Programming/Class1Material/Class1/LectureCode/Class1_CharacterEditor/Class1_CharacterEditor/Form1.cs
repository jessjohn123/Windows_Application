using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class1_CharacterEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Character c = new Character();

            //string n1 = c.Name;
            //c.Name = "Bob";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Character c = new Character();

            c.Name = textBoxName.Text;
            c.Age = numericUpDownAge.Value;

            listBox1.Items.Add(c);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Character c = (Character) listBox1.Items[listBox1.SelectedIndex];

            textBoxName.Text = c.Name;
            numericUpDownAge.Value = c.Age;
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = !groupBox1.Visible;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
