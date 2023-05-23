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
            this.buttonBuscarTipo = new System.Windows.Forms.Button();
            this.buttonCadastrarReserva = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.comboBoxBuscarTipo = new System.Windows.Forms.ComboBox();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(12, 57);
            this.monthCalendar.MaxDate = new System.DateTime(2033, 12, 31, 0, 0, 0, 0);
            this.monthCalendar.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 3;
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
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataSource = typeof(Models.Reserva);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(276, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nenhum registro Cadastrado!";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(280, 80);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(508, 399);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(209, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            // 
            // FormReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.comboBoxBuscarTipo);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.buttonBuscarTipo);
            this.Controls.Add(this.buttonCadastrarReserva);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReserva";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOTELOGIX - Reservas";
            this.Load += new System.EventHandler(this.FormReserva_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormReserva_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCadastrarReserva;
        private System.Windows.Forms.Button buttonBuscarTipo;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ComboBox comboBoxBuscarTipo;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}