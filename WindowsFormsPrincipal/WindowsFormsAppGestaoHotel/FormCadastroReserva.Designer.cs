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
            this.diariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valor_TotalTextBox = new System.Windows.Forms.TextBox();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.buttonSelecionarCliente = new System.Windows.Forms.Button();
            this.buttonSelecionarPagamento = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.id_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.id_PagamentoTextBox = new System.Windows.Forms.TextBox();
            this.data_EntradaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.data_SaidaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.quartosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSelecionarQuarto = new System.Windows.Forms.Button();
            this.classeTextBox = new System.Windows.Forms.TextBox();
            this.valor_DiariaTextBox = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.diariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // data_EntradaLabel
            // 
            data_EntradaLabel.AutoSize = true;
            data_EntradaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_EntradaLabel.Location = new System.Drawing.Point(338, 133);
            data_EntradaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            data_EntradaLabel.Name = "data_EntradaLabel";
            data_EntradaLabel.Size = new System.Drawing.Size(73, 20);
            data_EntradaLabel.TabIndex = 13;
            data_EntradaLabel.Text = "Check-In";
            // 
            // data_SaidaLabel
            // 
            data_SaidaLabel.AutoSize = true;
            data_SaidaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_SaidaLabel.Location = new System.Drawing.Point(472, 133);
            data_SaidaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            data_SaidaLabel.Name = "data_SaidaLabel";
            data_SaidaLabel.Size = new System.Drawing.Size(85, 20);
            data_SaidaLabel.TabIndex = 15;
            data_SaidaLabel.Text = "Check-Out";
            // 
            // id_clienteLabel
            // 
            id_clienteLabel.AutoSize = true;
            id_clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_clienteLabel.Location = new System.Drawing.Point(12, 72);
            id_clienteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            id_clienteLabel.Name = "id_clienteLabel";
            id_clienteLabel.Size = new System.Drawing.Size(74, 20);
            id_clienteLabel.TabIndex = 4;
            id_clienteLabel.Text = "Hóspede";
            // 
            // id_PagamentoLabel
            // 
            id_PagamentoLabel.AutoSize = true;
            id_PagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_PagamentoLabel.Location = new System.Drawing.Point(167, 196);
            id_PagamentoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            id_PagamentoLabel.Name = "id_PagamentoLabel";
            id_PagamentoLabel.Size = new System.Drawing.Size(103, 20);
            id_PagamentoLabel.TabIndex = 7;
            id_PagamentoLabel.Text = "Forma PGTO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(12, 133);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 20);
            label1.TabIndex = 10;
            label1.Text = "Quarto";
            // 
            // valor_TotalLabel
            // 
            valor_TotalLabel.AutoSize = true;
            valor_TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valor_TotalLabel.Location = new System.Drawing.Point(472, 194);
            valor_TotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            valor_TotalLabel.Name = "valor_TotalLabel";
            valor_TotalLabel.Size = new System.Drawing.Size(85, 20);
            valor_TotalLabel.TabIndex = 17;
            valor_TotalLabel.Text = "Valor Total";
            // 
            // classeLabel
            // 
            classeLabel.AutoSize = true;
            classeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            classeLabel.Location = new System.Drawing.Point(167, 133);
            classeLabel.Name = "classeLabel";
            classeLabel.Size = new System.Drawing.Size(110, 20);
            classeLabel.TabIndex = 21;
            classeLabel.Text = "Classe Quarto";
            // 
            // valor_DiariaLabel
            // 
            valor_DiariaLabel.AutoSize = true;
            valor_DiariaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valor_DiariaLabel.Location = new System.Drawing.Point(338, 194);
            valor_DiariaLabel.Name = "valor_DiariaLabel";
            valor_DiariaLabel.Size = new System.Drawing.Size(91, 20);
            valor_DiariaLabel.TabIndex = 23;
            valor_DiariaLabel.Text = "Valor Diária";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(512, 72);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(82, 20);
            label2.TabIndex = 4;
            label2.Text = "Hóspedes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(12, 259);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(94, 20);
            label3.TabIndex = 4;
            label3.Text = "Observação";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(12, 194);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(107, 20);
            label4.TabIndex = 23;
            label4.Text = "Valor Entrada";
            // 
            // diariaBindingSource
            // 
            this.diariaBindingSource.DataSource = typeof(Models.Diaria);
            // 
            // valor_TotalTextBox
            // 
            this.valor_TotalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valor_TotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diariaBindingSource, "Valor_Total", true));
            this.valor_TotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor_TotalTextBox.Location = new System.Drawing.Point(476, 218);
            this.valor_TotalTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.valor_TotalTextBox.Name = "valor_TotalTextBox";
            this.valor_TotalTextBox.Size = new System.Drawing.Size(120, 26);
            this.valor_TotalTextBox.TabIndex = 18;
            // 
            // tituloLabel
            // 
            this.tituloLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tituloLabel.Location = new System.Drawing.Point(0, 0);
            this.tituloLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(613, 55);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "Cadastro de Reserva";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonSelecionarCliente
            // 
            this.buttonSelecionarCliente.FlatAppearance.BorderSize = 0;
            this.buttonSelecionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelecionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionarCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelecionarCliente.Image")));
            this.buttonSelecionarCliente.Location = new System.Drawing.Point(434, 95);
            this.buttonSelecionarCliente.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSelecionarCliente.Name = "buttonSelecionarCliente";
            this.buttonSelecionarCliente.Size = new System.Drawing.Size(30, 26);
            this.buttonSelecionarCliente.TabIndex = 6;
            this.buttonSelecionarCliente.UseVisualStyleBackColor = true;
            this.buttonSelecionarCliente.Click += new System.EventHandler(this.buttonSelecionarCliente_Click);
            // 
            // buttonSelecionarPagamento
            // 
            this.buttonSelecionarPagamento.FlatAppearance.BorderSize = 0;
            this.buttonSelecionarPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelecionarPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionarPagamento.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelecionarPagamento.Image")));
            this.buttonSelecionarPagamento.Location = new System.Drawing.Point(292, 218);
            this.buttonSelecionarPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelecionarPagamento.Name = "buttonSelecionarPagamento";
            this.buttonSelecionarPagamento.Size = new System.Drawing.Size(30, 26);
            this.buttonSelecionarPagamento.TabIndex = 9;
            this.buttonSelecionarPagamento.UseVisualStyleBackColor = true;
            this.buttonSelecionarPagamento.Click += new System.EventHandler(this.buttonSelecionarPagamento_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Image = global::WindowsFormsAppGestaoHotel.Properties.Resources.save;
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(363, 366);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(101, 33);
            this.buttonSalvar.TabIndex = 19;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = global::WindowsFormsAppGestaoHotel.Properties.Resources.close;
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(472, 366);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(124, 33);
            this.buttonCancelar.TabIndex = 20;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // id_ClienteTextBox
            // 
            this.id_ClienteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diariaBindingSource, "Nome_Cliente", true));
            this.id_ClienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.id_ClienteTextBox.Location = new System.Drawing.Point(16, 96);
            this.id_ClienteTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.id_ClienteTextBox.Name = "id_ClienteTextBox";
            this.id_ClienteTextBox.Size = new System.Drawing.Size(413, 26);
            this.id_ClienteTextBox.TabIndex = 5;
            // 
            // id_PagamentoTextBox
            // 
            this.id_PagamentoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_PagamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diariaBindingSource, "Pagamento", true));
            this.id_PagamentoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_PagamentoTextBox.Location = new System.Drawing.Point(171, 218);
            this.id_PagamentoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.id_PagamentoTextBox.Name = "id_PagamentoTextBox";
            this.id_PagamentoTextBox.Size = new System.Drawing.Size(119, 26);
            this.id_PagamentoTextBox.TabIndex = 8;
            // 
            // data_EntradaDateTimePicker
            // 
            this.data_EntradaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.diariaBindingSource, "Data_Entrada", true));
            this.data_EntradaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.data_EntradaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_EntradaDateTimePicker.Location = new System.Drawing.Point(342, 157);
            this.data_EntradaDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.data_EntradaDateTimePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.data_EntradaDateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.data_EntradaDateTimePicker.Name = "data_EntradaDateTimePicker";
            this.data_EntradaDateTimePicker.Size = new System.Drawing.Size(117, 26);
            this.data_EntradaDateTimePicker.TabIndex = 14;
            this.data_EntradaDateTimePicker.Value = new System.DateTime(2023, 5, 12, 13, 0, 0, 0);
            // 
            // data_SaidaDateTimePicker
            // 
            this.data_SaidaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.diariaBindingSource, "Data_Saida", true));
            this.data_SaidaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.data_SaidaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_SaidaDateTimePicker.Location = new System.Drawing.Point(476, 157);
            this.data_SaidaDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.data_SaidaDateTimePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.data_SaidaDateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.data_SaidaDateTimePicker.Name = "data_SaidaDateTimePicker";
            this.data_SaidaDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.data_SaidaDateTimePicker.Size = new System.Drawing.Size(120, 26);
            this.data_SaidaDateTimePicker.TabIndex = 16;
            this.data_SaidaDateTimePicker.Value = new System.DateTime(2023, 5, 12, 12, 0, 0, 0);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartosBindingSource, "Numero", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(16, 155);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 26);
            this.textBox1.TabIndex = 11;
            // 
            // quartosBindingSource
            // 
            this.quartosBindingSource.DataMember = "Quartos";
            this.quartosBindingSource.DataSource = this.diariaBindingSource;
            // 
            // buttonSelecionarQuarto
            // 
            this.buttonSelecionarQuarto.FlatAppearance.BorderSize = 0;
            this.buttonSelecionarQuarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelecionarQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionarQuarto.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelecionarQuarto.Image")));
            this.buttonSelecionarQuarto.Location = new System.Drawing.Point(126, 155);
            this.buttonSelecionarQuarto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelecionarQuarto.Name = "buttonSelecionarQuarto";
            this.buttonSelecionarQuarto.Size = new System.Drawing.Size(30, 26);
            this.buttonSelecionarQuarto.TabIndex = 12;
            this.buttonSelecionarQuarto.UseVisualStyleBackColor = true;
            this.buttonSelecionarQuarto.Click += new System.EventHandler(this.buttonSelecionarQuarto_Click_1);
            // 
            // classeTextBox
            // 
            this.classeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartosBindingSource, "Classe", true));
            this.classeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classeTextBox.Location = new System.Drawing.Point(171, 156);
            this.classeTextBox.Name = "classeTextBox";
            this.classeTextBox.Size = new System.Drawing.Size(119, 26);
            this.classeTextBox.TabIndex = 22;
            // 
            // valor_DiariaTextBox
            // 
            this.valor_DiariaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valor_DiariaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartosBindingSource, "Valor_Diaria", true));
            this.valor_DiariaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor_DiariaTextBox.Location = new System.Drawing.Point(342, 218);
            this.valor_DiariaTextBox.Name = "valor_DiariaTextBox";
            this.valor_DiariaTextBox.Size = new System.Drawing.Size(117, 26);
            this.valor_DiariaTextBox.TabIndex = 24;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(516, 95);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 26);
            this.numericUpDown1.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox2.Location = new System.Drawing.Point(16, 281);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(580, 63);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(16, 218);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(106, 26);
            this.textBox3.TabIndex = 24;
            // 
            // FormCadastroDiaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(613, 410);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonSelecionarCliente);
            this.Controls.Add(label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(valor_DiariaLabel);
            this.Controls.Add(this.valor_DiariaTextBox);
            this.Controls.Add(classeLabel);
            this.Controls.Add(this.classeTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonSelecionarQuarto);
            this.Controls.Add(label1);
            this.Controls.Add(this.data_SaidaDateTimePicker);
            this.Controls.Add(this.data_EntradaDateTimePicker);
            this.Controls.Add(this.id_PagamentoTextBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.id_ClienteTextBox);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonSelecionarPagamento);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(valor_TotalLabel);
            this.Controls.Add(this.valor_TotalTextBox);
            this.Controls.Add(id_PagamentoLabel);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.Controls.Add(id_clienteLabel);
            this.Controls.Add(data_SaidaLabel);
            this.Controls.Add(data_EntradaLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(629, 449);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(629, 449);
            this.Name = "FormCadastroDiaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Diaria";
            this.Load += new System.EventHandler(this.FormCadastroDiaria_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadastroDiaria_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.diariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource diariaBindingSource;
        private System.Windows.Forms.TextBox valor_TotalTextBox;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Button buttonSelecionarCliente;
        private System.Windows.Forms.Button buttonSelecionarPagamento;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox id_ClienteTextBox;
        private System.Windows.Forms.TextBox id_PagamentoTextBox;
        private System.Windows.Forms.DateTimePicker data_EntradaDateTimePicker;
        private System.Windows.Forms.DateTimePicker data_SaidaDateTimePicker;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSelecionarQuarto;
        private System.Windows.Forms.BindingSource quartosBindingSource;
        private System.Windows.Forms.TextBox classeTextBox;
        private System.Windows.Forms.TextBox valor_DiariaTextBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}