using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsPrincipal1;

namespace WindowsFormsAppGestaoHotel
{
    public partial class FormCadastroDiaria : Form
    {
        public FormCadastroDiaria()
        {
            InitializeComponent();
        }

        private void FormCadastroDiaria_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSelecionarFuncionario_Click(object sender, EventArgs e)
        {
            using(FormConsultaFuncionario frm = new FormConsultaFuncionario())
            {
                frm.ShowDialog();
            }
        }
        private void buttonSelecionarPagamento_Click(object sender, EventArgs e)
        {
            using(FormConsultarPagamento frm = new FormConsultarPagamento())
            {
                frm.ShowDialog();
            }
        }
        private void buttonSelecionarCliente_Click(object sender, EventArgs e)
        {
            using(FormConsultaCliente frm = new FormConsultaCliente())
            {
                frm.ShowDialog();
            } 
        }
    }
}
