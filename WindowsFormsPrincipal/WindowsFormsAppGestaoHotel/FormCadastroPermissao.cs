using BLL;
using Models;
using System;
using System.Windows.Forms;

namespace WindowsFormsPrincipal1
{
    public partial class FormCadastroPermissao : Form
    {
        public int Id;
        public FormCadastroPermissao(int _id = 0)
        {
            InitializeComponent();
            Id = _id;
        }

        private void FormCadastroPermissao_Load(object sender, EventArgs e)
        {
            try
            {
                if (Id == 0)
                    permissaoBindingSource.AddNew();
                else
                {
                    tituloLabel.Text = "Editar Grupo de Funcionário";
                    permissaoBindingSource.DataSource = new PermissaoBLL().BuscarPorId(Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            PermissaoBLL permissaoBLL = new PermissaoBLL();
            permissaoBindingSource.EndEdit();

            if (Id == 0)
                permissaoBLL.Inserir((Permissao)permissaoBindingSource.Current);
            else
                permissaoBLL.Alterar((Permissao)permissaoBindingSource.Current);

            MessageBox.Show("Registro salvo com sucesso!");
            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
