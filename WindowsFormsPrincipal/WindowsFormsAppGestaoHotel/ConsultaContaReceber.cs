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
        decimal Valor_Receber;
        decimal Valor_Recebido;

        public ConsultaContaReceber()
        {
            InitializeComponent();
        }

        private void ConsultaContaReceber_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxBuscarTipo.SelectedIndex = 0;
                ValorReceber();
                ValorRecebido();
                contasReceberBindingSource.DataSource = new ContasReceberBLL().BuscaPorTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ValorReceber()
        {
            contasReceberBindingSource.DataSource = new ContasReceberBLL().ValorReceber(false);
            Valor_Receber = ((ContasReceber)contasReceberBindingSource.Current).Valor_Receber;

            if (Valor_Receber == 0)
                labelValorAReceber.Text = "R$ 0,00";
            else
                labelValorAReceber.Text = "R$ " + Valor_Receber.ToString();
        }
        public void ValorRecebido()
        {
            contasReceberBindingSource.DataSource = new ContasReceberBLL().ValorRecebido(true);
            Valor_Recebido = ((ContasReceber)contasReceberBindingSource.DataSource).Valor_Recebido;

            if (Valor_Recebido == 0)
                labelValorRecebido.Text = "R$ 0,00";
            else
                labelValorRecebido.Text = "R$ " + Valor_Recebido.ToString();
        }

        private void buttonBuscarTipo_Click(object sender, EventArgs e)
        {
            try
            {
                ValorReceber();
                ValorRecebido();

                switch (comboBoxBuscarTipo.SelectedIndex)
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
                buttonBuscarTipo_Click(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
