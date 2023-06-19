using Infra;
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
            Log.Gravar("Foi chamada a tela Principal.");
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                Log.Gravar("Abrir a tela de login");
                using (FormLogin frm = new FormLogin())
                {
                    frm.ShowDialog();
                    if (!frm.Logou)
                    {
                        Log.Gravar("Fechar a tela de login");
                        Application.Exit();
                    }
                }
                labelNomeFuncionario.Text = Constante.NomeUsuario;
                labelCargoFuncionario.Text = Constante.Cargo;
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

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
                labelNomeFuncionario.Visible = false;
                pictureBoxUsu2.Visible = false;
                pictureBoxfundo.Visible = false;
                labelCargoFuncionario.Visible = false;
            }
            else
            {
                pictureBoxSair.Visible = true;
                pictureBoxCaixaLogin.Visible = true;
                pictureBoxCaixaLogin2.Visible = true;
                labelNomeFuncionario.Visible = true;
                pictureBoxUsu2.Visible = true;
                pictureBoxfundo.Visible = true;
                labelCargoFuncionario.Visible = true;
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
                labelNomeFuncionario.Visible = false;
                pictureBoxUsu2.Visible = false;
                pictureBoxfundo.Visible = false;
                labelCargoFuncionario.Visible = false;
            }
            else
            {
                pictureBoxSair.Visible = true;
                pictureBoxCaixaLogin.Visible = true;
                pictureBoxCaixaLogin2.Visible = true;
                labelNomeFuncionario.Visible = true;
                pictureBoxUsu2.Visible = true;
                pictureBoxfundo.Visible = true;
                labelCargoFuncionario.Visible = true;
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
            try
            {
                using (FormReserva frm = new FormReserva())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void acessosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormBuscarPermissao frm = new FormBuscarPermissao())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormPrincipal_Resize(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(((this.ClientSize.Width - pictureBox1.Width) / 2),(40));
            pictureBoxUsu1.Location = new Point((this.ClientSize.Width - pictureBoxUsu1.Width) - 46, 38);
            pictureBoxUsu2.Location = new Point((this.ClientSize.Width - pictureBoxUsu2.Width) - 46,38);
            pictureBoxSair.Location = new Point((this.ClientSize.Width - pictureBoxSair.Width)-55, 182);
            pictureBoxfundo.Location = new Point((this.ClientSize.Width - pictureBoxSair.Width) - 57, 180);
            pictureBoxCaixaLogin.Location = new Point((this.ClientSize.Width - pictureBoxCaixaLogin.Width) - 5, 35);
            pictureBoxCaixaLogin2.Location = new Point((this.ClientSize.Width - pictureBoxCaixaLogin.Width) - 7, 33);
            labelNomeFuncionario.Location = new Point((this.ClientSize.Width - labelNomeFuncionario.Width) - 7,95);
            labelCargoFuncionario.Location = new Point((this.ClientSize.Width - labelNomeFuncionario.Width) - 7, 150);
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (ConsultaContasPagar frm = new ConsultaContasPagar())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (ConsultaContaReceber frm = new ConsultaContaReceber())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
        

