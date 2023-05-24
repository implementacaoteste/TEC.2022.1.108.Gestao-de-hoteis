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
using WindowsFormsPrincipal1;

namespace WindowsFormsAppGestaoHotel
{
    public partial class FormReserva : Form
    {
        public FormReserva()
        {
            InitializeComponent();
        }
        
        private void FormReserva_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 4; i++)
            {
                Label _quarto = addLabel(i);
                flowLayoutPanelQuartos.Controls.Add(_quarto);
            }

            try
            {
                comboBoxBuscarTipo.SelectedIndex = 0;
                reservaBindingSource.DataSource = new ReservaBLL().BuscarPorDataCheckin(monthCalendar.SelectionStart, monthCalendar.SelectionEnd);

                if (reservaBindingSource.Count == 0)
                    labelRegistro.Visible = true;
                else
                    labelRegistro.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }

        Label addLabel(int i)
        {
            Label _quarto = new Label();
            _quarto.Name = i.ToString();
            _quarto.Text = i.ToString();
            _quarto.ForeColor = Color.White;
            _quarto.BackColor = Color.Green;
            _quarto.Width = 40;
            _quarto.Height = 40;
            _quarto.TextAlign = ContentAlignment.MiddleCenter;
            _quarto.Margin = new Padding(5);

            return _quarto;
        }

        private void buttonBuscarTipo_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarTipo.SelectedIndex)
                {
                    case 0:
                        reservaBindingSource.DataSource = new ReservaBLL().BuscarPorDataCheckin(monthCalendar.SelectionStart, monthCalendar.SelectionEnd);
                        break;
                    case 1:
                        reservaBindingSource.DataSource = new ReservaBLL().BuscarPorDataCheckout(monthCalendar.SelectionStart, monthCalendar.SelectionEnd);
                        break;
                    case 2:
                        reservaBindingSource.DataSource = new ReservaBLL().BuscarPorDataLancamento(monthCalendar.SelectionStart, monthCalendar.SelectionEnd);
                        break;
                    default:
                        break;
                }

                if( reservaBindingSource.Count == 0 )
                    labelRegistro.Visible = true;
                else
                    labelRegistro.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCadastrarReserva_Click(object sender, EventArgs e)
        {
            using (FormCadastroReserva frm = new FormCadastroReserva())
            {
                frm.ShowDialog();
            }
            buttonBuscarTipo_Click(sender, e);
        }

        private void FormReserva_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                switch (comboBoxBuscarTipo.SelectedIndex)
                {
                    case 0:
                        reservaBindingSource.DataSource = new ReservaBLL().BuscarPorDataCheckin(monthCalendar.SelectionStart, monthCalendar.SelectionEnd);
                        break;
                    case 1:
                        reservaBindingSource.DataSource = new ReservaBLL().BuscarPorDataCheckout(monthCalendar.SelectionStart, monthCalendar.SelectionEnd);
                        break;
                    case 2:
                        reservaBindingSource.DataSource = new ReservaBLL().BuscarPorDataLancamento(monthCalendar.SelectionStart, monthCalendar.SelectionEnd);
                        break;
                    default:
                        break;
                }

                if (reservaBindingSource.Count == 0)
                    labelRegistro.Visible = true;
                else
                    labelRegistro.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
