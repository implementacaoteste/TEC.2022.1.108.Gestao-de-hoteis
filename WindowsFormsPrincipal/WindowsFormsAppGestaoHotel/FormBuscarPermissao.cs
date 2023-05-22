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
using WindowsFormsPrincipal1;

namespace WindowsFormsAppGestaoHotel
{
    public partial class FormBuscarPermissao : Form
    {
        public FormBuscarPermissao()
        {
            InitializeComponent();
        }

        private void FormBuscarPermissao_Load(object sender, EventArgs e)
        {
            try
            {
                radioButtonTodos.Checked = true;
                permissaoBindingSource.DataSource = new PermissaoBLL().BuscarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }

        private void buttonBuscarPermissao_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonTodos.Checked)
                {
                    textBoxBuscar.Clear();
                    permissaoBindingSource.DataSource = new PermissaoBLL().BuscarTodos();
                }
                else if (radioButtonDescricao.Checked)
                {
                    permissaoBindingSource.DataSource = new PermissaoBLL().BuscarPorDescricao(textBoxBuscar.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdicionarPermissao_Click(object sender, EventArgs e)
        {
            using (FormCadastroPermissao frm = new FormCadastroPermissao())
            {
                frm.ShowDialog();
            }
            buttonBuscarPermissao_Click(null, null);
        }

        private void buttonAlterarPermissao_Click(object sender, EventArgs e)
        {
            int id = ((Permissao)permissaoBindingSource.Current).Id;
            using (FormCadastroPermissao frm = new FormCadastroPermissao(id))
            {
                frm.ShowDialog();
            }
            buttonBuscarPermissao_Click(null, null);
        }

        private void buttonExcluirPermissao_Click(object sender, EventArgs e)
        {
            if (permissaoBindingSource.Count <= 0)
            {
                MessageBox.Show("Não existe registro para ser excluído");
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((Permissao)permissaoBindingSource.Current).Id;
            new PermissaoBLL().Excluir(id);
            permissaoBindingSource.RemoveCurrent();

            MessageBox.Show("Registro excluído com sucesso!");
        }
    }
}
