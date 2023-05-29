namespace WindowsFormsPrincipal1
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeQuartoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quartoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acessosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrarReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quartosDisponíveisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAReceberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxSair = new System.Windows.Forms.PictureBox();
            this.pictureBoxfundo = new System.Windows.Forms.PictureBox();
            this.pictureBoxUsu2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxUsu1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCaixaLogin = new System.Windows.Forms.PictureBox();
            this.pictureBoxCaixaLogin2 = new System.Windows.Forms.PictureBox();
            this.labelCargoFuncionario = new System.Windows.Forms.Label();
            this.labelNomeFuncionario = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaixaLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaixaLogin2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            this.menuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.reservasToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1424, 33);
            this.menuStrip.Stretch = false;
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(183)))), ((int)(((byte)(219)))));
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.funcionarioToolStripMenuItem});
            this.cadastroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroToolStripMenuItem.Image")));
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(120, 29);
            this.cadastroToolStripMenuItem.Text = "Pessoas";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.clienteToolStripMenuItem.Text = "Hóspedes";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.funcionarioToolStripMenuItem.Text = "Funcionários";
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.funcionarioToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(183)))), ((int)(((byte)(219)))));
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDeQuartoToolStripMenuItem,
            this.quartoToolStripMenuItem,
            this.grupoFuncionarioToolStripMenuItem,
            this.acessosToolStripMenuItem});
            this.consultaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultaToolStripMenuItem.Image")));
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(134, 29);
            this.consultaToolStripMenuItem.Text = "Cadastros";
            // 
            // tipoDeQuartoToolStripMenuItem
            // 
            this.tipoDeQuartoToolStripMenuItem.Name = "tipoDeQuartoToolStripMenuItem";
            this.tipoDeQuartoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.tipoDeQuartoToolStripMenuItem.Size = new System.Drawing.Size(296, 30);
            this.tipoDeQuartoToolStripMenuItem.Text = "Tipo de Quarto";
            // 
            // quartoToolStripMenuItem
            // 
            this.quartoToolStripMenuItem.Name = "quartoToolStripMenuItem";
            this.quartoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quartoToolStripMenuItem.Size = new System.Drawing.Size(296, 30);
            this.quartoToolStripMenuItem.Text = "Quartos";
            this.quartoToolStripMenuItem.Click += new System.EventHandler(this.quartoToolStripMenuItem_Click);
            // 
            // grupoFuncionarioToolStripMenuItem
            // 
            this.grupoFuncionarioToolStripMenuItem.Name = "grupoFuncionarioToolStripMenuItem";
            this.grupoFuncionarioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.grupoFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(296, 30);
            this.grupoFuncionarioToolStripMenuItem.Text = "Cargos";
            this.grupoFuncionarioToolStripMenuItem.Click += new System.EventHandler(this.grupoFuncionarioToolStripMenuItem_Click);
            // 
            // acessosToolStripMenuItem
            // 
            this.acessosToolStripMenuItem.Name = "acessosToolStripMenuItem";
            this.acessosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.acessosToolStripMenuItem.Size = new System.Drawing.Size(296, 30);
            this.acessosToolStripMenuItem.Text = "Acessos";
            this.acessosToolStripMenuItem.Click += new System.EventHandler(this.acessosToolStripMenuItem_Click);
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(183)))), ((int)(((byte)(219)))));
            this.reservasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservasToolStripMenuItem1,
            this.filtrarReservasToolStripMenuItem,
            this.quartosDisponíveisToolStripMenuItem});
            this.reservasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reservasToolStripMenuItem.Image")));
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(126, 29);
            this.reservasToolStripMenuItem.Text = "Reservas";
            // 
            // reservasToolStripMenuItem1
            // 
            this.reservasToolStripMenuItem1.Name = "reservasToolStripMenuItem1";
            this.reservasToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.reservasToolStripMenuItem1.Size = new System.Drawing.Size(394, 30);
            this.reservasToolStripMenuItem1.Text = "Reservas";
            this.reservasToolStripMenuItem1.Click += new System.EventHandler(this.reservasToolStripMenuItem1_Click);
            // 
            // filtrarReservasToolStripMenuItem
            // 
            this.filtrarReservasToolStripMenuItem.Name = "filtrarReservasToolStripMenuItem";
            this.filtrarReservasToolStripMenuItem.Size = new System.Drawing.Size(394, 30);
            this.filtrarReservasToolStripMenuItem.Text = "Filtrar Reservas";
            this.filtrarReservasToolStripMenuItem.Click += new System.EventHandler(this.filtrarReservasToolStripMenuItem_Click);
            // 
            // quartosDisponíveisToolStripMenuItem
            // 
            this.quartosDisponíveisToolStripMenuItem.Name = "quartosDisponíveisToolStripMenuItem";
            this.quartosDisponíveisToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Q)));
            this.quartosDisponíveisToolStripMenuItem.Size = new System.Drawing.Size(394, 30);
            this.quartosDisponíveisToolStripMenuItem.Text = "Quartos Disponíveis";
            this.quartosDisponíveisToolStripMenuItem.Click += new System.EventHandler(this.quartosDisponíveisToolStripMenuItem_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(183)))), ((int)(((byte)(219)))));
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contasAPagarToolStripMenuItem,
            this.contasAReceberToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.financeiroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("financeiroToolStripMenuItem.Image")));
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(135, 29);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // contasAPagarToolStripMenuItem
            // 
            this.contasAPagarToolStripMenuItem.Name = "contasAPagarToolStripMenuItem";
            this.contasAPagarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.contasAPagarToolStripMenuItem.Size = new System.Drawing.Size(372, 30);
            this.contasAPagarToolStripMenuItem.Text = "Contas a Pagar";
            this.contasAPagarToolStripMenuItem.Click += new System.EventHandler(this.contasAPagarToolStripMenuItem_Click);
            // 
            // contasAReceberToolStripMenuItem
            // 
            this.contasAReceberToolStripMenuItem.Name = "contasAReceberToolStripMenuItem";
            this.contasAReceberToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.contasAReceberToolStripMenuItem.Size = new System.Drawing.Size(372, 30);
            this.contasAReceberToolStripMenuItem.Text = "Contas a Receber";
            this.contasAReceberToolStripMenuItem.Click += new System.EventHandler(this.contasAReceberToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(372, 30);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            this.relatóriosToolStripMenuItem.Click += new System.EventHandler(this.relatóriosToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(183)))), ((int)(((byte)(219)))));
            this.sobreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sobreToolStripMenuItem.Image")));
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // pictureBoxSair
            // 
            this.pictureBoxSair.BackColor = System.Drawing.Color.Red;
            this.pictureBoxSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSair.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSair.Image")));
            this.pictureBoxSair.Location = new System.Drawing.Point(1305, 222);
            this.pictureBoxSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxSair.Name = "pictureBoxSair";
            this.pictureBoxSair.Size = new System.Drawing.Size(40, 37);
            this.pictureBoxSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSair.TabIndex = 14;
            this.pictureBoxSair.TabStop = false;
            this.pictureBoxSair.Visible = false;
            this.pictureBoxSair.Click += new System.EventHandler(this.pictureBoxSair_Click);
            // 
            // pictureBoxfundo
            // 
            this.pictureBoxfundo.BackColor = System.Drawing.Color.Black;
            this.pictureBoxfundo.Location = new System.Drawing.Point(1303, 220);
            this.pictureBoxfundo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxfundo.Name = "pictureBoxfundo";
            this.pictureBoxfundo.Size = new System.Drawing.Size(45, 42);
            this.pictureBoxfundo.TabIndex = 16;
            this.pictureBoxfundo.TabStop = false;
            this.pictureBoxfundo.Visible = false;
            // 
            // pictureBoxUsu2
            // 
            this.pictureBoxUsu2.BackColor = System.Drawing.Color.PowderBlue;
            this.pictureBoxUsu2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pictureBoxUsu2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUsu2.Image")));
            this.pictureBoxUsu2.Location = new System.Drawing.Point(1292, 47);
            this.pictureBoxUsu2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxUsu2.Name = "pictureBoxUsu2";
            this.pictureBoxUsu2.Size = new System.Drawing.Size(67, 62);
            this.pictureBoxUsu2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUsu2.TabIndex = 15;
            this.pictureBoxUsu2.TabStop = false;
            this.pictureBoxUsu2.UseWaitCursor = true;
            this.pictureBoxUsu2.Visible = false;
            this.pictureBoxUsu2.Click += new System.EventHandler(this.pictureBoxUsu2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(523, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(469, 450);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxUsu1
            // 
            this.pictureBoxUsu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.pictureBoxUsu1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pictureBoxUsu1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUsu1.Image")));
            this.pictureBoxUsu1.Location = new System.Drawing.Point(1292, 47);
            this.pictureBoxUsu1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxUsu1.Name = "pictureBoxUsu1";
            this.pictureBoxUsu1.Size = new System.Drawing.Size(67, 62);
            this.pictureBoxUsu1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUsu1.TabIndex = 15;
            this.pictureBoxUsu1.TabStop = false;
            this.pictureBoxUsu1.UseWaitCursor = true;
            this.pictureBoxUsu1.Click += new System.EventHandler(this.pictureBoxUsu2_Click);
            // 
            // pictureBoxCaixaLogin
            // 
            this.pictureBoxCaixaLogin.BackColor = System.Drawing.Color.PowderBlue;
            this.pictureBoxCaixaLogin.Location = new System.Drawing.Point(1239, 42);
            this.pictureBoxCaixaLogin.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxCaixaLogin.Name = "pictureBoxCaixaLogin";
            this.pictureBoxCaixaLogin.Size = new System.Drawing.Size(176, 225);
            this.pictureBoxCaixaLogin.TabIndex = 8;
            this.pictureBoxCaixaLogin.TabStop = false;
            this.pictureBoxCaixaLogin.Visible = false;
            // 
            // pictureBoxCaixaLogin2
            // 
            this.pictureBoxCaixaLogin2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBoxCaixaLogin2.Location = new System.Drawing.Point(1236, 39);
            this.pictureBoxCaixaLogin2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxCaixaLogin2.Name = "pictureBoxCaixaLogin2";
            this.pictureBoxCaixaLogin2.Size = new System.Drawing.Size(181, 230);
            this.pictureBoxCaixaLogin2.TabIndex = 7;
            this.pictureBoxCaixaLogin2.TabStop = false;
            this.pictureBoxCaixaLogin2.Visible = false;
            // 
            // labelCargoFuncionario
            // 
            this.labelCargoFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(203)))), ((int)(((byte)(254)))));
            this.labelCargoFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCargoFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelCargoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCargoFuncionario.Location = new System.Drawing.Point(1240, 181);
            this.labelCargoFuncionario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCargoFuncionario.Name = "labelCargoFuncionario";
            this.labelCargoFuncionario.Size = new System.Drawing.Size(171, 31);
            this.labelCargoFuncionario.TabIndex = 17;
            this.labelCargoFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCargoFuncionario.Visible = false;
            // 
            // labelNomeFuncionario
            // 
            this.labelNomeFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(203)))), ((int)(((byte)(254)))));
            this.labelNomeFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeFuncionario.Location = new System.Drawing.Point(1240, 113);
            this.labelNomeFuncionario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomeFuncionario.Name = "labelNomeFuncionario";
            this.labelNomeFuncionario.Size = new System.Drawing.Size(171, 59);
            this.labelNomeFuncionario.TabIndex = 18;
            this.labelNomeFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNomeFuncionario.Visible = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1424, 862);
            this.Controls.Add(this.labelNomeFuncionario);
            this.Controls.Add(this.labelCargoFuncionario);
            this.Controls.Add(this.pictureBoxSair);
            this.Controls.Add(this.pictureBoxfundo);
            this.Controls.Add(this.pictureBoxUsu2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.pictureBoxCaixaLogin);
            this.Controls.Add(this.pictureBoxCaixaLogin2);
            this.Controls.Add(this.pictureBoxUsu1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOTELOGIX - Gestão de Hotéis";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPrincipal_KeyDown);
            this.Resize += new System.EventHandler(this.FormPrincipal_Resize);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaixaLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaixaLogin2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
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
        private System.Windows.Forms.ToolStripMenuItem grupoFuncionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxCaixaLogin2;
        private System.Windows.Forms.PictureBox pictureBoxCaixaLogin;
        private System.Windows.Forms.PictureBox pictureBoxSair;
        private System.Windows.Forms.PictureBox pictureBoxUsu2;
        private System.Windows.Forms.PictureBox pictureBoxfundo;
        private System.Windows.Forms.PictureBox pictureBoxUsu1;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quartosDisponíveisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAReceberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeQuartoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acessosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrarReservasToolStripMenuItem;
        private System.Windows.Forms.Label labelCargoFuncionario;
        private System.Windows.Forms.Label labelNomeFuncionario;
    }
}