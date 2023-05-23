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
    public partial class FormRelatorio : Form
    {
        public FormRelatorio()
        {
            InitializeComponent();
        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
              switch(comboBoxBuscar.SelectedIndex)
                {
                    case 0:
                        relatorioBindingSource.DataSource = new RelatorioBLL().DataCheckin(dateTimePicker1.Value);
                        break;
                    case 1:
                        relatorioBindingSource.DataSource = new RelatorioBLL().DataCheckout(dateTimePicker1.Value);
                        break ;
                    case 2:
                        relatorioBindingSource.DataSource = new RelatorioBLL().BuscarPortodos();
                        break ;
                    default:
                        break;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
