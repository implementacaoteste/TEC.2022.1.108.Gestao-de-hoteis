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
    public partial class ConsultaContaReceber : Form
    {
        public ConsultaContaReceber()
        {
            InitializeComponent();
        }

        private void ConsultaContaReceber_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxBuscarTipo.SelectedIndex = 0;
                contasReceberBindingSource.DataSource = new ContasReceberBLL().BuscaPorTodos();
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
                switch(comboBoxBuscarTipo.SelectedIndex)
                {
                    case 0:
                        contasReceberBindingSource.DataSource = new ContasReceberBLL().BuscaPorTodos();
                        break;
                    case 1:
                        contasReceberBindingSource.DataSource = new ContasReceberBLL().BuscarPorData(datePickerInicial.Value, datePickerFinal.Value);
                        break;
                    case 2:
                        contasReceberBindingSource.DataSource = new ContasReceberBLL().BuscarPorPagar(true);
                        break;
                    case 3:
                        contasReceberBindingSource.DataSource = new ContasReceberBLL().BuscarPorPagar(false);
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

        private void buttonCadastrarContaReceber_Click(object sender, EventArgs e)
        {
            try
            {
                using(FormContasReceber frm= new FormContasReceber())
                {
                    frm.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
