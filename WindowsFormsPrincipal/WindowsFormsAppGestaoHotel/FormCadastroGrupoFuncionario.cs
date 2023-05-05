using BLL;
using Models;
using System;
using System.Windows.Forms;

namespace WindowsFormsPrincipal1
{
    public partial class FormCadastroGrupoFuncionario : Form
    {
        public int Id;
        public FormCadastroGrupoFuncionario(int _id = 0)
        {
            InitializeComponent();
            Id = _id;
        }

        private void FormCadastroGrupoFuncionario_Load(object sender, EventArgs e)
        {
            try
            {
                if (Id == 0)
                    grupoFuncionarioBindingSource.AddNew();
                else
                {
                    tituloLabel.Text = "Editar Grupo de Funcionário";
                    grupoFuncionarioBindingSource.DataSource = new GrupoFuncionarioBLL().BuscarPorId(Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            GrupoFuncionarioBLL grupoFuncionarioBLL = new GrupoFuncionarioBLL();
            grupoFuncionarioBindingSource.EndEdit();

            if (Id == 0)
                grupoFuncionarioBLL.Inserir((GrupoFuncionario)grupoFuncionarioBindingSource.Current);
            else
                grupoFuncionarioBLL.Alterar((GrupoFuncionario)grupoFuncionarioBindingSource.Current);

            MessageBox.Show("Registro salvo com sucesso!");
            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCancelar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void FormCadastroGrupoFuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                buttonCancelar_Click(null, null);
            }
        }
    }
}
