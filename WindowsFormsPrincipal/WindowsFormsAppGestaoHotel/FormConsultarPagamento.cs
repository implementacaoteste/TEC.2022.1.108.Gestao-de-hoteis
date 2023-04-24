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
    public partial class FormConsultarPagamento : Form
    {
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
               // pagamentoBindingSource.DataSource = new PagamentoBLL().BuscarPorTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
