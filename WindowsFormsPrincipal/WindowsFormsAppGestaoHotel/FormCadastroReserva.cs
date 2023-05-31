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
                }
                qtd_HospedesNumericUpDown.Value = 1;
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
                    }
                }
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
    }
}
