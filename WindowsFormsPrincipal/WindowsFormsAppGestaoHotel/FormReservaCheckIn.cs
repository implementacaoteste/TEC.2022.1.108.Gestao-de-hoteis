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
        public decimal Vlr_Total;
        public decimal Vlr_Entrada;
        public decimal Vlr_Restante;
        public int Qtd_Hospedes;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCheckin_Click(object sender, EventArgs e)
        {
            try
            {
                ReservaBLL reservaBLL = new ReservaBLL();
                reservaBindingSource.EndEdit();
                reservaBLL.CheckIn((Reserva)reservaBindingSource.Current);
                MessageBox.Show("Check In efetuado com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void addLabel()
        {
            int i = 0;
            //reservaBindingSource.DataSource = new ReservaBLL().BuscarPorId(Id);
            Label _hospede;
            Qtd_Hospedes = ((Reserva)reservaBindingSource.Current).Qtd_Hospedes;
            List<Hospede> Hospedes = new List<Hospede>();
            Hospedes.Clear();
            
            Hospedes.Add(new Hospede() { Id = Id, Nome = nome_HospedeTextBox.Text, CPF = cPF_HopesdeMaskedTextBox.Text, Celular = celular_HospedeMaskedTextBox.Text });

            _hospede = new Label();
            _hospede.Name = "hospede" + Hospedes[i].Id;
            _hospede.Text = Hospedes[i].Nome + " - " + Hospedes[i].CPF + " - " + Hospedes[i].Celular;
            _hospede.ForeColor = Color.Black;
            _hospede.AutoSize = true;
            _hospede.Font = new Font("Microsoft Sans Serif", 10);
            _hospede.TextAlign = ContentAlignment.TopLeft;
            _hospede.Margin = new Padding(3);

            if (flowLayoutPanelHospedes.Controls.Count < 0)
                flowLayoutPanelHospedes.Controls.Clear();
            else 
                if (flowLayoutPanelHospedes.Controls.Count == Qtd_Hospedes)
                    return;
                else 
                    flowLayoutPanelHospedes.Controls.Add(_hospede);

            i++;
        }

        void mascaraMoeda()
        {
            Vlr_Total = ((Reserva)reservaBindingSource.Current).Valor_Total;
            Vlr_Entrada = ((Reserva)reservaBindingSource.Current).Valor_Entrada;
            Vlr_Restante = ((Reserva)reservaBindingSource.Current).Valor_Restante;

            
            if (Decimal.TryParse(valor_RestanteTextBox.Text, out Vlr_Restante))
            {
                valor_RestanteTextBox.Text = Vlr_Restante.ToString("C", CultureInfo.CurrentCulture);
                if (Vlr_Restante > 0)
                    valor_RestanteTextBox.ForeColor = Color.Red;
                else
                    valor_RestanteTextBox.ForeColor = Color.Black;
            }   

            if (Decimal.TryParse(valor_TotalTextBox.Text, out Vlr_Total))
                valor_TotalTextBox.Text = Vlr_Total.ToString("C", CultureInfo.CurrentCulture);

            if (Decimal.TryParse(valor_EntradaTextBox.Text, out Vlr_Entrada))
                valor_EntradaTextBox.Text = Vlr_Entrada.ToString("C", CultureInfo.CurrentCulture);
        }

        private void buttonSalvarHospede_Click(object sender, EventArgs e)
        {
            addLabel();
            nome_HospedeTextBox.Clear();
            cPF_HopesdeMaskedTextBox.Clear();
            celular_HospedeMaskedTextBox.Clear();
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
