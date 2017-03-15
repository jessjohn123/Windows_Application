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
    public partial class ModalDialog : Form
    {
        public event ApplyEventHandler Apply;

        public ModalDialog()
        {
            InitializeComponent();
        }

        public string FormTitle
        {
            get
            {
                return textBoxFormTitle.Text;
            }

            set
            {
                textBoxFormTitle.Text = value;
            }
        }

        public Color Color
        {
            get
            {
                if (radioButtonGreen.Checked) return Color.Green;

                if (radioButtonBlue.Checked) return Color.Blue;

                return Color.Red;
            }

            set
            {
                if(value == Color.Green)
                {
                    radioButtonGreen.Checked = true;
                }
                else if(value == Color.Blue)
                {
                    radioButtonBlue.Checked = true;
                }
                else
                {
                    radioButtonRed.Checked = true;
                }
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if(Apply != null)
            {
                Apply(this, new ApplyEventArgs(textBoxFormTitle.Text, this.Color));
            }
        }
    }

    public delegate void ApplyEventHandler(object sender, ApplyEventArgs e);

    public class ApplyEventArgs : EventArgs
    {
        string formTitle;

        public string FormTitle
        {
            get { return formTitle; }
            set { formTitle = value; }
        }

        Color color;

        public Color Color
        {
            get { return color; }
            set { color = value; }
        }


        public ApplyEventArgs(string formTitle, Color color)
        {
            this.formTitle = formTitle;
            this.color = color;
        }
    }
}
