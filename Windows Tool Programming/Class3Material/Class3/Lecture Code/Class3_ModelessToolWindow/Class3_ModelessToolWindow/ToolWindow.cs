using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class3_ModelessToolWindow
{
    public partial class ToolWindow : Form
    {
        public event EventHandler UpdateButtonClicked;

        public ToolWindow()
        {
            InitializeComponent();
        }

        public string ToolWindow_TextBox1_Text
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }

        public decimal ToolWindow_NumericUpDown1_Value
        {
            get
            {
                return numericUpDown1.Value;
            }
            set
            {
                numericUpDown1.Value = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 form = (Form1)this.Owner;
            //form.Form1_NumericUpDown1_Value = numericUpDown1.Value;

            if (UpdateButtonClicked != null)
            {
                UpdateButtonClicked(this, EventArgs.Empty);
            }
        }
    }
}
