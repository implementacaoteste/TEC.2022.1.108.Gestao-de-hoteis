﻿namespace WindowsFormsPrincipal1
{
    partial class FormBuscarCliente
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
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label data_nascimentoLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarCliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonCPF = new System.Windows.Forms.RadioButton();
            this.radioButtonNome = new System.Windows.Forms.RadioButton();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.buttonBuscarCliente = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.funcionarioDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.data_nascimentoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.idSexoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox1 = new System.Windows.Forms.TextBox();
            this.cPFMaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.emailTextBox1 = new System.Windows.Forms.TextBox();
            this.enderecoTextBox1 = new System.Windows.Forms.TextBox();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.celularMaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAlterarCliente = new System.Windows.Forms.Button();
            this.buttonExcluirCliente = new System.Windows.Forms.Button();
            this.buttonAdicionarCliente = new System.Windows.Forms.Button();
            this.sexoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            celularLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            data_nascimentoLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(20, 146);
            celularLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(42, 13);
            celularLabel.TabIndex = 14;
            celularLabel.Text = "Celular:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(26, 120);
            emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 12;
            emailLabel.Text = "Email:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(7, 95);
            enderecoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(56, 13);
            enderecoLabel.TabIndex = 10;
            enderecoLabel.Text = "Endereço:";
            // 
            // data_nascimentoLabel
            // 
            data_nascimentoLabel.AutoSize = true;
            data_nascimentoLabel.Location = new System.Drawing.Point(261, 71);
            data_nascimentoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            data_nascimentoLabel.Name = "data_nascimentoLabel";
            data_nascimentoLabel.Size = new System.Drawing.Size(64, 13);
            data_nascimentoLabel.TabIndex = 8;
            data_nascimentoLabel.Text = "Data Nasc.:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(288, 47);
            sexoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(34, 13);
            sexoLabel.TabIndex = 4;
            sexoLabel.Text = "Sexo:";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(32, 71);
            cPFLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(30, 13);
            cPFLabel.TabIndex = 6;
            cPFLabel.Text = "CPF:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(23, 47);
            nomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome:";
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(31, 23);
            idLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(32, 13);
            idLabel1.TabIndex = 0;
            idLabel1.Text = "Cód.:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonTodos);
            this.groupBox1.Controls.Add(this.radioButtonCPF);
            this.groupBox1.Controls.Add(this.radioButtonNome);
            this.groupBox1.Controls.Add(this.textBoxBuscar);
            this.groupBox1.Controls.Add(this.buttonBuscarCliente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(409, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar por";
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonTodos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonTodos.Location = new System.Drawing.Point(4, 17);
            this.radioButtonTodos.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(72, 22);
            this.radioButtonTodos.TabIndex = 0;
            this.radioButtonTodos.TabStop = true;
            this.radioButtonTodos.Text = "Todos";
            this.radioButtonTodos.UseVisualStyleBackColor = false;
            // 
            // radioButtonCPF
            // 
            this.radioButtonCPF.AutoSize = true;
            this.radioButtonCPF.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonCPF.Location = new System.Drawing.Point(162, 17);
            this.radioButtonCPF.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonCPF.Name = "radioButtonCPF";
            this.radioButtonCPF.Size = new System.Drawing.Size(58, 22);
            this.radioButtonCPF.TabIndex = 2;
            this.radioButtonCPF.TabStop = true;
            this.radioButtonCPF.Text = "CPF";
            this.radioButtonCPF.UseVisualStyleBackColor = true;
            // 
            // radioButtonNome
            // 
            this.radioButtonNome.AutoSize = true;
            this.radioButtonNome.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonNome.Location = new System.Drawing.Point(89, 17);
            this.radioButtonNome.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonNome.Name = "radioButtonNome";
            this.radioButtonNome.Size = new System.Drawing.Size(69, 22);
            this.radioButtonNome.TabIndex = 1;
            this.radioButtonNome.TabStop = true;
            this.radioButtonNome.Text = "Nome";
            this.radioButtonNome.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxBuscar.Location = new System.Drawing.Point(4, 44);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(367, 26);
            this.textBoxBuscar.TabIndex = 3;
            // 
            // buttonBuscarCliente
            // 
            this.buttonBuscarCliente.BackColor = System.Drawing.Color.Transparent;
            this.buttonBuscarCliente.FlatAppearance.BorderSize = 0;
            this.buttonBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarCliente.Image = global::WindowsFormsAppGestaoHotel.Properties.Resources.search_bk1;
            this.buttonBuscarCliente.Location = new System.Drawing.Point(375, 42);
            this.buttonBuscarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscarCliente.Name = "buttonBuscarCliente";
            this.buttonBuscarCliente.Size = new System.Drawing.Size(30, 30);
            this.buttonBuscarCliente.TabIndex = 4;
            this.buttonBuscarCliente.UseVisualStyleBackColor = false;
            this.buttonBuscarCliente.Click += new System.EventHandler(this.buttonBuscarCliente_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.funcionarioDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox2.Location = new System.Drawing.Point(13, 110);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(409, 240);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóspedes cadastrados";
            // 
            // funcionarioDataGridView
            // 
            this.funcionarioDataGridView.AllowUserToAddRows = false;
            this.funcionarioDataGridView.AllowUserToDeleteRows = false;
            this.funcionarioDataGridView.AllowUserToOrderColumns = true;
            this.funcionarioDataGridView.AutoGenerateColumns = false;
            this.funcionarioDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.funcionarioDataGridView.ColumnHeadersHeight = 30;
            this.funcionarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.datanascimentoDataGridViewTextBoxColumn,
            this.idSexoDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn});
            this.funcionarioDataGridView.DataSource = this.clienteBindingSource;
            this.funcionarioDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.funcionarioDataGridView.Location = new System.Drawing.Point(4, 17);
            this.funcionarioDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.funcionarioDataGridView.Name = "funcionarioDataGridView";
            this.funcionarioDataGridView.ReadOnly = true;
            this.funcionarioDataGridView.RowHeadersVisible = false;
            this.funcionarioDataGridView.RowHeadersWidth = 10;
            this.funcionarioDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.funcionarioDataGridView.RowTemplate.Height = 24;
            this.funcionarioDataGridView.Size = new System.Drawing.Size(400, 216);
            this.funcionarioDataGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            dataGridViewCellStyle1.NullValue = "0";
            this.cPFDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Visible = false;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "Celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            this.celularDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            this.enderecoDataGridViewTextBoxColumn.Visible = false;
            this.enderecoDataGridViewTextBoxColumn.Width = 125;
            // 
            // datanascimentoDataGridViewTextBoxColumn
            // 
            this.datanascimentoDataGridViewTextBoxColumn.DataPropertyName = "Data_nascimento";
            this.datanascimentoDataGridViewTextBoxColumn.HeaderText = "Data_nascimento";
            this.datanascimentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datanascimentoDataGridViewTextBoxColumn.Name = "datanascimentoDataGridViewTextBoxColumn";
            this.datanascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.datanascimentoDataGridViewTextBoxColumn.Visible = false;
            this.datanascimentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // idSexoDataGridViewTextBoxColumn
            // 
            this.idSexoDataGridViewTextBoxColumn.DataPropertyName = "IdSexo";
            this.idSexoDataGridViewTextBoxColumn.HeaderText = "IdSexo";
            this.idSexoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idSexoDataGridViewTextBoxColumn.Name = "idSexoDataGridViewTextBoxColumn";
            this.idSexoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSexoDataGridViewTextBoxColumn.Visible = false;
            this.idSexoDataGridViewTextBoxColumn.Width = 125;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexoDataGridViewTextBoxColumn.Visible = false;
            this.sexoDataGridViewTextBoxColumn.Width = 125;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Models.Hospede);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.data_nascimentoMaskedTextBox);
            this.groupBox4.Controls.Add(this.idSexoTextBox);
            this.groupBox4.Controls.Add(this.nomeTextBox1);
            this.groupBox4.Controls.Add(this.cPFMaskedTextBox1);
            this.groupBox4.Controls.Add(this.emailTextBox1);
            this.groupBox4.Controls.Add(this.enderecoTextBox1);
            this.groupBox4.Controls.Add(celularLabel);
            this.groupBox4.Controls.Add(emailLabel);
            this.groupBox4.Controls.Add(idLabel1);
            this.groupBox4.Controls.Add(this.idTextBox1);
            this.groupBox4.Controls.Add(enderecoLabel);
            this.groupBox4.Controls.Add(this.celularMaskedTextBox1);
            this.groupBox4.Controls.Add(data_nascimentoLabel);
            this.groupBox4.Controls.Add(sexoLabel);
            this.groupBox4.Controls.Add(cPFLabel);
            this.groupBox4.Controls.Add(nomeLabel);
            this.groupBox4.Location = new System.Drawing.Point(13, 369);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(409, 172);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dados Pessoais";
            // 
            // data_nascimentoMaskedTextBox
            // 
            this.data_nascimentoMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.data_nascimentoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Data_nascimento", true));
            this.data_nascimentoMaskedTextBox.Location = new System.Drawing.Point(323, 68);
            this.data_nascimentoMaskedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.data_nascimentoMaskedTextBox.Mask = "00/00/0000";
            this.data_nascimentoMaskedTextBox.Name = "data_nascimentoMaskedTextBox";
            this.data_nascimentoMaskedTextBox.ReadOnly = true;
            this.data_nascimentoMaskedTextBox.Size = new System.Drawing.Size(76, 20);
            this.data_nascimentoMaskedTextBox.TabIndex = 9;
            this.data_nascimentoMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // idSexoTextBox
            // 
            this.idSexoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idSexoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Sexo", true));
            this.idSexoTextBox.Location = new System.Drawing.Point(323, 45);
            this.idSexoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idSexoTextBox.Name = "idSexoTextBox";
            this.idSexoTextBox.ReadOnly = true;
            this.idSexoTextBox.Size = new System.Drawing.Size(76, 20);
            this.idSexoTextBox.TabIndex = 5;
            // 
            // nomeTextBox1
            // 
            this.nomeTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nome", true));
            this.nomeTextBox1.Location = new System.Drawing.Point(66, 45);
            this.nomeTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.nomeTextBox1.Name = "nomeTextBox1";
            this.nomeTextBox1.ReadOnly = true;
            this.nomeTextBox1.Size = new System.Drawing.Size(188, 20);
            this.nomeTextBox1.TabIndex = 3;
            // 
            // cPFMaskedTextBox1
            // 
            this.cPFMaskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cPFMaskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "CPF", true));
            this.cPFMaskedTextBox1.Location = new System.Drawing.Point(66, 68);
            this.cPFMaskedTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.cPFMaskedTextBox1.Mask = "000,000,000-00";
            this.cPFMaskedTextBox1.Name = "cPFMaskedTextBox1";
            this.cPFMaskedTextBox1.ReadOnly = true;
            this.cPFMaskedTextBox1.Size = new System.Drawing.Size(188, 20);
            this.cPFMaskedTextBox1.TabIndex = 7;
            // 
            // emailTextBox1
            // 
            this.emailTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Email", true));
            this.emailTextBox1.Location = new System.Drawing.Point(66, 119);
            this.emailTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.emailTextBox1.Name = "emailTextBox1";
            this.emailTextBox1.ReadOnly = true;
            this.emailTextBox1.Size = new System.Drawing.Size(334, 20);
            this.emailTextBox1.TabIndex = 13;
            // 
            // enderecoTextBox1
            // 
            this.enderecoTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enderecoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Endereco", true));
            this.enderecoTextBox1.Location = new System.Drawing.Point(66, 93);
            this.enderecoTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.enderecoTextBox1.Name = "enderecoTextBox1";
            this.enderecoTextBox1.ReadOnly = true;
            this.enderecoTextBox1.Size = new System.Drawing.Size(334, 20);
            this.enderecoTextBox1.TabIndex = 11;
            // 
            // idTextBox1
            // 
            this.idTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Id", true));
            this.idTextBox1.Location = new System.Drawing.Point(66, 21);
            this.idTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.ReadOnly = true;
            this.idTextBox1.Size = new System.Drawing.Size(38, 20);
            this.idTextBox1.TabIndex = 1;
            this.idTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // celularMaskedTextBox1
            // 
            this.celularMaskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.celularMaskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Celular", true));
            this.celularMaskedTextBox1.Location = new System.Drawing.Point(66, 141);
            this.celularMaskedTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.celularMaskedTextBox1.Mask = "(99) 00000-0000";
            this.celularMaskedTextBox1.Name = "celularMaskedTextBox1";
            this.celularMaskedTextBox1.ReadOnly = true;
            this.celularMaskedTextBox1.Size = new System.Drawing.Size(113, 20);
            this.celularMaskedTextBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(520, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // buttonAlterarCliente
            // 
            this.buttonAlterarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(183)))), ((int)(((byte)(219)))));
            this.buttonAlterarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlterarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterarCliente.ForeColor = System.Drawing.Color.Black;
            this.buttonAlterarCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlterarCliente.Image")));
            this.buttonAlterarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAlterarCliente.Location = new System.Drawing.Point(165, 578);
            this.buttonAlterarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAlterarCliente.Name = "buttonAlterarCliente";
            this.buttonAlterarCliente.Size = new System.Drawing.Size(120, 33);
            this.buttonAlterarCliente.TabIndex = 4;
            this.buttonAlterarCliente.Text = "Alterar";
            this.buttonAlterarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAlterarCliente.UseVisualStyleBackColor = false;
            this.buttonAlterarCliente.Click += new System.EventHandler(this.buttonAlterarCliente_Click);
            // 
            // buttonExcluirCliente
            // 
            this.buttonExcluirCliente.BackColor = System.Drawing.Color.IndianRed;
            this.buttonExcluirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirCliente.ForeColor = System.Drawing.Color.Black;
            this.buttonExcluirCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluirCliente.Image")));
            this.buttonExcluirCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExcluirCliente.Location = new System.Drawing.Point(302, 578);
            this.buttonExcluirCliente.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExcluirCliente.Name = "buttonExcluirCliente";
            this.buttonExcluirCliente.Size = new System.Drawing.Size(120, 33);
            this.buttonExcluirCliente.TabIndex = 5;
            this.buttonExcluirCliente.Text = "Excluir";
            this.buttonExcluirCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExcluirCliente.UseVisualStyleBackColor = false;
            this.buttonExcluirCliente.Click += new System.EventHandler(this.buttonExcluirCliente_Click);
            this.buttonExcluirCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonExcluirCliente_KeyDown);
            // 
            // buttonAdicionarCliente
            // 
            this.buttonAdicionarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(210)))), ((int)(((byte)(156)))));
            this.buttonAdicionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarCliente.ForeColor = System.Drawing.Color.Black;
            this.buttonAdicionarCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdicionarCliente.Image")));
            this.buttonAdicionarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdicionarCliente.Location = new System.Drawing.Point(17, 578);
            this.buttonAdicionarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdicionarCliente.Name = "buttonAdicionarCliente";
            this.buttonAdicionarCliente.Size = new System.Drawing.Size(128, 33);
            this.buttonAdicionarCliente.TabIndex = 3;
            this.buttonAdicionarCliente.Text = "Adicionar";
            this.buttonAdicionarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdicionarCliente.UseVisualStyleBackColor = false;
            this.buttonAdicionarCliente.Click += new System.EventHandler(this.buttonAdicionarCliente_Click);
            // 
            // sexoBindingSource
            // 
            this.sexoBindingSource.DataSource = typeof(Models.Sexo);
            // 
            // FormBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 622);
            this.Controls.Add(this.buttonAlterarCliente);
            this.Controls.Add(this.buttonExcluirCliente);
            this.Controls.Add(this.buttonAdicionarCliente);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 661);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 661);
            this.Name = "FormBuscarCliente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOTELOGIX - Consulta de Hóspedes";
            this.Load += new System.EventHandler(this.FormBuscarCliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormBuscarCliente_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.RadioButton radioButtonCPF;
        private System.Windows.Forms.RadioButton radioButtonNome;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonBuscarCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView funcionarioDataGridView;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.MaskedTextBox cPFMaskedTextBox1;
        private System.Windows.Forms.MaskedTextBox celularMaskedTextBox1;
        private System.Windows.Forms.TextBox emailTextBox1;
        private System.Windows.Forms.TextBox enderecoTextBox1;
        private System.Windows.Forms.TextBox nomeTextBox1;
        private System.Windows.Forms.TextBox idSexoTextBox;
        private System.Windows.Forms.Button buttonAlterarCliente;
        private System.Windows.Forms.Button buttonExcluirCliente;
        private System.Windows.Forms.Button buttonAdicionarCliente;
        private System.Windows.Forms.BindingSource sexoBindingSource;
        private System.Windows.Forms.MaskedTextBox data_nascimentoMaskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
    }
}