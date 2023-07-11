namespace WindowsFormsAppGestaoHotel
{
    partial class FormReservaCheckOut
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
            System.Windows.Forms.Label labelNomeHospedes;
            System.Windows.Forms.Label obs_CheckinLabel;
            System.Windows.Forms.Label pagamentoLabel;
            System.Windows.Forms.Label numero_QuartoLabel;
            System.Windows.Forms.Label valor_RestanteLabel;
            System.Windows.Forms.Label qtd_HospedesLabel;
            System.Windows.Forms.Label valor_TotalLabel;
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.obs_CheckoutTextBox = new System.Windows.Forms.TextBox();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pagamentoComboBox = new System.Windows.Forms.ComboBox();
            this.buttonCheckin = new System.Windows.Forms.Button();
            this.valor_RestanteTextBox = new System.Windows.Forms.TextBox();
            this.numero_QuartoTextBox = new System.Windows.Forms.TextBox();
            this.qtd_HospedesTextBox = new System.Windows.Forms.TextBox();
            this.valor_TotalTextBox = new System.Windows.Forms.TextBox();
            labelNomeHospedes = new System.Windows.Forms.Label();
            obs_CheckinLabel = new System.Windows.Forms.Label();
            pagamentoLabel = new System.Windows.Forms.Label();
            numero_QuartoLabel = new System.Windows.Forms.Label();
            valor_RestanteLabel = new System.Windows.Forms.Label();
            qtd_HospedesLabel = new System.Windows.Forms.Label();
            valor_TotalLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNomeHospedes
            // 
            labelNomeHospedes.AutoSize = true;
            labelNomeHospedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            labelNomeHospedes.Location = new System.Drawing.Point(6, 28);
            labelNomeHospedes.Name = "labelNomeHospedes";
            labelNomeHospedes.Size = new System.Drawing.Size(73, 20);
            labelNomeHospedes.TabIndex = 2;
            labelNomeHospedes.Text = "1 - Nome";
            // 
            // obs_CheckinLabel
            // 
            obs_CheckinLabel.AutoSize = true;
            obs_CheckinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            obs_CheckinLabel.Location = new System.Drawing.Point(4, 84);
            obs_CheckinLabel.Name = "obs_CheckinLabel";
            obs_CheckinLabel.Size = new System.Drawing.Size(94, 20);
            obs_CheckinLabel.TabIndex = 12;
            obs_CheckinLabel.Text = "Observação";
            // 
            // pagamentoLabel
            // 
            pagamentoLabel.AutoSize = true;
            pagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pagamentoLabel.Location = new System.Drawing.Point(483, 20);
            pagamentoLabel.Name = "pagamentoLabel";
            pagamentoLabel.Size = new System.Drawing.Size(103, 20);
            pagamentoLabel.TabIndex = 10;
            pagamentoLabel.Text = "Forma PGTO";
            // 
            // numero_QuartoLabel
            // 
            numero_QuartoLabel.AutoSize = true;
            numero_QuartoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            numero_QuartoLabel.Location = new System.Drawing.Point(4, 20);
            numero_QuartoLabel.Name = "numero_QuartoLabel";
            numero_QuartoLabel.Size = new System.Drawing.Size(58, 20);
            numero_QuartoLabel.TabIndex = 1;
            numero_QuartoLabel.Text = "Quarto";
            // 
            // valor_RestanteLabel
            // 
            valor_RestanteLabel.AutoSize = true;
            valor_RestanteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valor_RestanteLabel.Location = new System.Drawing.Point(371, 20);
            valor_RestanteLabel.Name = "valor_RestanteLabel";
            valor_RestanteLabel.Size = new System.Drawing.Size(75, 20);
            valor_RestanteLabel.TabIndex = 6;
            valor_RestanteLabel.Text = "Restante";
            // 
            // qtd_HospedesLabel
            // 
            qtd_HospedesLabel.AutoSize = true;
            qtd_HospedesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qtd_HospedesLabel.Location = new System.Drawing.Point(125, 20);
            qtd_HospedesLabel.Name = "qtd_HospedesLabel";
            qtd_HospedesLabel.Size = new System.Drawing.Size(82, 20);
            qtd_HospedesLabel.TabIndex = 2;
            qtd_HospedesLabel.Text = "Hóspedes";
            // 
            // valor_TotalLabel
            // 
            valor_TotalLabel.AutoSize = true;
            valor_TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valor_TotalLabel.Location = new System.Drawing.Point(253, 20);
            valor_TotalLabel.Name = "valor_TotalLabel";
            valor_TotalLabel.Size = new System.Drawing.Size(85, 20);
            valor_TotalLabel.TabIndex = 4;
            valor_TotalLabel.Text = "Valor Total";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(labelNomeHospedes);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(623, 142);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóspedes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.obs_CheckoutTextBox);
            this.groupBox1.Controls.Add(this.pagamentoComboBox);
            this.groupBox1.Controls.Add(this.buttonCheckin);
            this.groupBox1.Controls.Add(obs_CheckinLabel);
            this.groupBox1.Controls.Add(pagamentoLabel);
            this.groupBox1.Controls.Add(numero_QuartoLabel);
            this.groupBox1.Controls.Add(valor_RestanteLabel);
            this.groupBox1.Controls.Add(this.valor_RestanteTextBox);
            this.groupBox1.Controls.Add(this.numero_QuartoTextBox);
            this.groupBox1.Controls.Add(this.qtd_HospedesTextBox);
            this.groupBox1.Controls.Add(qtd_HospedesLabel);
            this.groupBox1.Controls.Add(valor_TotalLabel);
            this.groupBox1.Controls.Add(this.valor_TotalTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 186);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reserva";
            // 
            // obs_CheckoutTextBox
            // 
            this.obs_CheckoutTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.obs_CheckoutTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Obs_Checkout", true));
            this.obs_CheckoutTextBox.Location = new System.Drawing.Point(8, 107);
            this.obs_CheckoutTextBox.Multiline = true;
            this.obs_CheckoutTextBox.Name = "obs_CheckoutTextBox";
            this.obs_CheckoutTextBox.Size = new System.Drawing.Size(317, 60);
            this.obs_CheckoutTextBox.TabIndex = 16;
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataSource = typeof(Models.Reserva);
            // 
            // pagamentoComboBox
            // 
            this.pagamentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Pagamento", true));
            this.pagamentoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.pagamentoComboBox.FormattingEnabled = true;
            this.pagamentoComboBox.Location = new System.Drawing.Point(487, 43);
            this.pagamentoComboBox.Name = "pagamentoComboBox";
            this.pagamentoComboBox.Size = new System.Drawing.Size(121, 26);
            this.pagamentoComboBox.TabIndex = 15;
            // 
            // buttonCheckin
            // 
            this.buttonCheckin.AutoSize = true;
            this.buttonCheckin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(177)))), ((int)(((byte)(229)))));
            this.buttonCheckin.FlatAppearance.BorderSize = 0;
            this.buttonCheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckin.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckin.ForeColor = System.Drawing.Color.White;
            this.buttonCheckin.Location = new System.Drawing.Point(487, 119);
            this.buttonCheckin.Name = "buttonCheckin";
            this.buttonCheckin.Size = new System.Drawing.Size(121, 32);
            this.buttonCheckin.TabIndex = 14;
            this.buttonCheckin.Text = "CHECK OUT";
            this.buttonCheckin.UseVisualStyleBackColor = false;
            this.buttonCheckin.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // valor_RestanteTextBox
            // 
            this.valor_RestanteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valor_RestanteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Valor_Restante", true));
            this.valor_RestanteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.valor_RestanteTextBox.ForeColor = System.Drawing.Color.Red;
            this.valor_RestanteTextBox.Location = new System.Drawing.Point(375, 43);
            this.valor_RestanteTextBox.Name = "valor_RestanteTextBox";
            this.valor_RestanteTextBox.ReadOnly = true;
            this.valor_RestanteTextBox.Size = new System.Drawing.Size(100, 26);
            this.valor_RestanteTextBox.TabIndex = 7;
            // 
            // numero_QuartoTextBox
            // 
            this.numero_QuartoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numero_QuartoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Numero_Quarto", true));
            this.numero_QuartoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numero_QuartoTextBox.Location = new System.Drawing.Point(8, 43);
            this.numero_QuartoTextBox.Name = "numero_QuartoTextBox";
            this.numero_QuartoTextBox.ReadOnly = true;
            this.numero_QuartoTextBox.Size = new System.Drawing.Size(100, 26);
            this.numero_QuartoTextBox.TabIndex = 2;
            // 
            // qtd_HospedesTextBox
            // 
            this.qtd_HospedesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qtd_HospedesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Qtd_Hospedes", true));
            this.qtd_HospedesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.qtd_HospedesTextBox.Location = new System.Drawing.Point(129, 43);
            this.qtd_HospedesTextBox.Name = "qtd_HospedesTextBox";
            this.qtd_HospedesTextBox.ReadOnly = true;
            this.qtd_HospedesTextBox.Size = new System.Drawing.Size(100, 26);
            this.qtd_HospedesTextBox.TabIndex = 3;
            // 
            // valor_TotalTextBox
            // 
            this.valor_TotalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valor_TotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Valor_Total", true));
            this.valor_TotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.valor_TotalTextBox.Location = new System.Drawing.Point(257, 43);
            this.valor_TotalTextBox.Name = "valor_TotalTextBox";
            this.valor_TotalTextBox.ReadOnly = true;
            this.valor_TotalTextBox.Size = new System.Drawing.Size(100, 26);
            this.valor_TotalTextBox.TabIndex = 5;
            // 
            // FormReservaCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(644, 353);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormReservaCheckOut";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormReservaCheckOut_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCheckin;
        private System.Windows.Forms.TextBox valor_RestanteTextBox;
        private System.Windows.Forms.TextBox numero_QuartoTextBox;
        private System.Windows.Forms.TextBox qtd_HospedesTextBox;
        private System.Windows.Forms.TextBox valor_TotalTextBox;
        private System.Windows.Forms.ComboBox pagamentoComboBox;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private System.Windows.Forms.TextBox obs_CheckoutTextBox;
    }
}