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
    public partial class ConsultaContaReceber : Form
    {
        decimal ValorReceber;
        decimal ValorRecebido;

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
                contasReceberBindingSource.DataSource = new ContasReceberBLL().ValorRecebido(true);
                contasReceberBindingSource.DataSource = new ContasReceberBLL().ValorReceber(false);

                ValorReceber = ((ContasReceber)contasReceberBindingSource.Current).Valor_Receber;
                ValorRecebido = ((ContasReceber)contasReceberBindingSource.Current).Valor_Recebido;

                labelValorAReceber.Text = "R$ " + ValorReceber.ToString();
                labelValorRecebido.Text = "R$ " + ValorRecebido.ToString();
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
                        contasReceberBindingSource.DataSource = new ContasReceberBLL().BuscarPorPagar(false);
                        break;
                    case 3:
                        contasReceberBindingSource.DataSource = new ContasReceberBLL().BuscarPorPagar(true);
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

        private void labelValorAReceber_TextChanged(object sender, EventArgs e)
        {
            /*string ValorT = ((ContasReceber)contasReceberBindingSource.Current).Valor.ToString();
            labelValorAReceber.Text = ValorT;*/
        }
    }
}
