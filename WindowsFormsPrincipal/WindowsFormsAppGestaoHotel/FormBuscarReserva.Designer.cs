namespace WindowsFormsAppGestaoHotel
{
    partial class FormBuscarReserva
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
            System.Windows.Forms.Button buttonBuscarIdReserva;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarReserva));
            System.Windows.Forms.Button buttonBuscarTipo;
            System.Windows.Forms.Label cPF_HopesdeLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nome_FuncionarioLabel;
            System.Windows.Forms.Label nome_HospedeLabel;
            System.Windows.Forms.Label numero_QuartoLabel;
            System.Windows.Forms.Label obs_ReservaLabel;
            System.Windows.Forms.Label qtd_HospedesLabel;
            System.Windows.Forms.Label valor_EntradaLabel;
            System.Windows.Forms.Label valor_TotalLabel;
            System.Windows.Forms.Label data_ReservaLabel;
            System.Windows.Forms.Label valor_RestanteLabel;
            System.Windows.Forms.Label data_CheckinLabel;
            System.Windows.Forms.Label data_CheckoutLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxDiaria = new System.Windows.Forms.GroupBox();
            this.data_CheckoutMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_CheckinMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cPF_HopesdeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.valor_RestanteTextBox = new System.Windows.Forms.TextBox();
            this.data_ReservaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.valor_TotalTextBox = new System.Windows.Forms.TextBox();
            this.valor_EntradaTextBox = new System.Windows.Forms.TextBox();
            this.qtd_HospedesTextBox = new System.Windows.Forms.TextBox();
            this.obs_ReservaTextBox = new System.Windows.Forms.TextBox();
            this.numero_QuartoTextBox = new System.Windows.Forms.TextBox();
            this.nome_HospedeTextBox = new System.Windows.Forms.TextBox();
            this.nome_FuncionarioTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reservaDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeHospedeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Quarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroQuartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCheckinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCheckoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxBuscarIdReserva = new System.Windows.Forms.TextBox();
            this.data_FinalLabel = new System.Windows.Forms.Label();
            this.data_InicialLabel = new System.Windows.Forms.Label();
            this.datePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.datePickerInicial = new System.Windows.Forms.DateTimePicker();
            this.comboBoxBuscarTipo = new System.Windows.Forms.ComboBox();
            buttonBuscarIdReserva = new System.Windows.Forms.Button();
            buttonBuscarTipo = new System.Windows.Forms.Button();
            cPF_HopesdeLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nome_FuncionarioLabel = new System.Windows.Forms.Label();
            nome_HospedeLabel = new System.Windows.Forms.Label();
            numero_QuartoLabel = new System.Windows.Forms.Label();
            obs_ReservaLabel = new System.Windows.Forms.Label();
            qtd_HospedesLabel = new System.Windows.Forms.Label();
            valor_EntradaLabel = new System.Windows.Forms.Label();
            valor_TotalLabel = new System.Windows.Forms.Label();
            data_ReservaLabel = new System.Windows.Forms.Label();
            valor_RestanteLabel = new System.Windows.Forms.Label();
            data_CheckinLabel = new System.Windows.Forms.Label();
            data_CheckoutLabel = new System.Windows.Forms.Label();
            this.groupBoxDiaria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservaDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBuscarIdReserva
            // 
            buttonBuscarIdReserva.BackColor = System.Drawing.Color.Transparent;
            buttonBuscarIdReserva.FlatAppearance.BorderSize = 0;
            buttonBuscarIdReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonBuscarIdReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonBuscarIdReserva.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarIdReserva.Image")));
            buttonBuscarIdReserva.Location = new System.Drawing.Point(886, 21);
            buttonBuscarIdReserva.Margin = new System.Windows.Forms.Padding(2);
            buttonBuscarIdReserva.Name = "buttonBuscarIdReserva";
            buttonBuscarIdReserva.Size = new System.Drawing.Size(30, 30);
            buttonBuscarIdReserva.TabIndex = 4;
            buttonBuscarIdReserva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            buttonBuscarIdReserva.UseVisualStyleBackColor = false;
            buttonBuscarIdReserva.Click += new System.EventHandler(this.buttonBuscarIdReserva_Click);
            // 
            // buttonBuscarTipo
            // 
            buttonBuscarTipo.BackColor = System.Drawing.Color.Transparent;
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
            buttonBuscarTipo.Click += new System.EventHandler(this.buttonBuscarTipo_Click);
            // 
            // cPF_HopesdeLabel
            // 
            cPF_HopesdeLabel.AutoSize = true;
            cPF_HopesdeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            cPF_HopesdeLabel.Location = new System.Drawing.Point(13, 93);
            cPF_HopesdeLabel.Name = "cPF_HopesdeLabel";
            cPF_HopesdeLabel.Size = new System.Drawing.Size(113, 20);
            cPF_HopesdeLabel.TabIndex = 0;
            cPF_HopesdeLabel.Text = "CPF Hópesde:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            idLabel.Location = new System.Drawing.Point(80, 29);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(46, 20);
            idLabel.TabIndex = 2;
            idLabel.Text = "Cód.:";
            // 
            // nome_FuncionarioLabel
            // 
            nome_FuncionarioLabel.AutoSize = true;
            nome_FuncionarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            nome_FuncionarioLabel.Location = new System.Drawing.Point(503, 57);
            nome_FuncionarioLabel.Name = "nome_FuncionarioLabel";
            nome_FuncionarioLabel.Size = new System.Drawing.Size(96, 20);
            nome_FuncionarioLabel.TabIndex = 4;
            nome_FuncionarioLabel.Text = "Funcionário:";
            // 
            // nome_HospedeLabel
            // 
            nome_HospedeLabel.AutoSize = true;
            nome_HospedeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            nome_HospedeLabel.Location = new System.Drawing.Point(48, 60);
            nome_HospedeLabel.Name = "nome_HospedeLabel";
            nome_HospedeLabel.Size = new System.Drawing.Size(78, 20);
            nome_HospedeLabel.TabIndex = 6;
            nome_HospedeLabel.Text = "Hóspede:";
            // 
            // numero_QuartoLabel
            // 
            numero_QuartoLabel.AutoSize = true;
            numero_QuartoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            numero_QuartoLabel.Location = new System.Drawing.Point(516, 93);
            numero_QuartoLabel.Name = "numero_QuartoLabel";
            numero_QuartoLabel.Size = new System.Drawing.Size(83, 20);
            numero_QuartoLabel.TabIndex = 8;
            numero_QuartoLabel.Text = "Nº Quarto:";
            // 
            // obs_ReservaLabel
            // 
            obs_ReservaLabel.AutoSize = true;
            obs_ReservaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            obs_ReservaLabel.Location = new System.Drawing.Point(490, 124);
            obs_ReservaLabel.Name = "obs_ReservaLabel";
            obs_ReservaLabel.Size = new System.Drawing.Size(109, 20);
            obs_ReservaLabel.TabIndex = 10;
            obs_ReservaLabel.Text = "Obs. Reserva:";
            // 
            // qtd_HospedesLabel
            // 
            qtd_HospedesLabel.AutoSize = true;
            qtd_HospedesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            qtd_HospedesLabel.Location = new System.Drawing.Point(258, 93);
            qtd_HospedesLabel.Name = "qtd_HospedesLabel";
            qtd_HospedesLabel.Size = new System.Drawing.Size(116, 20);
            qtd_HospedesLabel.TabIndex = 12;
            qtd_HospedesLabel.Text = "Qtd Hóspedes:";
            // 
            // valor_EntradaLabel
            // 
            valor_EntradaLabel.AutoSize = true;
            valor_EntradaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            valor_EntradaLabel.Location = new System.Drawing.Point(263, 125);
            valor_EntradaLabel.Name = "valor_EntradaLabel";
            valor_EntradaLabel.Size = new System.Drawing.Size(111, 20);
            valor_EntradaLabel.TabIndex = 14;
            valor_EntradaLabel.Text = "Valor Entrada:";
            // 
            // valor_TotalLabel
            // 
            valor_TotalLabel.AutoSize = true;
            valor_TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            valor_TotalLabel.Location = new System.Drawing.Point(285, 158);
            valor_TotalLabel.Name = "valor_TotalLabel";
            valor_TotalLabel.Size = new System.Drawing.Size(89, 20);
            valor_TotalLabel.TabIndex = 16;
            valor_TotalLabel.Text = "Valor Total:";
            // 
            // data_ReservaLabel
            // 
            data_ReservaLabel.AutoSize = true;
            data_ReservaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            data_ReservaLabel.Location = new System.Drawing.Point(15, 190);
            data_ReservaLabel.Name = "data_ReservaLabel";
            data_ReservaLabel.Size = new System.Drawing.Size(111, 20);
            data_ReservaLabel.TabIndex = 18;
            data_ReservaLabel.Text = "Data Reserva:";
            // 
            // valor_RestanteLabel
            // 
            valor_RestanteLabel.AutoSize = true;
            valor_RestanteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            valor_RestanteLabel.Location = new System.Drawing.Point(254, 190);
            valor_RestanteLabel.Name = "valor_RestanteLabel";
            valor_RestanteLabel.Size = new System.Drawing.Size(120, 20);
            valor_RestanteLabel.TabIndex = 20;
            valor_RestanteLabel.Text = "Valor Restante:";
            // 
            // data_CheckinLabel
            // 
            data_CheckinLabel.AutoSize = true;
            data_CheckinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            data_CheckinLabel.Location = new System.Drawing.Point(17, 125);
            data_CheckinLabel.Name = "data_CheckinLabel";
            data_CheckinLabel.Size = new System.Drawing.Size(109, 20);
            data_CheckinLabel.TabIndex = 22;
            data_CheckinLabel.Text = "Data Checkin:";
            // 
            // data_CheckoutLabel
            // 
            data_CheckoutLabel.AutoSize = true;
            data_CheckoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            data_CheckoutLabel.Location = new System.Drawing.Point(6, 158);
            data_CheckoutLabel.Name = "data_CheckoutLabel";
            data_CheckoutLabel.Size = new System.Drawing.Size(120, 20);
            data_CheckoutLabel.TabIndex = 24;
            data_CheckoutLabel.Text = "Data Checkout:";
            // 
            // groupBoxDiaria
            // 
            this.groupBoxDiaria.Controls.Add(this.data_CheckoutMaskedTextBox);
            this.groupBoxDiaria.Controls.Add(this.data_CheckinMaskedTextBox);
            this.groupBoxDiaria.Controls.Add(data_CheckoutLabel);
            this.groupBoxDiaria.Controls.Add(data_CheckinLabel);
            this.groupBoxDiaria.Controls.Add(this.cPF_HopesdeMaskedTextBox);
            this.groupBoxDiaria.Controls.Add(valor_RestanteLabel);
            this.groupBoxDiaria.Controls.Add(this.valor_RestanteTextBox);
            this.groupBoxDiaria.Controls.Add(data_ReservaLabel);
            this.groupBoxDiaria.Controls.Add(this.data_ReservaMaskedTextBox);
            this.groupBoxDiaria.Controls.Add(valor_TotalLabel);
            this.groupBoxDiaria.Controls.Add(this.valor_TotalTextBox);
            this.groupBoxDiaria.Controls.Add(valor_EntradaLabel);
            this.groupBoxDiaria.Controls.Add(this.valor_EntradaTextBox);
            this.groupBoxDiaria.Controls.Add(qtd_HospedesLabel);
            this.groupBoxDiaria.Controls.Add(this.qtd_HospedesTextBox);
            this.groupBoxDiaria.Controls.Add(obs_ReservaLabel);
            this.groupBoxDiaria.Controls.Add(this.obs_ReservaTextBox);
            this.groupBoxDiaria.Controls.Add(numero_QuartoLabel);
            this.groupBoxDiaria.Controls.Add(this.numero_QuartoTextBox);
            this.groupBoxDiaria.Controls.Add(nome_HospedeLabel);
            this.groupBoxDiaria.Controls.Add(this.nome_HospedeTextBox);
            this.groupBoxDiaria.Controls.Add(nome_FuncionarioLabel);
            this.groupBoxDiaria.Controls.Add(this.nome_FuncionarioTextBox);
            this.groupBoxDiaria.Controls.Add(idLabel);
            this.groupBoxDiaria.Controls.Add(this.idTextBox);
            this.groupBoxDiaria.Controls.Add(cPF_HopesdeLabel);
            this.groupBoxDiaria.Location = new System.Drawing.Point(9, 405);
            this.groupBoxDiaria.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxDiaria.Name = "groupBoxDiaria";
            this.groupBoxDiaria.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxDiaria.Size = new System.Drawing.Size(920, 225);
            this.groupBoxDiaria.TabIndex = 3;
            this.groupBoxDiaria.TabStop = false;
            this.groupBoxDiaria.Text = "Dados da Reserva";
            // 
            // data_CheckoutMaskedTextBox
            // 
            this.data_CheckoutMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.data_CheckoutMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Data_Checkout", true));
            this.data_CheckoutMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.data_CheckoutMaskedTextBox.Location = new System.Drawing.Point(131, 155);
            this.data_CheckoutMaskedTextBox.Mask = "00/00/0000";
            this.data_CheckoutMaskedTextBox.Name = "data_CheckoutMaskedTextBox";
            this.data_CheckoutMaskedTextBox.ReadOnly = true;
            this.data_CheckoutMaskedTextBox.Size = new System.Drawing.Size(85, 26);
            this.data_CheckoutMaskedTextBox.TabIndex = 26;
            this.data_CheckoutMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataSource = typeof(Models.Reserva);
            // 
            // data_CheckinMaskedTextBox
            // 
            this.data_CheckinMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.data_CheckinMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Data_Checkin", true));
            this.data_CheckinMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.data_CheckinMaskedTextBox.Location = new System.Drawing.Point(131, 122);
            this.data_CheckinMaskedTextBox.Mask = "00/00/0000";
            this.data_CheckinMaskedTextBox.Name = "data_CheckinMaskedTextBox";
            this.data_CheckinMaskedTextBox.ReadOnly = true;
            this.data_CheckinMaskedTextBox.Size = new System.Drawing.Size(85, 26);
            this.data_CheckinMaskedTextBox.TabIndex = 25;
            this.data_CheckinMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // cPF_HopesdeMaskedTextBox
            // 
            this.cPF_HopesdeMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cPF_HopesdeMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "CPF_Hopesde", true));
            this.cPF_HopesdeMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cPF_HopesdeMaskedTextBox.Location = new System.Drawing.Point(131, 90);
            this.cPF_HopesdeMaskedTextBox.Mask = "000,000,000-00";
            this.cPF_HopesdeMaskedTextBox.Name = "cPF_HopesdeMaskedTextBox";
            this.cPF_HopesdeMaskedTextBox.ReadOnly = true;
            this.cPF_HopesdeMaskedTextBox.Size = new System.Drawing.Size(120, 26);
            this.cPF_HopesdeMaskedTextBox.TabIndex = 22;
            // 
            // valor_RestanteTextBox
            // 
            this.valor_RestanteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valor_RestanteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Valor_Restante", true));
            this.valor_RestanteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.valor_RestanteTextBox.Location = new System.Drawing.Point(382, 187);
            this.valor_RestanteTextBox.Name = "valor_RestanteTextBox";
            this.valor_RestanteTextBox.ReadOnly = true;
            this.valor_RestanteTextBox.Size = new System.Drawing.Size(100, 26);
            this.valor_RestanteTextBox.TabIndex = 21;
            this.valor_RestanteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // data_ReservaMaskedTextBox
            // 
            this.data_ReservaMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.data_ReservaMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Data_Reserva", true));
            this.data_ReservaMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.data_ReservaMaskedTextBox.Location = new System.Drawing.Point(131, 187);
            this.data_ReservaMaskedTextBox.Mask = "00/00/0000";
            this.data_ReservaMaskedTextBox.Name = "data_ReservaMaskedTextBox";
            this.data_ReservaMaskedTextBox.ReadOnly = true;
            this.data_ReservaMaskedTextBox.Size = new System.Drawing.Size(85, 26);
            this.data_ReservaMaskedTextBox.TabIndex = 19;
            this.data_ReservaMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // valor_TotalTextBox
            // 
            this.valor_TotalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valor_TotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Valor_Total", true));
            this.valor_TotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.valor_TotalTextBox.Location = new System.Drawing.Point(382, 155);
            this.valor_TotalTextBox.Name = "valor_TotalTextBox";
            this.valor_TotalTextBox.ReadOnly = true;
            this.valor_TotalTextBox.Size = new System.Drawing.Size(100, 26);
            this.valor_TotalTextBox.TabIndex = 17;
            this.valor_TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valor_TotalTextBox.TextChanged += new System.EventHandler(this.valor_TotalTextBox_TextChanged);
            // 
            // valor_EntradaTextBox
            // 
            this.valor_EntradaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valor_EntradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Valor_Entrada", true));
            this.valor_EntradaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.valor_EntradaTextBox.Location = new System.Drawing.Point(382, 122);
            this.valor_EntradaTextBox.Name = "valor_EntradaTextBox";
            this.valor_EntradaTextBox.ReadOnly = true;
            this.valor_EntradaTextBox.Size = new System.Drawing.Size(100, 26);
            this.valor_EntradaTextBox.TabIndex = 15;
            this.valor_EntradaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valor_EntradaTextBox.TextChanged += new System.EventHandler(this.valor_EntradaTextBox_TextChanged);
            // 
            // qtd_HospedesTextBox
            // 
            this.qtd_HospedesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qtd_HospedesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Qtd_Hospedes", true));
            this.qtd_HospedesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.qtd_HospedesTextBox.Location = new System.Drawing.Point(382, 90);
            this.qtd_HospedesTextBox.Name = "qtd_HospedesTextBox";
            this.qtd_HospedesTextBox.ReadOnly = true;
            this.qtd_HospedesTextBox.Size = new System.Drawing.Size(52, 26);
            this.qtd_HospedesTextBox.TabIndex = 13;
            this.qtd_HospedesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // obs_ReservaTextBox
            // 
            this.obs_ReservaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.obs_ReservaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Obs_Reserva", true));
            this.obs_ReservaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.obs_ReservaTextBox.Location = new System.Drawing.Point(603, 121);
            this.obs_ReservaTextBox.Multiline = true;
            this.obs_ReservaTextBox.Name = "obs_ReservaTextBox";
            this.obs_ReservaTextBox.ReadOnly = true;
            this.obs_ReservaTextBox.Size = new System.Drawing.Size(303, 92);
            this.obs_ReservaTextBox.TabIndex = 11;
            // 
            // numero_QuartoTextBox
            // 
            this.numero_QuartoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numero_QuartoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Numero_Quarto", true));
            this.numero_QuartoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numero_QuartoTextBox.Location = new System.Drawing.Point(603, 90);
            this.numero_QuartoTextBox.Name = "numero_QuartoTextBox";
            this.numero_QuartoTextBox.ReadOnly = true;
            this.numero_QuartoTextBox.Size = new System.Drawing.Size(52, 26);
            this.numero_QuartoTextBox.TabIndex = 9;
            this.numero_QuartoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nome_HospedeTextBox
            // 
            this.nome_HospedeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nome_HospedeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Nome_Hospede", true));
            this.nome_HospedeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nome_HospedeTextBox.Location = new System.Drawing.Point(131, 57);
            this.nome_HospedeTextBox.Name = "nome_HospedeTextBox";
            this.nome_HospedeTextBox.ReadOnly = true;
            this.nome_HospedeTextBox.Size = new System.Drawing.Size(303, 26);
            this.nome_HospedeTextBox.TabIndex = 7;
            // 
            // nome_FuncionarioTextBox
            // 
            this.nome_FuncionarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nome_FuncionarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Nome_Funcionario", true));
            this.nome_FuncionarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nome_FuncionarioTextBox.Location = new System.Drawing.Point(603, 54);
            this.nome_FuncionarioTextBox.Name = "nome_FuncionarioTextBox";
            this.nome_FuncionarioTextBox.ReadOnly = true;
            this.nome_FuncionarioTextBox.Size = new System.Drawing.Size(303, 26);
            this.nome_FuncionarioTextBox.TabIndex = 5;
            // 
            // idTextBox
            // 
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.idTextBox.Location = new System.Drawing.Point(131, 26);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(50, 26);
            this.idTextBox.TabIndex = 3;
            this.idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reservaDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(9, 99);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(920, 291);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservas";
            // 
            // reservaDataGridView
            // 
            this.reservaDataGridView.AllowUserToAddRows = false;
            this.reservaDataGridView.AllowUserToDeleteRows = false;
            this.reservaDataGridView.AllowUserToOrderColumns = true;
            this.reservaDataGridView.AutoGenerateColumns = false;
            this.reservaDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.reservaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeHospedeDataGridViewTextBoxColumn,
            this.Tipo_Quarto,
            this.numeroQuartoDataGridViewTextBoxColumn,
            this.dataCheckinDataGridViewTextBoxColumn,
            this.dataCheckoutDataGridViewTextBoxColumn,
            this.Data_Reserva,
            this.nomeFuncionarioDataGridViewTextBoxColumn,
            this.valorTotalDataGridViewTextBoxColumn});
            this.reservaDataGridView.DataSource = this.reservaBindingSource;
            this.reservaDataGridView.Location = new System.Drawing.Point(5, 18);
            this.reservaDataGridView.Name = "reservaDataGridView";
            this.reservaDataGridView.ReadOnly = true;
            this.reservaDataGridView.RowHeadersVisible = false;
            this.reservaDataGridView.RowHeadersWidth = 47;
            this.reservaDataGridView.Size = new System.Drawing.Size(910, 268);
            this.reservaDataGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idDataGridViewTextBoxColumn.FillWeight = 27F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Cód";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 67;
            // 
            // nomeHospedeDataGridViewTextBoxColumn
            // 
            this.nomeHospedeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeHospedeDataGridViewTextBoxColumn.DataPropertyName = "Nome_Hospede";
            this.nomeHospedeDataGridViewTextBoxColumn.FillWeight = 45.62093F;
            this.nomeHospedeDataGridViewTextBoxColumn.HeaderText = "Hóspede";
            this.nomeHospedeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeHospedeDataGridViewTextBoxColumn.Name = "nomeHospedeDataGridViewTextBoxColumn";
            this.nomeHospedeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Tipo_Quarto
            // 
            this.Tipo_Quarto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tipo_Quarto.DataPropertyName = "Tipo_Quarto";
            this.Tipo_Quarto.FillWeight = 45.62093F;
            this.Tipo_Quarto.HeaderText = "Tipo Quarto";
            this.Tipo_Quarto.MinimumWidth = 6;
            this.Tipo_Quarto.Name = "Tipo_Quarto";
            this.Tipo_Quarto.ReadOnly = true;
            // 
            // numeroQuartoDataGridViewTextBoxColumn
            // 
            this.numeroQuartoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numeroQuartoDataGridViewTextBoxColumn.DataPropertyName = "Numero_Quarto";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.numeroQuartoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.numeroQuartoDataGridViewTextBoxColumn.FillWeight = 30F;
            this.numeroQuartoDataGridViewTextBoxColumn.HeaderText = "Nº Quarto";
            this.numeroQuartoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroQuartoDataGridViewTextBoxColumn.Name = "numeroQuartoDataGridViewTextBoxColumn";
            this.numeroQuartoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataCheckinDataGridViewTextBoxColumn
            // 
            this.dataCheckinDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataCheckinDataGridViewTextBoxColumn.DataPropertyName = "Data_Checkin";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dataCheckinDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataCheckinDataGridViewTextBoxColumn.FillWeight = 45.62093F;
            this.dataCheckinDataGridViewTextBoxColumn.HeaderText = "Check-In";
            this.dataCheckinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataCheckinDataGridViewTextBoxColumn.Name = "dataCheckinDataGridViewTextBoxColumn";
            this.dataCheckinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataCheckoutDataGridViewTextBoxColumn
            // 
            this.dataCheckoutDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataCheckoutDataGridViewTextBoxColumn.DataPropertyName = "Data_Checkout";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.dataCheckoutDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataCheckoutDataGridViewTextBoxColumn.FillWeight = 45.62093F;
            this.dataCheckoutDataGridViewTextBoxColumn.HeaderText = "Check-Out";
            this.dataCheckoutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataCheckoutDataGridViewTextBoxColumn.Name = "dataCheckoutDataGridViewTextBoxColumn";
            this.dataCheckoutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Data_Reserva
            // 
            this.Data_Reserva.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Data_Reserva.DataPropertyName = "Data_Reserva";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.Data_Reserva.DefaultCellStyle = dataGridViewCellStyle5;
            this.Data_Reserva.FillWeight = 45.62093F;
            this.Data_Reserva.HeaderText = "Data Reserva";
            this.Data_Reserva.MinimumWidth = 6;
            this.Data_Reserva.Name = "Data_Reserva";
            this.Data_Reserva.ReadOnly = true;
            // 
            // nomeFuncionarioDataGridViewTextBoxColumn
            // 
            this.nomeFuncionarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "Nome_Funcionario";
            this.nomeFuncionarioDataGridViewTextBoxColumn.FillWeight = 45.62093F;
            this.nomeFuncionarioDataGridViewTextBoxColumn.HeaderText = "Funcionário";
            this.nomeFuncionarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeFuncionarioDataGridViewTextBoxColumn.Name = "nomeFuncionarioDataGridViewTextBoxColumn";
            this.nomeFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            this.valorTotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valorTotalDataGridViewTextBoxColumn.DataPropertyName = "Valor_Total";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.valorTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.valorTotalDataGridViewTextBoxColumn.FillWeight = 45.62093F;
            this.valorTotalDataGridViewTextBoxColumn.HeaderText = "Valor Total";
            this.valorTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            this.valorTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxBuscarIdReserva);
            this.groupBox2.Controls.Add(this.data_FinalLabel);
            this.groupBox2.Controls.Add(this.data_InicialLabel);
            this.groupBox2.Controls.Add(this.datePickerFinal);
            this.groupBox2.Controls.Add(this.datePickerInicial);
            this.groupBox2.Controls.Add(this.comboBoxBuscarTipo);
            this.groupBox2.Controls.Add(buttonBuscarIdReserva);
            this.groupBox2.Controls.Add(buttonBuscarTipo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(920, 68);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar por";
            // 
            // textBoxBuscarIdReserva
            // 
            this.textBoxBuscarIdReserva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBuscarIdReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxBuscarIdReserva.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxBuscarIdReserva.Location = new System.Drawing.Point(779, 23);
            this.textBoxBuscarIdReserva.Name = "textBoxBuscarIdReserva";
            this.textBoxBuscarIdReserva.Size = new System.Drawing.Size(102, 26);
            this.textBoxBuscarIdReserva.TabIndex = 8;
            this.textBoxBuscarIdReserva.Text = "Cód. Reserva";
            this.textBoxBuscarIdReserva.Click += new System.EventHandler(this.textBoxBuscarIdReserva_Click);
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
            "Data Check In",
            "Data Check Out",
            "Data Lançamento"});
            this.comboBoxBuscarTipo.Location = new System.Drawing.Point(5, 24);
            this.comboBoxBuscarTipo.Name = "comboBoxBuscarTipo";
            this.comboBoxBuscarTipo.Size = new System.Drawing.Size(155, 26);
            this.comboBoxBuscarTipo.TabIndex = 5;
            // 
            // FormBuscarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(939, 641);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxDiaria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(955, 680);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(955, 680);
            this.Name = "FormBuscarReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOTELOGIX - Consulta de Reservas";
            this.Load += new System.EventHandler(this.FormBuscarReserva_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormBuscarReserva_KeyDown);
            this.groupBoxDiaria.ResumeLayout(false);
            this.groupBoxDiaria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reservaDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxDiaria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxBuscarTipo;
        private System.Windows.Forms.TextBox textBoxBuscarIdReserva;
        private System.Windows.Forms.Label data_FinalLabel;
        private System.Windows.Forms.Label data_InicialLabel;
        private System.Windows.Forms.DateTimePicker datePickerFinal;
        private System.Windows.Forms.DateTimePicker datePickerInicial;
        private System.Windows.Forms.DataGridView reservaDataGridView;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeHospedeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Quarto;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroQuartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCheckinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCheckoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Reserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox data_CheckoutMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox data_CheckinMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cPF_HopesdeMaskedTextBox;
        private System.Windows.Forms.TextBox valor_RestanteTextBox;
        private System.Windows.Forms.MaskedTextBox data_ReservaMaskedTextBox;
        private System.Windows.Forms.TextBox valor_TotalTextBox;
        private System.Windows.Forms.TextBox valor_EntradaTextBox;
        private System.Windows.Forms.TextBox qtd_HospedesTextBox;
        private System.Windows.Forms.TextBox obs_ReservaTextBox;
        private System.Windows.Forms.TextBox numero_QuartoTextBox;
        private System.Windows.Forms.TextBox nome_HospedeTextBox;
        private System.Windows.Forms.TextBox nome_FuncionarioTextBox;
        private System.Windows.Forms.TextBox idTextBox;
    }
}