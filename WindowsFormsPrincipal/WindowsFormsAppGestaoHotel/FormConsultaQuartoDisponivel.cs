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
        DateTime dataEntrada;
        DateTime dataSaida;

        public FormConsultaQuartoDisponivel()
        {
            InitializeComponent();
        }

        private void FormConsultaQuartoDisponivel_Load(object sender, EventArgs e)
        {
            classeBindingSource.DataSource = new ClasseBLL().BuscaPorTodos();
            classeComboBox.Text = ((Classe)classeBindingSource.Current).Descricao;
            dateTimeQEntrar.Value = DateTime.Now;
            dateTimeQSair.Value = DateTime.Now;
        }
        private void buttonBuscarQuartoDisp_Click(object sender, EventArgs e)
        {
            try
            {
                dataEntrada = dateTimeQEntrar.Value;
                dataSaida = dateTimeQSair.Value;

                new QuartoBLL().BuscarQuartoDisponivelPorPeriodo(dataEntrada, dataSaida, classeComboBox.Text);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
