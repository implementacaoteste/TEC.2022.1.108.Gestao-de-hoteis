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
    public partial class FormCadastroDiaria : Form
    {
        public int Id;
        private int idDiaria;
        private int idQuarto;

        public FormCadastroDiaria(int _id = 0)
        {
            Id = _id;
            InitializeComponent();
        }

        private void FormCadastroDiaria_Load(object sender, EventArgs e)
        {
            try
            {
                if (Id == 0)
                    diariaBindingSource.AddNew();
                else
                {
                    tituloLabel.Text = "Editar Diária";
                    diariaBindingSource.DataSource = new DiariaBLL().BuscarPorId(Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //sexoBindingSource.DataSource = new SexoBLL().BuscarPorTodos();
            //comboBox1.Text = ((Funcionario)funcionarioBindingSource.Current).Sexo;
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSelecionarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormConsultaFuncionario frm = new FormConsultaFuncionario())
                {
                    frm.ShowDialog();
                    ((Diaria)diariaBindingSource.Current).Id_Funcionario = frm.Id;
                    ((Diaria)diariaBindingSource.Current).Funcionario = frm.NomeUsuario;
                    funcionarioTextBox.Text = frm.NomeUsuario;
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
                    id_ClienteTextBox.Text = frm.NomeCliente;
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
                DiariaBLL diariaBLL = new DiariaBLL();
                diariaBindingSource.EndEdit();
                if (Id == 0)
                {
                    diariaBLL.Inserir((Diaria)diariaBindingSource.Current);
                }
                else
                {

                    diariaBLL.Alterar((Diaria)diariaBindingSource.Current);
                }
                MessageBox.Show("Diaria salvo com sucesso");
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
