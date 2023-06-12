using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using BLL;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using BLL;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsPrincipal1;
using Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using System.Threading;

namespace WindowsFormsAppGestaoHotel
{
    public partial class FormCadastroReserva : Form
    {
        public int Id;
        public double Vlr_Diaria;
        public double Vlr_Total;
        public double Vlr_Entrada;

        public FormCadastroReserva(int _id = 0)
        {
            InitializeComponent();
            Id = _id;
        }

        private void FormCadastroReserva_Load(object sender, EventArgs e)
        {
            try
            {
                if (Id == 0)
                {
                    reservaBindingSource.AddNew();
                    data_Ent_ReservaDateTimePicker.Value = DateTime.Now.Date;
                    data_SaidaDateTimePicker.Value = DateTime.Now.Date;
                }
                else
                {
                    tituloLabel.Text = "Editar Reserva";
                    reservaBindingSource.DataSource = new ReservaBLL().BuscarPorId(Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonSelecionarPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormConsultarPagamento frm = new FormConsultarPagamento())
                {
                    frm.ShowDialog();
                    ((Reserva)reservaBindingSource.Current).Id_Pagamento = frm.Id;
                    ((Reserva)reservaBindingSource.Current).Pagamento = frm.TipoPagamento;
                    id_PagamentoTextBox.Text = frm.TipoPagamento;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonSelecionarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormConsultaCliente frm = new FormConsultaCliente())
                {
                    frm.ShowDialog();
                    ((Reserva)reservaBindingSource.Current).Id_Hospede = frm.Id;
                    ((Reserva)reservaBindingSource.Current).Nome_Hospede = frm.NomeHospede;
                    id_HospedeTextBox.Text = frm.NomeHospede;
                    qtd_HospedesNumericUpDown.Value = reservaBindingSource.Count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ReservaBLL reservaBLL = new ReservaBLL();
                reservaBindingSource.EndEdit();
                if (Id == 0)
                    reservaBLL.Inserir((Reserva)reservaBindingSource.Current);
                else
                    reservaBLL.Alterar((Reserva)reservaBindingSource.Current);

                MessageBox.Show("Reserva cadastrada com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonSelecionarQuarto_Click(object sender, EventArgs e)
        {
            try
            {
                if (reservaBindingSource.Count == 0)
                    throw new Exception("Não existe nenhum Quarto selecionado para efetuar uma Reserva.");

                using (FormConsultaQuarto frm = new FormConsultaQuarto())
                {
                    frm.ShowDialog();
                    if (frm.Id != 0)
                    {
                        ((Reserva)reservaBindingSource.Current).Quartos.Add(new Quarto() { Id = frm.Id, Numero = frm.Numero, Classe = frm.Tipo_Quarto, Valor_Diaria = frm.Valor_Diaria });
                        numero_QuartoTextBox.Text = frm.Numero.ToString();
                        tipo_QuartoTextBox.Text = frm.Tipo_Quarto.ToString();
                        valor_DiariaTextBox.Text = frm.Valor_Diaria.ToString();
                        ((Reserva)reservaBindingSource.Current).Id_Quarto = frm.Id;

                        double value = frm.Valor_Diaria;
                        if (Double.TryParse(valor_DiariaTextBox.Text, out value))
                            valor_DiariaTextBox.Text = value.ToString("C", CultureInfo.CurrentCulture);
                    }
                }
                CalcularValorReserva();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormCadastroDiaria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                buttonCancelar_Click(null, null);
            }
        }

        public void CalcularValorReserva()
        {
            if (data_SaidaDateTimePicker.Value < data_Ent_ReservaDateTimePicker.Value)
                return;

            DateTime data_ent = data_Ent_ReservaDateTimePicker.Value;
            DateTime data_sai = data_SaidaDateTimePicker.Value;
            int TotalDays = (data_sai.Date - data_ent.Date).Days;
            double valor_total = 0;
            //double valor_total_reserva = ((Reserva)reservaBindingSource.Current).Valor_Total;
            double valor_diaria = ((Quarto)quartosBindingSource.Current).Valor_Diaria;

            

            if (valor_diaria > 0)
                valor_total = TotalDays * valor_diaria;

            valor_EntradaTextBox.Text = (valor_total / 2).ToString();

            valor_TotalTextBox.Text = valor_total.ToString();

            if (Double.TryParse(valor_DiariaTextBox.Text, out valor_diaria))
                valor_DiariaTextBox.Text = valor_diaria.ToString("C", CultureInfo.CurrentCulture);

            if (Double.TryParse(valor_TotalTextBox.Text, out valor_total))
                valor_TotalTextBox.Text = valor_total.ToString("C", CultureInfo.CurrentCulture);

            if (Double.TryParse(valor_EntradaTextBox.Text, out Vlr_Entrada))
                valor_EntradaTextBox.Text = Vlr_Entrada.ToString("C", CultureInfo.CurrentCulture);
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

        private void data_Ent_ReservaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            valor_EntradaTextBox.Focus();
            data_Ent_ReservaDateTimePicker.Focus();
        }

        private void data_SaidaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            valor_EntradaTextBox.Focus();
            data_Ent_ReservaDateTimePicker.Focus();
        }

        private void valor_EntradaTextBox_Enter(object sender, EventArgs e)
        {
            CalcularValorReserva();
        }

        private void valor_EntradaTextBox_TextChanged(object sender, EventArgs e)
        {
            CalcularValorReserva();
        }

        private void valor_DiariaTextBox_TextChanged(object sender, EventArgs e)
        {
            CalcularValorReserva();
        }

        private void valor_TotalTextBox_TextChanged(object sender, EventArgs e)
        {
            CalcularValorReserva();
        }
    }
}
