﻿namespace WindowsFormsAppGestaoHotel
{
    partial class FormCadastroReserva
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
            System.Windows.Forms.Label data_EntradaLabel;
            System.Windows.Forms.Label data_SaidaLabel;
            System.Windows.Forms.Label id_clienteLabel;
            System.Windows.Forms.Label id_PagamentoLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label valor_TotalLabel;
            System.Windows.Forms.Label classeLabel;
            System.Windows.Forms.Label valor_DiariaLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroReserva));
            this.tituloLabel = new System.Windows.Forms.Label();
            this.id_HospedeTextBox = new System.Windows.Forms.TextBox();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_PagamentoTextBox = new System.Windows.Forms.TextBox();
            this.data_Ent_ReservaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.data_SaidaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tipo_QuartoTextBox = new System.Windows.Forms.TextBox();
            this.qtd_HospedesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.obs_ReservaTextBox = new System.Windows.Forms.TextBox();
            this.numero_QuartoTextBox = new System.Windows.Forms.TextBox();
            this.quartosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSelecionarCliente = new System.Windows.Forms.Button();
            this.buttonSelecionarQuarto = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonSelecionarPagamento = new System.Windows.Forms.Button();
            this.valor_DiariaTextBox = new ComponentesDesktop.TextBoxDinheiro();
            this.valor_EntradaTextBox = new ComponentesDesktop.TextBoxDinheiro();
            this.valor_TotalTextBox = new ComponentesDesktop.TextBoxDinheiro();
            data_EntradaLabel = new System.Windows.Forms.Label();
            data_SaidaLabel = new System.Windows.Forms.Label();
            id_clienteLabel = new System.Windows.Forms.Label();
            id_PagamentoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            valor_TotalLabel = new System.Windows.Forms.Label();
            classeLabel = new System.Windows.Forms.Label();
            valor_DiariaLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtd_HospedesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // data_EntradaLabel
            // 
            data_EntradaLabel.AutoSize = true;
            data_EntradaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_EntradaLabel.Location = new System.Drawing.Point(451, 164);
            data_EntradaLabel.Name = "data_EntradaLabel";
            data_EntradaLabel.Size = new System.Drawing.Size(92, 25);
            data_EntradaLabel.TabIndex = 11;
            data_EntradaLabel.Text = "Check-In";
            // 
            // data_SaidaLabel
            // 
            data_SaidaLabel.AutoSize = true;
            data_SaidaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_SaidaLabel.Location = new System.Drawing.Point(629, 164);
            data_SaidaLabel.Name = "data_SaidaLabel";
            data_SaidaLabel.Size = new System.Drawing.Size(108, 25);
            data_SaidaLabel.TabIndex = 13;
            data_SaidaLabel.Text = "Check-Out";
            // 
            // id_clienteLabel
            // 
            id_clienteLabel.AutoSize = true;
            id_clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_clienteLabel.Location = new System.Drawing.Point(16, 89);
            id_clienteLabel.Name = "id_clienteLabel";
            id_clienteLabel.Size = new System.Drawing.Size(91, 25);
            id_clienteLabel.TabIndex = 1;
            id_clienteLabel.Text = "Hóspede";
            // 
            // id_PagamentoLabel
            // 
            id_PagamentoLabel.AutoSize = true;
            id_PagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_PagamentoLabel.Location = new System.Drawing.Point(223, 239);
            id_PagamentoLabel.Name = "id_PagamentoLabel";
            id_PagamentoLabel.Size = new System.Drawing.Size(130, 25);
            id_PagamentoLabel.TabIndex = 17;
            id_PagamentoLabel.Text = "Forma PGTO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(16, 164);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 25);
            label1.TabIndex = 6;
            label1.Text = "Quarto";
            // 
            // valor_TotalLabel
            // 
            valor_TotalLabel.AutoSize = true;
            valor_TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valor_TotalLabel.Location = new System.Drawing.Point(629, 239);
            valor_TotalLabel.Name = "valor_TotalLabel";
            valor_TotalLabel.Size = new System.Drawing.Size(107, 25);
            valor_TotalLabel.TabIndex = 22;
            valor_TotalLabel.Text = "Valor Total";
            // 
            // classeLabel
            // 
            classeLabel.AutoSize = true;
            classeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            classeLabel.Location = new System.Drawing.Point(223, 164);
            classeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            classeLabel.Name = "classeLabel";
            classeLabel.Size = new System.Drawing.Size(116, 25);
            classeLabel.TabIndex = 9;
            classeLabel.Text = "Tipo Quarto";
            // 
            // valor_DiariaLabel
            // 
            valor_DiariaLabel.AutoSize = true;
            valor_DiariaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valor_DiariaLabel.Location = new System.Drawing.Point(451, 239);
            valor_DiariaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            valor_DiariaLabel.Name = "valor_DiariaLabel";
            valor_DiariaLabel.Size = new System.Drawing.Size(113, 25);
            valor_DiariaLabel.TabIndex = 20;
            valor_DiariaLabel.Text = "Valor Diária";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(683, 89);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(101, 25);
            label2.TabIndex = 4;
            label2.Text = "Hóspedes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(16, 319);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(119, 25);
            label3.TabIndex = 24;
            label3.Text = "Observação";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(16, 239);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(131, 25);
            label4.TabIndex = 15;
            label4.Text = "Valor Entrada";
            // 
            // tituloLabel
            // 
            this.tituloLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tituloLabel.Location = new System.Drawing.Point(0, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(815, 74);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "Cadastro de Reserva";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id_HospedeTextBox
            // 
            this.id_HospedeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_HospedeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Nome_Hospede", true));
            this.id_HospedeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.id_HospedeTextBox.Location = new System.Drawing.Point(21, 119);
            this.id_HospedeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_HospedeTextBox.Name = "id_HospedeTextBox";
            this.id_HospedeTextBox.Size = new System.Drawing.Size(550, 30);
            this.id_HospedeTextBox.TabIndex = 2;
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataSource = typeof(Models.Reserva);
            // 
            // id_PagamentoTextBox
            // 
            this.id_PagamentoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_PagamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Pagamento", true));
            this.id_PagamentoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_PagamentoTextBox.Location = new System.Drawing.Point(228, 268);
            this.id_PagamentoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_PagamentoTextBox.Name = "id_PagamentoTextBox";
            this.id_PagamentoTextBox.Size = new System.Drawing.Size(158, 30);
            this.id_PagamentoTextBox.TabIndex = 18;
            // 
            // data_Ent_ReservaDateTimePicker
            // 
            this.data_Ent_ReservaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "Data_Ent_Reserva", true));
            this.data_Ent_ReservaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.data_Ent_ReservaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_Ent_ReservaDateTimePicker.Location = new System.Drawing.Point(456, 193);
            this.data_Ent_ReservaDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_Ent_ReservaDateTimePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.data_Ent_ReservaDateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.data_Ent_ReservaDateTimePicker.Name = "data_Ent_ReservaDateTimePicker";
            this.data_Ent_ReservaDateTimePicker.Size = new System.Drawing.Size(155, 30);
            this.data_Ent_ReservaDateTimePicker.TabIndex = 12;
            this.data_Ent_ReservaDateTimePicker.Value = new System.DateTime(2023, 5, 12, 0, 0, 0, 0);
            // 
            // data_SaidaDateTimePicker
            // 
            this.data_SaidaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "Data_Sai_Reserva", true));
            this.data_SaidaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.data_SaidaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_SaidaDateTimePicker.Location = new System.Drawing.Point(635, 193);
            this.data_SaidaDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_SaidaDateTimePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.data_SaidaDateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.data_SaidaDateTimePicker.Name = "data_SaidaDateTimePicker";
            this.data_SaidaDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.data_SaidaDateTimePicker.Size = new System.Drawing.Size(159, 30);
            this.data_SaidaDateTimePicker.TabIndex = 14;
            this.data_SaidaDateTimePicker.Value = new System.DateTime(2023, 5, 13, 0, 0, 0, 0);
            this.data_SaidaDateTimePicker.CloseUp += new System.EventHandler(this.data_SaidaDateTimePicker_CloseUp);
            // 
            // tipo_QuartoTextBox
            // 
            this.tipo_QuartoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipo_QuartoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Tipo_Quarto", true));
            this.tipo_QuartoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo_QuartoTextBox.Location = new System.Drawing.Point(228, 193);
            this.tipo_QuartoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tipo_QuartoTextBox.Name = "tipo_QuartoTextBox";
            this.tipo_QuartoTextBox.Size = new System.Drawing.Size(158, 30);
            this.tipo_QuartoTextBox.TabIndex = 10;
            // 
            // qtd_HospedesNumericUpDown
            // 
            this.qtd_HospedesNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qtd_HospedesNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "Qtd_Hospedes", true));
            this.qtd_HospedesNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtd_HospedesNumericUpDown.Location = new System.Drawing.Point(688, 118);
            this.qtd_HospedesNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.qtd_HospedesNumericUpDown.Name = "qtd_HospedesNumericUpDown";
            this.qtd_HospedesNumericUpDown.Size = new System.Drawing.Size(107, 30);
            this.qtd_HospedesNumericUpDown.TabIndex = 5;
            this.qtd_HospedesNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // obs_ReservaTextBox
            // 
            this.obs_ReservaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.obs_ReservaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Obs_Reserva", true));
            this.obs_ReservaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.obs_ReservaTextBox.Location = new System.Drawing.Point(21, 346);
            this.obs_ReservaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.obs_ReservaTextBox.Multiline = true;
            this.obs_ReservaTextBox.Name = "obs_ReservaTextBox";
            this.obs_ReservaTextBox.Size = new System.Drawing.Size(773, 77);
            this.obs_ReservaTextBox.TabIndex = 25;
            // 
            // numero_QuartoTextBox
            // 
            this.numero_QuartoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numero_QuartoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Numero_Quarto", true));
            this.numero_QuartoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numero_QuartoTextBox.Location = new System.Drawing.Point(21, 194);
            this.numero_QuartoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numero_QuartoTextBox.Name = "numero_QuartoTextBox";
            this.numero_QuartoTextBox.Size = new System.Drawing.Size(141, 30);
            this.numero_QuartoTextBox.TabIndex = 7;
            this.numero_QuartoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // quartosBindingSource
            // 
            this.quartosBindingSource.DataMember = "Quartos";
            this.quartosBindingSource.DataSource = this.reservaBindingSource;
            // 
            // buttonSelecionarCliente
            // 
            this.buttonSelecionarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(93)))), ((int)(((byte)(168)))));
            this.buttonSelecionarCliente.FlatAppearance.BorderSize = 0;
            this.buttonSelecionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelecionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionarCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelecionarCliente.Image")));
            this.buttonSelecionarCliente.Location = new System.Drawing.Point(579, 117);
            this.buttonSelecionarCliente.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSelecionarCliente.Name = "buttonSelecionarCliente";
            this.buttonSelecionarCliente.Size = new System.Drawing.Size(40, 37);
            this.buttonSelecionarCliente.TabIndex = 3;
            this.buttonSelecionarCliente.UseVisualStyleBackColor = false;
            this.buttonSelecionarCliente.Click += new System.EventHandler(this.buttonSelecionarCliente_Click);
            // 
            // buttonSelecionarQuarto
            // 
            this.buttonSelecionarQuarto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(93)))), ((int)(((byte)(168)))));
            this.buttonSelecionarQuarto.FlatAppearance.BorderSize = 0;
            this.buttonSelecionarQuarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelecionarQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionarQuarto.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelecionarQuarto.Image")));
            this.buttonSelecionarQuarto.Location = new System.Drawing.Point(168, 192);
            this.buttonSelecionarQuarto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelecionarQuarto.Name = "buttonSelecionarQuarto";
            this.buttonSelecionarQuarto.Size = new System.Drawing.Size(40, 37);
            this.buttonSelecionarQuarto.TabIndex = 8;
            this.buttonSelecionarQuarto.UseVisualStyleBackColor = false;
            this.buttonSelecionarQuarto.Click += new System.EventHandler(this.buttonSelecionarQuarto_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(77)))), ((int)(((byte)(87)))));
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(595, 449);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(200, 41);
            this.buttonCancelar.TabIndex = 27;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(179)))), ((int)(((byte)(122)))));
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.ForeColor = System.Drawing.Color.White;
            this.buttonSalvar.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalvar.Image")));
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(429, 449);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(160, 41);
            this.buttonSalvar.TabIndex = 26;
            this.buttonSalvar.Text = "SALVAR";
            this.buttonSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonSelecionarPagamento
            // 
            this.buttonSelecionarPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(93)))), ((int)(((byte)(168)))));
            this.buttonSelecionarPagamento.FlatAppearance.BorderSize = 0;
            this.buttonSelecionarPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelecionarPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionarPagamento.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelecionarPagamento.Image")));
            this.buttonSelecionarPagamento.Location = new System.Drawing.Point(392, 266);
            this.buttonSelecionarPagamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelecionarPagamento.Name = "buttonSelecionarPagamento";
            this.buttonSelecionarPagamento.Size = new System.Drawing.Size(40, 37);
            this.buttonSelecionarPagamento.TabIndex = 19;
            this.buttonSelecionarPagamento.UseVisualStyleBackColor = false;
            this.buttonSelecionarPagamento.Click += new System.EventHandler(this.buttonSelecionarPagamento_Click);
            // 
            // valor_DiariaTextBox
            // 
            this.valor_DiariaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valor_DiariaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartosBindingSource, "Valor_Diaria", true));
            this.valor_DiariaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.valor_DiariaTextBox.Location = new System.Drawing.Point(456, 268);
            this.valor_DiariaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valor_DiariaTextBox.Name = "valor_DiariaTextBox";
            this.valor_DiariaTextBox.Size = new System.Drawing.Size(155, 30);
            this.valor_DiariaTextBox.TabIndex = 21;
            this.valor_DiariaTextBox.Text = "R$ 0,00";
            this.valor_DiariaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // valor_EntradaTextBox
            // 
            this.valor_EntradaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valor_EntradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Valor_Entrada", true));
            this.valor_EntradaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.valor_EntradaTextBox.Location = new System.Drawing.Point(21, 268);
            this.valor_EntradaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.valor_EntradaTextBox.Name = "valor_EntradaTextBox";
            this.valor_EntradaTextBox.Size = new System.Drawing.Size(141, 30);
            this.valor_EntradaTextBox.TabIndex = 16;
            this.valor_EntradaTextBox.Text = "R$ 0,00";
            this.valor_EntradaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // valor_TotalTextBox
            // 
            this.valor_TotalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valor_TotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Valor_Total", true));
            this.valor_TotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.valor_TotalTextBox.Location = new System.Drawing.Point(635, 268);
            this.valor_TotalTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.valor_TotalTextBox.Name = "valor_TotalTextBox";
            this.valor_TotalTextBox.Size = new System.Drawing.Size(159, 30);
            this.valor_TotalTextBox.TabIndex = 23;
            this.valor_TotalTextBox.Text = "R$ 0,00";
            this.valor_TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormCadastroReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(815, 494);
            this.Controls.Add(this.valor_TotalTextBox);
            this.Controls.Add(this.valor_DiariaTextBox);
            this.Controls.Add(this.valor_EntradaTextBox);
            this.Controls.Add(this.numero_QuartoTextBox);
            this.Controls.Add(this.qtd_HospedesNumericUpDown);
            this.Controls.Add(this.buttonSelecionarCliente);
            this.Controls.Add(label4);
            this.Controls.Add(valor_DiariaLabel);
            this.Controls.Add(classeLabel);
            this.Controls.Add(this.tipo_QuartoTextBox);
            this.Controls.Add(this.buttonSelecionarQuarto);
            this.Controls.Add(label1);
            this.Controls.Add(this.data_SaidaDateTimePicker);
            this.Controls.Add(this.data_Ent_ReservaDateTimePicker);
            this.Controls.Add(this.id_PagamentoTextBox);
            this.Controls.Add(this.obs_ReservaTextBox);
            this.Controls.Add(this.id_HospedeTextBox);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonSelecionarPagamento);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(valor_TotalLabel);
            this.Controls.Add(id_PagamentoLabel);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.Controls.Add(id_clienteLabel);
            this.Controls.Add(data_SaidaLabel);
            this.Controls.Add(data_EntradaLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(833, 541);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(833, 541);
            this.Name = "FormCadastroReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOTELOGIX - Cadastro de Reserva";
            this.Load += new System.EventHandler(this.FormCadastroReserva_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadastroDiaria_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtd_HospedesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Button buttonSelecionarCliente;
        private System.Windows.Forms.Button buttonSelecionarPagamento;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox id_HospedeTextBox;
        private System.Windows.Forms.TextBox id_PagamentoTextBox;
        private System.Windows.Forms.DateTimePicker data_Ent_ReservaDateTimePicker;
        private System.Windows.Forms.DateTimePicker data_SaidaDateTimePicker;
        private System.Windows.Forms.Button buttonSelecionarQuarto;
        private System.Windows.Forms.TextBox tipo_QuartoTextBox;
        private System.Windows.Forms.NumericUpDown qtd_HospedesNumericUpDown;
        private System.Windows.Forms.TextBox obs_ReservaTextBox;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private System.Windows.Forms.TextBox numero_QuartoTextBox;
        private System.Windows.Forms.BindingSource quartosBindingSource;
        private ComponentesDesktop.TextBoxDinheiro valor_EntradaTextBox;
        private ComponentesDesktop.TextBoxDinheiro valor_DiariaTextBox;
        private ComponentesDesktop.TextBoxDinheiro valor_TotalTextBox;
    }
}