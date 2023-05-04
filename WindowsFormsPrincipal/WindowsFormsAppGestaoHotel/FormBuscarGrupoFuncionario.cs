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
        private void FormBuscarGrupoFuncionario_Load(object sender, EventArgs e)
        {
            try
            {
                radioButtonTodos.Checked = true;
                grupoFuncionarioBindingSource.DataSource = new GrupoFuncionarioBLL().BuscarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }

        private void buttonBuscarGrupoFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonTodos.Checked)
                {
                    textBoxBuscar.Clear();
                    grupoFuncionarioBindingSource.DataSource = new GrupoFuncionarioBLL().BuscarTodos();
                }
                else if (radioButtonNome.Checked)
                {
                    grupoFuncionarioBindingSource.DataSource = new GrupoFuncionarioBLL().BuscarPorNomeGrupo(textBoxBuscar.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void buttonAdicionarPermissão_Click(object sender, EventArgs e)
        {
            try
            {
                if (grupoFuncionarioBindingSource.Count == 0)
                    throw new Exception("Não existe um grupo selecionado para adicionar uma permissão.");

                using (FormConsultaPermissao frm = new FormConsultaPermissao())
                {
                    frm.ShowDialog();
                    if (frm.Id != 0)
                    {
                        int idGrupoFuncionario = ((GrupoFuncionario)grupoFuncionarioBindingSource.Current).Id;
                        new GrupoFuncionarioBLL().AdicionarPermissao(idGrupoFuncionario, frm.Id);
                    }
                }
                buttonBuscarGrupoFuncionario_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluirPermissão_Click(object sender, EventArgs e)
        {
            try
            {
                int idGrupoFuncionario = ((GrupoFuncionario)grupoFuncionarioBindingSource.Current).Id;
                int idPermissao = ((Permissao)permissoesBindingSource.Current).Id;
                new GrupoFuncionarioBLL().RemoverPermissao(idGrupoFuncionario, idPermissao);
                permissoesBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
