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
    public partial class FormConsultaQuartoDisponivel : Form
    {
        DateTime dataEntrada;
        DateTime dataSaida;
        string Classe;

        public FormConsultaQuartoDisponivel()
        {
            InitializeComponent();
        }

        private void FormConsultaQuartoDisponivel_Load(object sender, EventArgs e)
        {
            radioButtonHoje.Checked = true;
        }

        private void radioButtonPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            this.buttonBuscarQuartoDisp.Location = new System.Drawing.Point(769, 93);
            this.labelClasse.Location = new System.Drawing.Point(563, 100);
            this.comboBoxClasse.Location = new System.Drawing.Point(627, 96);
            labelEntrada.Visible = true;
            labelSair.Visible = true;
            dateTimeQEntrar.Visible = true;
            dateTimeQSair.Visible = true;
        }

        private void radioButtonHoje_CheckedChanged(object sender, EventArgs e)
        {
            labelEntrada.Visible = false;
            labelSair.Visible = false;
            dateTimeQEntrar.Visible = false;
            dateTimeQSair.Visible = false;
            this.labelClasse.Location = new System.Drawing.Point(197, 100);
            this.comboBoxClasse.Location = new System.Drawing.Point(261, 96);
            this.buttonBuscarQuartoDisp.Location = new System.Drawing.Point(403, 93);
        }

        private void buttonBuscarQuartoDisp_Click(object sender, EventArgs e)
        {
            if(radioButtonHoje.Checked)
            {
                new QuartoBLL().BuscarPorQuartoDisponivel();
            }
            if (radioButtonPeriodo.Checked)
            {
                dataEntrada = dateTimeQEntrar.D;
                dataSaida = dateTimeQSair;
                Classe = comboBoxClasse.SelectedText.ToString();

                new QuartoBLL().BuscarQuartoDisponivelPorPeriodo(dataEntrada,dataSaida,Classe);
            }
        }
    }
}
