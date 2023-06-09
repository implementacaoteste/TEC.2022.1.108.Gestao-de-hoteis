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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.labelCargoFuncionario = new System.Windows.Forms.Label();
            this.labelNomeFuncionario = new System.Windows.Forms.Label();
            this.pictureBoxUsu2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSair = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCaixaLogin = new System.Windows.Forms.PictureBox();
            this.pictureBoxCaixaLogin2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxUsu1 = new System.Windows.Forms.PictureBox();
            this.checkOutHoje1 = new WindowsFormsAppGestaoHotel.CheckOutHoje();
            this.checkInHoje1 = new WindowsFormsAppGestaoHotel.CheckInHoje();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservasHoje1 = new WindowsFormsAppGestaoHotel.ReservasHoje();
            this.totalHospedes1 = new WindowsFormsAppGestaoHotel.TotalHospedes();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaixaLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaixaLogin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1068, 28);
            this.menuStrip.Stretch = false;
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.funcionarioToolStripMenuItem});
            this.cadastroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroToolStripMenuItem.Image")));
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.cadastroToolStripMenuItem.Text = "Pessoas";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.clienteToolStripMenuItem.Text = "Hóspedes";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.funcionarioToolStripMenuItem.Text = "Funcionários";
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.funcionarioToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quartoToolStripMenuItem,
            this.grupoFuncionarioToolStripMenuItem,
            this.acessosToolStripMenuItem});
            this.consultaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultaToolStripMenuItem.Image")));
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.consultaToolStripMenuItem.Text = "Cadastros";
            // 
            // quartoToolStripMenuItem
            // 
            this.quartoToolStripMenuItem.Name = "quartoToolStripMenuItem";
            this.quartoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quartoToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.quartoToolStripMenuItem.Text = "Quartos";
            this.quartoToolStripMenuItem.Click += new System.EventHandler(this.quartoToolStripMenuItem_Click);
            // 
            // grupoFuncionarioToolStripMenuItem
            // 
            this.grupoFuncionarioToolStripMenuItem.Name = "grupoFuncionarioToolStripMenuItem";
            this.grupoFuncionarioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.grupoFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.grupoFuncionarioToolStripMenuItem.Text = "Cargos";
            this.grupoFuncionarioToolStripMenuItem.Click += new System.EventHandler(this.grupoFuncionarioToolStripMenuItem_Click);
            // 
            // acessosToolStripMenuItem
            // 
            this.acessosToolStripMenuItem.Name = "acessosToolStripMenuItem";
            this.acessosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.acessosToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.acessosToolStripMenuItem.Text = "Acessos";
            this.acessosToolStripMenuItem.Click += new System.EventHandler(this.acessosToolStripMenuItem_Click);
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reservasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservasToolStripMenuItem1,
            this.filtrarReservasToolStripMenuItem,
            this.quartosDisponíveisToolStripMenuItem});
            this.reservasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reservasToolStripMenuItem.Image")));
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.reservasToolStripMenuItem.Text = "Reservas";
            // 
            // reservasToolStripMenuItem1
            // 
            this.reservasToolStripMenuItem1.Name = "reservasToolStripMenuItem1";
            this.reservasToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.reservasToolStripMenuItem1.Size = new System.Drawing.Size(315, 24);
            this.reservasToolStripMenuItem1.Text = "Reservas";
            this.reservasToolStripMenuItem1.Click += new System.EventHandler(this.reservasToolStripMenuItem1_Click);
            // 
            // filtrarReservasToolStripMenuItem
            // 
            this.filtrarReservasToolStripMenuItem.Name = "filtrarReservasToolStripMenuItem";
            this.filtrarReservasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F1)));
            this.filtrarReservasToolStripMenuItem.Size = new System.Drawing.Size(315, 24);
            this.filtrarReservasToolStripMenuItem.Text = "Filtrar Reservas";
            this.filtrarReservasToolStripMenuItem.Click += new System.EventHandler(this.filtrarReservasToolStripMenuItem_Click);
            // 
            // quartosDisponíveisToolStripMenuItem
            // 
            this.quartosDisponíveisToolStripMenuItem.Name = "quartosDisponíveisToolStripMenuItem";
            this.quartosDisponíveisToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Q)));
            this.quartosDisponíveisToolStripMenuItem.Size = new System.Drawing.Size(315, 24);
            this.quartosDisponíveisToolStripMenuItem.Text = "Quartos Disponíveis";
            this.quartosDisponíveisToolStripMenuItem.Click += new System.EventHandler(this.quartosDisponíveisToolStripMenuItem_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contasAPagarToolStripMenuItem,
            this.contasAReceberToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.financeiroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("financeiroToolStripMenuItem.Image")));
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // contasAPagarToolStripMenuItem
            // 
            this.contasAPagarToolStripMenuItem.Name = "contasAPagarToolStripMenuItem";
            this.contasAPagarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.contasAPagarToolStripMenuItem.Size = new System.Drawing.Size(303, 24);
            this.contasAPagarToolStripMenuItem.Text = "Contas a Pagar";
            this.contasAPagarToolStripMenuItem.Click += new System.EventHandler(this.contasAPagarToolStripMenuItem_Click);
            // 
            // contasAReceberToolStripMenuItem
            // 
            this.contasAReceberToolStripMenuItem.Name = "contasAReceberToolStripMenuItem";
            this.contasAReceberToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.contasAReceberToolStripMenuItem.Size = new System.Drawing.Size(303, 24);
            this.contasAReceberToolStripMenuItem.Text = "Contas a Receber";
            this.contasAReceberToolStripMenuItem.Click += new System.EventHandler(this.contasAReceberToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(303, 24);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            this.relatóriosToolStripMenuItem.Click += new System.EventHandler(this.relatóriosToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sobreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sobreToolStripMenuItem.Image")));
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // labelCargoFuncionario
            // 
            this.labelCargoFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            this.labelCargoFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCargoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCargoFuncionario.Location = new System.Drawing.Point(924, 154);
            this.labelCargoFuncionario.Name = "labelCargoFuncionario";
            this.labelCargoFuncionario.Size = new System.Drawing.Size(128, 25);
            this.labelCargoFuncionario.TabIndex = 17;
            this.labelCargoFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCargoFuncionario.Visible = false;
            // 
            // labelNomeFuncionario
            // 
            this.labelNomeFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            this.labelNomeFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeFuncionario.Location = new System.Drawing.Point(924, 99);
            this.labelNomeFuncionario.Name = "labelNomeFuncionario";
            this.labelNomeFuncionario.Size = new System.Drawing.Size(128, 48);
            this.labelNomeFuncionario.TabIndex = 18;
            this.labelNomeFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNomeFuncionario.Visible = false;
            // 
            // pictureBoxUsu2
            // 
            this.pictureBoxUsu2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBoxUsu2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxUsu2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxUsu2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUsu2.Image")));
            this.pictureBoxUsu2.Location = new System.Drawing.Point(963, 42);
            this.pictureBoxUsu2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxUsu2.Name = "pictureBoxUsu2";
            this.pictureBoxUsu2.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxUsu2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUsu2.TabIndex = 15;
            this.pictureBoxUsu2.TabStop = false;
            this.pictureBoxUsu2.Visible = false;
            this.pictureBoxUsu2.Click += new System.EventHandler(this.pictureBoxUsu2_Click);
            // 
            // pictureBoxSair
            // 
            this.pictureBoxSair.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSair.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSair.Image")));
            this.pictureBoxSair.Location = new System.Drawing.Point(973, 188);
            this.pictureBoxSair.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxSair.Name = "pictureBoxSair";
            this.pictureBoxSair.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSair.TabIndex = 14;
            this.pictureBoxSair.TabStop = false;
            this.pictureBoxSair.Visible = false;
            this.pictureBoxSair.Click += new System.EventHandler(this.pictureBoxSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(396, 185);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(352, 366);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxCaixaLogin
            // 
            this.pictureBoxCaixaLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBoxCaixaLogin.Location = new System.Drawing.Point(922, 41);
            this.pictureBoxCaixaLogin.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxCaixaLogin.Name = "pictureBoxCaixaLogin";
            this.pictureBoxCaixaLogin.Size = new System.Drawing.Size(132, 183);
            this.pictureBoxCaixaLogin.TabIndex = 8;
            this.pictureBoxCaixaLogin.TabStop = false;
            this.pictureBoxCaixaLogin.Visible = false;
            // 
            // pictureBoxCaixaLogin2
            // 
            this.pictureBoxCaixaLogin2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBoxCaixaLogin2.Location = new System.Drawing.Point(920, 39);
            this.pictureBoxCaixaLogin2.Name = "pictureBoxCaixaLogin2";
            this.pictureBoxCaixaLogin2.Size = new System.Drawing.Size(136, 187);
            this.pictureBoxCaixaLogin2.TabIndex = 7;
            this.pictureBoxCaixaLogin2.TabStop = false;
            this.pictureBoxCaixaLogin2.Visible = false;
            // 
            // pictureBoxUsu1
            // 
            this.pictureBoxUsu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.pictureBoxUsu1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxUsu1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUsu1.Image")));
            this.pictureBoxUsu1.Location = new System.Drawing.Point(963, 44);
            this.pictureBoxUsu1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxUsu1.Name = "pictureBoxUsu1";
            this.pictureBoxUsu1.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxUsu1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUsu1.TabIndex = 15;
            this.pictureBoxUsu1.TabStop = false;
            this.pictureBoxUsu1.Click += new System.EventHandler(this.pictureBoxUsu2_Click);
            // 
            // checkOutHoje1
            // 
            this.checkOutHoje1.BackColor = System.Drawing.Color.White;
            this.checkOutHoje1.Location = new System.Drawing.Point(233, 41);
            this.checkOutHoje1.Name = "checkOutHoje1";
            this.checkOutHoje1.qtdCheckOut = null;
            this.checkOutHoje1.Size = new System.Drawing.Size(200, 60);
            this.checkOutHoje1.TabIndex = 21;
            // 
            // checkInHoje1
            // 
            this.checkInHoje1.BackColor = System.Drawing.Color.White;
            this.checkInHoje1.Location = new System.Drawing.Point(12, 41);
            this.checkInHoje1.Name = "checkInHoje1";
            this.checkInHoje1.qtdCheckIn = "0";
            this.checkInHoje1.Size = new System.Drawing.Size(200, 60);
            this.checkInHoje1.TabIndex = 20;
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataSource = typeof(Models.Reserva);
            // 
            // reservasHoje1
            // 
            this.reservasHoje1.BackColor = System.Drawing.Color.White;
            this.reservasHoje1.Location = new System.Drawing.Point(454, 41);
            this.reservasHoje1.Name = "reservasHoje1";
            this.reservasHoje1.Size = new System.Drawing.Size(200, 60);
            this.reservasHoje1.TabIndex = 22;
            // 
            // totalHospedes1
            // 
            this.totalHospedes1.BackColor = System.Drawing.Color.White;
            this.totalHospedes1.Location = new System.Drawing.Point(675, 41);
            this.totalHospedes1.Name = "totalHospedes1";
            this.totalHospedes1.Size = new System.Drawing.Size(200, 60);
            this.totalHospedes1.TabIndex = 23;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Models.Hospede);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1068, 700);
            this.Controls.Add(this.totalHospedes1);
            this.Controls.Add(this.reservasHoje1);
            this.Controls.Add(this.checkOutHoje1);
            this.Controls.Add(this.checkInHoje1);
            this.Controls.Add(this.pictureBoxUsu2);
            this.Controls.Add(this.labelNomeFuncionario);
            this.Controls.Add(this.labelCargoFuncionario);
            this.Controls.Add(this.pictureBoxSair);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.pictureBoxCaixaLogin);
            this.Controls.Add(this.pictureBoxCaixaLogin2);
            this.Controls.Add(this.pictureBoxUsu1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOTELOGIX - Gestão de Hotéis";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPrincipal_KeyDown);
            this.Resize += new System.EventHandler(this.FormPrincipal_Resize);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaixaLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaixaLogin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBoxUsu1;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quartosDisponíveisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAReceberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acessosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrarReservasToolStripMenuItem;
        private System.Windows.Forms.Label labelCargoFuncionario;
        private System.Windows.Forms.Label labelNomeFuncionario;
        private System.Windows.Forms.PictureBox pictureBoxUsu2;
        private WindowsFormsAppGestaoHotel.CheckInHoje checkInHoje1;
        private WindowsFormsAppGestaoHotel.CheckOutHoje checkOutHoje1;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private WindowsFormsAppGestaoHotel.ReservasHoje reservasHoje1;
        private WindowsFormsAppGestaoHotel.TotalHospedes totalHospedes1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
    }
}