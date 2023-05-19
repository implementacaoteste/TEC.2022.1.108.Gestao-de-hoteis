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
                reservaBindingSource.DataSource = new ReservaBLL().BuscarPorTodas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }
        private void buttonBuscarTipo_Click(object sender, EventArgs e)
        {
           /*try
           {
                if (radioButtonTodos.Checked)
                {
                    textBoxBuscar.Clear();
                    diariaBindingSource.DataSource = new DiariaBLL().BuscarPorTodos();
                }
                else if (radioButtonNome.Checked)
                {
                    diariaBindingSource.DataSource = new DiariaBLL().BuscarPorNomeCliente(textBoxBuscar.Text);
                }
                else if(radioButtonCPF.Checked)
                {
                    diariaBindingSource.DataSource = new DiariaBLL().BuscarPorCPFCliente(textBoxBuscar.Text);
                }else 
                quartosBindingSource.DataSource = new QuartoBLL().BuscarPorTodos();
           }
           catch(Exception ex )
           {
               MessageBox.Show(ex.Message);
           }*/
        }private void buttonBuscarIdReserva_Click(object sender, EventArgs e)
        {
           try
           {
                reservaBindingSource.DataSource = new ReservaBLL().BuscarPorIdReserva(textBoxBuscarIdReserva.Text);
           }
           catch(Exception ex )
           {
               MessageBox.Show(ex.Message);
           }
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
    }
}