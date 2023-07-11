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
    public partial class ListReserva : UserControl
    {
        bool checkin;
        bool checkout;

        public ListReserva()
        {
            InitializeComponent();
        }

        private void ListReserva_Load(object sender, EventArgs e)
        {
            BuscaReserva();
            checkin = false;
            checkout = false;
        }

        private void pictureBoxCancelar_Click(object sender, EventArgs e)
        {
            if (reservaBindingSource.Count <= 0)
            {
                MessageBox.Show("Não existe uma reserva para ser cancelada!");
                return;
            }

            if (MessageBox.Show("Deseja cancelar esta reserva?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            //ReservaBLL reservaBLL = new ReservaBLL();
            Reserva reserva = ((Reserva)reservaBindingSource.Current);
            int id = ((Reserva)reservaBindingSource.Current).Id;
            int idHospede = ((Reserva)reservaBindingSource.Current).Id_Hospede;
            new ReservaBLL().CancelarReserva(reserva, id, idHospede);
            reservaBindingSource.RemoveCurrent();

            MessageBox.Show("Reserva cancelada com sucesso!");

            this.Dispose();
            //FormReserva frm = new FormReserva();
            //frm.buttonBuscarTipo_Click(null, null);

        }

        public void BuscaReserva()
        {
            var dt_checkin = DateTime.Parse(labelDataCheckIn.Text);
            var dt_checkout = DateTime.Parse(labelDataCheckOut.Text);

            reservaBindingSource.DataSource = new ReservaBLL().BuscarPorId(_id);

            if (((Reserva)reservaBindingSource.Current).Data_Checkin == dt_checkin || ((Reserva)reservaBindingSource.Current).Data_Checkin != null)
            {
                pictureBoxCheckIn.Enabled = false;
                pictureBoxCheckIn.Image = Properties.Resources.calendar_month_gray;
                pictureBoxAlterar.Visible = false;
                pictureBoxCancelar.Visible = false;
            }

            if (((Reserva)reservaBindingSource.Current).Data_Checkout == dt_checkout || ((Reserva)reservaBindingSource.Current).Data_Checkout != null)
            {
                pictureBoxCheckOut.Enabled = false;
                pictureBoxCheckOut.Image = Properties.Resources.calendar_month_gray;
            }
        }


        #region Getter & Setter For Labels

        private int _id;
        private string _numero;
        private string _classe;
        private string _hospede;
        private string _dataCheckin;
        private string _dataCheckout;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Category("Custom Props")]
        public string Numero
        { 
            get { return _numero; }
            set { _numero = value; labelNumeroQuarto.Text = value; }
        }

        [Category("Custom Props")]
        public string Classe
        {
            get { return _classe; }
            set { _classe = value; labelTipoQuarto.Text = value; }
        }

        [Category("Custom Props")]
        public string Hospede
        {
            get { return _hospede; }
            set { _hospede = value; labelNomeHospede.Text = value; }
        }

        [Category("Custom Props")]
        public string DataCheckin
        {
            get { return _dataCheckin; }
            set { _dataCheckin = value; labelDataCheckIn.Text = value; }
        }

        [Category("Custom Props")]
        public string DataCheckout
        {
            get { return _dataCheckout; }
            set { _dataCheckout = value; labelDataCheckOut.Text = value; }
        }

        #endregion

        private void pictureBoxCheckIn_Click(object sender, EventArgs e)
        {
            int id = this.Id;
            using (FormReservaCheckIn frm = new FormReservaCheckIn(id))
            {
                frm.ShowDialog();

                if (frm.Data_CheckIn != null)
                    checkin = true;
            }

            if (checkin)
            {
                pictureBoxCheckIn.Enabled = false;
                pictureBoxCheckIn.Image = Properties.Resources.calendar_month_gray;
                pictureBoxAlterar.Visible = false;
                pictureBoxCancelar.Visible = false;
            }
        }

        private void pictureBoxCheckOut_Click(object sender, EventArgs e)
        {
            int id = this.Id;
            try
            {
                if (pictureBoxCheckIn.Enabled == false)
                {
                    using (FormReservaCheckOut frm = new FormReservaCheckOut(id))
                    {
                        frm.ShowDialog();

                        if (frm.Data_CheckOut != null)
                            checkout = true;
                    }

                    if (checkout)
                    {
                        pictureBoxCheckOut.Enabled = false;
                        pictureBoxCheckOut.Image = Properties.Resources.calendar_month_gray;
                    }
                }
                else
                    throw new Exception("Faça primeiro o Check In!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBoxAlterar_Click(object sender, EventArgs e)
        {
            int id = this.Id;
            using (FormCadastroReserva frm = new FormCadastroReserva(id))
            {
                frm.ShowDialog();
            }
            using (FormReserva frm = new FormReserva())
            {
                frm.buttonBuscarTipo_Click(null, null);
            }
        }
    }
}
