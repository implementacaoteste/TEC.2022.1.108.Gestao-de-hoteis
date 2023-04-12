using System;
using BLL;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                new FuncionarioBLL().Altenticar(textBoxUsuario.Text, textBoxSenha.Text);
                Logou = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
