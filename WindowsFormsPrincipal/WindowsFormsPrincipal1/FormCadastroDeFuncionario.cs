using BLL;
using Models;
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
        public int Id;
        public FormCadastroDeFuncionario(int _id = 0)
        {
            InitializeComponent();
            Id = _id;
        }

        private void buttonSalvarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioBLL funcionarioBLL = new FuncionarioBLL();
                funcionarioBindingSource.EndEdit();
                if (Id == 0)
                    funcionarioBLL.Inserir((Funcionario)funcionarioBindingSource.Current, textBoxConfirmarSenha.Text);
                else
                    funcionarioBLL.Alterar((Funcionario)funcionarioBindingSource.Current, textBoxConfirmarSenha.Text);
            }
            catch
            {

            }
        }

        private void buttonCancelarCadastro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCadastroDeFuncionario_Load(object sender, EventArgs e)
        {
            if (Id == 0)
                funcionarioBindingSource.AddNew();
            else
                funcionarioBindingSource.DataSource = new FuncionarioBLL().BuscarPorId(Id);
        }
    }
}
