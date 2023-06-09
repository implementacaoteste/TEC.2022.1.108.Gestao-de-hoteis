using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsPrincipal1;

namespace WindowsFormsAppGestaoHotel
{
    public partial class FormBuscarReserva : Form
    {
        public FormBuscarReserva()
        {
            InitializeComponent();
        }

        private void FormBuscarReserva_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxBuscarTipo.SelectedIndex= 0;
                reservaBindingSource.DataSource = new ReservaBLL().BuscarPorDataEntCheckin(datePickerInicial.Value, datePickerFinal.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }
        private void buttonBuscarTipo_Click(object sender, EventArgs e)
        {
           try
           {
                switch (comboBoxBuscarTipo.SelectedIndex) 
                {
                    case 0:
                        reservaBindingSource.DataSource = new ReservaBLL().BuscarPorDataEntCheckin(datePickerInicial.Value, datePickerFinal.Value);
                        break;
                    case 1:
                        reservaBindingSource.DataSource = new ReservaBLL().BuscarPorDataSaiCheckout(datePickerInicial.Value, datePickerFinal.Value);
                        break;
                    case 2:
                        reservaBindingSource.DataSource = new ReservaBLL().BuscarPorDataLancamento(datePickerInicial.Value, datePickerFinal.Value);
                        break;
                    default:
                        break;
                }
           }
           catch(Exception ex )
           {
               MessageBox.Show(ex.Message);
           }
        }
        private void buttonBuscarIdReserva_Click(object sender, EventArgs e)
        {
           /*try
           {
                reservaBindingSource.DataSource = new ReservaBLL().BuscarPorIdReserva(int);
           }
           catch(Exception ex )
           {
               MessageBox.Show(ex.Message);
           }*/
        }

        private void FormBuscarReserva_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void valor_DiariaTextBox_TextChanged(object sender, EventArgs e)
        {
            /*double value = ((Quarto)quartosBindingSource.Current).Valor_Diaria;
            if (Double.TryParse(valor_DiariaTextBox.Text, out value))
                valor_DiariaTextBox.Text = value.ToString("C", CultureInfo.CurrentCulture);*/
        }

        private void textBoxBuscarIdReserva_Click(object sender, EventArgs e)
        {
            textBoxBuscarIdReserva.Clear();
        }

        private void valor_EntradaTextBox_TextChanged(object sender, EventArgs e)
        {
            double value = ((Reserva)reservaBindingSource.Current).Valor_Entrada;
            if (Double.TryParse(valor_EntradaTextBox.Text, out value))
                valor_EntradaTextBox.Text = value.ToString("C", CultureInfo.CurrentCulture);
        }

        private void valor_TotalTextBox_TextChanged(object sender, EventArgs e)
        {
            double value = ((Reserva)reservaBindingSource.Current).Valor_Total;
            if (Double.TryParse(valor_TotalTextBox.Text, out value))
                valor_TotalTextBox.Text = value.ToString("C", CultureInfo.CurrentCulture);
        }

        private void valor_RestanteTextBox_TextChanged(object sender, EventArgs e)
        {
            double value = ((Reserva)reservaBindingSource.Current).Valor_Restante;
            if (Double.TryParse(valor_RestanteTextBox.Text, out value))
                valor_RestanteTextBox.Text = value.ToString("C", CultureInfo.CurrentCulture);

            if (value > 0)
                valor_RestanteTextBox.ForeColor = Color.Red;
            else
                valor_RestanteTextBox.ForeColor = Color.Green;
        }
    }
}