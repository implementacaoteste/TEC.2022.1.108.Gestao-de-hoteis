﻿namespace WindowsFormsAppGestaoHotel
{
    partial class CheckOutHoje
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOutHoje));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.qtd_CheckoutLabel = new System.Windows.Forms.Label();
            this.labelCheckOut = new System.Windows.Forms.Label();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // qtd_CheckoutLabel
            // 
            this.qtd_CheckoutLabel.AutoSize = true;
            this.qtd_CheckoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtd_CheckoutLabel.Location = new System.Drawing.Point(117, 7);
            this.qtd_CheckoutLabel.Name = "qtd_CheckoutLabel";
            this.qtd_CheckoutLabel.Size = new System.Drawing.Size(20, 24);
            this.qtd_CheckoutLabel.TabIndex = 3;
            this.qtd_CheckoutLabel.Text = "0";
            // 
            // labelCheckOut
            // 
            this.labelCheckOut.AutoSize = true;
            this.labelCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckOut.Location = new System.Drawing.Point(69, 33);
            this.labelCheckOut.Name = "labelCheckOut";
            this.labelCheckOut.Size = new System.Drawing.Size(121, 20);
            this.labelCheckOut.TabIndex = 4;
            this.labelCheckOut.Text = "Check Out Hoje";
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataSource = typeof(Models.Reserva);
            // 
            // CheckOutHoje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.qtd_CheckoutLabel);
            this.Controls.Add(this.labelCheckOut);
            this.Name = "CheckOutHoje";
            this.Size = new System.Drawing.Size(200, 60);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label qtd_CheckoutLabel;
        private System.Windows.Forms.Label labelCheckOut;
        private System.Windows.Forms.BindingSource reservaBindingSource;
    }
}
