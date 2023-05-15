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
            try
            {
                radioButtonTodos.Checked = true;
                diariaBindingSource.DataSource = new DiariaBLL().BuscarPorTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
           try
           {
                if (radioButtonTodos.Checked)
                {
                    textBoxBuscar.Clear();
                    diariaBindingSource.DataSource = new DiariaBLL().BuscarPorTodos();
                }
                else if (radioButtonNome.Checked)
                {
                    diariaBindingSource.DataSource = new DiariaBLL().BuscarPorNomeCliente(textBoxBuscar.Text);
                }
                else if(radioButtonCPF.Checked)
                {
                    diariaBindingSource.DataSource = new DiariaBLL().BuscarPorCPFCliente(textBoxBuscar.Text);
                }else 
                quartosBindingSource.DataSource = new QuartoBLL().BuscarPorTodos();
           }
           catch(Exception ex )
           {
               MessageBox.Show(ex.Message);
           }
        }
        private void buttonAdicionarDiaria_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormCadastroDiaria frm = new FormCadastroDiaria())
                {
                    frm.ShowDialog();
                }
                buttonBuscar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonAlterarDiaria_Click(object sender, EventArgs e)
        {
            try
            {
                if (diariaBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não há registro selecionado para ser alterado.");
                    return;
                }
                else
                {
                    int id = ((Diaria)diariaBindingSource.Current).Id;
                    using (FormCadastroDiaria frm = new FormCadastroDiaria(id))
                    {
                        frm.ShowDialog();
                    }
                    buttonBuscar_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void buttonExcluirDiaria_Click(object sender, EventArgs e)
        {
            if (diariaBindingSource.Count <= 0)
            {
                MessageBox.Show("Não existe registro para ser excluído.");
                return;
            }
            if (MessageBox.Show("Deseja realmente excluir este registro?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            int id = ((Diaria)diariaBindingSource.Current).Id;
            new DiariaBLL().Excluir(id);
            diariaBindingSource.RemoveCurrent();

            MessageBox.Show("Registro excluído com sucesso!");
        }
        private void buttonAdicionarQuarto_Click(object sender, EventArgs e)
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
        private void buttonExcluirQuarto_Click(object sender, EventArgs e)
        {
            if (quartosBindingSource.Count <= 0)
            {
                MessageBox.Show("Não há registro para ser excluido.");
                return;
            }
            if (MessageBox.Show("Deseja realmente excluir o quarto","ATENÇÃO",MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            int id = (((Diaria)quartosBindingSource.Current).Id);
            new QuartoBLL().Excluir(id);
            quartosBindingSource.RemoveCurrent();

            MessageBox.Show("Registro excluido com sucesso!");
        }

        private void FormBuscarDiaria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void buttonExcluirDiaria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                buttonExcluirDiaria_Click(null, null);
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
            double value = ((Quarto)quartosBindingSource.Current).Valor_Diaria;
            if (Double.TryParse(valor_DiariaTextBox.Text, out value))
                valor_DiariaTextBox.Text = value.ToString("C", CultureInfo.CurrentCulture);
        }
    }
}
