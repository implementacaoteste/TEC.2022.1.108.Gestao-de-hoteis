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
using WindowsFormsPrincipal1;

namespace WindowsFormsAppGestaoHotel
{
    public partial class FormBuscarDiaria : Form
    {
        public FormBuscarDiaria()
        {
            InitializeComponent();
        }

        private void FormBuscarDiaria_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonADCquarto_Click(object sender, EventArgs e)
        {
            try
            {
                using(FormCadastroQuarto frm = new FormCadastroQuarto())
                    frm.ShowDialog();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                quartosBindingSource.DataSource = new QuartoBLL().BuscarPorTodos();
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
