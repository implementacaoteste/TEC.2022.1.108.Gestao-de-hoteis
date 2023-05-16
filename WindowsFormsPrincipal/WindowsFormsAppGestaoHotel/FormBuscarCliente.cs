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

            try
            {
                Hospede cliente = new Hospede();    
                radioButtonTodos.Checked = true;
                clienteBindingSource.DataSource = new HospedeBLL().BuscaPorTodos();
                label1.Text = Convert.ToString(cliente.Data_nascimento);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
            
        }
        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonTodos.Checked)
                {
                    textBoxBuscar.Clear();
                    clienteBindingSource.DataSource = new HospedeBLL().BuscaPorTodos();
                }
                else if (radioButtonNome.Checked)
                {
                    clienteBindingSource.DataSource = new HospedeBLL().BuscaPorNome(textBoxBuscar.Text);
                }
                else if (radioButtonCPF.Checked) 
                {
                    clienteBindingSource.DataSource = new HospedeBLL().BuscaPorCPF(textBoxBuscar.Text);
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

            int id = ((Hospede)clienteBindingSource.Current).Id;
            new HospedeBLL().Excluir(id);
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
                int id = ((Hospede)clienteBindingSource.Current).Id;
                using (FormCadastroCliente frm = new FormCadastroCliente(id))
                {
                    frm.ShowDialog();
                }
                buttonBuscarCliente_Click(null, null);
            }
        }

        private void FormBuscarCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void buttonExcluirCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                buttonExcluirCliente_Click(null, null);
            }
        }
    }
}
