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

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                clienteBindingSource.DataSource = new ClienteBLL().BuscaPorTodos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdicionarGrupoFuncionario_Click(object sender, EventArgs e)
        {
            using (FormCadastroCliente frm = new FormCadastroCliente())
            {
                frm.ShowDialog();
            }
        }

        private void buttonExcluirGrupoFuncionario_Click(object sender, EventArgs e)
        {
            if (clienteBindingSource.Count <= 0)
            {
                MessageBox.Show("Não há registro para ser excluido");
            }

            if(MessageBox.Show("Deseja realmente excluir o cliente permanentemente do sistema",
                                "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                 return;

            int id = ((Cliente));
        }

        private void buttonAlterarGrupoFuncionario_Click(object sender, EventArgs e)
        {
            if(clienteBindingSource.Count <= 0)
            {
                MessageBox.Show("Não há registro selecionar para ser alterado.");
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
