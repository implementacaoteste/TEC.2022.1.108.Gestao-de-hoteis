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
    public partial class FormReservaCheckIn : Form
    {
        public int Id;
        public DateTime Data_CheckIn;
        public FormReservaCheckIn(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void FormReservaCheckIn_Load(object sender, EventArgs e)
        {
            string hospede;
            try
            {
                reservaBindingSource.DataSource = new ReservaBLL().BuscarPorId(Id);
                hospede = nome_HospedeTextBox.Text;
                this.Text = "Check In: " + hospede;

                 //= hospede;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCheckin_Click(object sender, EventArgs e)
        {

        }
    }
}
