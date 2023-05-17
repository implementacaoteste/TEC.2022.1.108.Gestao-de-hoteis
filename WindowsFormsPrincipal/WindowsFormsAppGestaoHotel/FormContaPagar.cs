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
                PagamentoBLL pagamentoBLL = new PagamentoBLL();
                pagamentoBindingSource.EndEdit();
                if (Id == 0)
                    pagamentoBLL.Inserir((Pagamento)pagamentoBindingSource.Current);
                else
                    pagamentoBLL.Alterar((Pagamento)pagamentoBindingSource.Current);

                MessageBox.Show("Registro salvo com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancelarCadastro_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
