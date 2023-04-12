using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPrincipal1
{
    public partial class FormBuscarFuncionario : Form
    {
        public FormBuscarFuncionario()
        {
            InitializeComponent();
        }

        private void buttonBuscarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                funcionarioBindingSource.DataSource = new FuncionarioBLL().();
            }
        }
    }
}
