using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPrincipal1
{
    public partial class FormSobre : Form
    {
        public FormSobre()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormSobre_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                Close();
            }

            if (e.KeyCode == Keys.F1)
            {
                new FormLogin().linkLabelsuporte_LinkClicked(null, null);
            }
        }

        private void buttonSuporte_Click(object sender, EventArgs e)
        {
            new FormLogin().linkLabelsuporte_LinkClicked(null, null);
        }
    }
}
