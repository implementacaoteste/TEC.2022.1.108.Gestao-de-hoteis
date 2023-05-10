using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using WindowsFormsPrincipal1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppGestaoHotel
{
    public partial class FormBuscarQuarto : Form
    {
        public FormBuscarQuarto()
        {
            InitializeComponent();
        }
        private void FormBuscarQuarto_Load(object sender, EventArgs e)
        {
            try
            {
                radioButtonTodos.Checked = true;
                quartoBindingSource.DataSource = new QuartoBLL().BuscarPorTodos();
                //valor_DiariaTextBox.Text = "R$ 0,00";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }

        private void buttonBuscarQuarto_Click(object sender, EventArgs e)
        {
            try
            {
                //double value = ((Quarto)quartoBindingSource.Current).Valor_Diaria;
                //Double value;
                /*if (Double.TryParse(valor_DiariaTextBox.Text, out value))
                    valor_DiariaTextBox.Text = value.ToString("C", CultureInfo.CurrentCulture);*/

                if (radioButtonTodos.Checked)
                {
                    textBoxBuscar.Clear();
                    quartoBindingSource.DataSource = new QuartoBLL().BuscarPorTodos();
                }
                else if (radioButtonNumero.Checked)
                {
                    quartoBindingSource.DataSource = new QuartoBLL().BuscarPorNumero(textBoxBuscar.Text);
                }
                else if (radioButtonStatus.Checked) 
                {
                    quartoBindingSource.DataSource = new QuartoBLL().BuscarPorStatus(textBoxBuscar.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdicionarQuarto_Click(object sender, EventArgs e)
        {
            using (FormCadastroQuarto frm = new FormCadastroQuarto())
            {
                frm.ShowDialog();
            }
            buttonBuscarQuarto_Click(null, null);
        }

        private void buttonAlterarQuarto_Click(object sender, EventArgs e)
        {
            if (quartoBindingSource.Count <= 0)
            {
                MessageBox.Show("Não há registro selecionado para ser alterado.");
                return;
            }
            else
            {
                int id = ((Quarto)quartoBindingSource.Current).Id;

                using (FormCadastroQuarto frm = new FormCadastroQuarto(id))
                {
                    frm.ShowDialog();
                }
                buttonBuscarQuarto_Click(null, null);
            }
        }

        private void buttonExcluirQuarto_Click(object sender, EventArgs e)
        {
            if (quartoBindingSource.Count <= 0)
            {
                MessageBox.Show("Não existe registro para ser excluído");
                return;
            }
            if (MessageBox.Show("Deseja realmente excluir este registro?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((Quarto)quartoBindingSource.Current).Id;
            new QuartoBLL().Excluir(id);
            quartoBindingSource.RemoveCurrent();

            MessageBox.Show("Registro excluído com sucesso!");
        }

        private void FormBuscarQuarto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void buttonExcluirQuarto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                buttonExcluirQuarto_Click(null, null);
            }
        }

        private void valor_DiariaTextBox_TextChanged(object sender, EventArgs e)
        {
            double value = ((Quarto)quartoBindingSource.Current).Valor_Diaria;
            if (Double.TryParse(valor_DiariaTextBox.Text, out value))
                valor_DiariaTextBox.Text = value.ToString("C", CultureInfo.CurrentCulture);
        }
    }
}
