namespace WindowsFormsPrincipal1
{
    partial class FormCadastroPermissao
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
            System.Windows.Forms.Label nomePermissaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroPermissao));
            this.tituloLabel = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.nomePermissaoTextBox = new System.Windows.Forms.TextBox();
            this.permissaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nomePermissaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomePermissaoLabel
            // 
            nomePermissaoLabel.AutoSize = true;
            nomePermissaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            nomePermissaoLabel.Location = new System.Drawing.Point(11, 61);
            nomePermissaoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nomePermissaoLabel.Name = "nomePermissaoLabel";
            nomePermissaoLabel.Size = new System.Drawing.Size(159, 20);
            nomePermissaoLabel.TabIndex = 6;
            nomePermissaoLabel.Text = "Descrição do Acesso";
            // 
            // tituloLabel
            // 
            this.tituloLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tituloLabel.Location = new System.Drawing.Point(0, 0);
            this.tituloLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(329, 53);
            this.tituloLabel.TabIndex = 5;
            this.tituloLabel.Text = "Cadastro de Acesso";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(175, 156);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(120, 33);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click_1);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(183)))), ((int)(((byte)(219)))));
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalvar.Image")));
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(34, 156);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(110, 33);
            this.buttonSalvar.TabIndex = 8;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click_1);
            // 
            // nomePermissaoTextBox
            // 
            this.nomePermissaoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomePermissaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nomePermissaoTextBox.Location = new System.Drawing.Point(11, 85);
            this.nomePermissaoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nomePermissaoTextBox.Multiline = true;
            this.nomePermissaoTextBox.Name = "nomePermissaoTextBox";
            this.nomePermissaoTextBox.Size = new System.Drawing.Size(308, 51);
            this.nomePermissaoTextBox.TabIndex = 7;
            // 
            // permissaoBindingSource
            // 
            this.permissaoBindingSource.DataSource = typeof(Models.Permissao);
            // 
            // FormCadastroPermissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 198);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(nomePermissaoLabel);
            this.Controls.Add(this.nomePermissaoTextBox);
            this.Controls.Add(this.tituloLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(345, 237);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(345, 237);
            this.Name = "FormCadastroPermissao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOTELOGIX - Cadastro de Acesso";
            this.Load += new System.EventHandler(this.FormCadastroPermissao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.TextBox nomePermissaoTextBox;
        private System.Windows.Forms.BindingSource permissaoBindingSource;
    }
}