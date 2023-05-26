namespace WindowsFormsAppGestaoHotel
{
    partial class FormReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReserva));
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.comboBoxBuscarTipo = new System.Windows.Forms.ComboBox();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelQuartos = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonBuscarTipo = new System.Windows.Forms.Button();
            this.buttonCadastrarReserva = new System.Windows.Forms.Button();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quartoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(12, 57);
            this.monthCalendar.MaxDate = new System.DateTime(2033, 12, 31, 0, 0, 0, 0);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 3;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // comboBoxBuscarTipo
            // 
            this.comboBoxBuscarTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxBuscarTipo.FormattingEnabled = true;
            this.comboBoxBuscarTipo.Items.AddRange(new object[] {
            "Data Check In",
            "Data Check Out",
            "Data Lançamento"});
            this.comboBoxBuscarTipo.Location = new System.Drawing.Point(168, 15);
            this.comboBoxBuscarTipo.Name = "comboBoxBuscarTipo";
            this.comboBoxBuscarTipo.Size = new System.Drawing.Size(155, 26);
            this.comboBoxBuscarTipo.TabIndex = 4;
            // 
            // labelRegistro
            // 
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistro.Location = new System.Drawing.Point(276, 57);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(217, 20);
            this.labelRegistro.TabIndex = 5;
            this.labelRegistro.Text = "Nenhum registro Cadastrado!";
            this.labelRegistro.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox4);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Controls.Add(this.groupBox5);
            this.flowLayoutPanel1.Controls.Add(this.groupBox7);
            this.flowLayoutPanel1.Controls.Add(this.groupBox6);
            this.flowLayoutPanel1.Controls.Add(this.groupBox8);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(280, 80);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(618, 475);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(209, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(0, 0);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            // 
            // flowLayoutPanelQuartos
            // 
            this.flowLayoutPanelQuartos.Location = new System.Drawing.Point(15, 231);
            this.flowLayoutPanelQuartos.Name = "flowLayoutPanelQuartos";
            this.flowLayoutPanelQuartos.Size = new System.Drawing.Size(216, 248);
            this.flowLayoutPanelQuartos.TabIndex = 7;
            // 
            // buttonBuscarTipo
            // 
            this.buttonBuscarTipo.BackColor = System.Drawing.SystemColors.Control;
            this.buttonBuscarTipo.FlatAppearance.BorderSize = 0;
            this.buttonBuscarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarTipo.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarTipo.Image")));
            this.buttonBuscarTipo.Location = new System.Drawing.Point(329, 13);
            this.buttonBuscarTipo.MaximumSize = new System.Drawing.Size(30, 30);
            this.buttonBuscarTipo.MinimumSize = new System.Drawing.Size(30, 30);
            this.buttonBuscarTipo.Name = "buttonBuscarTipo";
            this.buttonBuscarTipo.Size = new System.Drawing.Size(30, 30);
            this.buttonBuscarTipo.TabIndex = 2;
            this.buttonBuscarTipo.UseVisualStyleBackColor = false;
            this.buttonBuscarTipo.Click += new System.EventHandler(this.buttonBuscarTipo_Click);
            // 
            // buttonCadastrarReserva
            // 
            this.buttonCadastrarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(183)))), ((int)(((byte)(219)))));
            this.buttonCadastrarReserva.FlatAppearance.BorderSize = 0;
            this.buttonCadastrarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrarReserva.ForeColor = System.Drawing.Color.White;
            this.buttonCadastrarReserva.Image = ((System.Drawing.Image)(resources.GetObject("buttonCadastrarReserva.Image")));
            this.buttonCadastrarReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCadastrarReserva.Location = new System.Drawing.Point(12, 12);
            this.buttonCadastrarReserva.Name = "buttonCadastrarReserva";
            this.buttonCadastrarReserva.Size = new System.Drawing.Size(120, 33);
            this.buttonCadastrarReserva.TabIndex = 1;
            this.buttonCadastrarReserva.Text = "Reserva";
            this.buttonCadastrarReserva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCadastrarReserva.UseVisualStyleBackColor = false;
            this.buttonCadastrarReserva.Click += new System.EventHandler(this.buttonCadastrarReserva_Click);
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataSource = typeof(Models.Reserva);
            // 
            // quartoBindingSource
            // 
            this.quartoBindingSource.DataSource = typeof(Models.Quarto);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RESERVA 1";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(415, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 150);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RESERVA 3";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(209, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 150);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "RESERVA 2";
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(3, 159);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 150);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "RESERVA 4";
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(415, 159);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 150);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "RESERVA 6";
            // 
            // groupBox7
            // 
            this.groupBox7.Location = new System.Drawing.Point(209, 159);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 150);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "RESERVA 5";
            // 
            // groupBox8
            // 
            this.groupBox8.Location = new System.Drawing.Point(3, 315);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(200, 150);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "RESERVA 7";
            // 
            // FormReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 567);
            this.Controls.Add(this.flowLayoutPanelQuartos);
            this.Controls.Add(this.labelRegistro);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.comboBoxBuscarTipo);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.buttonBuscarTipo);
            this.Controls.Add(this.buttonCadastrarReserva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(937, 606);
            this.Name = "FormReserva";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOTELOGIX - Reservas";
            this.Load += new System.EventHandler(this.FormReserva_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormReserva_KeyDown);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCadastrarReserva;
        private System.Windows.Forms.Button buttonBuscarTipo;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ComboBox comboBoxBuscarTipo;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private System.Windows.Forms.Label labelRegistro;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelQuartos;
        private System.Windows.Forms.BindingSource quartoBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox8;
    }
}