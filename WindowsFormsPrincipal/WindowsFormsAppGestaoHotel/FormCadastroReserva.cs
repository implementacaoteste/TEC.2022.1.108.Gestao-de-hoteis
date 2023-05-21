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
                    diariaBindingSource.AddNew();
                else
                {
                    tituloLabel.Text = "Editar Diária";
                    diariaBindingSource.DataSource = new ReservaBLL().BuscarPorId(Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            data_Ent_ReservaDateTimePicker.Value = DateTime.Now.Date;
            data_SaidaDateTimePicker.Value = DateTime.Now.Date;
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
                    ((Diaria)diariaBindingSource.Current).Id_Pagamento = frm.Id;
                    ((Diaria)diariaBindingSource.Current).Pagamento = frm.TipoPagamento;
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
                    ((Diaria)diariaBindingSource.Current).Id_Cliente = frm.Id;
                    ((Diaria)diariaBindingSource.Current).Nome_Cliente = frm.NomeCliente;
                    id_HospedeTextBox.Text = frm.NomeCliente;
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
                diariaBindingSource.EndEdit();
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
                if (diariaBindingSource.Count == 0)
                    throw new Exception("Não existe um grupo selecionado para adicionar uma permissão.");

                using (FormConsultaQuarto frm = new FormConsultaQuarto())
                {
                    frm.ShowDialog();
                    if (frm.Id != 0)
                    {
                        int idDiaria = ((Diaria)diariaBindingSource.Current).Id;
                        new DiariaBLL().SelecionarQuarto(idDiaria, frm.Id);
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

        private void buttonSelecionarQuarto_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (diariaBindingSource.Count == 0)
                    throw new Exception("Não existe um grupo selecionado para adicionar uma permissão.");

                using (FormConsultaQuarto frm = new FormConsultaQuarto())
                {
                    frm.ShowDialog();
                    if (frm.Id != 0)
                    {
                        ((Diaria)diariaBindingSource.Current).Quartos.Add(new Quarto() { Id = frm.Id, Numero = frm.Numero});
                        textBox1.Text = frm.Numero.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
