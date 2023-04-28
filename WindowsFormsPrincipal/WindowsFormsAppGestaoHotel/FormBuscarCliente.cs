using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Models;

namespace WindowsFormsPrincipal1
{
    public partial class FormBuscarCliente : Form
    {
        public FormBuscarCliente()
        {
            InitializeComponent();
        }
        private void FormBuscarCliente_Load(object sender, EventArgs e)
        {
            radioButtonTodos.Checked = true;
            clienteBindingSource.DataSource = new ClienteBLL().BuscaPorTodos();
        }
        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonTodos.Checked)
                {
                    textBoxBuscar.Clear();
                    clienteBindingSource.DataSource = new ClienteBLL().BuscaPorTodos();
                }
                else if (radioButtonNome.Checked)
                {
                    clienteBindingSource.DataSource = new ClienteBLL().BuscaPorNome(textBoxBuscar.Text);
                }
                else if (radioButtonCPF.Checked) 
                {
                    clienteBindingSource.DataSource = new ClienteBLL().BuscaPorCPF(textBoxBuscar.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonAdicionarCliente_Click(object sender, EventArgs e)
        {
            using (FormCadastroCliente frm = new FormCadastroCliente())
            {
                frm.ShowDialog();
            }
        }
        private void buttonExcluirCliente_Click(object sender, EventArgs e)
        {
            if (clienteBindingSource.Count <= 0)
            {
                MessageBox.Show("Não há registro para ser excluido");
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir o cliente permanentemente do sistema",
                                "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((Cliente)clienteBindingSource.Current).Id;
            new ClienteBLL().Excluir(id);
            clienteBindingSource.RemoveCurrent();
            MessageBox.Show("Usuário removido com sucesso");
        }
        private void buttonAlterarCliente_Click(object sender, EventArgs e)
        {
            if (clienteBindingSource.Count <= 0)
            {
                MessageBox.Show("Não há registro selecionado para ser alterado.");
                return;
            }
            else
            {
                int id = ((Cliente)clienteBindingSource.Current).Id;
                using (FormCadastroCliente frm = new FormCadastroCliente(id))
                {
                    frm.ShowDialog();
                }
                buttonBuscarCliente_Click(null, null);
            }
        }
    }
}
