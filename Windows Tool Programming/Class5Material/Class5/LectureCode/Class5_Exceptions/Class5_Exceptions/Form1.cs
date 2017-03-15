using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class5_Exceptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                numericUpDown3.Value = numericUpDown1.Value + numericUpDown2.Value;

            }

            catch(ArgumentOutOfRangeException argExp)
            {
                //MessageBox.Show(argExp.Message);
                numericUpDown3.Value = numericUpDown3.Maximum;
            }
            catch(NullReferenceException nullExp)
            {

            }
            catch(Exception exp)
            {

            }
            finally
            {
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sentence s = new Sentence();

            try
            {
                s.Text = textBox1.Text;

                listBox1.Items.Add(s);
            }
            catch(NaughtyWordException naughtyExp)
            {
                MessageBox.Show(naughtyExp.Message);
            }
            finally
            {
                textBox1.Text = string.Empty;
            }

        }
    }
}
