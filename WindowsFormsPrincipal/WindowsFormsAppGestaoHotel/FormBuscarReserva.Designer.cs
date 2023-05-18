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
            System.Windows.Forms.Button buttonBuscarTipo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarReserva));
            System.Windows.Forms.Button buttonBuscarIdReserva;
            this.quartosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxDiaria = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.data_InicialLabel = new System.Windows.Forms.Label();
            this.data_FinalLabel = new System.Windows.Forms.Label();
            this.textBoxBuscarIdReserva = new System.Windows.Forms.TextBox();
            buttonBuscarTipo = new System.Windows.Forms.Button();
            buttonBuscarIdReserva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quartosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diariaBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBuscarTipo
            // 
            buttonBuscarTipo.BackColor = System.Drawing.SystemColors.Control;
            buttonBuscarTipo.FlatAppearance.BorderSize = 0;
            buttonBuscarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonBuscarTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonBuscarTipo.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarTipo.Image")));
            buttonBuscarTipo.Location = new System.Drawing.Point(167, 28);
            buttonBuscarTipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            buttonBuscarTipo.Name = "buttonBuscarTipo";
            buttonBuscarTipo.Size = new System.Drawing.Size(30, 30);
            buttonBuscarTipo.TabIndex = 4;
            buttonBuscarTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            buttonBuscarTipo.UseVisualStyleBackColor = false;
            buttonBuscarTipo.Click += new System.EventHandler(this.buttonBuscar_Click);
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
            // groupBoxDiaria
            // 
            this.groupBoxDiaria.Location = new System.Drawing.Point(9, 375);
            this.groupBoxDiaria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDiaria.Name = "groupBoxDiaria";
            this.groupBoxDiaria.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDiaria.Size = new System.Drawing.Size(920, 164);
            this.groupBoxDiaria.TabIndex = 3;
            this.groupBoxDiaria.TabStop = false;
            this.groupBoxDiaria.Text = "Dados da Reserva";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(9, 120);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(920, 244);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxBuscarIdReserva);
            this.groupBox2.Controls.Add(this.data_FinalLabel);
            this.groupBox2.Controls.Add(this.data_InicialLabel);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(buttonBuscarIdReserva);
            this.groupBox2.Controls.Add(buttonBuscarTipo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(920, 93);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar por";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Data Check In",
            "Data Check Out",
            "Data Lançamento"});
            this.comboBox1.Location = new System.Drawing.Point(5, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 26);
            this.comboBox1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(332, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 26);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(574, 30);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(130, 26);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // data_InicialLabel
            // 
            this.data_InicialLabel.AutoSize = true;
            this.data_InicialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.data_InicialLabel.Location = new System.Drawing.Point(238, 33);
            this.data_InicialLabel.Name = "data_InicialLabel";
            this.data_InicialLabel.Size = new System.Drawing.Size(88, 20);
            this.data_InicialLabel.TabIndex = 7;
            this.data_InicialLabel.Text = "Data Inicial";
            // 
            // data_FinalLabel
            // 
            this.data_FinalLabel.AutoSize = true;
            this.data_FinalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.data_FinalLabel.Location = new System.Drawing.Point(486, 33);
            this.data_FinalLabel.Name = "data_FinalLabel";
            this.data_FinalLabel.Size = new System.Drawing.Size(82, 20);
            this.data_FinalLabel.TabIndex = 7;
            this.data_FinalLabel.Text = "Data Final";
            // 
            // textBoxBuscarIdReserva
            // 
            this.textBoxBuscarIdReserva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBuscarIdReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxBuscarIdReserva.Location = new System.Drawing.Point(753, 30);
            this.textBoxBuscarIdReserva.Name = "textBoxBuscarIdReserva";
            this.textBoxBuscarIdReserva.Size = new System.Drawing.Size(68, 26);
            this.textBoxBuscarIdReserva.TabIndex = 8;
            // 
            // buttonBuscarIdReserva
            // 
            buttonBuscarIdReserva.BackColor = System.Drawing.SystemColors.Control;
            buttonBuscarIdReserva.FlatAppearance.BorderSize = 0;
            buttonBuscarIdReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonBuscarIdReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonBuscarIdReserva.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarIdReserva.Image")));
            buttonBuscarIdReserva.Location = new System.Drawing.Point(826, 28);
            buttonBuscarIdReserva.Margin = new System.Windows.Forms.Padding(2);
            buttonBuscarIdReserva.Name = "buttonBuscarIdReserva";
            buttonBuscarIdReserva.Size = new System.Drawing.Size(30, 30);
            buttonBuscarIdReserva.TabIndex = 4;
            buttonBuscarIdReserva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            buttonBuscarIdReserva.UseVisualStyleBackColor = false;
            buttonBuscarIdReserva.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // FormBuscarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(940, 644);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxDiaria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(956, 683);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(956, 683);
            this.Name = "FormBuscarReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOTELOGIX - Consulta de Reservas";
            this.Load += new System.EventHandler(this.FormBuscarDiaria_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormBuscarDiaria_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.quartosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diariaBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource diariaBindingSource;
        private System.Windows.Forms.BindingSource quartosBindingSource;
        private System.Windows.Forms.GroupBox groupBoxDiaria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxBuscarIdReserva;
        private System.Windows.Forms.Label data_FinalLabel;
        private System.Windows.Forms.Label data_InicialLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}