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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsPrincipal1
{
    public partial class FormCadastroCliente : Form
    {
        public int Id;
        public FormCadastroCliente(int _id = 0)
        {
            InitializeComponent();
            Id = _id;
        }
        private void buttonSalvarCadastroCliente_Click(object sender, EventArgs e)
        {
            try
            {
                HospedeBLL clienteBLL = new HospedeBLL();
                clienteBindingSource.EndEdit();
                if (Id == 0)
                    clienteBLL.Inserir((Hospede)clienteBindingSource.Current);
                else
                    clienteBLL.Alterar((Hospede)clienteBindingSource.Current);

                MessageBox.Show("Registro salvo com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonCancelarCadastroCliente_Click(object sender, EventArgs e)
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
        private void FormCadastroCliente_Load(object sender, EventArgs e)
        {
            try
            {
                if (Id == 0)
                    clienteBindingSource.AddNew();
                else
                {
                    tituloLabel.Text = "Editar Cliente";
                    clienteBindingSource.DataSource = new HospedeBLL().BuscarPorId(Id);
                }

                sexoBindingSource.DataSource = new SexoBLL().BuscarPorTodos();
                generoComboBox.Text = ((Hospede)clienteBindingSource.Current).Sexo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return;
        }

        private void FormCadastroCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                buttonCancelarCadastroCliente_Click(null, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HospedeBLL clienteBLL = new HospedeBLL();
                clienteBindingSource.EndEdit();
                if (Id == 0)
                    clienteBLL.Inserir((Hospede)clienteBindingSource.Current);
                else
                    clienteBLL.Alterar((Hospede)clienteBindingSource.Current);

                MessageBox.Show("Registro salvo com sucesso!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
