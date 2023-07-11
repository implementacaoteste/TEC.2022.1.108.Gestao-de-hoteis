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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsPrincipal1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppGestaoHotel
{
    public partial class FormReserva : Form
    {
        bool remover;
        bool remover2;

        public FormReserva()
        {
            InitializeComponent();
            remover = true;
            remover2 = true;
        }

        private void FormReserva_Load(object sender, EventArgs e)
        {
            //int qtd_quartos;
            quartoBindingSource.DataSource = new QuartoBLL().BuscarPorTodos();
            //qtd_quartos = quartoBindingSource.Count;

            quartoBindingSource.DataSource = new QuartoBLL().BuscarPorDia(monthCalendar.SelectionRange.Start);

            addLabel();

            try
            {
                comboBoxBuscarTipo.SelectedIndex = 0;
                monthCalendar_DateChanged(sender, null);

                return;


                comboBoxBuscarTipo.SelectedIndex = 0;
                reservaBindingSource.DataSource = new ReservaBLL().BuscarPorDataEntCheckin(monthCalendar.SelectionStart, monthCalendar.SelectionEnd);

                if (reservaBindingSource.Count > 0)
                    popularItems();
                /*else
                    flowLayoutPanelReserva.Controls.Clear();*/

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
            //flowLayoutPanelReserva.Controls.Clear();

            foreach (Reserva item in reservaBindingSource)
            {
                _listReserva = new ListReserva();
                _listReserva.Id = item.Id;
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
                    _quarto.BackColor = Color.FromArgb(219, 161, 0);
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

        public void buttonBuscarTipo_Click(object sender, EventArgs e)
        {
            try
            {
                //if (remover)
                    flowLayoutPanelReserva.Controls.Clear();

                switch (comboBoxBuscarTipo.SelectedIndex)
                {
                    case 0:
                        reservaBindingSource.DataSource = new ReservaBLL().BuscarPorDataEntCheckin(monthCalendar.SelectionStart, monthCalendar.SelectionEnd);
                        break;
                    case 1:
                        reservaBindingSource.DataSource = new ReservaBLL().BuscarPorDataSaiCheckout(monthCalendar.SelectionStart, monthCalendar.SelectionEnd);
                        break;
                    case 2:
                        reservaBindingSource.DataSource = new ReservaBLL().BuscarPorDataLancamento(monthCalendar.SelectionStart, monthCalendar.SelectionEnd);
                        break;
                    default:
                        break;
                }

                if (reservaBindingSource.Count > 0)
                    popularItems();
                else if (remover)
                    flowLayoutPanelReserva.Controls.Clear();

                if (flowLayoutPanelReserva.Controls.Count == 0)
                    lblRegistro();

                remover = true;
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
            monthCalendar_DateChanged(sender, null);
            quartoBindingSource.DataSource = new QuartoBLL().BuscarPorDia(monthCalendar.SelectionRange.Start);
            addLabel();
            timer1.Enabled = true;
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
                quartoBindingSource.DataSource = new QuartoBLL().BuscarPorDia(monthCalendar.SelectionRange.Start);
                addLabel();

                buttonBuscarTipo_Click(sender, null);
                return;

                if (remover)
                    flowLayoutPanelReserva.Controls.Clear();

                switch (comboBoxBuscarTipo.SelectedIndex)
                {
                    case 0:
                        reservaBindingSource.DataSource = new ReservaBLL().BuscarPorDataEntCheckin(monthCalendar.SelectionStart, monthCalendar.SelectionEnd);
                        break;
                    case 1:
                        reservaBindingSource.DataSource = new ReservaBLL().BuscarPorDataSaiCheckout(monthCalendar.SelectionStart, monthCalendar.SelectionEnd);
                        break;
                    case 2:
                        reservaBindingSource.DataSource = new ReservaBLL().BuscarPorDataLancamento(monthCalendar.SelectionStart, monthCalendar.SelectionEnd);
                        break;
                    default:
                        break;
                }

                if (reservaBindingSource.Count > 0)
                    popularItems();
                else if (remover)
                    flowLayoutPanelReserva.Controls.Clear();

                if (flowLayoutPanelReserva.Controls.Count == 0)
                    lblRegistro();

                remover = true;

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
                monthCalendar_DateChanged(sender, null);
                return;

                flowLayoutPanelReserva.Controls.Clear();
                switch (comboBoxBuscarTipo.SelectedIndex)
                {
                    case 0:
                        reservaBindingSource.DataSource = new ReservaBLL().BuscarPorDataEntCheckin(monthCalendar.SelectionStart, monthCalendar.SelectionEnd);
                        break;
                    case 1:
                        reservaBindingSource.DataSource = new ReservaBLL().BuscarPorDataSaiCheckout(monthCalendar.SelectionStart, monthCalendar.SelectionEnd);
                        break;
                    case 2:
                        reservaBindingSource.DataSource = new ReservaBLL().BuscarPorDataLancamento(monthCalendar.SelectionStart, monthCalendar.SelectionEnd);
                        break;
                    default:
                        break;
                }

                if (reservaBindingSource.Count > 0)
                    popularItems();
                /*else
                    flowLayoutPanelReserva.Controls.Clear();*/

                if (flowLayoutPanelReserva.Controls.Count == 0)
                    lblRegistro();

                buttonBuscarTipo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void flowLayoutPanelReserva_ControlRemoved(object sender, ControlEventArgs e)
        {
            //quartoBindingSource.DataSource = new QuartoBLL().BuscarPorTodos();
            //quartoBindingSource.DataSource = new QuartoBLL().BuscarPorDia(monthCalendar.SelectionRange.Start);
            //buttonBuscarTipo_Click(null, null);
            //flowLayoutPanelReserva.ControlRemoved -= flowLayoutPanelReserva_ControlRemoved;
            remover = false;
            if (remover2)
            {
                remover2 = false;
                //monthCalendar_DateChanged(sender, null);
                timer1.Enabled = true;
            }
            remover2 = true;
            //flowLayoutPanelReserva.ControlRemoved += flowLayoutPanelReserva_ControlRemoved;
        }

        private void flowLayoutPanelReserva_BindingContextChanged(object sender, EventArgs e)
        {
            remover = false;
            monthCalendar_DateChanged(sender, null);
            remover = true;
            //quartoBindingSource.DataSource = new QuartoBLL().BuscarPorTodos();
            //quartoBindingSource.DataSource = new QuartoBLL().BuscarPorDia(monthCalendar.SelectionRange.Start);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            monthCalendar_DateChanged(sender, null);
            timer1.Enabled = false;
           // Thread.Sleep(1000);
        }
    }
}
