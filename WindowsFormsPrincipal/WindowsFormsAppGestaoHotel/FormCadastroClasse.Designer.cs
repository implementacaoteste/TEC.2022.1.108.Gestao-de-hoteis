namespace WindowsFormsPrincipal1
{
    partial class FormCadastroClasse
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
            System.Windows.Forms.Label classLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroClasse));
            this.tituloLabel = new System.Windows.Forms.Label();
            this.classTextBox = new System.Windows.Forms.TextBox();
            this.classeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            classLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // classLabel
            // 
            classLabel.AutoSize = true;
            classLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            classLabel.Location = new System.Drawing.Point(50, 73);
            classLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            classLabel.Name = "classLabel";
            classLabel.Size = new System.Drawing.Size(114, 20);
            classLabel.TabIndex = 2;
            classLabel.Text = "Tipo de Quarto";
            // 
            // tituloLabel
            // 
            this.tituloLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tituloLabel.Location = new System.Drawing.Point(0, 0);
            this.tituloLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(444, 60);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "Cadastro de Tipo de Quarto";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classTextBox
            // 
            this.classTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classeBindingSource, "Class", true));
            this.classTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.classTextBox.Location = new System.Drawing.Point(54, 99);
            this.classTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.Size = new System.Drawing.Size(332, 26);
            this.classTextBox.TabIndex = 3;
            // 
            // classeBindingSource
            // 
            this.classeBindingSource.DataSource = typeof(Models.Classe);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.Color.Black;
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(239, 154);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(120, 33);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            this.buttonCancelar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonCancelar_KeyDown);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(183)))), ((int)(((byte)(219)))));
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalvar.Image")));
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(92, 154);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(110, 33);
            this.buttonSalvar.TabIndex = 4;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // FormCadastroClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(444, 207);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(classLabel);
            this.Controls.Add(this.classTextBox);
            this.Controls.Add(this.tituloLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroClasse";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Classe";
            this.Load += new System.EventHandler(this.FormCadastroClasse_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadastroClasse_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.BindingSource classeBindingSource;
        private System.Windows.Forms.TextBox classTextBox;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}