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

namespace WindowsFormsAppGestaoHotel
{
    public partial class FormConsultaCliente : Form
    {
        public int Id;
        public string NomeHospede;
        public FormConsultaCliente()
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
                hospedeBindingSource.DataSource = new HospedeBLL().BuscaPorTodos();
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
                if (hospedeBindingSource.Count > 0)
                {
                    Id = ((Hospede)hospedeBindingSource.Current).Id;
                    NomeHospede = ((Hospede)hospedeBindingSource.Current).Nome;
                    Close();
                }
                else
                    MessageBox.Show("Não existe registro para ser Selecionado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
