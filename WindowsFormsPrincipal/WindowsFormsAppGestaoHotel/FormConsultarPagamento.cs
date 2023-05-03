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
    public partial class FormConsultarPagamento : Form
    {
        public int Id;
        public FormConsultarPagamento()
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
                pagamentoBindingSource.DataSource = new PagamentoBLL().BuscaPorTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (pagamentoBindingSource.Count > 0)
                {
                    Id = ((Pagamento)pagamentoBindingSource.Current).Id;
                }
                else
                    MessageBox.Show("Não existe registro para ser Selecionador");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
