namespace WindowsFormsAppGestaoHotel
{
    partial class FormReservaCheckIn
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
            System.Windows.Forms.Label numero_QuartoLabel;
            System.Windows.Forms.Label qtd_HospedesLabel;
            System.Windows.Forms.Label valor_TotalLabel;
            System.Windows.Forms.Label valor_RestanteLabel;
            System.Windows.Forms.Label valor_EntradaLabel;
            System.Windows.Forms.Label pagamentoLabel;
            System.Windows.Forms.Label obs_CheckinLabel;
            System.Windows.Forms.Label cPF_HopesdeLabel;
            System.Windows.Forms.Label nome_HospedeLabel;
            System.Windows.Forms.Label label1;
            this.numero_QuartoTextBox = new System.Windows.Forms.TextBox();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qtd_HospedesTextBox = new System.Windows.Forms.TextBox();
            this.valor_TotalTextBox = new System.Windows.Forms.TextBox();
            this.valor_RestanteTextBox = new System.Windows.Forms.TextBox();
            this.valor_EntradaTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCheckin = new System.Windows.Forms.Button();
            this.obs_CheckinTextBox = new System.Windows.Forms.TextBox();
            this.pagamentoComboBox = new System.Windows.Forms.ComboBox();
            this.pagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cPF_HopesdeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.celular_HospedeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.buttonSalvarHospede = new System.Windows.Forms.Button();
            this.flowLayoutPanelHospedes = new System.Windows.Forms.FlowLayoutPanel();
            this.nome_HospedeTextBox = new System.Windows.Forms.TextBox();
            numero_QuartoLabel = new System.Windows.Forms.Label();
            qtd_HospedesLabel = new System.Windows.Forms.Label();
            valor_TotalLabel = new System.Windows.Forms.Label();
            valor_RestanteLabel = new System.Windows.Forms.Label();
            valor_EntradaLabel = new System.Windows.Forms.Label();
            pagamentoLabel = new System.Windows.Forms.Label();
            obs_CheckinLabel = new System.Windows.Forms.Label();
            cPF_HopesdeLabel = new System.Windows.Forms.Label();
            nome_HospedeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // numero_QuartoLabel
            // 
            numero_QuartoLabel.AutoSize = true;
            numero_QuartoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            numero_QuartoLabel.Location = new System.Drawing.Point(4, 20);
            numero_QuartoLabel.Name = "numero_QuartoLabel";
            numero_QuartoLabel.Size = new System.Drawing.Size(58, 20);
            numero_QuartoLabel.TabIndex = 1;
            numero_QuartoLabel.Text = "Quarto";
            // 
            // qtd_HospedesLabel
            // 
            qtd_HospedesLabel.AutoSize = true;
            qtd_HospedesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qtd_HospedesLabel.Location = new System.Drawing.Point(125, 20);
            qtd_HospedesLabel.Name = "qtd_HospedesLabel";
            qtd_HospedesLabel.Size = new System.Drawing.Size(82, 20);
            qtd_HospedesLabel.TabIndex = 2;
            qtd_HospedesLabel.Text = "Hóspedes";
            // 
            // valor_TotalLabel
            // 
            valor_TotalLabel.AutoSize = true;
            valor_TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valor_TotalLabel.Location = new System.Drawing.Point(253, 20);
            valor_TotalLabel.Name = "valor_TotalLabel";
            valor_TotalLabel.Size = new System.Drawing.Size(85, 20);
            valor_TotalLabel.TabIndex = 4;
            valor_TotalLabel.Text = "Valor Total";
            // 
            // valor_RestanteLabel
            // 
            valor_RestanteLabel.AutoSize = true;
            valor_RestanteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valor_RestanteLabel.Location = new System.Drawing.Point(510, 20);
            valor_RestanteLabel.Name = "valor_RestanteLabel";
            valor_RestanteLabel.Size = new System.Drawing.Size(75, 20);
            valor_RestanteLabel.TabIndex = 6;
            valor_RestanteLabel.Text = "Restante";
            // 
            // valor_EntradaLabel
            // 
            valor_EntradaLabel.AutoSize = true;
            valor_EntradaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valor_EntradaLabel.Location = new System.Drawing.Point(383, 20);
            valor_EntradaLabel.Name = "valor_EntradaLabel";
            valor_EntradaLabel.Size = new System.Drawing.Size(66, 20);
            valor_EntradaLabel.TabIndex = 8;
            valor_EntradaLabel.Text = "Entrada";
            // 
            // pagamentoLabel
            // 
            pagamentoLabel.AutoSize = true;
            pagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pagamentoLabel.Location = new System.Drawing.Point(6, 89);
            pagamentoLabel.Name = "pagamentoLabel";
            pagamentoLabel.Size = new System.Drawing.Size(103, 20);
            pagamentoLabel.TabIndex = 10;
            pagamentoLabel.Text = "Forma PGTO";
            // 
            // obs_CheckinLabel
            // 
            obs_CheckinLabel.AutoSize = true;
            obs_CheckinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            obs_CheckinLabel.Location = new System.Drawing.Point(166, 89);
            obs_CheckinLabel.Name = "obs_CheckinLabel";
            obs_CheckinLabel.Size = new System.Drawing.Size(94, 20);
            obs_CheckinLabel.TabIndex = 12;
            obs_CheckinLabel.Text = "Observação";
            // 
            // cPF_HopesdeLabel
            // 
            cPF_HopesdeLabel.AutoSize = true;
            cPF_HopesdeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            cPF_HopesdeLabel.Location = new System.Drawing.Point(6, 77);
            cPF_HopesdeLabel.Name = "cPF_HopesdeLabel";
            cPF_HopesdeLabel.Size = new System.Drawing.Size(92, 20);
            cPF_HopesdeLabel.TabIndex = 0;
            cPF_HopesdeLabel.Text = "Documento";
            // 
            // nome_HospedeLabel
            // 
            nome_HospedeLabel.AutoSize = true;
            nome_HospedeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            nome_HospedeLabel.Location = new System.Drawing.Point(6, 16);
            nome_HospedeLabel.Name = "nome_HospedeLabel";
            nome_HospedeLabel.Size = new System.Drawing.Size(51, 20);
            nome_HospedeLabel.TabIndex = 2;
            nome_HospedeLabel.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label1.Location = new System.Drawing.Point(208, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(71, 20);
            label1.TabIndex = 2;
            label1.Text = "Telefone";
            // 
            // numero_QuartoTextBox
            // 
            this.numero_QuartoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numero_QuartoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Numero_Quarto", true));
            this.numero_QuartoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numero_QuartoTextBox.Location = new System.Drawing.Point(8, 43);
            this.numero_QuartoTextBox.Name = "numero_QuartoTextBox";
            this.numero_QuartoTextBox.ReadOnly = true;
            this.numero_QuartoTextBox.Size = new System.Drawing.Size(100, 26);
            this.numero_QuartoTextBox.TabIndex = 2;
            this.numero_QuartoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataSource = typeof(Models.Reserva);
            // 
            // qtd_HospedesTextBox
            // 
            this.qtd_HospedesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qtd_HospedesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Qtd_Hospedes", true));
            this.qtd_HospedesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.qtd_HospedesTextBox.Location = new System.Drawing.Point(129, 43);
            this.qtd_HospedesTextBox.Name = "qtd_HospedesTextBox";
            this.qtd_HospedesTextBox.ReadOnly = true;
            this.qtd_HospedesTextBox.Size = new System.Drawing.Size(100, 26);
            this.qtd_HospedesTextBox.TabIndex = 3;
            this.qtd_HospedesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // valor_TotalTextBox
            // 
            this.valor_TotalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valor_TotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Valor_Total", true));
            this.valor_TotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.valor_TotalTextBox.Location = new System.Drawing.Point(257, 43);
            this.valor_TotalTextBox.Name = "valor_TotalTextBox";
            this.valor_TotalTextBox.ReadOnly = true;
            this.valor_TotalTextBox.Size = new System.Drawing.Size(100, 26);
            this.valor_TotalTextBox.TabIndex = 5;
            this.valor_TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valor_TotalTextBox.TextChanged += new System.EventHandler(this.valor_TotalTextBox_TextChanged);
            // 
            // valor_RestanteTextBox
            // 
            this.valor_RestanteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valor_RestanteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Valor_Restante", true));
            this.valor_RestanteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.valor_RestanteTextBox.ForeColor = System.Drawing.Color.Black;
            this.valor_RestanteTextBox.Location = new System.Drawing.Point(514, 43);
            this.valor_RestanteTextBox.Name = "valor_RestanteTextBox";
            this.valor_RestanteTextBox.ReadOnly = true;
            this.valor_RestanteTextBox.Size = new System.Drawing.Size(100, 26);
            this.valor_RestanteTextBox.TabIndex = 7;
            this.valor_RestanteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valor_RestanteTextBox.TextChanged += new System.EventHandler(this.valor_RestanteTextBox_TextChanged);
            // 
            // valor_EntradaTextBox
            // 
            this.valor_EntradaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valor_EntradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Valor_Entrada", true));
            this.valor_EntradaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.valor_EntradaTextBox.Location = new System.Drawing.Point(387, 43);
            this.valor_EntradaTextBox.Name = "valor_EntradaTextBox";
            this.valor_EntradaTextBox.ReadOnly = true;
            this.valor_EntradaTextBox.Size = new System.Drawing.Size(100, 26);
            this.valor_EntradaTextBox.TabIndex = 9;
            this.valor_EntradaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valor_EntradaTextBox.TextChanged += new System.EventHandler(this.valor_EntradaTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCheckin);
            this.groupBox1.Controls.Add(obs_CheckinLabel);
            this.groupBox1.Controls.Add(this.obs_CheckinTextBox);
            this.groupBox1.Controls.Add(pagamentoLabel);
            this.groupBox1.Controls.Add(this.pagamentoComboBox);
            this.groupBox1.Controls.Add(numero_QuartoLabel);
            this.groupBox1.Controls.Add(valor_RestanteLabel);
            this.groupBox1.Controls.Add(valor_EntradaLabel);
            this.groupBox1.Controls.Add(this.valor_RestanteTextBox);
            this.groupBox1.Controls.Add(this.valor_EntradaTextBox);
            this.groupBox1.Controls.Add(this.numero_QuartoTextBox);
            this.groupBox1.Controls.Add(this.qtd_HospedesTextBox);
            this.groupBox1.Controls.Add(qtd_HospedesLabel);
            this.groupBox1.Controls.Add(valor_TotalLabel);
            this.groupBox1.Controls.Add(this.valor_TotalTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 181);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reserva";
            // 
            // buttonCheckin
            // 
            this.buttonCheckin.AutoSize = true;
            this.buttonCheckin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(177)))), ((int)(((byte)(229)))));
            this.buttonCheckin.FlatAppearance.BorderSize = 0;
            this.buttonCheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckin.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckin.ForeColor = System.Drawing.Color.White;
            this.buttonCheckin.Location = new System.Drawing.Point(514, 125);
            this.buttonCheckin.Name = "buttonCheckin";
            this.buttonCheckin.Size = new System.Drawing.Size(100, 32);
            this.buttonCheckin.TabIndex = 14;
            this.buttonCheckin.Text = "CHECK IN";
            this.buttonCheckin.UseVisualStyleBackColor = false;
            this.buttonCheckin.Click += new System.EventHandler(this.buttonCheckin_Click);
            // 
            // obs_CheckinTextBox
            // 
            this.obs_CheckinTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.obs_CheckinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Obs_Checkin", true));
            this.obs_CheckinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.obs_CheckinTextBox.Location = new System.Drawing.Point(170, 111);
            this.obs_CheckinTextBox.Multiline = true;
            this.obs_CheckinTextBox.Name = "obs_CheckinTextBox";
            this.obs_CheckinTextBox.Size = new System.Drawing.Size(317, 60);
            this.obs_CheckinTextBox.TabIndex = 13;
            // 
            // pagamentoComboBox
            // 
            this.pagamentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Pagamento", true));
            this.pagamentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.reservaBindingSource, "Pagamento", true));
            this.pagamentoComboBox.DataSource = this.pagamentoBindingSource;
            this.pagamentoComboBox.DisplayMember = "Forma_pagamento";
            this.pagamentoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.pagamentoComboBox.FormattingEnabled = true;
            this.pagamentoComboBox.Location = new System.Drawing.Point(10, 112);
            this.pagamentoComboBox.Name = "pagamentoComboBox";
            this.pagamentoComboBox.Size = new System.Drawing.Size(121, 26);
            this.pagamentoComboBox.TabIndex = 11;
            this.pagamentoComboBox.ValueMember = "Id";
            // 
            // pagamentoBindingSource
            // 
            this.pagamentoBindingSource.DataSource = typeof(Models.Pagamento);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cPF_HopesdeMaskedTextBox);
            this.groupBox2.Controls.Add(this.celular_HospedeMaskedTextBox);
            this.groupBox2.Controls.Add(this.buttonSalvarHospede);
            this.groupBox2.Controls.Add(this.flowLayoutPanelHospedes);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(nome_HospedeLabel);
            this.groupBox2.Controls.Add(this.nome_HospedeTextBox);
            this.groupBox2.Controls.Add(cPF_HopesdeLabel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(623, 144);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóspedes";
            // 
            // cPF_HopesdeMaskedTextBox
            // 
            this.cPF_HopesdeMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "CPF_Hopesde", true));
            this.cPF_HopesdeMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cPF_HopesdeMaskedTextBox.Location = new System.Drawing.Point(10, 97);
            this.cPF_HopesdeMaskedTextBox.Mask = "000,000,000-00";
            this.cPF_HopesdeMaskedTextBox.Name = "cPF_HopesdeMaskedTextBox";
            this.cPF_HopesdeMaskedTextBox.Size = new System.Drawing.Size(180, 26);
            this.cPF_HopesdeMaskedTextBox.TabIndex = 16;
            // 
            // celular_HospedeMaskedTextBox
            // 
            this.celular_HospedeMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Celular_Hospede", true));
            this.celular_HospedeMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.celular_HospedeMaskedTextBox.Location = new System.Drawing.Point(212, 39);
            this.celular_HospedeMaskedTextBox.Mask = "(99) 00000-0000";
            this.celular_HospedeMaskedTextBox.Name = "celular_HospedeMaskedTextBox";
            this.celular_HospedeMaskedTextBox.Size = new System.Drawing.Size(126, 26);
            this.celular_HospedeMaskedTextBox.TabIndex = 15;
            // 
            // buttonSalvarHospede
            // 
            this.buttonSalvarHospede.AutoSize = true;
            this.buttonSalvarHospede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(179)))), ((int)(((byte)(122)))));
            this.buttonSalvarHospede.FlatAppearance.BorderSize = 0;
            this.buttonSalvarHospede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvarHospede.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarHospede.ForeColor = System.Drawing.Color.White;
            this.buttonSalvarHospede.Location = new System.Drawing.Point(212, 94);
            this.buttonSalvarHospede.Name = "buttonSalvarHospede";
            this.buttonSalvarHospede.Size = new System.Drawing.Size(126, 32);
            this.buttonSalvarHospede.TabIndex = 14;
            this.buttonSalvarHospede.Text = "SALVAR";
            this.buttonSalvarHospede.UseVisualStyleBackColor = false;
            this.buttonSalvarHospede.Click += new System.EventHandler(this.buttonSalvarHospede_Click);
            // 
            // flowLayoutPanelHospedes
            // 
            this.flowLayoutPanelHospedes.AutoScroll = true;
            this.flowLayoutPanelHospedes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelHospedes.Location = new System.Drawing.Point(355, 16);
            this.flowLayoutPanelHospedes.Name = "flowLayoutPanelHospedes";
            this.flowLayoutPanelHospedes.Size = new System.Drawing.Size(259, 120);
            this.flowLayoutPanelHospedes.TabIndex = 4;
            // 
            // nome_HospedeTextBox
            // 
            this.nome_HospedeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nome_HospedeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Nome_Hospede", true));
            this.nome_HospedeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nome_HospedeTextBox.Location = new System.Drawing.Point(10, 39);
            this.nome_HospedeTextBox.Name = "nome_HospedeTextBox";
            this.nome_HospedeTextBox.Size = new System.Drawing.Size(180, 26);
            this.nome_HospedeTextBox.TabIndex = 3;
            // 
            // FormReservaCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(646, 355);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReservaCheckIn";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormReservaCheckIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource reservaBindingSource;
        private System.Windows.Forms.TextBox numero_QuartoTextBox;
        private System.Windows.Forms.TextBox qtd_HospedesTextBox;
        private System.Windows.Forms.TextBox valor_TotalTextBox;
        private System.Windows.Forms.TextBox valor_RestanteTextBox;
        private System.Windows.Forms.TextBox valor_EntradaTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox obs_CheckinTextBox;
        private System.Windows.Forms.ComboBox pagamentoComboBox;
        private System.Windows.Forms.Button buttonCheckin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox nome_HospedeTextBox;
        private System.Windows.Forms.Button buttonSalvarHospede;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHospedes;
        private System.Windows.Forms.MaskedTextBox cPF_HopesdeMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox celular_HospedeMaskedTextBox;
        private System.Windows.Forms.BindingSource pagamentoBindingSource;
    }
}