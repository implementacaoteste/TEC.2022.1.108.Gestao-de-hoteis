namespace WindowsFormsAppGestaoHotel
{
    partial class FormBuscarQuarto
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
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label id_ClasseLabel;
            System.Windows.Forms.Label id_StatusLabel;
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label valor_DiariaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarQuarto));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonStatus = new System.Windows.Forms.RadioButton();
            this.radioButtonNumero = new System.Windows.Forms.RadioButton();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.funcionarioDataGridView = new System.Windows.Forms.DataGridView();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.ClasseTextBox = new System.Windows.Forms.TextBox();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.valor_DiariaTextBox = new System.Windows.Forms.TextBox();
            this.buttonAlterarQuarto = new System.Windows.Forms.Button();
            this.buttonExcluirQuarto = new System.Windows.Forms.Button();
            this.buttonAdicionarQuarto = new System.Windows.Forms.Button();
            this.quartoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClasseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDiariaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBuscarQuarto = new System.Windows.Forms.Button();
            descricaoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            id_ClasseLabel = new System.Windows.Forms.Label();
            id_StatusLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            valor_DiariaLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioDataGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(185, 51);
            descricaoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(58, 13);
            descricaoLabel.TabIndex = 11;
            descricaoLabel.Text = "Descrição:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(26, 26);
            idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(32, 13);
            idLabel.TabIndex = 12;
            idLabel.Text = "Cód.:";
            // 
            // id_ClasseLabel
            // 
            id_ClasseLabel.AutoSize = true;
            id_ClasseLabel.Location = new System.Drawing.Point(16, 73);
            id_ClasseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            id_ClasseLabel.Name = "id_ClasseLabel";
            id_ClasseLabel.Size = new System.Drawing.Size(41, 13);
            id_ClasseLabel.TabIndex = 13;
            id_ClasseLabel.Text = "Classe:";
            // 
            // id_StatusLabel
            // 
            id_StatusLabel.AutoSize = true;
            id_StatusLabel.Location = new System.Drawing.Point(20, 97);
            id_StatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            id_StatusLabel.Name = "id_StatusLabel";
            id_StatusLabel.Size = new System.Drawing.Size(40, 13);
            id_StatusLabel.TabIndex = 14;
            id_StatusLabel.Text = "Status:";
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(11, 49);
            numeroLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(47, 13);
            numeroLabel.TabIndex = 15;
            numeroLabel.Text = "Número:";
            // 
            // valor_DiariaLabel
            // 
            valor_DiariaLabel.AutoSize = true;
            valor_DiariaLabel.Location = new System.Drawing.Point(164, 26);
            valor_DiariaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            valor_DiariaLabel.Name = "valor_DiariaLabel";
            valor_DiariaLabel.Size = new System.Drawing.Size(79, 13);
            valor_DiariaLabel.TabIndex = 16;
            valor_DiariaLabel.Text = "Valor da Diária:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonTodos);
            this.groupBox1.Controls.Add(this.radioButtonStatus);
            this.groupBox1.Controls.Add(this.radioButtonNumero);
            this.groupBox1.Controls.Add(this.textBoxBuscar);
            this.groupBox1.Controls.Add(this.buttonBuscarQuarto);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(363, 95);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar por";
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonTodos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonTodos.Location = new System.Drawing.Point(10, 17);
            this.radioButtonTodos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(81, 25);
            this.radioButtonTodos.TabIndex = 2;
            this.radioButtonTodos.TabStop = true;
            this.radioButtonTodos.Text = "Todos";
            this.radioButtonTodos.UseVisualStyleBackColor = false;
            // 
            // radioButtonStatus
            // 
            this.radioButtonStatus.AutoSize = true;
            this.radioButtonStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonStatus.Location = new System.Drawing.Point(177, 17);
            this.radioButtonStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonStatus.Name = "radioButtonStatus";
            this.radioButtonStatus.Size = new System.Drawing.Size(84, 25);
            this.radioButtonStatus.TabIndex = 2;
            this.radioButtonStatus.TabStop = true;
            this.radioButtonStatus.Text = "Status";
            this.radioButtonStatus.UseVisualStyleBackColor = true;
            // 
            // radioButtonNumero
            // 
            this.radioButtonNumero.AutoSize = true;
            this.radioButtonNumero.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonNumero.Location = new System.Drawing.Point(95, 17);
            this.radioButtonNumero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonNumero.Name = "radioButtonNumero";
            this.radioButtonNumero.Size = new System.Drawing.Size(93, 25);
            this.radioButtonNumero.TabIndex = 2;
            this.radioButtonNumero.TabStop = true;
            this.radioButtonNumero.Text = "Número";
            this.radioButtonNumero.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxBuscar.Location = new System.Drawing.Point(4, 49);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(223, 28);
            this.textBoxBuscar.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.funcionarioDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox2.Location = new System.Drawing.Point(9, 109);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(472, 240);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quartos cadastrados";
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
            this.numeroDataGridViewTextBoxColumn,
            this.idClasseDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.valorDiariaDataGridViewTextBoxColumn,
            this.idStatusDataGridViewTextBoxColumn});
            this.funcionarioDataGridView.DataSource = this.quartoBindingSource;
            this.funcionarioDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.funcionarioDataGridView.Location = new System.Drawing.Point(4, 16);
            this.funcionarioDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.funcionarioDataGridView.Name = "funcionarioDataGridView";
            this.funcionarioDataGridView.ReadOnly = true;
            this.funcionarioDataGridView.RowHeadersVisible = false;
            this.funcionarioDataGridView.RowHeadersWidth = 10;
            this.funcionarioDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.funcionarioDataGridView.RowTemplate.Height = 24;
            this.funcionarioDataGridView.Size = new System.Drawing.Size(464, 216);
            this.funcionarioDataGridView.TabIndex = 6;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartoBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(244, 49);
            this.descricaoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.ReadOnly = true;
            this.descricaoTextBox.Size = new System.Drawing.Size(188, 40);
            this.descricaoTextBox.TabIndex = 12;
            // 
            // idTextBox
            // 
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartoBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(64, 24);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(38, 20);
            this.idTextBox.TabIndex = 13;
            // 
            // ClasseTextBox
            // 
            this.ClasseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClasseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartoBindingSource, "Classe", true));
            this.ClasseTextBox.Location = new System.Drawing.Point(64, 71);
            this.ClasseTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClasseTextBox.Name = "ClasseTextBox";
            this.ClasseTextBox.ReadOnly = true;
            this.ClasseTextBox.Size = new System.Drawing.Size(94, 20);
            this.ClasseTextBox.TabIndex = 14;
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartoBindingSource, "Status", true));
            this.StatusTextBox.Location = new System.Drawing.Point(64, 94);
            this.StatusTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.ReadOnly = true;
            this.StatusTextBox.Size = new System.Drawing.Size(94, 20);
            this.StatusTextBox.TabIndex = 15;
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartoBindingSource, "Numero", true));
            this.numeroTextBox.Location = new System.Drawing.Point(64, 46);
            this.numeroTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.ReadOnly = true;
            this.numeroTextBox.Size = new System.Drawing.Size(38, 20);
            this.numeroTextBox.TabIndex = 16;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.valor_DiariaTextBox);
            this.groupBox4.Controls.Add(valor_DiariaLabel);
            this.groupBox4.Controls.Add(numeroLabel);
            this.groupBox4.Controls.Add(this.numeroTextBox);
            this.groupBox4.Controls.Add(id_ClasseLabel);
            this.groupBox4.Controls.Add(id_StatusLabel);
            this.groupBox4.Controls.Add(this.descricaoTextBox);
            this.groupBox4.Controls.Add(this.StatusTextBox);
            this.groupBox4.Controls.Add(descricaoLabel);
            this.groupBox4.Controls.Add(this.idTextBox);
            this.groupBox4.Controls.Add(this.ClasseTextBox);
            this.groupBox4.Controls.Add(idLabel);
            this.groupBox4.Location = new System.Drawing.Point(9, 364);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(472, 118);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informações do Quarto";
            // 
            // valor_DiariaTextBox
            // 
            this.valor_DiariaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valor_DiariaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartoBindingSource, "Valor_Diaria", true));
            this.valor_DiariaTextBox.Location = new System.Drawing.Point(244, 24);
            this.valor_DiariaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.valor_DiariaTextBox.Name = "valor_DiariaTextBox";
            this.valor_DiariaTextBox.ReadOnly = true;
            this.valor_DiariaTextBox.Size = new System.Drawing.Size(76, 20);
            this.valor_DiariaTextBox.TabIndex = 17;
            // 
            // buttonAlterarQuarto
            // 
            this.buttonAlterarQuarto.BackColor = System.Drawing.Color.White;
            this.buttonAlterarQuarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlterarQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAlterarQuarto.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlterarQuarto.Image")));
            this.buttonAlterarQuarto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAlterarQuarto.Location = new System.Drawing.Point(256, 495);
            this.buttonAlterarQuarto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAlterarQuarto.MinimumSize = new System.Drawing.Size(82, 28);
            this.buttonAlterarQuarto.Name = "buttonAlterarQuarto";
            this.buttonAlterarQuarto.Size = new System.Drawing.Size(101, 33);
            this.buttonAlterarQuarto.TabIndex = 19;
            this.buttonAlterarQuarto.Text = "Alterar";
            this.buttonAlterarQuarto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAlterarQuarto.UseVisualStyleBackColor = false;
            this.buttonAlterarQuarto.Click += new System.EventHandler(this.buttonAlterarQuarto_Click);
            // 
            // buttonExcluirQuarto
            // 
            this.buttonExcluirQuarto.BackColor = System.Drawing.Color.White;
            this.buttonExcluirQuarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluirQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirQuarto.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluirQuarto.Image")));
            this.buttonExcluirQuarto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExcluirQuarto.Location = new System.Drawing.Point(141, 495);
            this.buttonExcluirQuarto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExcluirQuarto.MinimumSize = new System.Drawing.Size(82, 28);
            this.buttonExcluirQuarto.Name = "buttonExcluirQuarto";
            this.buttonExcluirQuarto.Size = new System.Drawing.Size(111, 33);
            this.buttonExcluirQuarto.TabIndex = 20;
            this.buttonExcluirQuarto.Text = "Excluir";
            this.buttonExcluirQuarto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExcluirQuarto.UseVisualStyleBackColor = false;
            this.buttonExcluirQuarto.Click += new System.EventHandler(this.buttonExcluirQuarto_Click);
            // 
            // buttonAdicionarQuarto
            // 
            this.buttonAdicionarQuarto.BackColor = System.Drawing.Color.White;
            this.buttonAdicionarQuarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionarQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAdicionarQuarto.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdicionarQuarto.Image")));
            this.buttonAdicionarQuarto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdicionarQuarto.Location = new System.Drawing.Point(9, 495);
            this.buttonAdicionarQuarto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdicionarQuarto.MinimumSize = new System.Drawing.Size(98, 33);
            this.buttonAdicionarQuarto.Name = "buttonAdicionarQuarto";
            this.buttonAdicionarQuarto.Size = new System.Drawing.Size(124, 33);
            this.buttonAdicionarQuarto.TabIndex = 21;
            this.buttonAdicionarQuarto.Text = "Adicionar";
            this.buttonAdicionarQuarto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdicionarQuarto.UseVisualStyleBackColor = false;
            this.buttonAdicionarQuarto.Click += new System.EventHandler(this.buttonAdicionarQuarto_Click);
            // 
            // quartoBindingSource
            // 
            this.quartoBindingSource.DataSource = typeof(Models.Quarto);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Número";
            this.numeroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idClasseDataGridViewTextBoxColumn
            // 
            this.idClasseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idClasseDataGridViewTextBoxColumn.DataPropertyName = "Id_Classe";
            this.idClasseDataGridViewTextBoxColumn.HeaderText = "Classe";
            this.idClasseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idClasseDataGridViewTextBoxColumn.Name = "idClasseDataGridViewTextBoxColumn";
            this.idClasseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // valorDiariaDataGridViewTextBoxColumn
            // 
            this.valorDiariaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valorDiariaDataGridViewTextBoxColumn.DataPropertyName = "Valor_Diaria";
            this.valorDiariaDataGridViewTextBoxColumn.HeaderText = "Valor da diária";
            this.valorDiariaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorDiariaDataGridViewTextBoxColumn.Name = "valorDiariaDataGridViewTextBoxColumn";
            this.valorDiariaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idStatusDataGridViewTextBoxColumn
            // 
            this.idStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idStatusDataGridViewTextBoxColumn.DataPropertyName = "Id_Status";
            this.idStatusDataGridViewTextBoxColumn.HeaderText = "STATUS";
            this.idStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idStatusDataGridViewTextBoxColumn.Name = "idStatusDataGridViewTextBoxColumn";
            this.idStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buttonBuscarQuarto
            // 
            this.buttonBuscarQuarto.BackColor = System.Drawing.Color.White;
            this.buttonBuscarQuarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarQuarto.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarQuarto.Image")));
            this.buttonBuscarQuarto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscarQuarto.Location = new System.Drawing.Point(231, 47);
            this.buttonBuscarQuarto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscarQuarto.MinimumSize = new System.Drawing.Size(82, 28);
            this.buttonBuscarQuarto.Name = "buttonBuscarQuarto";
            this.buttonBuscarQuarto.Size = new System.Drawing.Size(101, 33);
            this.buttonBuscarQuarto.TabIndex = 0;
            this.buttonBuscarQuarto.Text = "Buscar";
            this.buttonBuscarQuarto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscarQuarto.UseVisualStyleBackColor = false;
            this.buttonBuscarQuarto.Click += new System.EventHandler(this.buttonBuscarQuarto_Click);
            // 
            // FormBuscarQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(698, 539);
            this.Controls.Add(this.buttonAlterarQuarto);
            this.Controls.Add(this.buttonExcluirQuarto);
            this.Controls.Add(this.buttonAdicionarQuarto);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(716, 583);
            this.MinimumSize = new System.Drawing.Size(716, 583);
            this.Name = "FormBuscarQuarto";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOTELOGIX - Consulta de Quartos";
            this.Load += new System.EventHandler(this.FormBuscarQuarto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioDataGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.RadioButton radioButtonNumero;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonBuscarQuarto;
        private System.Windows.Forms.RadioButton radioButtonStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView funcionarioDataGridView;
        private System.Windows.Forms.BindingSource quartoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClasseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDiariaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox ClasseTextBox;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox valor_DiariaTextBox;
        private System.Windows.Forms.Button buttonAlterarQuarto;
        private System.Windows.Forms.Button buttonExcluirQuarto;
        private System.Windows.Forms.Button buttonAdicionarQuarto;
    }
}