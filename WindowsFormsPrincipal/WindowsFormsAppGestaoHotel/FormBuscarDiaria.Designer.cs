namespace WindowsFormsAppGestaoHotel
{
    partial class FormBuscarDiaria
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
            System.Windows.Forms.Label data_EntradaLabel;
            System.Windows.Forms.Label id_clienteLabel;
            System.Windows.Forms.Label id_funcionarioLabel;
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label valor_DiariaLabel;
            System.Windows.Forms.Label cpf_ClienteLabel;
            System.Windows.Forms.Label data_SaidaLabel;
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label id_ClasseLabel;
            System.Windows.Forms.Label id_StatusLabel;
            System.Windows.Forms.Button buttonBuscar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarDiaria));
            this.quartosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quartosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.clienteTextBox = new System.Windows.Forms.TextBox();
            this.funcionarioTextBox = new System.Windows.Forms.TextBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.diariaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDiaria = new System.Windows.Forms.GroupBox();
            this.data_SaidaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cpf_ClienteMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.data_EntradaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxQuarto = new System.Windows.Forms.GroupBox();
            this.valor_DiariaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.id_StatusTextBox = new System.Windows.Forms.TextBox();
            this.id_ClasseTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonCPF = new System.Windows.Forms.RadioButton();
            this.radioButtonNome = new System.Windows.Forms.RadioButton();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.buttonBuscarData = new System.Windows.Forms.Button();
            this.buttonExcluirQuarto = new System.Windows.Forms.Button();
            this.buttonADCquarto = new System.Windows.Forms.Button();
            this.buttonExcluirDiaria = new System.Windows.Forms.Button();
            this.buttonAlterarDiaria = new System.Windows.Forms.Button();
            this.buttonAdicionarDiaria = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            data_EntradaLabel = new System.Windows.Forms.Label();
            id_clienteLabel = new System.Windows.Forms.Label();
            id_funcionarioLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            valor_DiariaLabel = new System.Windows.Forms.Label();
            cpf_ClienteLabel = new System.Windows.Forms.Label();
            data_SaidaLabel = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            id_ClasseLabel = new System.Windows.Forms.Label();
            id_StatusLabel = new System.Windows.Forms.Label();
            buttonBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quartosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diariaDataGridView)).BeginInit();
            this.groupBoxDiaria.SuspendLayout();
            this.groupBoxQuarto.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(68, 33);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(38, 16);
            idLabel.TabIndex = 8;
            idLabel.Text = "Cód.:";
            // 
            // data_EntradaLabel
            // 
            data_EntradaLabel.AutoSize = true;
            data_EntradaLabel.Location = new System.Drawing.Point(17, 128);
            data_EntradaLabel.Name = "data_EntradaLabel";
            data_EntradaLabel.Size = new System.Drawing.Size(89, 16);
            data_EntradaLabel.TabIndex = 10;
            data_EntradaLabel.Text = "Data Entrada:";
            // 
            // id_clienteLabel
            // 
            id_clienteLabel.AutoSize = true;
            id_clienteLabel.Location = new System.Drawing.Point(55, 64);
            id_clienteLabel.Name = "id_clienteLabel";
            id_clienteLabel.Size = new System.Drawing.Size(51, 16);
            id_clienteLabel.TabIndex = 12;
            id_clienteLabel.Text = "Cliente:";
            // 
            // id_funcionarioLabel
            // 
            id_funcionarioLabel.AutoSize = true;
            id_funcionarioLabel.Location = new System.Drawing.Point(27, 95);
            id_funcionarioLabel.Name = "id_funcionarioLabel";
            id_funcionarioLabel.Size = new System.Drawing.Size(80, 16);
            id_funcionarioLabel.TabIndex = 14;
            id_funcionarioLabel.Text = "Funcionário:";
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(53, 62);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(58, 16);
            numeroLabel.TabIndex = 16;
            numeroLabel.Text = "Número:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(40, 94);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(72, 16);
            descricaoLabel.TabIndex = 18;
            descricaoLabel.Text = "Descrição:";
            // 
            // valor_DiariaLabel
            // 
            valor_DiariaLabel.AutoSize = true;
            valor_DiariaLabel.Location = new System.Drawing.Point(12, 203);
            valor_DiariaLabel.Name = "valor_DiariaLabel";
            valor_DiariaLabel.Size = new System.Drawing.Size(100, 16);
            valor_DiariaLabel.TabIndex = 20;
            valor_DiariaLabel.Text = "Valor da Diária:";
            // 
            // cpf_ClienteLabel
            // 
            cpf_ClienteLabel.AutoSize = true;
            cpf_ClienteLabel.Location = new System.Drawing.Point(277, 63);
            cpf_ClienteLabel.Name = "cpf_ClienteLabel";
            cpf_ClienteLabel.Size = new System.Drawing.Size(36, 16);
            cpf_ClienteLabel.TabIndex = 32;
            cpf_ClienteLabel.Text = "CPF:";
            // 
            // data_SaidaLabel
            // 
            data_SaidaLabel.AutoSize = true;
            data_SaidaLabel.Location = new System.Drawing.Point(235, 128);
            data_SaidaLabel.Name = "data_SaidaLabel";
            data_SaidaLabel.Size = new System.Drawing.Size(78, 16);
            data_SaidaLabel.TabIndex = 32;
            data_SaidaLabel.Text = "Data Saída:";
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(91, 33);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(21, 16);
            idLabel1.TabIndex = 21;
            idLabel1.Text = "Id:";
            // 
            // id_ClasseLabel
            // 
            id_ClasseLabel.AutoSize = true;
            id_ClasseLabel.Location = new System.Drawing.Point(60, 172);
            id_ClasseLabel.Name = "id_ClasseLabel";
            id_ClasseLabel.Size = new System.Drawing.Size(52, 16);
            id_ClasseLabel.TabIndex = 22;
            id_ClasseLabel.Text = "Classe:";
            // 
            // id_StatusLabel
            // 
            id_StatusLabel.AutoSize = true;
            id_StatusLabel.Location = new System.Drawing.Point(224, 172);
            id_StatusLabel.Name = "id_StatusLabel";
            id_StatusLabel.Size = new System.Drawing.Size(47, 16);
            id_StatusLabel.TabIndex = 32;
            id_StatusLabel.Text = "Status:";
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = System.Drawing.Color.White;
            buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.Image")));
            buttonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonBuscar.Location = new System.Drawing.Point(313, 56);
            buttonBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            buttonBuscar.MinimumSize = new System.Drawing.Size(145, 40);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new System.Drawing.Size(145, 40);
            buttonBuscar.TabIndex = 0;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // quartosDataGridView
            // 
            this.quartosDataGridView.AllowUserToAddRows = false;
            this.quartosDataGridView.AllowUserToDeleteRows = false;
            this.quartosDataGridView.AllowUserToOrderColumns = true;
            this.quartosDataGridView.AutoGenerateColumns = false;
            this.quartosDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.quartosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quartosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.quartosDataGridView.DataSource = this.quartosBindingSource;
            this.quartosDataGridView.Location = new System.Drawing.Point(5, 20);
            this.quartosDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quartosDataGridView.Name = "quartosDataGridView";
            this.quartosDataGridView.ReadOnly = true;
            this.quartosDataGridView.RowHeadersVisible = false;
            this.quartosDataGridView.RowHeadersWidth = 51;
            this.quartosDataGridView.RowTemplate.Height = 24;
            this.quartosDataGridView.Size = new System.Drawing.Size(453, 273);
            this.quartosDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Numero";
            this.dataGridViewTextBoxColumn7.HeaderText = "Número";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn9.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Valor_Diaria";
            this.dataGridViewTextBoxColumn10.HeaderText = "Valor da Diária";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // quartosBindingSource
            // 
            this.quartosBindingSource.DataMember = "Quartos";
            this.quartosBindingSource.DataSource = this.diariaBindingSource;
            // 
            // diariaBindingSource
            // 
            this.diariaBindingSource.DataSource = typeof(Models.Diaria);
            // 
            // idTextBox
            // 
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diariaBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(112, 31);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(50, 22);
            this.idTextBox.TabIndex = 9;
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diariaBindingSource, "Nome_Cliente", true));
            this.clienteTextBox.Location = new System.Drawing.Point(112, 62);
            this.clienteTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.ReadOnly = true;
            this.clienteTextBox.Size = new System.Drawing.Size(150, 22);
            this.clienteTextBox.TabIndex = 13;
            // 
            // funcionarioTextBox
            // 
            this.funcionarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.funcionarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diariaBindingSource, "Funcionario", true));
            this.funcionarioTextBox.Location = new System.Drawing.Point(112, 94);
            this.funcionarioTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.funcionarioTextBox.Name = "funcionarioTextBox";
            this.funcionarioTextBox.ReadOnly = true;
            this.funcionarioTextBox.Size = new System.Drawing.Size(150, 22);
            this.funcionarioTextBox.TabIndex = 15;
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartosBindingSource, "Numero", true));
            this.numeroTextBox.Location = new System.Drawing.Point(117, 58);
            this.numeroTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.ReadOnly = true;
            this.numeroTextBox.Size = new System.Drawing.Size(50, 22);
            this.numeroTextBox.TabIndex = 17;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartosBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(117, 86);
            this.descricaoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.ReadOnly = true;
            this.descricaoTextBox.Size = new System.Drawing.Size(199, 68);
            this.descricaoTextBox.TabIndex = 19;
            // 
            // diariaDataGridView
            // 
            this.diariaDataGridView.AllowUserToAddRows = false;
            this.diariaDataGridView.AllowUserToDeleteRows = false;
            this.diariaDataGridView.AllowUserToOrderColumns = true;
            this.diariaDataGridView.AutoGenerateColumns = false;
            this.diariaDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.diariaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.diariaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn3,
            this.Funcionario,
            this.Id_Funcionario,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn11});
            this.diariaDataGridView.DataSource = this.diariaBindingSource;
            this.diariaDataGridView.Location = new System.Drawing.Point(5, 20);
            this.diariaDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diariaDataGridView.Name = "diariaDataGridView";
            this.diariaDataGridView.ReadOnly = true;
            this.diariaDataGridView.RowHeadersVisible = false;
            this.diariaDataGridView.RowHeadersWidth = 51;
            this.diariaDataGridView.RowTemplate.Height = 24;
            this.diariaDataGridView.Size = new System.Drawing.Size(745, 273);
            this.diariaDataGridView.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Data_Entrada";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data Entrada";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 115;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nome_Cliente";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Funcionario
            // 
            this.Funcionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Funcionario.DataPropertyName = "Funcionario";
            this.Funcionario.HeaderText = "Funcionário";
            this.Funcionario.MinimumWidth = 6;
            this.Funcionario.Name = "Funcionario";
            this.Funcionario.ReadOnly = true;
            // 
            // Id_Funcionario
            // 
            this.Id_Funcionario.DataPropertyName = "Id_Funcionario";
            this.Id_Funcionario.HeaderText = "Id_Funcionario";
            this.Id_Funcionario.MinimumWidth = 6;
            this.Id_Funcionario.Name = "Id_Funcionario";
            this.Id_Funcionario.ReadOnly = true;
            this.Id_Funcionario.Visible = false;
            this.Id_Funcionario.Width = 115;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Valor_Total";
            this.dataGridViewTextBoxColumn5.HeaderText = "Valor total";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 115;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Id_Pagamento";
            this.dataGridViewTextBoxColumn12.HeaderText = "Pagamento";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            this.dataGridViewTextBoxColumn12.Width = 115;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Data_Saida";
            this.dataGridViewTextBoxColumn11.HeaderText = "Data Saída";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            this.dataGridViewTextBoxColumn11.Width = 115;
            // 
            // groupBoxDiaria
            // 
            this.groupBoxDiaria.Controls.Add(data_SaidaLabel);
            this.groupBoxDiaria.Controls.Add(this.data_SaidaMaskedTextBox);
            this.groupBoxDiaria.Controls.Add(cpf_ClienteLabel);
            this.groupBoxDiaria.Controls.Add(this.cpf_ClienteMaskedTextBox);
            this.groupBoxDiaria.Controls.Add(this.data_EntradaMaskedTextBox);
            this.groupBoxDiaria.Controls.Add(idLabel);
            this.groupBoxDiaria.Controls.Add(this.idTextBox);
            this.groupBoxDiaria.Controls.Add(data_EntradaLabel);
            this.groupBoxDiaria.Controls.Add(this.clienteTextBox);
            this.groupBoxDiaria.Controls.Add(id_clienteLabel);
            this.groupBoxDiaria.Controls.Add(this.funcionarioTextBox);
            this.groupBoxDiaria.Controls.Add(id_funcionarioLabel);
            this.groupBoxDiaria.Location = new System.Drawing.Point(12, 462);
            this.groupBoxDiaria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDiaria.Name = "groupBoxDiaria";
            this.groupBoxDiaria.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDiaria.Size = new System.Drawing.Size(515, 155);
            this.groupBoxDiaria.TabIndex = 31;
            this.groupBoxDiaria.TabStop = false;
            this.groupBoxDiaria.Text = "Dados da Diária";
            // 
            // data_SaidaMaskedTextBox
            // 
            this.data_SaidaMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.data_SaidaMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diariaBindingSource, "Data_Saida", true));
            this.data_SaidaMaskedTextBox.Location = new System.Drawing.Point(319, 126);
            this.data_SaidaMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_SaidaMaskedTextBox.Mask = "00/00/0000";
            this.data_SaidaMaskedTextBox.Name = "data_SaidaMaskedTextBox";
            this.data_SaidaMaskedTextBox.ReadOnly = true;
            this.data_SaidaMaskedTextBox.Size = new System.Drawing.Size(101, 22);
            this.data_SaidaMaskedTextBox.TabIndex = 33;
            this.data_SaidaMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // cpf_ClienteMaskedTextBox
            // 
            this.cpf_ClienteMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpf_ClienteMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diariaBindingSource, "Cpf_Cliente", true));
            this.cpf_ClienteMaskedTextBox.Location = new System.Drawing.Point(319, 60);
            this.cpf_ClienteMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cpf_ClienteMaskedTextBox.Mask = "000,000,000-00";
            this.cpf_ClienteMaskedTextBox.Name = "cpf_ClienteMaskedTextBox";
            this.cpf_ClienteMaskedTextBox.ReadOnly = true;
            this.cpf_ClienteMaskedTextBox.Size = new System.Drawing.Size(150, 22);
            this.cpf_ClienteMaskedTextBox.TabIndex = 33;
            // 
            // data_EntradaMaskedTextBox
            // 
            this.data_EntradaMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.data_EntradaMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diariaBindingSource, "Data_Entrada", true));
            this.data_EntradaMaskedTextBox.Location = new System.Drawing.Point(112, 126);
            this.data_EntradaMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_EntradaMaskedTextBox.Mask = "00/00/0000";
            this.data_EntradaMaskedTextBox.Name = "data_EntradaMaskedTextBox";
            this.data_EntradaMaskedTextBox.ReadOnly = true;
            this.data_EntradaMaskedTextBox.Size = new System.Drawing.Size(101, 22);
            this.data_EntradaMaskedTextBox.TabIndex = 33;
            this.data_EntradaMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // groupBoxQuarto
            // 
            this.groupBoxQuarto.Controls.Add(this.valor_DiariaMaskedTextBox);
            this.groupBoxQuarto.Controls.Add(id_StatusLabel);
            this.groupBoxQuarto.Controls.Add(id_ClasseLabel);
            this.groupBoxQuarto.Controls.Add(this.id_StatusTextBox);
            this.groupBoxQuarto.Controls.Add(this.id_ClasseTextBox);
            this.groupBoxQuarto.Controls.Add(idLabel1);
            this.groupBoxQuarto.Controls.Add(this.idTextBox1);
            this.groupBoxQuarto.Controls.Add(numeroLabel);
            this.groupBoxQuarto.Controls.Add(this.numeroTextBox);
            this.groupBoxQuarto.Controls.Add(this.descricaoTextBox);
            this.groupBoxQuarto.Controls.Add(descricaoLabel);
            this.groupBoxQuarto.Controls.Add(valor_DiariaLabel);
            this.groupBoxQuarto.Location = new System.Drawing.Point(773, 462);
            this.groupBoxQuarto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxQuarto.Name = "groupBoxQuarto";
            this.groupBoxQuarto.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxQuarto.Size = new System.Drawing.Size(464, 230);
            this.groupBoxQuarto.TabIndex = 31;
            this.groupBoxQuarto.TabStop = false;
            this.groupBoxQuarto.Text = "Dados da Quarto";
            // 
            // valor_DiariaMaskedTextBox
            // 
            this.valor_DiariaMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valor_DiariaMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartosBindingSource, "Valor_Diaria", true));
            this.valor_DiariaMaskedTextBox.Location = new System.Drawing.Point(117, 199);
            this.valor_DiariaMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valor_DiariaMaskedTextBox.Mask = "$";
            this.valor_DiariaMaskedTextBox.Name = "valor_DiariaMaskedTextBox";
            this.valor_DiariaMaskedTextBox.ReadOnly = true;
            this.valor_DiariaMaskedTextBox.Size = new System.Drawing.Size(101, 22);
            this.valor_DiariaMaskedTextBox.TabIndex = 33;
            this.valor_DiariaMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // id_StatusTextBox
            // 
            this.id_StatusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_StatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartosBindingSource, "Id_Status", true));
            this.id_StatusTextBox.Location = new System.Drawing.Point(277, 167);
            this.id_StatusTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_StatusTextBox.Name = "id_StatusTextBox";
            this.id_StatusTextBox.ReadOnly = true;
            this.id_StatusTextBox.Size = new System.Drawing.Size(101, 22);
            this.id_StatusTextBox.TabIndex = 33;
            // 
            // id_ClasseTextBox
            // 
            this.id_ClasseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_ClasseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartosBindingSource, "Id_Classe", true));
            this.id_ClasseTextBox.Location = new System.Drawing.Point(117, 167);
            this.id_ClasseTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_ClasseTextBox.Name = "id_ClasseTextBox";
            this.id_ClasseTextBox.ReadOnly = true;
            this.id_ClasseTextBox.Size = new System.Drawing.Size(101, 22);
            this.id_ClasseTextBox.TabIndex = 23;
            // 
            // idTextBox1
            // 
            this.idTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartosBindingSource, "Id", true));
            this.idTextBox1.Location = new System.Drawing.Point(117, 30);
            this.idTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.ReadOnly = true;
            this.idTextBox1.Size = new System.Drawing.Size(50, 22);
            this.idTextBox1.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.diariaDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 148);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(756, 300);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diárias cadastradas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonTodos);
            this.groupBox2.Controls.Add(this.radioButtonCPF);
            this.groupBox2.Controls.Add(this.radioButtonNome);
            this.groupBox2.Controls.Add(this.textBoxBuscar);
            this.groupBox2.Controls.Add(buttonBuscar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(464, 101);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisar por";
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
            this.radioButtonTodos.TabIndex = 2;
            this.radioButtonTodos.TabStop = true;
            this.radioButtonTodos.Text = "Todos";
            this.radioButtonTodos.UseVisualStyleBackColor = false;
            // 
            // radioButtonCPF
            // 
            this.radioButtonCPF.AutoSize = true;
            this.radioButtonCPF.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonCPF.Location = new System.Drawing.Point(230, 22);
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
            this.radioButtonNome.Location = new System.Drawing.Point(119, 21);
            this.radioButtonNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonNome.Name = "radioButtonNome";
            this.radioButtonNome.Size = new System.Drawing.Size(83, 25);
            this.radioButtonNome.TabIndex = 2;
            this.radioButtonNome.TabStop = true;
            this.radioButtonNome.Text = "Nome";
            this.radioButtonNome.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxBuscar.Location = new System.Drawing.Point(5, 62);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(297, 30);
            this.textBoxBuscar.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.quartosDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(773, 148);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(464, 300);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quartos";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.maskedTextBox1);
            this.groupBox4.Controls.Add(this.buttonBuscarData);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(773, 11);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(291, 71);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pesquisar por Data";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskedTextBox1.Location = new System.Drawing.Point(5, 30);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(123, 30);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // buttonBuscarData
            // 
            this.buttonBuscarData.BackColor = System.Drawing.Color.White;
            this.buttonBuscarData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarData.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarData.Image")));
            this.buttonBuscarData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscarData.Location = new System.Drawing.Point(140, 25);
            this.buttonBuscarData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarData.MinimumSize = new System.Drawing.Size(145, 40);
            this.buttonBuscarData.Name = "buttonBuscarData";
            this.buttonBuscarData.Size = new System.Drawing.Size(145, 40);
            this.buttonBuscarData.TabIndex = 0;
            this.buttonBuscarData.Text = "Buscar";
            this.buttonBuscarData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscarData.UseVisualStyleBackColor = false;
            // 
            // buttonExcluirQuarto
            // 
            this.buttonExcluirQuarto.BackColor = System.Drawing.Color.White;
            this.buttonExcluirQuarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluirQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonExcluirQuarto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonExcluirQuarto.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluirQuarto.Image")));
            this.buttonExcluirQuarto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExcluirQuarto.Location = new System.Drawing.Point(1092, 735);
            this.buttonExcluirQuarto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExcluirQuarto.MinimumSize = new System.Drawing.Size(145, 40);
            this.buttonExcluirQuarto.Name = "buttonExcluirQuarto";
            this.buttonExcluirQuarto.Size = new System.Drawing.Size(145, 40);
            this.buttonExcluirQuarto.TabIndex = 24;
            this.buttonExcluirQuarto.Text = "Excluir";
            this.buttonExcluirQuarto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExcluirQuarto.UseVisualStyleBackColor = false;
            this.buttonExcluirQuarto.Click += new System.EventHandler(this.buttonExcluirQuarto_Click);
            // 
            // buttonADCquarto
            // 
            this.buttonADCquarto.BackColor = System.Drawing.Color.White;
            this.buttonADCquarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonADCquarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonADCquarto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonADCquarto.Image = ((System.Drawing.Image)(resources.GetObject("buttonADCquarto.Image")));
            this.buttonADCquarto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonADCquarto.Location = new System.Drawing.Point(919, 735);
            this.buttonADCquarto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonADCquarto.MinimumSize = new System.Drawing.Size(145, 40);
            this.buttonADCquarto.Name = "buttonADCquarto";
            this.buttonADCquarto.Size = new System.Drawing.Size(145, 40);
            this.buttonADCquarto.TabIndex = 24;
            this.buttonADCquarto.Text = "Adicionar";
            this.buttonADCquarto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonADCquarto.UseVisualStyleBackColor = false;
            this.buttonADCquarto.Click += new System.EventHandler(this.buttonAdicionarQuarto_Click);
            // 
            // buttonExcluirDiaria
            // 
            this.buttonExcluirDiaria.BackColor = System.Drawing.Color.White;
            this.buttonExcluirDiaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluirDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonExcluirDiaria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonExcluirDiaria.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluirDiaria.Image")));
            this.buttonExcluirDiaria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExcluirDiaria.Location = new System.Drawing.Point(331, 735);
            this.buttonExcluirDiaria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExcluirDiaria.MinimumSize = new System.Drawing.Size(145, 40);
            this.buttonExcluirDiaria.Name = "buttonExcluirDiaria";
            this.buttonExcluirDiaria.Size = new System.Drawing.Size(145, 40);
            this.buttonExcluirDiaria.TabIndex = 24;
            this.buttonExcluirDiaria.Text = "Excluir";
            this.buttonExcluirDiaria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExcluirDiaria.UseVisualStyleBackColor = false;
            this.buttonExcluirDiaria.Click += new System.EventHandler(this.buttonExcluirDiaria_Click);
            // 
            // buttonAlterarDiaria
            // 
            this.buttonAlterarDiaria.BackColor = System.Drawing.Color.White;
            this.buttonAlterarDiaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlterarDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAlterarDiaria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAlterarDiaria.Image = global::WindowsFormsAppGestaoHotel.Properties.Resources.edit;
            this.buttonAlterarDiaria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAlterarDiaria.Location = new System.Drawing.Point(169, 735);
            this.buttonAlterarDiaria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAlterarDiaria.MinimumSize = new System.Drawing.Size(145, 40);
            this.buttonAlterarDiaria.Name = "buttonAlterarDiaria";
            this.buttonAlterarDiaria.Size = new System.Drawing.Size(145, 40);
            this.buttonAlterarDiaria.TabIndex = 24;
            this.buttonAlterarDiaria.Text = "Alterar";
            this.buttonAlterarDiaria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAlterarDiaria.UseVisualStyleBackColor = false;
            this.buttonAlterarDiaria.Click += new System.EventHandler(this.buttonAlterarDiaria_Click);
            // 
            // buttonAdicionarDiaria
            // 
            this.buttonAdicionarDiaria.BackColor = System.Drawing.Color.White;
            this.buttonAdicionarDiaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionarDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAdicionarDiaria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAdicionarDiaria.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdicionarDiaria.Image")));
            this.buttonAdicionarDiaria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdicionarDiaria.Location = new System.Drawing.Point(12, 735);
            this.buttonAdicionarDiaria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdicionarDiaria.MinimumSize = new System.Drawing.Size(145, 40);
            this.buttonAdicionarDiaria.Name = "buttonAdicionarDiaria";
            this.buttonAdicionarDiaria.Size = new System.Drawing.Size(145, 40);
            this.buttonAdicionarDiaria.TabIndex = 24;
            this.buttonAdicionarDiaria.Text = "Adicionar";
            this.buttonAdicionarDiaria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdicionarDiaria.UseVisualStyleBackColor = false;
            this.buttonAdicionarDiaria.Click += new System.EventHandler(this.buttonAdicionarDiaria_Click);
            // 
            // FormBuscarDiaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 786);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxQuarto);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxDiaria);
            this.Controls.Add(this.buttonExcluirQuarto);
            this.Controls.Add(this.buttonADCquarto);
            this.Controls.Add(this.buttonExcluirDiaria);
            this.Controls.Add(this.buttonAlterarDiaria);
            this.Controls.Add(this.buttonAdicionarDiaria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1270, 833);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1270, 833);
            this.Name = "FormBuscarDiaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOTELOGIX - Consulta de Diária";
            this.Load += new System.EventHandler(this.FormBuscarDiaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quartosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diariaDataGridView)).EndInit();
            this.groupBoxDiaria.ResumeLayout(false);
            this.groupBoxDiaria.PerformLayout();
            this.groupBoxQuarto.ResumeLayout(false);
            this.groupBoxQuarto.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource diariaBindingSource;
        private System.Windows.Forms.BindingSource quartosBindingSource;
        private System.Windows.Forms.DataGridView quartosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox clienteTextBox;
        private System.Windows.Forms.TextBox funcionarioTextBox;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Button buttonAdicionarDiaria;
        private System.Windows.Forms.Button buttonAlterarDiaria;
        private System.Windows.Forms.Button buttonExcluirDiaria;
        private System.Windows.Forms.Button buttonADCquarto;
        private System.Windows.Forms.Button buttonExcluirQuarto;
        private System.Windows.Forms.DataGridView diariaDataGridView;
        private System.Windows.Forms.GroupBox groupBoxDiaria;
        private System.Windows.Forms.GroupBox groupBoxQuarto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.RadioButton radioButtonCPF;
        private System.Windows.Forms.RadioButton radioButtonNome;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.MaskedTextBox cpf_ClienteMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox data_EntradaMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox data_SaidaMaskedTextBox;
        private System.Windows.Forms.TextBox id_StatusTextBox;
        private System.Windows.Forms.TextBox id_ClasseTextBox;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonBuscarData;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox valor_DiariaMaskedTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}