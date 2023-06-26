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
            try
           {
                ContasPagarBLL _contasPagarBLL = new ContasPagarBLL();
                contasPagarBindingSource.EndEdit();
                if (Id == 0)
                    _contasPagarBLL.Inserir((ContasPagar)contasPagarBindingSource.Current);
                else
                    _contasPagarBLL.Alterar((ContasPagar)contasPagarBindingSource.Current);

                MessageBox.Show("Registro salvo com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
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
                    ((ContasPagar)contasPagarBindingSource.Current).Id_Hospede = frm.Id;
                    ((ContasPagar)contasPagarBindingSource.Current).Nome_Hospede = frm.NomeHospede;
                    id_ClienteTextBox.Text = frm.NomeHospede;
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
                    ((ContasPagar)contasPagarBindingSource.Current).Nome_Funcionario = frm.NomeUsuario;
                    id_FuncionarioTextBox.Text = frm.NomeUsuario;
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
    }
}
