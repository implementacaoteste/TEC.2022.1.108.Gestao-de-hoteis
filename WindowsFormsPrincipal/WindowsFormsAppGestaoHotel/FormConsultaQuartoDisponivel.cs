using BLL;
using System;
using Models;
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
    public partial class FormConsultaQuartoDisponivel : Form
    {
        public FormConsultaQuartoDisponivel()
        {
            InitializeComponent();
        }

        private void FormConsultaQuartoDisponivel_Load(object sender, EventArgs e)
        {
            comboBoxclass.DataSource = new ClasseBLL().BuscaPorTodos();
        }

        private void buttonBuscarQuartoDisp_Click(object sender, EventArgs e)
        {
            try
            {
                quartoBindingSource.DataSource = new QuartoBLL().BuscarQuartoDisponivelPorPeriodo(datePickerInicial.Value, comboBoxclass.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormConsultaQuartoDisponivel_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buttonBuscarQuartoDisp_Click(null, null);
            }

            if(e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
