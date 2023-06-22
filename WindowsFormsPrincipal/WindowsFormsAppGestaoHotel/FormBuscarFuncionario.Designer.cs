namespace WindowsFormsPrincipal1
{
    partial class FormBuscarFuncionario
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label data_nascimentoLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label nomeUsuarioLabel;
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label nomeGrupoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarFuncionario));
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.funcionarioDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonCPF = new System.Windows.Forms.RadioButton();
            this.radioButtonNome = new System.Windows.Forms.RadioButton();
            this.buttonBuscarFuncionario = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grupoFuncionariosDataGridView = new System.Windows.Forms.DataGridView();
            this.grupoFuncionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.data_nascimentoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.idSexoTextBox = new System.Windows.Forms.TextBox();
            this.celularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cPFMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.nomeGrupoTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.nomeUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.buttonAlterarFuncionario = new System.Windows.Forms.Button();
            this.buttonExcluirGrupoFuncionario = new System.Windows.Forms.Button();
            this.buttonAdicionarGrupoFuncionario = new System.Windows.Forms.Button();
            this.buttonExcluirFuncionario = new System.Windows.Forms.Button();
            this.buttonAdicionarFuncionario = new System.Windows.Forms.Button();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            data_nascimentoLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            nomeUsuarioLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            nomeGrupoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupoFuncionariosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoFuncionariosBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(44, 26);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(60, 25);
            idLabel.TabIndex = 0;
            idLabel.Text = "Cód.:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(29, 63);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(70, 25);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome:";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cPFLabel.Location = new System.Drawing.Point(41, 103);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(58, 25);
            cPFLabel.TabIndex = 6;
            cPFLabel.Text = "CPF:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sexoLabel.Location = new System.Drawing.Point(418, 65);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(64, 25);
            sexoLabel.TabIndex = 4;
            sexoLabel.Text = "Sexo:";
            // 
            // data_nascimentoLabel
            // 
            data_nascimentoLabel.AutoSize = true;
            data_nascimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_nascimentoLabel.Location = new System.Drawing.Point(371, 101);
            data_nascimentoLabel.Name = "data_nascimentoLabel";
            data_nascimentoLabel.Size = new System.Drawing.Size(114, 25);
            data_nascimentoLabel.TabIndex = 8;
            data_nascimentoLabel.Text = "Data Nasc.:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            enderecoLabel.Location = new System.Drawing.Point(2, 146);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(102, 25);
            enderecoLabel.TabIndex = 10;
            enderecoLabel.Text = "Endereço:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(33, 191);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(66, 25);
            emailLabel.TabIndex = 12;
            emailLabel.Text = "Email:";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            celularLabel.Location = new System.Drawing.Point(24, 244);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(80, 25);
            celularLabel.TabIndex = 14;
            celularLabel.Text = "Celular:";
            // 
            // nomeUsuarioLabel
            // 
            nomeUsuarioLabel.AutoSize = true;
            nomeUsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            nomeUsuarioLabel.Location = new System.Drawing.Point(19, 23);
            nomeUsuarioLabel.Name = "nomeUsuarioLabel";
            nomeUsuarioLabel.Size = new System.Drawing.Size(85, 25);
            nomeUsuarioLabel.TabIndex = 0;
            nomeUsuarioLabel.Text = "Usuário:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            senhaLabel.Location = new System.Drawing.Point(29, 62);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(76, 25);
            senhaLabel.TabIndex = 2;
            senhaLabel.Text = "Senha:";
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            idLabel1.Location = new System.Drawing.Point(123, 25);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(60, 25);
            idLabel1.TabIndex = 0;
            idLabel1.Text = "Cód.:";
            // 
            // nomeGrupoLabel
            // 
            nomeGrupoLabel.AutoSize = true;
            nomeGrupoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            nomeGrupoLabel.Location = new System.Drawing.Point(19, 62);
            nomeGrupoLabel.Name = "nomeGrupoLabel";
            nomeGrupoLabel.Size = new System.Drawing.Size(156, 25);
            nomeGrupoLabel.TabIndex = 2;
            nomeGrupoLabel.Text = "Nome do Cargo:";
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxBuscar.Location = new System.Drawing.Point(5, 58);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(538, 30);
            this.textBoxBuscar.TabIndex = 3;
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.Senha,
            this.dataGridViewCheckBoxColumn1});
            this.funcionarioDataGridView.DataSource = this.funcionarioBindingSource;
            this.funcionarioDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.funcionarioDataGridView.Location = new System.Drawing.Point(5, 21);
            this.funcionarioDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.funcionarioDataGridView.Name = "funcionarioDataGridView";
            this.funcionarioDataGridView.ReadOnly = true;
            this.funcionarioDataGridView.RowHeadersVisible = false;
            this.funcionarioDataGridView.RowHeadersWidth = 10;
            this.funcionarioDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.funcionarioDataGridView.RowTemplate.Height = 24;
            this.funcionarioDataGridView.Size = new System.Drawing.Size(584, 266);
            this.funcionarioDataGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonTodos);
            this.groupBox1.Controls.Add(this.radioButtonCPF);
            this.groupBox1.Controls.Add(this.radioButtonNome);
            this.groupBox1.Controls.Add(this.textBoxBuscar);
            this.groupBox1.Controls.Add(this.buttonBuscarFuncionario);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(606, 100);
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
            this.radioButtonTodos.Location = new System.Drawing.Point(5, 22);
            this.radioButtonTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(85, 25);
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
            this.radioButtonCPF.Location = new System.Drawing.Point(212, 22);
            this.radioButtonCPF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonCPF.Name = "radioButtonCPF";
            this.radioButtonCPF.Size = new System.Drawing.Size(72, 25);
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
            this.radioButtonNome.Location = new System.Drawing.Point(115, 22);
            this.radioButtonNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonNome.Name = "radioButtonNome";
            this.radioButtonNome.Size = new System.Drawing.Size(83, 25);
            this.radioButtonNome.TabIndex = 1;
            this.radioButtonNome.TabStop = true;
            this.radioButtonNome.Text = "Nome";
            this.radioButtonNome.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarFuncionario
            // 
            this.buttonBuscarFuncionario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonBuscarFuncionario.FlatAppearance.BorderSize = 0;
            this.buttonBuscarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarFuncionario.Image = global::WindowsFormsAppGestaoHotel.Properties.Resources.search_bk;
            this.buttonBuscarFuncionario.Location = new System.Drawing.Point(549, 54);
            this.buttonBuscarFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarFuncionario.Name = "buttonBuscarFuncionario";
            this.buttonBuscarFuncionario.Size = new System.Drawing.Size(40, 37);
            this.buttonBuscarFuncionario.TabIndex = 4;
            this.buttonBuscarFuncionario.UseVisualStyleBackColor = false;
            this.buttonBuscarFuncionario.Click += new System.EventHandler(this.buttonBuscarFuncionario_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.funcionarioDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox2.Location = new System.Drawing.Point(12, 128);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(606, 295);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funcionários cadastrados";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grupoFuncionariosDataGridView);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox3.Location = new System.Drawing.Point(630, 128);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(436, 295);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cargo";
            // 
            // grupoFuncionariosDataGridView
            // 
            this.grupoFuncionariosDataGridView.AllowUserToAddRows = false;
            this.grupoFuncionariosDataGridView.AllowUserToDeleteRows = false;
            this.grupoFuncionariosDataGridView.AllowUserToOrderColumns = true;
            this.grupoFuncionariosDataGridView.AutoGenerateColumns = false;
            this.grupoFuncionariosDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.grupoFuncionariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupoFuncionariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.grupoFuncionariosDataGridView.DataSource = this.grupoFuncionariosBindingSource;
            this.grupoFuncionariosDataGridView.Location = new System.Drawing.Point(5, 22);
            this.grupoFuncionariosDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoFuncionariosDataGridView.Name = "grupoFuncionariosDataGridView";
            this.grupoFuncionariosDataGridView.ReadOnly = true;
            this.grupoFuncionariosDataGridView.RowHeadersVisible = false;
            this.grupoFuncionariosDataGridView.RowHeadersWidth = 51;
            this.grupoFuncionariosDataGridView.RowTemplate.Height = 24;
            this.grupoFuncionariosDataGridView.Size = new System.Drawing.Size(424, 265);
            this.grupoFuncionariosDataGridView.TabIndex = 0;
            // 
            // grupoFuncionariosBindingSource
            // 
            this.grupoFuncionariosBindingSource.DataMember = "GrupoFuncionarios";
            this.grupoFuncionariosBindingSource.DataSource = this.funcionarioBindingSource;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.data_nascimentoMaskedTextBox);
            this.groupBox4.Controls.Add(this.idSexoTextBox);
            this.groupBox4.Controls.Add(this.celularMaskedTextBox);
            this.groupBox4.Controls.Add(this.cPFMaskedTextBox);
            this.groupBox4.Controls.Add(celularLabel);
            this.groupBox4.Controls.Add(emailLabel);
            this.groupBox4.Controls.Add(this.emailTextBox);
            this.groupBox4.Controls.Add(enderecoLabel);
            this.groupBox4.Controls.Add(this.enderecoTextBox);
            this.groupBox4.Controls.Add(data_nascimentoLabel);
            this.groupBox4.Controls.Add(sexoLabel);
            this.groupBox4.Controls.Add(cPFLabel);
            this.groupBox4.Controls.Add(nomeLabel);
            this.groupBox4.Controls.Add(this.nomeTextBox);
            this.groupBox4.Controls.Add(idLabel);
            this.groupBox4.Controls.Add(this.idTextBox);
            this.groupBox4.Location = new System.Drawing.Point(12, 433);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(606, 291);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dados Pessoais";
            // 
            // data_nascimentoMaskedTextBox
            // 
            this.data_nascimentoMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.data_nascimentoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Data_nascimento", true));
            this.data_nascimentoMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_nascimentoMaskedTextBox.Location = new System.Drawing.Point(488, 103);
            this.data_nascimentoMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_nascimentoMaskedTextBox.Mask = "00/00/0000";
            this.data_nascimentoMaskedTextBox.Name = "data_nascimentoMaskedTextBox";
            this.data_nascimentoMaskedTextBox.ReadOnly = true;
            this.data_nascimentoMaskedTextBox.Size = new System.Drawing.Size(112, 30);
            this.data_nascimentoMaskedTextBox.TabIndex = 9;
            this.data_nascimentoMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // idSexoTextBox
            // 
            this.idSexoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idSexoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Sexo", true));
            this.idSexoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idSexoTextBox.Location = new System.Drawing.Point(488, 63);
            this.idSexoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idSexoTextBox.Name = "idSexoTextBox";
            this.idSexoTextBox.ReadOnly = true;
            this.idSexoTextBox.Size = new System.Drawing.Size(112, 30);
            this.idSexoTextBox.TabIndex = 5;
            // 
            // celularMaskedTextBox
            // 
            this.celularMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.celularMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Celular", true));
            this.celularMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celularMaskedTextBox.Location = new System.Drawing.Point(115, 242);
            this.celularMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.celularMaskedTextBox.Mask = "(99) 0000-0000";
            this.celularMaskedTextBox.Name = "celularMaskedTextBox";
            this.celularMaskedTextBox.ReadOnly = true;
            this.celularMaskedTextBox.Size = new System.Drawing.Size(150, 30);
            this.celularMaskedTextBox.TabIndex = 15;
            // 
            // cPFMaskedTextBox
            // 
            this.cPFMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cPFMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "CPF", true));
            this.cPFMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPFMaskedTextBox.Location = new System.Drawing.Point(115, 101);
            this.cPFMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cPFMaskedTextBox.Mask = "000,000,000-00";
            this.cPFMaskedTextBox.Name = "cPFMaskedTextBox";
            this.cPFMaskedTextBox.ReadOnly = true;
            this.cPFMaskedTextBox.Size = new System.Drawing.Size(250, 30);
            this.cPFMaskedTextBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(115, 191);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(445, 30);
            this.emailTextBox.TabIndex = 13;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Endereco", true));
            this.enderecoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoTextBox.Location = new System.Drawing.Point(115, 146);
            this.enderecoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.ReadOnly = true;
            this.enderecoTextBox.Size = new System.Drawing.Size(445, 30);
            this.enderecoTextBox.TabIndex = 11;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Nome", true));
            this.nomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.Location = new System.Drawing.Point(115, 62);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.ReadOnly = true;
            this.nomeTextBox.Size = new System.Drawing.Size(250, 30);
            this.nomeTextBox.TabIndex = 3;
            // 
            // idTextBox
            // 
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(115, 26);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(50, 30);
            this.idTextBox.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(nomeGrupoLabel);
            this.groupBox5.Controls.Add(this.nomeGrupoTextBox);
            this.groupBox5.Controls.Add(idLabel1);
            this.groupBox5.Controls.Add(this.idTextBox1);
            this.groupBox5.Location = new System.Drawing.Point(630, 433);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(436, 100);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dados do Cargo";
            // 
            // nomeGrupoTextBox
            // 
            this.nomeGrupoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeGrupoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoFuncionariosBindingSource, "NomeGrupo", true));
            this.nomeGrupoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nomeGrupoTextBox.Location = new System.Drawing.Point(188, 58);
            this.nomeGrupoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nomeGrupoTextBox.Name = "nomeGrupoTextBox";
            this.nomeGrupoTextBox.ReadOnly = true;
            this.nomeGrupoTextBox.Size = new System.Drawing.Size(217, 30);
            this.nomeGrupoTextBox.TabIndex = 3;
            // 
            // idTextBox1
            // 
            this.idTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoFuncionariosBindingSource, "Id", true));
            this.idTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.idTextBox1.Location = new System.Drawing.Point(188, 21);
            this.idTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.ReadOnly = true;
            this.idTextBox1.Size = new System.Drawing.Size(50, 30);
            this.idTextBox1.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(senhaLabel);
            this.groupBox6.Controls.Add(this.senhaTextBox);
            this.groupBox6.Controls.Add(nomeUsuarioLabel);
            this.groupBox6.Controls.Add(this.nomeUsuarioTextBox);
            this.groupBox6.Location = new System.Drawing.Point(12, 728);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(606, 100);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Dados Usuário";
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Senha", true));
            this.senhaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.senhaTextBox.Location = new System.Drawing.Point(111, 58);
            this.senhaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.ReadOnly = true;
            this.senhaTextBox.Size = new System.Drawing.Size(166, 30);
            this.senhaTextBox.TabIndex = 3;
            // 
            // nomeUsuarioTextBox
            // 
            this.nomeUsuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "NomeUsuario", true));
            this.nomeUsuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nomeUsuarioTextBox.Location = new System.Drawing.Point(111, 20);
            this.nomeUsuarioTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nomeUsuarioTextBox.Name = "nomeUsuarioTextBox";
            this.nomeUsuarioTextBox.ReadOnly = true;
            this.nomeUsuarioTextBox.Size = new System.Drawing.Size(166, 30);
            this.nomeUsuarioTextBox.TabIndex = 1;
            // 
            // buttonAlterarFuncionario
            // 
            this.buttonAlterarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(183)))), ((int)(((byte)(219)))));
            this.buttonAlterarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlterarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterarFuncionario.ForeColor = System.Drawing.Color.Black;
            this.buttonAlterarFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlterarFuncionario.Image")));
            this.buttonAlterarFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAlterarFuncionario.Location = new System.Drawing.Point(237, 847);
            this.buttonAlterarFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAlterarFuncionario.Name = "buttonAlterarFuncionario";
            this.buttonAlterarFuncionario.Size = new System.Drawing.Size(160, 41);
            this.buttonAlterarFuncionario.TabIndex = 6;
            this.buttonAlterarFuncionario.Text = "Alterar";
            this.buttonAlterarFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAlterarFuncionario.UseVisualStyleBackColor = false;
            this.buttonAlterarFuncionario.Click += new System.EventHandler(this.buttonAlterarFuncionario_Click);
            // 
            // buttonExcluirGrupoFuncionario
            // 
            this.buttonExcluirGrupoFuncionario.BackColor = System.Drawing.Color.IndianRed;
            this.buttonExcluirGrupoFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluirGrupoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirGrupoFuncionario.ForeColor = System.Drawing.Color.Black;
            this.buttonExcluirGrupoFuncionario.Image = global::WindowsFormsAppGestaoHotel.Properties.Resources.delete_bk;
            this.buttonExcluirGrupoFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExcluirGrupoFuncionario.Location = new System.Drawing.Point(899, 847);
            this.buttonExcluirGrupoFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExcluirGrupoFuncionario.Name = "buttonExcluirGrupoFuncionario";
            this.buttonExcluirGrupoFuncionario.Size = new System.Drawing.Size(160, 41);
            this.buttonExcluirGrupoFuncionario.TabIndex = 11;
            this.buttonExcluirGrupoFuncionario.Text = "Excluir";
            this.buttonExcluirGrupoFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExcluirGrupoFuncionario.UseVisualStyleBackColor = false;
            this.buttonExcluirGrupoFuncionario.Click += new System.EventHandler(this.buttonExcluirGrupoFuncionario_Click);
            this.buttonExcluirGrupoFuncionario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonExcluirGrupoFuncionario_KeyDown);
            // 
            // buttonAdicionarGrupoFuncionario
            // 
            this.buttonAdicionarGrupoFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(210)))), ((int)(((byte)(156)))));
            this.buttonAdicionarGrupoFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionarGrupoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarGrupoFuncionario.ForeColor = System.Drawing.Color.Black;
            this.buttonAdicionarGrupoFuncionario.Image = global::WindowsFormsAppGestaoHotel.Properties.Resources.add_bk;
            this.buttonAdicionarGrupoFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdicionarGrupoFuncionario.Location = new System.Drawing.Point(697, 847);
            this.buttonAdicionarGrupoFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdicionarGrupoFuncionario.Name = "buttonAdicionarGrupoFuncionario";
            this.buttonAdicionarGrupoFuncionario.Size = new System.Drawing.Size(171, 41);
            this.buttonAdicionarGrupoFuncionario.TabIndex = 10;
            this.buttonAdicionarGrupoFuncionario.Text = "Adicionar";
            this.buttonAdicionarGrupoFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdicionarGrupoFuncionario.UseVisualStyleBackColor = false;
            this.buttonAdicionarGrupoFuncionario.Click += new System.EventHandler(this.buttonAdicionarGrupoFuncionario_Click);
            // 
            // buttonExcluirFuncionario
            // 
            this.buttonExcluirFuncionario.BackColor = System.Drawing.Color.IndianRed;
            this.buttonExcluirFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluirFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirFuncionario.ForeColor = System.Drawing.Color.Black;
            this.buttonExcluirFuncionario.Image = global::WindowsFormsAppGestaoHotel.Properties.Resources.delete_bk;
            this.buttonExcluirFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExcluirFuncionario.Location = new System.Drawing.Point(458, 847);
            this.buttonExcluirFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExcluirFuncionario.Name = "buttonExcluirFuncionario";
            this.buttonExcluirFuncionario.Size = new System.Drawing.Size(160, 41);
            this.buttonExcluirFuncionario.TabIndex = 7;
            this.buttonExcluirFuncionario.Text = "Excluir";
            this.buttonExcluirFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExcluirFuncionario.UseVisualStyleBackColor = false;
            this.buttonExcluirFuncionario.Click += new System.EventHandler(this.buttonExcluirFuncionário_Click);
            this.buttonExcluirFuncionario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonExcluirFuncionario_KeyDown);
            // 
            // buttonAdicionarFuncionario
            // 
            this.buttonAdicionarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(210)))), ((int)(((byte)(156)))));
            this.buttonAdicionarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarFuncionario.ForeColor = System.Drawing.Color.Black;
            this.buttonAdicionarFuncionario.Image = global::WindowsFormsAppGestaoHotel.Properties.Resources.add_bk;
            this.buttonAdicionarFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdicionarFuncionario.Location = new System.Drawing.Point(12, 847);
            this.buttonAdicionarFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdicionarFuncionario.Name = "buttonAdicionarFuncionario";
            this.buttonAdicionarFuncionario.Size = new System.Drawing.Size(171, 41);
            this.buttonAdicionarFuncionario.TabIndex = 5;
            this.buttonAdicionarFuncionario.Text = "Adicionar";
            this.buttonAdicionarFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdicionarFuncionario.UseVisualStyleBackColor = false;
            this.buttonAdicionarFuncionario.Click += new System.EventHandler(this.buttonAdicionarFuncionario_Click);
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataSource = typeof(Models.Funcionario);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn9.HeaderText = "Id";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "NomeGrupo";
            this.dataGridViewTextBoxColumn10.HeaderText = "Cargo";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cód.";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.FillWeight = 195.7219F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 260;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NomeUsuario";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nome de usuário";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CPF";
            this.dataGridViewTextBoxColumn3.FillWeight = 87.36213F;
            this.dataGridViewTextBoxColumn3.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "E-mail";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Celular";
            this.dataGridViewTextBoxColumn5.HeaderText = "Celular";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Endereco";
            this.dataGridViewTextBoxColumn6.HeaderText = "Endereço";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Data_nascimento";
            this.dataGridViewTextBoxColumn8.HeaderText = " Data de nascimento";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // Senha
            // 
            this.Senha.DataPropertyName = "Senha";
            this.Senha.HeaderText = "Senha";
            this.Senha.MinimumWidth = 6;
            this.Senha.Name = "Senha";
            this.Senha.ReadOnly = true;
            this.Senha.Visible = false;
            this.Senha.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Ativo";
            this.dataGridViewCheckBoxColumn1.FillWeight = 16.91595F;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Ativo";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // FormBuscarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 931);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAlterarFuncionario);
            this.Controls.Add(this.buttonExcluirGrupoFuncionario);
            this.Controls.Add(this.buttonAdicionarGrupoFuncionario);
            this.Controls.Add(this.buttonExcluirFuncionario);
            this.Controls.Add(this.buttonAdicionarFuncionario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 978);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1100, 950);
            this.Name = "FormBuscarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Funcionário";
            this.Load += new System.EventHandler(this.FormBuscarFuncionario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormBuscarFuncionario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grupoFuncionariosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoFuncionariosBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Button buttonBuscarFuncionario;
        private System.Windows.Forms.Button buttonAdicionarFuncionario;
        private System.Windows.Forms.Button buttonExcluirFuncionario;
        private System.Windows.Forms.Button buttonAlterarFuncionario;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private System.Windows.Forms.DataGridView funcionarioDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonCPF;
        private System.Windows.Forms.RadioButton radioButtonNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView grupoFuncionariosDataGridView;
        private System.Windows.Forms.BindingSource grupoFuncionariosBindingSource;
        private System.Windows.Forms.Button buttonAdicionarGrupoFuncionario;
        private System.Windows.Forms.Button buttonExcluirGrupoFuncionario;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox nomeGrupoTextBox;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.TextBox nomeUsuarioTextBox;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.MaskedTextBox celularMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cPFMaskedTextBox;
        private System.Windows.Forms.TextBox idSexoTextBox;
        private System.Windows.Forms.MaskedTextBox data_nascimentoMaskedTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}