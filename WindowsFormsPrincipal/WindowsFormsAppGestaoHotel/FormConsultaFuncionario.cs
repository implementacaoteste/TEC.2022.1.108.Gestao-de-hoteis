using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using BLL;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace WindowsFormsAppGestaoHotel
{
    public partial class FormConsultaFuncionario : Form
    {
        public int Id;
        public FormConsultaFuncionario()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                funcionarioBindingSource.DataSource = new FuncionarioBLL().BuscarPorNome(textBoxBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (funcionarioBindingSource.Count > 0)
                    Id = ((Funcionario)funcionarioBindingSource.Current).Id;
                else
                    MessageBox.Show("Não existe registro para ser Selecionado");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
