using BLL;
using Microsoft.Win32;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            //int qtd_quartos;
            quartoBindingSource.DataSource = new QuartoBLL().BuscarPorTodos();
            //qtd_quartos = quartoBindingSource.Count;

            addLabel();

            try
            {
                comboBoxBuscarTipo.SelectedIndex = 0;
                reservaBindingSource.DataSource = new ReservaBLL().BuscarPorDataCheckin(monthCalendar.SelectionStart, monthCalendar.SelectionEnd);

                if (reservaBindingSource.Count > 0)
                    popularItems();
                else
                    flowLayoutPanelReserva.Controls.Clear();

                if (flowLayoutPanelReserva.Controls.Count == 0)
                    lblRegistro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }

        public void lblRegistro()
        {
            Label _registro;
            _registro = new Label();
            _registro.Name = "labelRegistro";
            _registro.Text = "Nenhum registro Cadastrado!";
            _registro.AutoSize = true;
            _registro.Font = new Font("Microsoft Sans Serif", 12);
            _registro.TextAlign = ContentAlignment.MiddleCenter;
            _registro.Margin = new Padding(3);
            flowLayoutPanelReserva.Controls.Add(_registro);
        }

        void popularItems()
        {
            ListReserva _listReserva;
            flowLayoutPanelReserva.Controls.Clear();

            foreach (Reserva item in reservaBindingSource)
            {
                _listReserva = new ListReserva();
                _listReserva.Numero = item.Numero_Quarto.ToString();
                _listReserva.Classe = item.Tipo_Quarto.ToString();
                _listReserva.Hospede = item.Nome_Hospede.ToString();
                _listReserva.DataCheckin = item.Data_Ent_Reserva.ToShortDateString();
                _listReserva.DataCheckout = item.Data_Sai_Reserva.ToShortDateString();

                flowLayoutPanelReserva.Controls.Add(_listReserva);
            }
        }

        void addLabel()
        {
            Label _quarto;
            flowLayoutPanelQuartos.Controls.Clear();

            foreach (Quarto item in quartoBindingSource)
            {
                _quarto = new Label();
                _quarto.Name = "quarto" + item.Numero.ToString();
                _quarto.Text = item.Numero.ToString();
                _quarto.ForeColor = Color.White;
                _quarto.BackColor = Color.Green;

                if (item.Id_Status == 2)
                    _quarto.BackColor = Color.Red;
                else if (item.Id_Status == 3)
                    _quarto.BackColor = Color.FromArgb(219,161,0);
                else if (item.Id_Status == 4)
                    _quarto.BackColor = Color.Blue;

                _quarto.Width = 30;
                _quarto.Height = 30;
                _quarto.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                _quarto.TextAlign = ContentAlignment.MiddleCenter;
                _quarto.Margin = new Padding(3);

                flowLayoutPanelQuartos.Controls.Add(_quarto);
            }
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

                if (reservaBindingSource.Count > 0)
                    popularItems();
                else
                    flowLayoutPanelReserva.Controls.Clear();

                if (flowLayoutPanelReserva.Controls.Count == 0)
                    lblRegistro();
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
            buttonBuscarTipo_Click(null, null);
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
            Label _registro;
            _registro = new Label();
            _registro.Name = "labelRegistro";
            _registro.Text = "Nenhum registro Cadastrado!";
            _registro.Font = new Font("Microsoft Sans Serif", 12);
            flowLayoutPanelReserva.Controls.Add(_registro);

            try
            {
                quartoBindingSource.DataSource = new QuartoBLL().BuscarPorDia(monthCalendar.SelectionRange.Start);
                addLabel();

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

                if (reservaBindingSource.Count > 0)
                    popularItems();
                else
                    flowLayoutPanelReserva.Controls.Clear();

                if (flowLayoutPanelReserva.Controls.Count == 0)
                    lblRegistro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxBuscarTipo_SelectedIndexChanged(object sender, EventArgs e)
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

                if (reservaBindingSource.Count > 0)
                    popularItems();
                else
                    flowLayoutPanelReserva.Controls.Clear();

                if (flowLayoutPanelReserva.Controls.Count == 0)
                    lblRegistro();

                buttonBuscarTipo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
