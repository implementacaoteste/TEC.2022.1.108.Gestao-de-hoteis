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
            this.flowLayoutPanelReserva = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelQuartos = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonBuscarTipo = new System.Windows.Forms.Button();
            this.buttonCadastrarReserva = new System.Windows.Forms.Button();
            this.cor_verde = new System.Windows.Forms.Label();
            this.disponivel = new System.Windows.Forms.Label();
            this.reservado = new System.Windows.Forms.Label();
            this.ocupado = new System.Windows.Forms.Label();
            this.cor_amarela = new System.Windows.Forms.Label();
            this.cor_vermelha = new System.Windows.Forms.Label();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quartoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.comboBoxBuscarTipo.SelectedIndexChanged += new System.EventHandler(this.comboBoxBuscarTipo_SelectedIndexChanged);
            // 
            // flowLayoutPanelReserva
            // 
            this.flowLayoutPanelReserva.AutoScroll = true;
            this.flowLayoutPanelReserva.Location = new System.Drawing.Point(280, 57);
            this.flowLayoutPanelReserva.Name = "flowLayoutPanelReserva";
            this.flowLayoutPanelReserva.Size = new System.Drawing.Size(772, 475);
            this.flowLayoutPanelReserva.TabIndex = 6;
            this.flowLayoutPanelReserva.BindingContextChanged += new System.EventHandler(this.flowLayoutPanelReserva_BindingContextChanged);
            this.flowLayoutPanelReserva.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanelReserva_ControlRemoved);
            // 
            // flowLayoutPanelQuartos
            // 
            this.flowLayoutPanelQuartos.AutoScroll = true;
            this.flowLayoutPanelQuartos.Location = new System.Drawing.Point(15, 231);
            this.flowLayoutPanelQuartos.Name = "flowLayoutPanelQuartos";
            this.flowLayoutPanelQuartos.Size = new System.Drawing.Size(216, 278);
            this.flowLayoutPanelQuartos.TabIndex = 7;
            // 
            // buttonBuscarTipo
            // 
            this.buttonBuscarTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(93)))), ((int)(((byte)(168)))));
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
            this.buttonCadastrarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(179)))), ((int)(((byte)(122)))));
            this.buttonCadastrarReserva.FlatAppearance.BorderSize = 0;
            this.buttonCadastrarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrarReserva.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrarReserva.ForeColor = System.Drawing.Color.White;
            this.buttonCadastrarReserva.Image = ((System.Drawing.Image)(resources.GetObject("buttonCadastrarReserva.Image")));
            this.buttonCadastrarReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCadastrarReserva.Location = new System.Drawing.Point(12, 12);
            this.buttonCadastrarReserva.Name = "buttonCadastrarReserva";
            this.buttonCadastrarReserva.Size = new System.Drawing.Size(130, 33);
            this.buttonCadastrarReserva.TabIndex = 1;
            this.buttonCadastrarReserva.Text = "RESERVA";
            this.buttonCadastrarReserva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCadastrarReserva.UseVisualStyleBackColor = false;
            this.buttonCadastrarReserva.Click += new System.EventHandler(this.buttonCadastrarReserva_Click);
            // 
            // cor_verde
            // 
            this.cor_verde.BackColor = System.Drawing.Color.Green;
            this.cor_verde.Location = new System.Drawing.Point(12, 522);
            this.cor_verde.Name = "cor_verde";
            this.cor_verde.Size = new System.Drawing.Size(10, 10);
            this.cor_verde.TabIndex = 8;
            // 
            // disponivel
            // 
            this.disponivel.AutoSize = true;
            this.disponivel.Location = new System.Drawing.Point(28, 521);
            this.disponivel.Name = "disponivel";
            this.disponivel.Size = new System.Drawing.Size(58, 13);
            this.disponivel.TabIndex = 8;
            this.disponivel.Text = "Disponível";
            // 
            // reservado
            // 
            this.reservado.AutoSize = true;
            this.reservado.Location = new System.Drawing.Point(110, 521);
            this.reservado.Name = "reservado";
            this.reservado.Size = new System.Drawing.Size(59, 13);
            this.reservado.TabIndex = 8;
            this.reservado.Text = "Reservado";
            // 
            // ocupado
            // 
            this.ocupado.AutoSize = true;
            this.ocupado.Location = new System.Drawing.Point(197, 521);
            this.ocupado.Name = "ocupado";
            this.ocupado.Size = new System.Drawing.Size(51, 13);
            this.ocupado.TabIndex = 8;
            this.ocupado.Text = "Ocupado";
            // 
            // cor_amarela
            // 
            this.cor_amarela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(161)))), ((int)(((byte)(0)))));
            this.cor_amarela.Location = new System.Drawing.Point(94, 522);
            this.cor_amarela.Name = "cor_amarela";
            this.cor_amarela.Size = new System.Drawing.Size(10, 10);
            this.cor_amarela.TabIndex = 8;
            // 
            // cor_vermelha
            // 
            this.cor_vermelha.BackColor = System.Drawing.Color.Red;
            this.cor_vermelha.Location = new System.Drawing.Point(181, 522);
            this.cor_vermelha.Name = "cor_vermelha";
            this.cor_vermelha.Size = new System.Drawing.Size(10, 10);
            this.cor_vermelha.TabIndex = 8;
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataSource = typeof(Models.Reserva);
            // 
            // quartoBindingSource
            // 
            this.quartoBindingSource.DataSource = typeof(Models.Quarto);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1064, 567);
            this.Controls.Add(this.ocupado);
            this.Controls.Add(this.reservado);
            this.Controls.Add(this.disponivel);
            this.Controls.Add(this.cor_vermelha);
            this.Controls.Add(this.cor_amarela);
            this.Controls.Add(this.cor_verde);
            this.Controls.Add(this.flowLayoutPanelQuartos);
            this.Controls.Add(this.flowLayoutPanelReserva);
            this.Controls.Add(this.comboBoxBuscarTipo);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.buttonBuscarTipo);
            this.Controls.Add(this.buttonCadastrarReserva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1080, 606);
            this.Name = "FormReserva";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOTELOGIX - Reservas";
            this.Load += new System.EventHandler(this.FormReserva_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormReserva_KeyDown);
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelReserva;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelQuartos;
        private System.Windows.Forms.BindingSource quartoBindingSource;
        private System.Windows.Forms.Label cor_verde;
        private System.Windows.Forms.Label disponivel;
        private System.Windows.Forms.Label reservado;
        private System.Windows.Forms.Label ocupado;
        private System.Windows.Forms.Label cor_amarela;
        private System.Windows.Forms.Label cor_vermelha;
        private System.Windows.Forms.Timer timer1;
    }
}