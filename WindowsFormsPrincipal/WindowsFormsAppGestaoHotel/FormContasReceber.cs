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
    public partial class FormContasReceber : Form
    {
        int Id;
        string NomeHospede;
        public FormContasReceber(int _id = 0)
        {
            InitializeComponent();
            Id = _id;
        }

        private void FormContasReceber_Load(object sender, EventArgs e)
        {
            //FuncionarioTextBox.Text = Constante.Nome.ToString();
            contasReceberBindingSource.AddNew();
        }

        private void buttonSelecionarFun_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormConsultaFuncionario frm = new FormConsultaFuncionario())
                {
                    frm.ShowDialog();
                    ((ContasReceber)contasReceberBindingSource.Current).Id_Funcionario = frm.Id;
                    ((ContasReceber)contasReceberBindingSource.Current).Nome_Funcionario = frm.NomeUsuario;
                    FuncionarioTextBox.Text = frm.NomeUsuario;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSelecionarHospede_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormConsultaCliente frm = new FormConsultaCliente())
                {
                    frm.ShowDialog();
                    ((ContasReceber)contasReceberBindingSource.Current).Id_Hospede = frm.Id;
                    ((ContasReceber)contasReceberBindingSource.Current).Nome_Hospede = frm.NomeHospede;
                    NomeHospede = frm.NomeHospede;
                }
                id_ClienteTextBox.Text = NomeHospede;
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
                ContasReceberBLL _contasReceberBLL = new ContasReceberBLL();
                contasReceberBindingSource.EndEdit();
                if (Id == 0)
                    _contasReceberBLL.Inserir((ContasReceber)contasReceberBindingSource.Current);
                else
                    _contasReceberBLL.Alterar((ContasReceber)contasReceberBindingSource.Current);

                MessageBox.Show("Registro salvo com sucesso!");
                Close();
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
    }
}
