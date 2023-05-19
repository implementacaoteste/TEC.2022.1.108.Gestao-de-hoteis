using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppGestaoHotel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsPrincipal1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                using (FormLogin frm = new FormLogin())
                {
                    frm.ShowDialog();
                    if (!frm.Logou)
                    {
                        Application.Exit();
                    }
                }
                textBoxNomeUsuario.Text = Constante.NomeUsuario;
                textBoxCargo.Text = Constante.Cargo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormBuscarCliente frm = new FormBuscarCliente())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void quartoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormBuscarQuarto frm = new FormBuscarQuarto())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormSobre frm = new FormSobre())
            {
                frm.ShowDialog();
            }
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormBuscarFuncionario frm = new FormBuscarFuncionario())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grupoFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormBuscarGrupoFuncionario frm = new FormBuscarGrupoFuncionario())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBoxUsu1_Click(object sender, EventArgs e)
        {
            if (pictureBoxUsu2.Visible)
            {
                pictureBoxSair.Visible = false;
                pictureBoxCaixaLogin.Visible = false;
                pictureBoxCaixaLogin2.Visible = false;
                textBoxNomeUsuario.Visible = false;
                pictureBoxUsu2.Visible = false;
                pictureBoxfundo.Visible = false;
                textBoxCargo.Visible = false;
            }
            else
            {
                pictureBoxSair.Visible = true;
                pictureBoxCaixaLogin.Visible = true;
                pictureBoxCaixaLogin2.Visible = true;
                textBoxNomeUsuario.Visible = true;
                pictureBoxUsu2.Visible = true;
                pictureBoxfundo.Visible = true;
                textBoxCargo.Visible = true;
            }

        }

        private void pictureBoxSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do seu usuário", "Cuidado", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            LimparDados();
            Application.Restart();
        }
        private void LimparDados()
        {
            Constante.IdLogado = 0;
            Constante.Nome = null;
            Constante.CPF = null;
            Constante.Email = null;
            Constante.Celular = null;
            Constante.Endereco = null;
            Constante.NomeUsuario = null;
            Constante.Data_nascimento = DateTime.MinValue;
            Constante.Senha = null;
            Constante.Ativo = false;
            Constante.IdSexo = 0;
            Constante.Sexo = null;
        }

        private void pictureBoxUsu2_Click(object sender, EventArgs e)
        {
            if (pictureBoxSair.Visible)
            {
                pictureBoxSair.Visible = false;
                pictureBoxCaixaLogin.Visible = false;
                pictureBoxCaixaLogin2.Visible = false;
                textBoxNomeUsuario.Visible = false;
                pictureBoxUsu2.Visible = false;
                pictureBoxfundo.Visible = false;
                textBoxCargo.Visible = false;
            }
            else
            {
                pictureBoxSair.Visible = true;
                pictureBoxCaixaLogin.Visible = true;
                pictureBoxCaixaLogin2.Visible = true;
                textBoxNomeUsuario.Visible = true;
                pictureBoxUsu2.Visible = true;
                pictureBoxfundo.Visible = true;
                textBoxCargo.Visible = true;
            }
        }

        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.U)
            {
                pictureBoxUsu1_Click(null, null);
            }
            if (e.KeyCode == Keys.Escape)
            {
                pictureBoxSair_Click(null, null);
            }
        }

        private void reservasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*try
            {
                using (FormBuscarDiaria frm = new FormBuscarDiaria())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void filtrarReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormBuscarReserva frm = new FormBuscarReserva())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormRelatorio frm = new FormRelatorio())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void quartosDisponíveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormConsultaQuartoDisponivel frm = new FormConsultaQuartoDisponivel())
                {
                    frm.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
        

