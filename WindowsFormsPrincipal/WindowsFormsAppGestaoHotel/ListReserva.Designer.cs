namespace WindowsFormsAppGestaoHotel
{
    partial class ListReserva
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListReserva));
            this.labelNumeroQuarto = new System.Windows.Forms.Label();
            this.labelNomeHospede = new System.Windows.Forms.Label();
            this.labelDataCheckIn = new System.Windows.Forms.Label();
            this.labelDataCheckOut = new System.Windows.Forms.Label();
            this.labelTipoQuarto = new System.Windows.Forms.Label();
            this.pictureBoxCheckOut = new System.Windows.Forms.PictureBox();
            this.pictureBoxCheckIn = new System.Windows.Forms.PictureBox();
            this.pictureBoxAlterar = new System.Windows.Forms.PictureBox();
            this.pictureBoxCancelar = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlterar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNumeroQuarto
            // 
            this.labelNumeroQuarto.AutoSize = true;
            this.labelNumeroQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelNumeroQuarto.Location = new System.Drawing.Point(74, 42);
            this.labelNumeroQuarto.Name = "labelNumeroQuarto";
            this.labelNumeroQuarto.Size = new System.Drawing.Size(27, 20);
            this.labelNumeroQuarto.TabIndex = 1;
            this.labelNumeroQuarto.Text = "01";
            // 
            // labelNomeHospede
            // 
            this.labelNomeHospede.AutoSize = true;
            this.labelNomeHospede.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNomeHospede.Location = new System.Drawing.Point(75, 69);
            this.labelNomeHospede.Name = "labelNomeHospede";
            this.labelNomeHospede.Size = new System.Drawing.Size(115, 17);
            this.labelNomeHospede.TabIndex = 1;
            this.labelNomeHospede.Text = "Hóspede - Nome";
            // 
            // labelDataCheckIn
            // 
            this.labelDataCheckIn.AutoSize = true;
            this.labelDataCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDataCheckIn.Location = new System.Drawing.Point(42, 123);
            this.labelDataCheckIn.Name = "labelDataCheckIn";
            this.labelDataCheckIn.Size = new System.Drawing.Size(80, 17);
            this.labelDataCheckIn.TabIndex = 8;
            this.labelDataCheckIn.Text = "01/05/2023";
            // 
            // labelDataCheckOut
            // 
            this.labelDataCheckOut.AutoSize = true;
            this.labelDataCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDataCheckOut.Location = new System.Drawing.Point(162, 123);
            this.labelDataCheckOut.Name = "labelDataCheckOut";
            this.labelDataCheckOut.Size = new System.Drawing.Size(80, 17);
            this.labelDataCheckOut.TabIndex = 8;
            this.labelDataCheckOut.Text = "31/05/2023";
            // 
            // labelTipoQuarto
            // 
            this.labelTipoQuarto.AutoSize = true;
            this.labelTipoQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTipoQuarto.Location = new System.Drawing.Point(107, 42);
            this.labelTipoQuarto.Name = "labelTipoQuarto";
            this.labelTipoQuarto.Size = new System.Drawing.Size(85, 20);
            this.labelTipoQuarto.TabIndex = 1;
            this.labelTipoQuarto.Text = "(Standard)";
            // 
            // pictureBoxCheckOut
            // 
            this.pictureBoxCheckOut.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCheckOut.ErrorImage")));
            this.pictureBoxCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCheckOut.Image")));
            this.pictureBoxCheckOut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxCheckOut.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCheckOut.InitialImage")));
            this.pictureBoxCheckOut.Location = new System.Drawing.Point(127, 116);
            this.pictureBoxCheckOut.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCheckOut.MaximumSize = new System.Drawing.Size(30, 30);
            this.pictureBoxCheckOut.MinimumSize = new System.Drawing.Size(30, 30);
            this.pictureBoxCheckOut.Name = "pictureBoxCheckOut";
            this.pictureBoxCheckOut.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxCheckOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCheckOut.TabIndex = 7;
            this.pictureBoxCheckOut.TabStop = false;
            this.pictureBoxCheckOut.Click += new System.EventHandler(this.pictureBoxCheckOut_Click);
            // 
            // pictureBoxCheckIn
            // 
            this.pictureBoxCheckIn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCheckIn.ErrorImage")));
            this.pictureBoxCheckIn.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCheckIn.Image")));
            this.pictureBoxCheckIn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxCheckIn.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCheckIn.InitialImage")));
            this.pictureBoxCheckIn.Location = new System.Drawing.Point(7, 116);
            this.pictureBoxCheckIn.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCheckIn.MaximumSize = new System.Drawing.Size(30, 30);
            this.pictureBoxCheckIn.MinimumSize = new System.Drawing.Size(30, 30);
            this.pictureBoxCheckIn.Name = "pictureBoxCheckIn";
            this.pictureBoxCheckIn.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxCheckIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCheckIn.TabIndex = 7;
            this.pictureBoxCheckIn.TabStop = false;
            this.pictureBoxCheckIn.Click += new System.EventHandler(this.pictureBoxCheckIn_Click);
            // 
            // pictureBoxAlterar
            // 
            this.pictureBoxAlterar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxAlterar.ErrorImage")));
            this.pictureBoxAlterar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAlterar.Image")));
            this.pictureBoxAlterar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxAlterar.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxAlterar.InitialImage")));
            this.pictureBoxAlterar.Location = new System.Drawing.Point(200, 2);
            this.pictureBoxAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxAlterar.MaximumSize = new System.Drawing.Size(22, 24);
            this.pictureBoxAlterar.MinimumSize = new System.Drawing.Size(22, 24);
            this.pictureBoxAlterar.Name = "pictureBoxAlterar";
            this.pictureBoxAlterar.Size = new System.Drawing.Size(22, 24);
            this.pictureBoxAlterar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlterar.TabIndex = 7;
            this.pictureBoxAlterar.TabStop = false;
            this.pictureBoxAlterar.Click += new System.EventHandler(this.pictureBoxAlterar_Click);
            // 
            // pictureBoxCancelar
            // 
            this.pictureBoxCancelar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCancelar.ErrorImage")));
            this.pictureBoxCancelar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCancelar.Image")));
            this.pictureBoxCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxCancelar.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCancelar.InitialImage")));
            this.pictureBoxCancelar.Location = new System.Drawing.Point(226, 2);
            this.pictureBoxCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCancelar.MaximumSize = new System.Drawing.Size(22, 24);
            this.pictureBoxCancelar.MinimumSize = new System.Drawing.Size(22, 24);
            this.pictureBoxCancelar.Name = "pictureBoxCancelar";
            this.pictureBoxCancelar.Size = new System.Drawing.Size(22, 24);
            this.pictureBoxCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCancelar.TabIndex = 7;
            this.pictureBoxCancelar.TabStop = false;
            this.pictureBoxCancelar.Click += new System.EventHandler(this.pictureBoxCancelar_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(7, 9);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(61, 102);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataSource = typeof(Models.Reserva);
            // 
            // ListReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelDataCheckOut);
            this.Controls.Add(this.labelDataCheckIn);
            this.Controls.Add(this.labelTipoQuarto);
            this.Controls.Add(this.labelNumeroQuarto);
            this.Controls.Add(this.labelNomeHospede);
            this.Controls.Add(this.pictureBoxCheckOut);
            this.Controls.Add(this.pictureBoxCheckIn);
            this.Controls.Add(this.pictureBoxAlterar);
            this.Controls.Add(this.pictureBoxCancelar);
            this.Controls.Add(this.pictureBox);
            this.Name = "ListReserva";
            this.Size = new System.Drawing.Size(250, 150);
            this.Load += new System.EventHandler(this.ListReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlterar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelNumeroQuarto;
        private System.Windows.Forms.PictureBox pictureBoxCancelar;
        private System.Windows.Forms.Label labelNomeHospede;
        private System.Windows.Forms.Label labelDataCheckIn;
        private System.Windows.Forms.Label labelDataCheckOut;
        private System.Windows.Forms.PictureBox pictureBoxCheckIn;
        private System.Windows.Forms.PictureBox pictureBoxCheckOut;
        private System.Windows.Forms.PictureBox pictureBoxAlterar;
        private System.Windows.Forms.Label labelTipoQuarto;
        private System.Windows.Forms.BindingSource reservaBindingSource;
    }
}
