using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MIPS_Assembler
{
    public partial class InputText : Form
    {
        public string Mif_name
        {
            set
            {
                textBox1.Text = value;
            }
            get
            {
                return textBox1.Text;
            }
        }
        public InputText()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
