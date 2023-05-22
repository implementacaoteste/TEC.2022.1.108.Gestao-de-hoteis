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
        public FormConsultaQuartoDisponivel()
        {
            InitializeComponent();
        }

        private void FormConsultaQuartoDisponivel_Load(object sender, EventArgs e)
        {
            radioButtonTodos.Checked = true;
        }

        private void radioButtonPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPeriodo.Checked == true)
            {
                this.buttonBuscarQuartoDisp.Location = new System.Drawing.Point(769, 93);
                this.labelClasse.Location = new System.Drawing.Point(563, 100);
                this.comboBoxClasse.Location = new System.Drawing.Point(627, 96);
                labelEntrada.Visible = true;
                labelSair.Visible = true;
                dateTimeQEntrar.Visible = true;
                dateTimeQSair.Visible = true;
            }
        }

        private void radioButtonTodos_CheckedChanged(object sender, EventArgs e)
        {
            labelEntrada.Visible = false;
            labelSair.Visible = false;
            dateTimeQEntrar.Visible = false;
            dateTimeQSair.Visible = false;
            this.labelClasse.Location = new System.Drawing.Point(197, 100);
            this.comboBoxClasse.Location = new System.Drawing.Point(261, 96);
            this.buttonBuscarQuartoDisp.Location = new System.Drawing.Point(403, 93);
        }
    }
}
