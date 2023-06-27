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
    public partial class FormReservaCheckOut : Form
    {
        public int Id;
        public DateTime Data_CheckOut;
        public FormReservaCheckOut(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void FormReservaCheckOut_Load(object sender, EventArgs e)
        {
            string hospede;
            try
            {
                reservaBindingSource.DataSource = new ReservaBLL().BuscarPorId(Id);
                hospede = ((Reserva)reservaBindingSource.Current).Nome_Hospede;
                this.Text = "Check Out: " + hospede;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                ReservaBLL reservaBLL = new ReservaBLL();
                reservaBindingSource.EndEdit();
                reservaBLL.CheckOut((Reserva)reservaBindingSource.Current);
                MessageBox.Show("Check Out efetuado com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
