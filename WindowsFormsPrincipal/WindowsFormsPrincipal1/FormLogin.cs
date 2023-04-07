using System;
using BLL;
using Models;
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
    public partial class FormLogin : Form
    {
        public bool Logou;
        public FormLogin()
        {
            InitializeComponent();
            Logou = false;
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                new FuncionarioBLL().Altenticar(textBoxUsuario.Text,textBoxSenha.Text);
                Logou = true;
                Close();
            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
