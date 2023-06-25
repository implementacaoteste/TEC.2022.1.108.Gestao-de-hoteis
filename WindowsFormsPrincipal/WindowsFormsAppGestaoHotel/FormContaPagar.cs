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
    public partial class FormContaPagar : Form
    {
        public int Id;
        public FormContaPagar(int _id = 0)
        {
            InitializeComponent();
            Id = _id;
        }

        private void buttonSalvarFuncionario_Click(object sender, EventArgs e)
        {
            //try
            //{
                ContasPagarBLL _contasPagarBLL = new ContasPagarBLL();
                contasPagarBindingSource.EndEdit();
                if (Id == 0)
                    _contasPagarBLL.Inserir((ContasPagar)contasPagarBindingSource.Current);
                else
                    _contasPagarBLL.Alterar((ContasPagar)contasPagarBindingSource.Current);

                MessageBox.Show("Registro salvo com sucesso!");
                Close();
            ///}
            //catch (Exception ex)
            ///{
           //     MessageBox.Show(ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error);
           // }
        }

        private void buttonCancelarCadastro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSelecionar_cliente_Click(object sender, EventArgs e)
        {
            try
            {
                using(FormConsultaCliente frm = new FormConsultaCliente())
                {
                    frm.ShowDialog();
                    ((ContasPagar)contasPagarBindingSource.Current).Id_Cliente = frm.Id;
                    ((ContasPagar)contasPagarBindingSource.Current).Nome_Hospede = frm.NomeHospede;
                    if (frm.NomeHospede == null)
                        nome_HospedeLabelHosp.Text = null;
                    else
                        nome_HospedeLabelHosp.Text = frm.NomeHospede.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSelecionar_funcionario_Click(object sender, EventArgs e)
        {
            try
            {
                using(FormConsultaFuncionario frm =new FormConsultaFuncionario())
                {
                    frm.ShowDialog();
                    ((ContasPagar)contasPagarBindingSource.Current).Id_Funcionario = frm.Id;
                    ((ContasPagar)contasPagarBindingSource.Current).Nome_funcionario = frm.NomeUsuario;
                    if (frm.NomeUsuario == null)
                        nome_funcionarioLabelNome.Text = null;
                    else
                        nome_funcionarioLabelNome.Text = frm.NomeUsuario.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormContaPagar_Load(object sender, EventArgs e)
        {
            contasPagarBindingSource.AddNew();
        }

        private void nome_HospedeLabelHosp_Click(object sender, EventArgs e)
        {
            buttonSelecionar_cliente_Click(null,null);
        }

        private void nome_funcionarioLabelNome_Click(object sender, EventArgs e)
        {
            buttonSelecionar_funcionario_Click(null,null);
        }
    }
}
