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

namespace WindowsFormsPrincipal1
{
    public partial class FormConsultaQuarto : Form
    {
        public int Id;
        public string Numero;
        public string Tipo_Quarto;
        public double Valor_Diaria;

        public FormConsultaQuarto()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                quartoBindingSource.DataSource = new QuartoBLL().BuscarPorQuartoDisponivel();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (quartoBindingSource.Count > 0)
                {
                    Id = ((Quarto)quartoBindingSource.Current).Id;
                    Numero = ((Quarto)quartoBindingSource.Current).Numero;
                    Tipo_Quarto = ((Quarto)quartoBindingSource.Current).Classe;
                    Valor_Diaria = ((Quarto)quartoBindingSource.Current).Valor_Diaria;
                    Close();
                }
                else
                    MessageBox.Show("Não existe registro para ser selecionado.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormConsultaQuarto_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                buttonCancelar_Click(null, null);
            }
        }
    }
}
