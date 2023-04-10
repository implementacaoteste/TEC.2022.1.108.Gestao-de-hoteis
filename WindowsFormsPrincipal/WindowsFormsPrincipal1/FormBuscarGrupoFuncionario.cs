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
    public partial class FormBuscarGrupoFuncionario : Form
    {
        public FormBuscarGrupoFuncionario()
        {
            InitializeComponent();
        }

        private void buttonBuscarGrupoFuncionario_Click(object sender, EventArgs e)
        {
            grupoFuncionarioBindingSource.DataSource = new GrupoFuncionarioBLL().BuscarTodos();
        }

        private void buttonAdicionarGrupoFuncionario_Click(object sender, EventArgs e)
        {
            using (FormCadastroGrupoFuncionario frm = new FormCadastroGrupoFuncionario())
            {
                frm.ShowDialog();
            }
            buttonBuscarGrupoFuncionario_Click(null, null);
        }

        private void buttonAlterarGrupoFuncionario_Click(object sender, EventArgs e)
        {
            int id = ((GrupoFuncionario)grupoFuncionarioBindingSource.Current).Id;
            using (FormCadastroGrupoFuncionario frm = new FormCadastroGrupoFuncionario(id))
            {
                frm.ShowDialog();
            }
            buttonBuscarGrupoFuncionario_Click(null, null);
        }

        private void buttonExcluirGrupoFuncionario_Click(object sender, EventArgs e)
        {
            if (grupoFuncionarioBindingSource.Count <= 0)
            {
                MessageBox.Show("Não existe registro para ser excluído");
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((GrupoFuncionario)grupoFuncionarioBindingSource.Current).Id;
            new FuncionarioBLL().Excluir(id);
            grupoFuncionarioBindingSource.RemoveCurrent();

            MessageBox.Show("Registro excluído com sucesso!");
        }
    }
}
