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
    public partial class Form1 : Form
    {
        ToolWindow tool = null;

        public Form1()
        {
            InitializeComponent();


        }

        private void toolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tool == null)
            {
                tool = new ToolWindow();

                tool.FormClosed += tool_FormClosed;
                tool.UpdateButtonClicked += tool_UpdateButtonClicked;

                //tool.Owner = this;

                tool.Show(this);
            }
        }

        void tool_UpdateButtonClicked(object sender, EventArgs e)
        {
            numericUpDown1.Value = tool.ToolWindow_NumericUpDown1_Value;


        }

        void tool_FormClosed(object sender, FormClosedEventArgs e)
        {
            tool = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(tool != null)
            {
                tool.ToolWindow_TextBox1_Text = textBox1.Text;
            }
        }

        public decimal Form1_NumericUpDown1_Value
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
    }
}
