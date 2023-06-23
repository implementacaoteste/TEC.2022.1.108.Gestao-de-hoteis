using BLL;
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
    public partial class ConsultaContasPagar : Form
    {
        public ConsultaContasPagar()
        {
            InitializeComponent();
        }

        private void ConsultaContasPagar_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxBuscarTipo.SelectedIndex = 0;
                contasPagarBindingSource.DataSource = new ContasPagarBLL().BuscaPorTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBuscarTipo_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarTipo.SelectedIndex)
                {
                    case 0:
                        contasPagarBindingSource.DataSource = new ContasPagarBLL().BuscaPorTodos();
                        break;
                    case 1:
                        contasPagarBindingSource.DataSource = new ContasPagarBLL().BuscarPorData(datePickerInicial.Value, datePickerFinal.Value);
                        break;
                    case 2:
                        contasPagarBindingSource.DataSource = new ContasPagarBLL().BuscarPorPagar(false);
                        break;
                    case 3:
                        contasPagarBindingSource.DataSource = new ContasPagarBLL().BuscarPorPagar(true);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormContaPagar frm = new FormContaPagar())
                {
                    frm.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ConsultaContasPagar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonBuscarTipo_Click(null, null);
            }

            if(e.KeyCode == Keys.Escape)
            {
                Close();
            }

            if(e.Control && e.KeyCode == Keys.A)
            {
                buttonAdicionar_Click(null, null);
            }
        }
    }
}
