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
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxUsuario.Text == null || textBoxSenha.Text == null)
                    throw new Exception("Campo nulos encontrados. Preencha todos os campos");
                new FuncionarioBLL().Altenticar(textBoxUsuario.Text, textBoxSenha.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
