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
    public partial class FormCadastroCliente : Form
    {
        public FormCadastroCliente()
        {
            InitializeComponent();
        }
        public int Id;
        public FormCadastroCliente(int _id = 0)
        {
            InitializeComponent();
            Id = _id;
        }
       

        private void buttonCancelar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void buttonSalvarCadastroCliente_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteBLL clienteBLL = new ClienteBLL();
                clienteBindingSource.EndEdit();
                if (Id == 0)
                    clienteBLL.Inserir((Cliente)clienteBindingSource.Current);
                else
                    clienteBLL.Alterar((Cliente)clienteBindingSource.Current);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar salvar um cliente no Banco de Dados", ex);
            }
        }

        private void buttonCancelarCadastroCliente_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
