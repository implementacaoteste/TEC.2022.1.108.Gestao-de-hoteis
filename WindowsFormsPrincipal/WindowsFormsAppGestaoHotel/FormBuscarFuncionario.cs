using BLL;
using Models;
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
        private void FormBuscarFuncionario_Load(object sender, EventArgs e)
        {
            try
            {
                radioButtonTodos.Checked = true;
                funcionarioBindingSource.DataSource = new FuncionarioBLL().BuscarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }
        private void buttonBuscarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonTodos.Checked)
                {
                    textBoxBuscar.Clear();
                    funcionarioBindingSource.DataSource = new FuncionarioBLL().BuscarTodos();
                }
                else if (radioButtonNome.Checked)
                {
                    funcionarioBindingSource.DataSource = new FuncionarioBLL().BuscarPorNome(textBoxBuscar.Text);
                }
                else if (radioButtonCPF.Checked)
                    funcionarioBindingSource.DataSource = new FuncionarioBLL().BuscarPorCPF(textBoxBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdicionarFuncionario_Click(object sender, EventArgs e)
        {
            using (FormCadastroDeFuncionario frm = new FormCadastroDeFuncionario())
            {
                frm.ShowDialog();
            }
            buttonBuscarFuncionario_Click(null, null);
        }

        private void buttonExcluirFuncionário_Click(object sender, EventArgs e)
        {
            if(funcionarioBindingSource.Count <= 0)
            {
                MessageBox.Show("Não existe registro para ser excluído");
                return;
            }
            if (MessageBox.Show("Deseja realmente excluir este registro?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((Funcionario)funcionarioBindingSource.Current).Id;
            new FuncionarioBLL().Excluir(id);
            funcionarioBindingSource.RemoveCurrent();

            MessageBox.Show("Registro excluído com sucesso!");
        }

        private void buttonAlterarFuncionario_Click(object sender, EventArgs e)
        {
            if(funcionarioBindingSource.Count <= 0)
            {
                MessageBox.Show("Não há registro selecionado para ser alterado.");
                return;
            }
            else
            {
                int id = ((Funcionario)funcionarioBindingSource.Current).Id;

                using(FormCadastroDeFuncionario frm = new FormCadastroDeFuncionario(id))
                {
                    frm.ShowDialog();
                }
                buttonBuscarFuncionario_Click(null, null);
            }
        }

        private void buttonAdicionarGrupoFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormConsultaGrupoFuncionario frm = new FormConsultaGrupoFuncionario())
                {
                    frm.ShowDialog();
                    if (frm.Id != 0)
                    {
                        int idFuncionario = ((Funcionario)funcionarioBindingSource.Current).Id;
                        new FuncionarioBLL().AdicionarGrupoUsuario(idFuncionario, frm.Id);
                    }
                }
                buttonBuscarFuncionario_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluirGrupoFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                int idGrupoFuncionario = ((GrupoFuncionario)grupoFuncionariosBindingSource.Current).Id;
                int idFuncionario = ((Funcionario)funcionarioBindingSource.Current).Id;
                new FuncionarioBLL().RemoverGrupoUsuario(idFuncionario, idGrupoFuncionario);
                grupoFuncionariosBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormBuscarFuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void buttonExcluirFuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                buttonExcluirFuncionário_Click(null, null);
            }
            buttonBuscarFuncionario_Click(null, null);
        }

        private void buttonExcluirGrupoFuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                buttonExcluirGrupoFuncionario_Click(null, null);
            }
            buttonBuscarFuncionario_Click(null, null);
        }
    }
}
