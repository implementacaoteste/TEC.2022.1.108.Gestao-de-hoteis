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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListReserva));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelNumeroQuarto = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.labelNomeHospede = new System.Windows.Forms.Label();
            this.labelDataCheckIn = new System.Windows.Forms.Label();
            this.labelDataCheckOut = new System.Windows.Forms.Label();
            this.pictureBoxCheckIn = new System.Windows.Forms.PictureBox();
            this.pictureBoxCheckOut = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTipoQuarto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // pictureBoxClose
            // 
            this.pictureBoxClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.ErrorImage")));
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.InitialImage")));
            this.pictureBoxClose.Location = new System.Drawing.Point(226, 2);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxClose.MaximumSize = new System.Drawing.Size(22, 24);
            this.pictureBoxClose.MinimumSize = new System.Drawing.Size(22, 24);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(22, 24);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 7;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
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
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(200, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(22, 24);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(22, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
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
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.pictureBox);
            this.Name = "ListReserva";
            this.Size = new System.Drawing.Size(250, 150);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelNumeroQuarto;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label labelNomeHospede;
        private System.Windows.Forms.Label labelDataCheckIn;
        private System.Windows.Forms.Label labelDataCheckOut;
        private System.Windows.Forms.PictureBox pictureBoxCheckIn;
        private System.Windows.Forms.PictureBox pictureBoxCheckOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTipoQuarto;
    }
}
