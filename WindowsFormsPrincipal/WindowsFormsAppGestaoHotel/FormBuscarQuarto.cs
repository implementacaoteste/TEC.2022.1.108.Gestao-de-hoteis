using BLL;
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
    public partial class FormBuscarQuarto : Form
    {
        public int Numero;
        public FormBuscarQuarto(int _numero = 0)
        {
            InitializeComponent();
            Numero = _numero;
        }
        private void FormBuscarQuarto_Load(object sender, EventArgs e)
        {
            radioButtonTodos.Checked = true;
            quartoBindingSource.DataSource = new QuartoBLL().BuscarPorTodos();
        }

        private void buttonBuscarQuarto_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonTodos.Checked)
                {
                    textBoxBuscar.Clear();
                    quartoBindingSource.DataSource = new QuartoBLL().BuscarPorTodos();
                }
                else if (radioButtonNumero.Checked)
                {
                    quartoBindingSource.DataSource = new QuartoBLL().BuscarPorNumero(Numero);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void valor_DiariaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
