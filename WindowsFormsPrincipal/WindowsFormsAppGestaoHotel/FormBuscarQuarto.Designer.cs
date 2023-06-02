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
            System.Windows.Forms.Label andarLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarQuarto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonStatus = new System.Windows.Forms.RadioButton();
            this.radioButtonNumero = new System.Windows.Forms.RadioButton();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.buttonBuscarQuarto = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.funcionarioDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Andar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClasseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDiariaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quartoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.ClasseTextBox = new System.Windows.Forms.TextBox();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.valor_DiariaTextBox = new System.Windows.Forms.TextBox();
            this.andarTextBox = new System.Windows.Forms.TextBox();
            this.buttonAlterarQuarto = new System.Windows.Forms.Button();
            this.buttonExcluirQuarto = new System.Windows.Forms.Button();
            this.buttonAdicionarQuarto = new System.Windows.Forms.Button();
            descricaoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            id_ClasseLabel = new System.Windows.Forms.Label();
            id_StatusLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            valor_DiariaLabel = new System.Windows.Forms.Label();
            andarLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(188, 47);
            descricaoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(58, 13);
            descricaoLabel.TabIndex = 10;
            descricaoLabel.Text = "Descrição:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(26, 26);
            idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(32, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Cód.:";
            // 
            // id_ClasseLabel
            // 
            id_ClasseLabel.AutoSize = true;
            id_ClasseLabel.Location = new System.Drawing.Point(16, 93);
            id_ClasseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            id_ClasseLabel.Name = "id_ClasseLabel";
            id_ClasseLabel.Size = new System.Drawing.Size(41, 13);
            id_ClasseLabel.TabIndex = 6;
            id_ClasseLabel.Text = "Classe:";
            // 
            // id_StatusLabel
            // 
            id_StatusLabel.AutoSize = true;
            id_StatusLabel.Location = new System.Drawing.Point(207, 92);
            id_StatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            id_StatusLabel.Name = "id_StatusLabel";
            id_StatusLabel.Size = new System.Drawing.Size(40, 13);
            id_StatusLabel.TabIndex = 12;
            id_StatusLabel.Text = "Status:";
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(11, 49);
            numeroLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(47, 13);
            numeroLabel.TabIndex = 2;
            numeroLabel.Text = "Número:";
            // 
            // valor_DiariaLabel
            // 
            valor_DiariaLabel.AutoSize = true;
            valor_DiariaLabel.Location = new System.Drawing.Point(167, 22);
            valor_DiariaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            valor_DiariaLabel.Name = "valor_DiariaLabel";
            valor_DiariaLabel.Size = new System.Drawing.Size(79, 13);
            valor_DiariaLabel.TabIndex = 8;
            valor_DiariaLabel.Text = "Valor da Diária:";
            // 
            // andarLabel
            // 
            andarLabel.AutoSize = true;
            andarLabel.Location = new System.Drawing.Point(20, 73);
            andarLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            andarLabel.Name = "andarLabel";
            andarLabel.Size = new System.Drawing.Size(38, 13);
            andarLabel.TabIndex = 4;
            andarLabel.Text = "Andar:";
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
            this.groupBox1.Size = new System.Drawing.Size(472, 89);
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
            this.radioButtonTodos.Location = new System.Drawing.Point(10, 17);
            this.radioButtonTodos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(72, 22);
            this.radioButtonTodos.TabIndex = 0;
            this.radioButtonTodos.TabStop = true;
            this.radioButtonTodos.Text = "Todos";
            this.radioButtonTodos.UseVisualStyleBackColor = false;
            // 
            // radioButtonStatus
            // 
            this.radioButtonStatus.AutoSize = true;
            this.radioButtonStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonStatus.Location = new System.Drawing.Point(189, 17);
            this.radioButtonStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonStatus.Name = "radioButtonStatus";
            this.radioButtonStatus.Size = new System.Drawing.Size(72, 22);
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
            this.radioButtonNumero.Size = new System.Drawing.Size(82, 22);
            this.radioButtonNumero.TabIndex = 1;
            this.radioButtonNumero.TabStop = true;
            this.radioButtonNumero.Text = "Número";
            this.radioButtonNumero.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxBuscar.Location = new System.Drawing.Point(4, 53);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(430, 26);
            this.textBoxBuscar.TabIndex = 3;
            // 
            // buttonBuscarQuarto
            // 
            this.buttonBuscarQuarto.BackColor = System.Drawing.Color.Transparent;
            this.buttonBuscarQuarto.FlatAppearance.BorderSize = 0;
            this.buttonBuscarQuarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarQuarto.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarQuarto.Image")));
            this.buttonBuscarQuarto.Location = new System.Drawing.Point(438, 51);
            this.buttonBuscarQuarto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuscarQuarto.Name = "buttonBuscarQuarto";
            this.buttonBuscarQuarto.Size = new System.Drawing.Size(30, 30);
            this.buttonBuscarQuarto.TabIndex = 4;
            this.buttonBuscarQuarto.UseVisualStyleBackColor = false;
            this.buttonBuscarQuarto.Click += new System.EventHandler(this.buttonBuscarQuarto_Click);
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
            this.groupBox2.TabIndex = 1;
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
            this.Andar,
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
            this.funcionarioDataGridView.TabIndex = 0;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.numeroDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Número";
            this.numeroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Andar
            // 
            this.Andar.DataPropertyName = "Andar";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Andar.DefaultCellStyle = dataGridViewCellStyle8;
            this.Andar.HeaderText = "Andar";
            this.Andar.MinimumWidth = 6;
            this.Andar.Name = "Andar";
            this.Andar.ReadOnly = true;
            this.Andar.Width = 125;
            // 
            // idClasseDataGridViewTextBoxColumn
            // 
            this.idClasseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idClasseDataGridViewTextBoxColumn.DataPropertyName = "Classe";
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.NullValue = null;
            this.valorDiariaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.valorDiariaDataGridViewTextBoxColumn.HeaderText = "Valor da diária";
            this.valorDiariaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorDiariaDataGridViewTextBoxColumn.Name = "valorDiariaDataGridViewTextBoxColumn";
            this.valorDiariaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idStatusDataGridViewTextBoxColumn
            // 
            this.idStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idStatusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.idStatusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.idStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idStatusDataGridViewTextBoxColumn.Name = "idStatusDataGridViewTextBoxColumn";
            this.idStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quartoBindingSource
            // 
            this.quartoBindingSource.DataSource = typeof(Models.Quarto);
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartoBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(250, 45);
            this.descricaoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.ReadOnly = true;
            this.descricaoTextBox.Size = new System.Drawing.Size(188, 40);
            this.descricaoTextBox.TabIndex = 11;
            // 
            // idTextBox
            // 
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartoBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(64, 24);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.idTextBox.Size = new System.Drawing.Size(38, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // ClasseTextBox
            // 
            this.ClasseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClasseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartoBindingSource, "Classe", true));
            this.ClasseTextBox.Location = new System.Drawing.Point(64, 90);
            this.ClasseTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClasseTextBox.Name = "ClasseTextBox";
            this.ClasseTextBox.ReadOnly = true;
            this.ClasseTextBox.Size = new System.Drawing.Size(94, 20);
            this.ClasseTextBox.TabIndex = 7;
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartoBindingSource, "Status", true));
            this.StatusTextBox.Location = new System.Drawing.Point(250, 89);
            this.StatusTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.ReadOnly = true;
            this.StatusTextBox.Size = new System.Drawing.Size(94, 20);
            this.StatusTextBox.TabIndex = 13;
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartoBindingSource, "Numero", true));
            this.numeroTextBox.Location = new System.Drawing.Point(64, 46);
            this.numeroTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.ReadOnly = true;
            this.numeroTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numeroTextBox.Size = new System.Drawing.Size(38, 20);
            this.numeroTextBox.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(andarLabel);
            this.groupBox4.Controls.Add(this.valor_DiariaTextBox);
            this.groupBox4.Controls.Add(this.andarTextBox);
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
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informações do Quarto";
            // 
            // valor_DiariaTextBox
            // 
            this.valor_DiariaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valor_DiariaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartoBindingSource, "Valor_Diaria", true));
            this.valor_DiariaTextBox.Location = new System.Drawing.Point(250, 20);
            this.valor_DiariaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.valor_DiariaTextBox.Name = "valor_DiariaTextBox";
            this.valor_DiariaTextBox.ReadOnly = true;
            this.valor_DiariaTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.valor_DiariaTextBox.Size = new System.Drawing.Size(76, 20);
            this.valor_DiariaTextBox.TabIndex = 9;
            this.valor_DiariaTextBox.TextChanged += new System.EventHandler(this.valor_DiariaTextBox_TextChanged);
            // 
            // andarTextBox
            // 
            this.andarTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.andarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartoBindingSource, "Andar", true));
            this.andarTextBox.Location = new System.Drawing.Point(64, 68);
            this.andarTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.andarTextBox.Name = "andarTextBox";
            this.andarTextBox.ReadOnly = true;
            this.andarTextBox.Size = new System.Drawing.Size(38, 20);
            this.andarTextBox.TabIndex = 5;
            this.andarTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonAlterarQuarto
            // 
            this.buttonAlterarQuarto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(183)))), ((int)(((byte)(219)))));
            this.buttonAlterarQuarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlterarQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterarQuarto.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlterarQuarto.Image")));
            this.buttonAlterarQuarto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAlterarQuarto.Location = new System.Drawing.Point(179, 499);
            this.buttonAlterarQuarto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAlterarQuarto.Name = "buttonAlterarQuarto";
            this.buttonAlterarQuarto.Size = new System.Drawing.Size(120, 33);
            this.buttonAlterarQuarto.TabIndex = 4;
            this.buttonAlterarQuarto.Text = "Alterar";
            this.buttonAlterarQuarto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAlterarQuarto.UseVisualStyleBackColor = false;
            this.buttonAlterarQuarto.Click += new System.EventHandler(this.buttonAlterarQuarto_Click);
            // 
            // buttonExcluirQuarto
            // 
            this.buttonExcluirQuarto.BackColor = System.Drawing.Color.IndianRed;
            this.buttonExcluirQuarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluirQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirQuarto.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluirQuarto.Image")));
            this.buttonExcluirQuarto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExcluirQuarto.Location = new System.Drawing.Point(361, 499);
            this.buttonExcluirQuarto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExcluirQuarto.Name = "buttonExcluirQuarto";
            this.buttonExcluirQuarto.Size = new System.Drawing.Size(120, 33);
            this.buttonExcluirQuarto.TabIndex = 5;
            this.buttonExcluirQuarto.Text = "Excluir";
            this.buttonExcluirQuarto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExcluirQuarto.UseVisualStyleBackColor = false;
            this.buttonExcluirQuarto.Click += new System.EventHandler(this.buttonExcluirQuarto_Click);
            this.buttonExcluirQuarto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonExcluirQuarto_KeyDown);
            // 
            // buttonAdicionarQuarto
            // 
            this.buttonAdicionarQuarto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(210)))), ((int)(((byte)(156)))));
            this.buttonAdicionarQuarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionarQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarQuarto.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdicionarQuarto.Image")));
            this.buttonAdicionarQuarto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdicionarQuarto.Location = new System.Drawing.Point(9, 499);
            this.buttonAdicionarQuarto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdicionarQuarto.Name = "buttonAdicionarQuarto";
            this.buttonAdicionarQuarto.Size = new System.Drawing.Size(120, 33);
            this.buttonAdicionarQuarto.TabIndex = 3;
            this.buttonAdicionarQuarto.Text = "Adicionar";
            this.buttonAdicionarQuarto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdicionarQuarto.UseVisualStyleBackColor = false;
            this.buttonAdicionarQuarto.Click += new System.EventHandler(this.buttonAdicionarQuarto_Click);
            // 
            // FormBuscarQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(492, 543);
            this.Controls.Add(this.buttonAlterarQuarto);
            this.Controls.Add(this.buttonExcluirQuarto);
            this.Controls.Add(this.buttonAdicionarQuarto);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormBuscarQuarto";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOTELOGIX - Consulta de Quartos";
            this.Load += new System.EventHandler(this.FormBuscarQuarto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormBuscarQuarto_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.TextBox andarTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Andar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClasseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDiariaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStatusDataGridViewTextBoxColumn;
    }
}