using System;
using BLL;
using System.Windows.Forms;
using WindowsFormsPrincipal1;
using Models;
using System.Security.Cryptography;

namespace WindowsFormsAppGestaoHotel
{
    public partial class FormCadastroReserva : Form
    {
        public int Id;
        public decimal Vlr_Diaria;
        public decimal Vlr_Total = 0;
        public decimal Vlr_Entrada;

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
                CalcularValorReserva();
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
                    //qtd_HospedesNumericUpDown.Value = reservaBindingSource.Count;
                }
                CalcularValorReserva();
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
                        quartosBindingSource.DataSource = new Quarto() { Id = frm.Id, Numero = frm.Numero, Classe = frm.Tipo_Quarto, Valor_Diaria = frm.Valor_Diaria };
                        ((Reserva)reservaBindingSource.Current).Quartos.Add(new Quarto() { Id = frm.Id, Numero = frm.Numero, Classe = frm.Tipo_Quarto, Valor_Diaria = frm.Valor_Diaria });
                        numero_QuartoTextBox.Text = frm.Numero.ToString();
                        tipo_QuartoTextBox.Text = frm.Tipo_Quarto.ToString();
                        valor_DiariaTextBox.Text = frm.Valor_Diaria.ToString();
                        ((Reserva)reservaBindingSource.Current).Id_Quarto = frm.Id;
                        ((Reserva)reservaBindingSource.Current).Numero_Quarto = frm.Numero;
                        ((Reserva)reservaBindingSource.Current).Tipo_Quarto = frm.Tipo_Quarto;
                    }
                }
                CalcularValorReserva();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CalcularValorReserva()
        {
            if (quartosBindingSource.Count == 0)
                return;

            if (data_SaidaDateTimePicker.Value < data_Ent_ReservaDateTimePicker.Value)
                return;

            DateTime data_ent = data_Ent_ReservaDateTimePicker.Value;
            DateTime data_sai = data_SaidaDateTimePicker.Value;
            int TotalDays = (data_sai.Date - data_ent.Date).Days;

            Vlr_Diaria = ((Quarto)quartosBindingSource.Current).Valor_Diaria;

            if (Vlr_Diaria > 0)
                Vlr_Total = TotalDays * Vlr_Diaria;

            Vlr_Entrada = (Vlr_Total / 2);
            ((Reserva)reservaBindingSource.Current).Valor_Entrada = Vlr_Entrada;

            valor_EntradaTextBox.Text = Vlr_Entrada.ToString();

            ((Reserva)reservaBindingSource.Current).Valor_Total = Vlr_Total;
            valor_TotalTextBox.Text = Vlr_Total.ToString();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCadastroDiaria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                buttonCancelar_Click(null, null);
            }
        }

        private void data_SaidaDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            CalcularValorReserva();
        }
    }
}
