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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void cadastroFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormCadastroDeFuncionario frm = new FormCadastroDeFuncionario())
            {
                frm.ShowDialog();
            }
        }

        private void cadastroGrupoDeFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormCadastroGrupoFuncionario frm = new FormCadastroGrupoFuncionario())
            {
                frm.ShowDialog();
            }
        }

        private void consultaFuncionárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (FormBuscarFuncionario frm = new FormBuscarFuncionario())
            {
                frm.ShowDialog();
            }
        }

        private void consultagrupoDeFuncionárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (FormBuscarGrupoFuncionario frm = new FormBuscarGrupoFuncionario())
            {
                frm.ShowDialog();
            }
        }
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormCadastroCliente frm = new FormCadastroCliente())
            {
                frm.ShowDialog();
            }
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (FormBuscarCliente frm = new FormBuscarCliente())
            {
                frm.ShowDialog();
            }
        }

        private void quartoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(FormBuscarQuarto frm = new FormBuscarQuarto())
            {
                frm.ShowDialog();
            }
        }

        private void clienteToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            using (FormBuscarCliente frm = new FormBuscarCliente())
            {
                frm.ShowDialog();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do seu usuário", "Cuidado", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            LimparDados();
            using (FormLogin frm = new FormLogin())
            {
                frm.ShowDialog();
            }
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

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormSobre frm = new FormSobre())
            {
                frm.ShowDialog();
            }
        }

        private void sobreToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            using (FormSobre frm = new FormSobre())
            {
                frm.ShowDialog();
            }
        }         
        

        private void buscarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormBuscarFuncionario frm = new FormBuscarFuncionario())
            {
                frm.ShowDialog();
            }
        }

        private void grupoFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormBuscarGrupoFuncionario frm = new FormBuscarGrupoFuncionario())
            {
                frm.ShowDialog();
            }
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormCadastroDeFuncionario frm = new FormCadastroDeFuncionario())
            {
                frm.ShowDialog();
            }
        }

        private void quartoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (FormCadastroQuarto frm = new FormCadastroQuarto())
            {
                frm.ShowDialog();
            }
        }

        private void grupoFuncionarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (FormCadastroGrupoFuncionario frm = new FormCadastroGrupoFuncionario())
            {
                frm.ShowDialog();
            }
        }

        private void buscarFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(FormBuscarFuncionario frm = new FormBuscarFuncionario())
            {
                frm.ShowDialog();
            }
        }

        private void grupoFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormBuscarGrupoFuncionario frm = new FormBuscarGrupoFuncionario())
            {
                frm.ShowDialog();
            }
        }

        private void diariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormBuscarDiaria frm = new FormBuscarDiaria())
            {
                frm.ShowDialog();
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do seu usuário", "Cuidado", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            new Logado().LimparDados();
            using (FormLogin frm = new FormLogin())
            {
                frm.ShowDialog();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(pictureBoxSair.Visible)
            {
                pictureBoxSair.Visible = false;
                pictureBoxCaixaLogin.Visible = false;
                pictureBoxCaixaLogin2.Visible = false;
                textBoxNomeUsuario.Visible = false;
            }
            else
            {
                pictureBoxSair.Visible = true;
                pictureBoxCaixaLogin.Visible = true;
                pictureBoxCaixaLogin2.Visible = true;
                textBoxNomeUsuario.Visible=true;
            }
            
        }

        private void pictureBoxSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do seu usuário", "Cuidado", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            new Logado().LimparDados();
            using (FormLogin frm = new FormLogin())
            {
                frm.ShowDialog();
            }
        }
    }
}
