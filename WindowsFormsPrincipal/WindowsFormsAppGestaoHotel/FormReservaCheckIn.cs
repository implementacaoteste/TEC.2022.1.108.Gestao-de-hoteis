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

namespace WindowsFormsAppGestaoHotel
{
    public partial class FormReservaCheckIn : Form
    {
        public int Id;
        public DateTime Data_CheckIn;
        public double Vlr_Total;
        public double Vlr_Entrada;
        public double Vlr_Restante;
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
                hospede = ((Reserva)reservaBindingSource.Current).Nome_Hospede;
                this.Text = "Check In: " + hospede;
                mascaraMoeda();

                 //= hospede;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void addLabel()
        {
            Label _hospede;
            flowLayoutPanelHospedes.Controls.Clear();

            foreach (Reserva item in reservaBindingSource)
            {
                _hospede = new Label();
                _hospede.Name = "hospede" + item.Hospedes;
                _hospede.Text = item.Hospedes.ToString();
                _hospede.ForeColor = Color.Black;
                _hospede.AutoSize = true;
                _hospede.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                _hospede.TextAlign = ContentAlignment.MiddleCenter;
                _hospede.Margin = new Padding(3);

                flowLayoutPanelHospedes.Controls.Add(_hospede);
            }
        }

        void mascaraMoeda()
        {
            Vlr_Total = ((Reserva)reservaBindingSource.Current).Valor_Total;
            Vlr_Entrada = ((Reserva)reservaBindingSource.Current).Valor_Entrada;
            Vlr_Restante = ((Reserva)reservaBindingSource.Current).Valor_Restante;

            
            if (Double.TryParse(valor_RestanteTextBox.Text, out Vlr_Restante))
            {
                valor_RestanteTextBox.Text = Vlr_Restante.ToString("C", CultureInfo.CurrentCulture);
                if (Vlr_Restante > 0)
                    valor_RestanteTextBox.ForeColor = Color.Red;
                else
                    valor_RestanteTextBox.ForeColor = Color.Black;
            }   

            if (Double.TryParse(valor_TotalTextBox.Text, out Vlr_Total))
                valor_TotalTextBox.Text = Vlr_Total.ToString("C", CultureInfo.CurrentCulture);

            if (Double.TryParse(valor_EntradaTextBox.Text, out Vlr_Entrada))
                valor_EntradaTextBox.Text = Vlr_Entrada.ToString("C", CultureInfo.CurrentCulture);
        }

        private void buttonCheckin_Click(object sender, EventArgs e)
        {
            addLabel();
        }

        private void valor_TotalTextBox_TextChanged(object sender, EventArgs e)
        {
            mascaraMoeda();
        }

        private void valor_EntradaTextBox_TextChanged(object sender, EventArgs e)
        {
            mascaraMoeda();
        }

        private void valor_RestanteTextBox_TextChanged(object sender, EventArgs e)
        {
            mascaraMoeda();
        }
    }
}
