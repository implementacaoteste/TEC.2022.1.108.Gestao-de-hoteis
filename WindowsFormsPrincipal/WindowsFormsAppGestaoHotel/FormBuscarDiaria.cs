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

        private void buttonExcluirDiaria_Click(object sender, EventArgs e)
        {
            if (diariaBindingSource.Count <= 0)
            {
                MessageBox.Show("Não existe registro para ser excluido.");
                return;
            }
            if (MessageBox.Show("Deseja realmente excluir a diaria?","ATENÇÃO",MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            int id = ((Diaria)diariaBindingSource.Current).Id;
            new DiariaBLL().Excluir(id);
            diariaBindingSource.RemoveCurrent();

            MessageBox.Show("Registro excluido com sucesso!");
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
    }
}
