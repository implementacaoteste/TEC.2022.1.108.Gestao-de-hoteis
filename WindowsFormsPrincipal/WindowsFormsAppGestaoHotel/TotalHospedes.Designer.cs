namespace WindowsFormsAppGestaoHotel
{
    partial class TotalHospedes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TotalHospedes));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.qtdHospedesLabel = new System.Windows.Forms.Label();
            this.labelCheckIn = new System.Windows.Forms.Label();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // qtdHospedesLabel
            // 
            this.qtdHospedesLabel.AutoSize = true;
            this.qtdHospedesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtdHospedesLabel.Location = new System.Drawing.Point(115, 7);
            this.qtdHospedesLabel.Name = "qtdHospedesLabel";
            this.qtdHospedesLabel.Size = new System.Drawing.Size(20, 24);
            this.qtdHospedesLabel.TabIndex = 6;
            this.qtdHospedesLabel.Text = "0";
            // 
            // labelCheckIn
            // 
            this.labelCheckIn.AutoSize = true;
            this.labelCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckIn.Location = new System.Drawing.Point(65, 32);
            this.labelCheckIn.Name = "labelCheckIn";
            this.labelCheckIn.Size = new System.Drawing.Size(121, 20);
            this.labelCheckIn.TabIndex = 7;
            this.labelCheckIn.Text = "Total Hóspedes";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Models.Hospede);
            // 
            // TotalHospedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.qtdHospedesLabel);
            this.Controls.Add(this.labelCheckIn);
            this.Name = "TotalHospedes";
            this.Size = new System.Drawing.Size(200, 60);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label qtdHospedesLabel;
        private System.Windows.Forms.Label labelCheckIn;
        private System.Windows.Forms.BindingSource clienteBindingSource;
    }
}
