namespace WindowsFormsAppGestaoHotel
{
    partial class ConsultaContaReceber
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
            System.Windows.Forms.Label data_VencimentoLabel1;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label nome_HospedeLabel;
            System.Windows.Forms.Label nome_funcionarioLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Button buttonBuscar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaContaReceber));
            System.Windows.Forms.Button buttonBuscarTipo;
            this.contasReceberDataGridView = new System.Windows.Forms.DataGridView();
            this.contasReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Adicionar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.data_VencimentoTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.pagarCheckBox = new System.Windows.Forms.CheckBox();
            this.nome_HospedeTextBox = new System.Windows.Forms.TextBox();
            this.nome_funcionarioTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxBuscarIdReserva = new System.Windows.Forms.TextBox();
            this.data_FinalLabel = new System.Windows.Forms.Label();
            this.data_InicialLabel = new System.Windows.Forms.Label();
            this.datePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.datePickerInicial = new System.Windows.Forms.DateTimePicker();
            this.comboBoxBuscarTipo = new System.Windows.Forms.ComboBox();
            data_VencimentoLabel1 = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            nome_HospedeLabel = new System.Windows.Forms.Label();
            nome_funcionarioLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            buttonBuscar = new System.Windows.Forms.Button();
            buttonBuscarTipo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_VencimentoLabel1
            // 
            data_VencimentoLabel1.AutoSize = true;
            data_VencimentoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_VencimentoLabel1.Location = new System.Drawing.Point(1, 69);
            data_VencimentoLabel1.Name = "data_VencimentoLabel1";
            data_VencimentoLabel1.Size = new System.Drawing.Size(81, 16);
            data_VencimentoLabel1.TabIndex = 15;
            data_VencimentoLabel1.Text = "Vencimento:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorLabel.Location = new System.Drawing.Point(615, 69);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(42, 16);
            valorLabel.TabIndex = 13;
            valorLabel.Text = "Valor:";
            // 
            // nome_HospedeLabel
            // 
            nome_HospedeLabel.AutoSize = true;
            nome_HospedeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nome_HospedeLabel.Location = new System.Drawing.Point(134, 26);
            nome_HospedeLabel.Name = "nome_HospedeLabel";
            nome_HospedeLabel.Size = new System.Drawing.Size(67, 16);
            nome_HospedeLabel.TabIndex = 6;
            nome_HospedeLabel.Text = "Hospede:";
            // 
            // nome_funcionarioLabel
            // 
            nome_funcionarioLabel.AutoSize = true;
            nome_funcionarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nome_funcionarioLabel.Location = new System.Drawing.Point(397, 26);
            nome_funcionarioLabel.Name = "nome_funcionarioLabel";
            nome_funcionarioLabel.Size = new System.Drawing.Size(115, 16);
            nome_funcionarioLabel.TabIndex = 4;
            nome_funcionarioLabel.Text = "Nome funcionario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(1, 26);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 16);
            label2.TabIndex = 2;
            label2.Text = "Código:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.Location = new System.Drawing.Point(202, 69);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(72, 16);
            descricaoLabel.TabIndex = 0;
            descricaoLabel.Text = "Descrição:";
            // 
            // contasReceberDataGridView
            // 
            this.contasReceberDataGridView.AllowUserToAddRows = false;
            this.contasReceberDataGridView.AllowUserToDeleteRows = false;
            this.contasReceberDataGridView.AllowUserToOrderColumns = true;
            this.contasReceberDataGridView.AutoGenerateColumns = false;
            this.contasReceberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contasReceberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1});
            this.contasReceberDataGridView.DataSource = this.contasReceberBindingSource;
            this.contasReceberDataGridView.Location = new System.Drawing.Point(4, 17);
            this.contasReceberDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contasReceberDataGridView.Name = "contasReceberDataGridView";
            this.contasReceberDataGridView.ReadOnly = true;
            this.contasReceberDataGridView.RowHeadersVisible = false;
            this.contasReceberDataGridView.RowHeadersWidth = 51;
            this.contasReceberDataGridView.RowTemplate.Height = 24;
            this.contasReceberDataGridView.Size = new System.Drawing.Size(909, 248);
            this.contasReceberDataGridView.TabIndex = 1;
            // 
            // contasReceberBindingSource
            // 
            this.contasReceberBindingSource.DataSource = typeof(Models.ContasReceber);
            // 
            // Adicionar
            // 
            this.Adicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(210)))), ((int)(((byte)(156)))));
            this.Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adicionar.Image = global::WindowsFormsAppGestaoHotel.Properties.Resources.add_bk;
            this.Adicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Adicionar.Location = new System.Drawing.Point(803, 79);
            this.Adicionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(120, 33);
            this.Adicionar.TabIndex = 5;
            this.Adicionar.Text = "Adicionar";
            this.Adicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Adicionar.UseVisualStyleBackColor = false;
            this.Adicionar.Click += new System.EventHandler(this.Adicionar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(data_VencimentoLabel1);
            this.groupBox1.Controls.Add(this.data_VencimentoTextBox);
            this.groupBox1.Controls.Add(valorLabel);
            this.groupBox1.Controls.Add(this.valorTextBox);
            this.groupBox1.Controls.Add(this.pagarCheckBox);
            this.groupBox1.Controls.Add(nome_HospedeLabel);
            this.groupBox1.Controls.Add(this.nome_HospedeTextBox);
            this.groupBox1.Controls.Add(nome_funcionarioLabel);
            this.groupBox1.Controls.Add(this.nome_funcionarioTextBox);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(descricaoLabel);
            this.groupBox1.Controls.Add(this.descricaoTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 408);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(915, 111);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // data_VencimentoTextBox
            // 
            this.data_VencimentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "Data_Vencimento", true));
            this.data_VencimentoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_VencimentoTextBox.Location = new System.Drawing.Point(88, 66);
            this.data_VencimentoTextBox.Name = "data_VencimentoTextBox";
            this.data_VencimentoTextBox.ReadOnly = true;
            this.data_VencimentoTextBox.Size = new System.Drawing.Size(100, 22);
            this.data_VencimentoTextBox.TabIndex = 16;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "Valor", true));
            this.valorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTextBox.Location = new System.Drawing.Point(663, 66);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.ReadOnly = true;
            this.valorTextBox.Size = new System.Drawing.Size(100, 22);
            this.valorTextBox.TabIndex = 14;
            // 
            // pagarCheckBox
            // 
            this.pagarCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.contasReceberBindingSource, "Receber", true));
            this.pagarCheckBox.Enabled = false;
            this.pagarCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagarCheckBox.Location = new System.Drawing.Point(698, 23);
            this.pagarCheckBox.Name = "pagarCheckBox";
            this.pagarCheckBox.Size = new System.Drawing.Size(112, 24);
            this.pagarCheckBox.TabIndex = 13;
            this.pagarCheckBox.Text = "Receber";
            this.pagarCheckBox.UseVisualStyleBackColor = true;
            // 
            // nome_HospedeTextBox
            // 
            this.nome_HospedeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "Nome_Hospede", true));
            this.nome_HospedeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_HospedeTextBox.Location = new System.Drawing.Point(207, 23);
            this.nome_HospedeTextBox.Name = "nome_HospedeTextBox";
            this.nome_HospedeTextBox.ReadOnly = true;
            this.nome_HospedeTextBox.Size = new System.Drawing.Size(167, 22);
            this.nome_HospedeTextBox.TabIndex = 7;
            // 
            // nome_funcionarioTextBox
            // 
            this.nome_funcionarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "Nome_funcionario", true));
            this.nome_funcionarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_funcionarioTextBox.Location = new System.Drawing.Point(518, 23);
            this.nome_funcionarioTextBox.Name = "nome_funcionarioTextBox";
            this.nome_funcionarioTextBox.ReadOnly = true;
            this.nome_funcionarioTextBox.Size = new System.Drawing.Size(176, 22);
            this.nome_funcionarioTextBox.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "Id", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(61, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(53, 22);
            this.textBox1.TabIndex = 3;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "Descricao", true));
            this.descricaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTextBox.Location = new System.Drawing.Point(276, 69);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.ReadOnly = true;
            this.descricaoTextBox.Size = new System.Drawing.Size(315, 22);
            this.descricaoTextBox.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.FillWeight = 60F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Cód.";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn4.FillWeight = 110F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Nome_Hospede";
            this.dataGridViewTextBoxColumn7.HeaderText = "Hóspede";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Valor";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn5.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Data_Vencimento";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn6.HeaderText = "Vencimento";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Nome_funcionario";
            this.dataGridViewTextBoxColumn8.HeaderText = "Lançada Por";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Receber";
            this.dataGridViewCheckBoxColumn1.FillWeight = 80F;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Receber";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.contasReceberDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(11, 120);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(917, 269);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contas à Receber";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.textBoxBuscarIdReserva);
            this.groupBox3.Controls.Add(this.data_FinalLabel);
            this.groupBox3.Controls.Add(this.data_InicialLabel);
            this.groupBox3.Controls.Add(this.datePickerFinal);
            this.groupBox3.Controls.Add(this.datePickerInicial);
            this.groupBox3.Controls.Add(this.comboBoxBuscarTipo);
            this.groupBox3.Controls.Add(buttonBuscar);
            this.groupBox3.Controls.Add(buttonBuscarTipo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(11, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(920, 68);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtrar por";
            // 
            // textBoxBuscarIdReserva
            // 
            this.textBoxBuscarIdReserva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBuscarIdReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxBuscarIdReserva.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxBuscarIdReserva.Location = new System.Drawing.Point(767, 24);
            this.textBoxBuscarIdReserva.Name = "textBoxBuscarIdReserva";
            this.textBoxBuscarIdReserva.Size = new System.Drawing.Size(102, 26);
            this.textBoxBuscarIdReserva.TabIndex = 8;
            this.textBoxBuscarIdReserva.Text = "Cód. Reserva";
            // 
            // data_FinalLabel
            // 
            this.data_FinalLabel.AutoSize = true;
            this.data_FinalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.data_FinalLabel.Location = new System.Drawing.Point(486, 26);
            this.data_FinalLabel.Name = "data_FinalLabel";
            this.data_FinalLabel.Size = new System.Drawing.Size(82, 20);
            this.data_FinalLabel.TabIndex = 7;
            this.data_FinalLabel.Text = "Data Final";
            // 
            // data_InicialLabel
            // 
            this.data_InicialLabel.AutoSize = true;
            this.data_InicialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.data_InicialLabel.Location = new System.Drawing.Point(238, 26);
            this.data_InicialLabel.Name = "data_InicialLabel";
            this.data_InicialLabel.Size = new System.Drawing.Size(88, 20);
            this.data_InicialLabel.TabIndex = 7;
            this.data_InicialLabel.Text = "Data Inicial";
            // 
            // datePickerFinal
            // 
            this.datePickerFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datePickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerFinal.Location = new System.Drawing.Point(585, 24);
            this.datePickerFinal.Name = "datePickerFinal";
            this.datePickerFinal.Size = new System.Drawing.Size(130, 26);
            this.datePickerFinal.TabIndex = 6;
            // 
            // datePickerInicial
            // 
            this.datePickerInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datePickerInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerInicial.Location = new System.Drawing.Point(343, 24);
            this.datePickerInicial.Name = "datePickerInicial";
            this.datePickerInicial.Size = new System.Drawing.Size(130, 26);
            this.datePickerInicial.TabIndex = 6;
            // 
            // comboBoxBuscarTipo
            // 
            this.comboBoxBuscarTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxBuscarTipo.FormattingEnabled = true;
            this.comboBoxBuscarTipo.Items.AddRange(new object[] {
            "Todas",
            "Pendentes",
            "Pagas",
            "Data do Vencimento"});
            this.comboBoxBuscarTipo.Location = new System.Drawing.Point(5, 24);
            this.comboBoxBuscarTipo.Name = "comboBoxBuscarTipo";
            this.comboBoxBuscarTipo.Size = new System.Drawing.Size(155, 26);
            this.comboBoxBuscarTipo.TabIndex = 5;
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            buttonBuscar.FlatAppearance.BorderSize = 0;
            buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.Image")));
            buttonBuscar.Location = new System.Drawing.Point(885, 24);
            buttonBuscar.Margin = new System.Windows.Forms.Padding(2);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new System.Drawing.Size(30, 30);
            buttonBuscar.TabIndex = 4;
            buttonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonBuscarTipo
            // 
            buttonBuscarTipo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            buttonBuscarTipo.FlatAppearance.BorderSize = 0;
            buttonBuscarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonBuscarTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonBuscarTipo.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarTipo.Image")));
            buttonBuscarTipo.Location = new System.Drawing.Point(167, 21);
            buttonBuscarTipo.Margin = new System.Windows.Forms.Padding(2);
            buttonBuscarTipo.Name = "buttonBuscarTipo";
            buttonBuscarTipo.Size = new System.Drawing.Size(30, 30);
            buttonBuscarTipo.TabIndex = 4;
            buttonBuscarTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            buttonBuscarTipo.UseVisualStyleBackColor = false;
            // 
            // ConsultaContaReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(939, 641);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Adicionar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaContaReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Conta Receber";
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource contasReceberBindingSource;
        private System.Windows.Forms.DataGridView contasReceberDataGridView;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox data_VencimentoTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.CheckBox pagarCheckBox;
        private System.Windows.Forms.TextBox nome_HospedeTextBox;
        private System.Windows.Forms.TextBox nome_funcionarioTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxBuscarIdReserva;
        private System.Windows.Forms.Label data_FinalLabel;
        private System.Windows.Forms.Label data_InicialLabel;
        private System.Windows.Forms.DateTimePicker datePickerFinal;
        private System.Windows.Forms.DateTimePicker datePickerInicial;
        private System.Windows.Forms.ComboBox comboBoxBuscarTipo;
    }
}