using BLL;
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
    public partial class FormCadastroDeFuncionario : Form
    {
        public int id;
        public FormCadastroDeFuncionario(int id = 0)
        {
            InitializeComponent();
            this.id = id;
        }

        private void FormCadastroDeFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSalvarFuncionario_Click(object sender, EventArgs e)
        {
            FuncionarioBLL funcionarioBLL = new FuncionarioBLL();
            
        }

        private void buttonCancelarCadastro_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
