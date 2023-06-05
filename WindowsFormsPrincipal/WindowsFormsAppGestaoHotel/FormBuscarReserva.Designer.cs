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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxDiaria = new System.Windows.Forms.GroupBox();
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
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxBuscarIdReserva = new System.Windows.Forms.TextBox();
            this.data_FinalLabel = new System.Windows.Forms.Label();
            this.data_InicialLabel = new System.Windows.Forms.Label();
            this.datePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.datePickerInicial = new System.Windows.Forms.DateTimePicker();
            this.comboBoxBuscarTipo = new System.Windows.Forms.ComboBox();
            buttonBuscarIdReserva = new System.Windows.Forms.Button();
            buttonBuscarTipo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
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
            // groupBoxDiaria
            // 
            this.groupBoxDiaria.Location = new System.Drawing.Point(9, 410);
            this.groupBoxDiaria.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxDiaria.Name = "groupBoxDiaria";
            this.groupBoxDiaria.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxDiaria.Size = new System.Drawing.Size(920, 193);
            this.groupBoxDiaria.TabIndex = 3;
            this.groupBoxDiaria.TabStop = false;
            this.groupBoxDiaria.Text = "Dados da Reserva";
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
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataSource = typeof(Models.Reserva);
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
            this.textBoxBuscarIdReserva.Size = new System.Drawing.Size(102, 28);
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
            this.data_FinalLabel.Size = new System.Drawing.Size(93, 24);
            this.data_FinalLabel.TabIndex = 7;
            this.data_FinalLabel.Text = "Data Final";
            // 
            // data_InicialLabel
            // 
            this.data_InicialLabel.AutoSize = true;
            this.data_InicialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.data_InicialLabel.Location = new System.Drawing.Point(238, 26);
            this.data_InicialLabel.Name = "data_InicialLabel";
            this.data_InicialLabel.Size = new System.Drawing.Size(99, 24);
            this.data_InicialLabel.TabIndex = 7;
            this.data_InicialLabel.Text = "Data Inicial";
            // 
            // datePickerFinal
            // 
            this.datePickerFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datePickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerFinal.Location = new System.Drawing.Point(585, 24);
            this.datePickerFinal.Name = "datePickerFinal";
            this.datePickerFinal.Size = new System.Drawing.Size(130, 28);
            this.datePickerFinal.TabIndex = 6;
            // 
            // datePickerInicial
            // 
            this.datePickerInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datePickerInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerInicial.Location = new System.Drawing.Point(343, 24);
            this.datePickerInicial.Name = "datePickerInicial";
            this.datePickerInicial.Size = new System.Drawing.Size(130, 28);
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
            this.comboBoxBuscarTipo.Size = new System.Drawing.Size(155, 28);
            this.comboBoxBuscarTipo.TabIndex = 5;
            // 
            // FormBuscarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(938, 639);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxDiaria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(956, 683);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(956, 683);
            this.Name = "FormBuscarReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOTELOGIX - Consulta de Reservas";
            this.Load += new System.EventHandler(this.FormBuscarReserva_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormBuscarReserva_KeyDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reservaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
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
    }
}