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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCadastroQuarto_Load(object sender, EventArgs e)
        {
            if (Id == 0)
                quartoBindingSource.AddNew();
            else
            {
                tituloLabel.Text = "Editar Quarto";
                quartoBindingSource.DataSource = new QuartoBLL().BuscarPorId(Id);
            }

            statusesBindingSource.DataSource = new StatusBLL().BuscaPorTodos();
            classeBindingSource.DataSource = new ClasseBLL().BuscaPorTodos();
            StatusComboBox.Text = ((Statuses)statusesBindingSource.Current).Status;
            ClasseComboBox.Text = ((Classe)classeBindingSource.Current).Descricao;
        }

        private void FormCadastroQuarto_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                buttonCancelar_Click(null, null);
            }
        }

        private void valor_DiariaTextBox_Leave(object sender, EventArgs e)
        {
            Decimal value;
            if (Decimal.TryParse(valor_DiariaTextBox.Text, out value))
                valor_DiariaTextBox.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
            else
                valor_DiariaTextBox.Text = String.Empty;
        }
    }
}
