using System;
using BLL;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using System.Security.Cryptography;

namespace WindowsFormsPrincipal1
{
    public partial class FormCadastroQuarto : Form
    {
        public int Id;
        public FormCadastroQuarto(int _id = 0)
        {
            InitializeComponent();
            Id = _id;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {


                QuartoBLL quartoBLL = new QuartoBLL();
               quartoBindingSource.EndEdit();
                if (Id == 0)
                    quartoBLL.Inserir((Quarto)quartoBindingSource.Current);
                else
                    quartoBLL.Alterar((Quarto)quartoBindingSource.Current);
                MessageBox.Show("Registro salvo com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
