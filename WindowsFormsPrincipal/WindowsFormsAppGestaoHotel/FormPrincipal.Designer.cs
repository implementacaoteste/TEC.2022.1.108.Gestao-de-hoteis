﻿namespace WindowsFormsPrincipal1
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoFuncionarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quartoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.diariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quartoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxUsu1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCaixaLogin2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCaixaLogin = new System.Windows.Forms.PictureBox();
            this.textBoxNomeUsuario = new System.Windows.Forms.TextBox();
            this.pictureBoxSair = new System.Windows.Forms.PictureBox();
            this.pictureBoxUsu2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxfundo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaixaLogin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaixaLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfundo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1176, 33);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(183)))), ((int)(((byte)(219)))));
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.funcionarioToolStripMenuItem,
            this.grupoFuncionarioToolStripMenuItem1,
            this.quartoToolStripMenuItem1});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.cadastroToolStripMenuItem.Text = "Cadastros";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(321, 30);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(321, 30);
            this.funcionarioToolStripMenuItem.Text = "Funcionário";
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.funcionarioToolStripMenuItem_Click);
            // 
            // grupoFuncionarioToolStripMenuItem1
            // 
            this.grupoFuncionarioToolStripMenuItem1.Name = "grupoFuncionarioToolStripMenuItem1";
            this.grupoFuncionarioToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.grupoFuncionarioToolStripMenuItem1.Size = new System.Drawing.Size(321, 30);
            this.grupoFuncionarioToolStripMenuItem1.Text = "Grupo funcionário";
            this.grupoFuncionarioToolStripMenuItem1.Click += new System.EventHandler(this.grupoFuncionarioToolStripMenuItem1_Click);
            // 
            // quartoToolStripMenuItem1
            // 
            this.quartoToolStripMenuItem1.Name = "quartoToolStripMenuItem1";
            this.quartoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quartoToolStripMenuItem1.Size = new System.Drawing.Size(321, 30);
            this.quartoToolStripMenuItem1.Text = "Quarto";
            this.quartoToolStripMenuItem1.Click += new System.EventHandler(this.quartoToolStripMenuItem1_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(183)))), ((int)(((byte)(219)))));
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1,
            this.diariaToolStripMenuItem,
            this.buscarFuncionarioToolStripMenuItem,
            this.grupoFuncionarioToolStripMenuItem,
            this.quartoToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(114, 29);
            this.consultaToolStripMenuItem.Text = "Consultas";
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(379, 30);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click_1);
            // 
            // diariaToolStripMenuItem
            // 
            this.diariaToolStripMenuItem.Name = "diariaToolStripMenuItem";
            this.diariaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.diariaToolStripMenuItem.Size = new System.Drawing.Size(379, 30);
            this.diariaToolStripMenuItem.Text = "Diária";
            this.diariaToolStripMenuItem.Click += new System.EventHandler(this.diariaToolStripMenuItem_Click);
            // 
            // buscarFuncionarioToolStripMenuItem
            // 
            this.buscarFuncionarioToolStripMenuItem.Name = "buscarFuncionarioToolStripMenuItem";
            this.buscarFuncionarioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.buscarFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(379, 30);
            this.buscarFuncionarioToolStripMenuItem.Text = "Funcionário";
            this.buscarFuncionarioToolStripMenuItem.Click += new System.EventHandler(this.buscarFuncionarioToolStripMenuItem_Click);
            // 
            // grupoFuncionarioToolStripMenuItem
            // 
            this.grupoFuncionarioToolStripMenuItem.Name = "grupoFuncionarioToolStripMenuItem";
            this.grupoFuncionarioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.G)));
            this.grupoFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(379, 30);
            this.grupoFuncionarioToolStripMenuItem.Text = "Grupo Funcionário";
            this.grupoFuncionarioToolStripMenuItem.Click += new System.EventHandler(this.grupoFuncionarioToolStripMenuItem_Click);
            // 
            // quartoToolStripMenuItem
            // 
            this.quartoToolStripMenuItem.Name = "quartoToolStripMenuItem";
            this.quartoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Q)));
            this.quartoToolStripMenuItem.Size = new System.Drawing.Size(379, 30);
            this.quartoToolStripMenuItem.Text = "Quarto";
            this.quartoToolStripMenuItem.Click += new System.EventHandler(this.quartoToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(183)))), ((int)(((byte)(219)))));
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(353, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(467, 431);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxUsu1
            // 

            this.pictureBoxUsu1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pictureBoxUsu1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUsu1.Image")));
            this.pictureBoxUsu1.Location = new System.Drawing.Point(787, 39);
            this.pictureBoxUsu1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxUsu1.Name = "pictureBoxUsu1";
            this.pictureBoxUsu1.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxUsu1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUsu1.TabIndex = 2;
            this.pictureBoxUsu1.TabStop = false;
            this.pictureBoxUsu1.UseWaitCursor = true;
            this.pictureBoxUsu1.Click += new System.EventHandler(this.pictureBox2_Click);

            // 
            // pictureBoxCaixaLogin2
            // 
            this.pictureBoxCaixaLogin2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBoxCaixaLogin2.Location = new System.Drawing.Point(744, 34);

            this.pictureBoxCaixaLogin2.Name = "pictureBoxCaixaLogin2";
            this.pictureBoxCaixaLogin2.Size = new System.Drawing.Size(180, 187);
            this.pictureBoxCaixaLogin2.TabIndex = 7;
            this.pictureBoxCaixaLogin2.TabStop = false;
            this.pictureBoxCaixaLogin2.Visible = false;
            // 
            // pictureBoxCaixaLogin
            // 
            this.pictureBoxCaixaLogin.BackColor = System.Drawing.Color.PowderBlue;
            this.pictureBoxCaixaLogin.Location = new System.Drawing.Point(746, 36);
            this.pictureBoxCaixaLogin.Name = "pictureBoxCaixaLogin";
            this.pictureBoxCaixaLogin.Size = new System.Drawing.Size(175, 182);
            this.pictureBoxCaixaLogin.TabIndex = 8;
            this.pictureBoxCaixaLogin.TabStop = false;
            this.pictureBoxCaixaLogin.Visible = false;
            // 
            // textBoxNomeUsuario
            // 
            this.textBoxNomeUsuario.BackColor = System.Drawing.Color.PowderBlue;
            this.textBoxNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomeUsuario.Location = new System.Drawing.Point(748, 93);
            this.textBoxNomeUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNomeUsuario.Multiline = true;
            this.textBoxNomeUsuario.Name = "textBoxNomeUsuario";
            this.textBoxNomeUsuario.ReadOnly = true;
            this.textBoxNomeUsuario.Size = new System.Drawing.Size(169, 61);
            this.textBoxNomeUsuario.TabIndex = 13;
            this.textBoxNomeUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNomeUsuario.Visible = false;
            // 
            // pictureBoxSair
            // 
            this.pictureBoxSair.BackColor = System.Drawing.Color.Red;
            this.pictureBoxSair.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSair.Image")));
            this.pictureBoxSair.Location = new System.Drawing.Point(798, 149);
            this.pictureBoxSair.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxSair.Name = "pictureBoxSair";
            this.pictureBoxSair.Size = new System.Drawing.Size(40, 37);
            this.pictureBoxSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSair.TabIndex = 14;
            this.pictureBoxSair.TabStop = false;
            this.pictureBoxSair.Visible = false;
            this.pictureBoxSair.Click += new System.EventHandler(this.pictureBoxSair_Click);
            // 
            // pictureBoxUsu2
            // 
            this.pictureBoxUsu2.BackColor = System.Drawing.Color.PowderBlue;
            this.pictureBoxUsu2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pictureBoxUsu2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUsu2.Image")));
            this.pictureBoxUsu2.Location = new System.Drawing.Point(787, 39);
            this.pictureBoxUsu2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxUsu2.Name = "pictureBoxUsu2";
            this.pictureBoxUsu2.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxUsu2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUsu2.TabIndex = 15;
            this.pictureBoxUsu2.TabStop = false;
            this.pictureBoxUsu2.UseWaitCursor = true;
            this.pictureBoxUsu2.Visible = false;
            this.pictureBoxUsu2.Click += new System.EventHandler(this.pictureBoxUsu2_Click);
            // 
            // pictureBoxfundo
            // 
            this.pictureBoxfundo.BackColor = System.Drawing.Color.Black;
            this.pictureBoxfundo.Location = new System.Drawing.Point(796, 147);
            this.pictureBoxfundo.Name = "pictureBoxfundo";
            this.pictureBoxfundo.Size = new System.Drawing.Size(34, 34);
            this.pictureBoxfundo.TabIndex = 16;
            this.pictureBoxfundo.TabStop = false;
            this.pictureBoxfundo.Visible = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1176, 681);
            this.Controls.Add(this.pictureBoxSair);
            this.Controls.Add(this.pictureBoxfundo);
            this.Controls.Add(this.textBoxNomeUsuario);
            this.Controls.Add(this.pictureBoxUsu2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBoxCaixaLogin);
            this.Controls.Add(this.pictureBoxCaixaLogin2);
            this.Controls.Add(this.pictureBoxUsu1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOTELOGIX - Gestão de Hotéis";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaixaLogin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaixaLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroFuncionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroGrupoDeFuncionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaFuncionarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultagrupoDeFuncionarioToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem quartoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarFuncionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupoFuncionarioToolStripMenuItem;

       // private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupoFuncionarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quartoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diariaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxUsu1;
        private System.Windows.Forms.PictureBox pictureBoxCaixaLogin2;
        private System.Windows.Forms.PictureBox pictureBoxCaixaLogin;
        private System.Windows.Forms.TextBox textBoxNomeUsuario;
        private System.Windows.Forms.PictureBox pictureBoxSair;
        private System.Windows.Forms.PictureBox pictureBoxUsu2;
        private System.Windows.Forms.PictureBox pictureBoxfundo;
    }
}