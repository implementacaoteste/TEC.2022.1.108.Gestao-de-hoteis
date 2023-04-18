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
    public partial class FormCadastroClasse : Form
    {
        public int Id;
        public FormCadastroClasse(int _id = 0)
        {
            InitializeComponent();
            Id = _id;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            ClasseBLL classeBLL = new ClasseBLL();
            classeBindingSource.EndEdit();
            if (Id == 0)
                classeBLL.Inserir((Classe)classeBindingSource.Current);
            else
                classeBLL.Alterar((Classe)classeBindingSource.Current);
            MessageBox.Show("Registro salvo com sucesso!");
            Close();
        }

        private void FormCadastroClasse_Load(object sender, EventArgs e)
        {
            if (Id == 0)
                classeBindingSource.AddNew();
            else
            {
                //classeBindingSource.DataSource = new ClasseBLL().BuscarPorId(Id);

            }
        }

        private void buttonCancelar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
