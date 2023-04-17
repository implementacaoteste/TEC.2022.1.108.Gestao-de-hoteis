namespace WindowsFormsPrincipal1
{
    partial class FormCadastroCliente
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
            System.Windows.Forms.Label nomeLabel1;
            System.Windows.Forms.Label celularLabel1;
            System.Windows.Forms.Label cPFLabel1;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label data_nascimentoLabel1;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label generoLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroCliente));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.nomeTextBox1 = new System.Windows.Forms.TextBox();
            this.celularTextBox1 = new System.Windows.Forms.TextBox();
            this.cPFTextBox1 = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_nascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            nomeLabel1 = new System.Windows.Forms.Label();
            celularLabel1 = new System.Windows.Forms.Label();
            cPFLabel1 = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            data_nascimentoLabel1 = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            generoLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel1
            // 
            nomeLabel1.AutoSize = true;
            nomeLabel1.Location = new System.Drawing.Point(22, 96);
            nomeLabel1.Name = "nomeLabel1";
            nomeLabel1.Size = new System.Drawing.Size(44, 16);
            nomeLabel1.TabIndex = 42;
            nomeLabel1.Text = "Nome";
            // 
            // celularLabel1
            // 
            celularLabel1.AutoSize = true;
            celularLabel1.Location = new System.Drawing.Point(317, 96);
            celularLabel1.Name = "celularLabel1";
            celularLabel1.Size = new System.Drawing.Size(49, 16);
            celularLabel1.TabIndex = 43;
            celularLabel1.Text = "Celular";
            // 
            // cPFLabel1
            // 
            cPFLabel1.AutoSize = true;
            cPFLabel1.Location = new System.Drawing.Point(526, 96);
            cPFLabel1.Name = "cPFLabel1";
            cPFLabel1.Size = new System.Drawing.Size(33, 16);
            cPFLabel1.TabIndex = 44;
            cPFLabel1.Text = "CPF";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(22, 166);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(66, 16);
            enderecoLabel.TabIndex = 45;
            enderecoLabel.Text = "Endereço";
            // 
            // data_nascimentoLabel1
            // 
            data_nascimentoLabel1.AutoSize = true;
            data_nascimentoLabel1.Location = new System.Drawing.Point(317, 166);
            data_nascimentoLabel1.Name = "data_nascimentoLabel1";
            data_nascimentoLabel1.Size = new System.Drawing.Size(127, 16);
            data_nascimentoLabel1.TabIndex = 46;
            data_nascimentoLabel1.Text = "Data de nascimento";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(497, 166);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(45, 16);
            emailLabel.TabIndex = 47;
            emailLabel.Text = "E-mail";
            // 
            // generoLabel1
            // 
            generoLabel1.AutoSize = true;
            generoLabel1.Location = new System.Drawing.Point(22, 235);
            generoLabel1.Name = "generoLabel1";
            generoLabel1.Size = new System.Drawing.Size(52, 16);
            generoLabel1.TabIndex = 48;
            generoLabel1.Text = "Genero";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 253);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 41;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(595, 360);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(79, 29);
            this.buttonSalvar.TabIndex = 42;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(676, 360);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(79, 29);
            this.buttonCancelar.TabIndex = 42;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            this.buttonCancelar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonCancelar_KeyDown);
            // 
            // nomeTextBox1
            // 
            this.nomeTextBox1.Location = new System.Drawing.Point(25, 115);
            this.nomeTextBox1.Name = "nomeTextBox1";
            this.nomeTextBox1.Size = new System.Drawing.Size(286, 22);
            this.nomeTextBox1.TabIndex = 43;
            // 
            // celularTextBox1
            // 
            this.celularTextBox1.Location = new System.Drawing.Point(317, 115);
            this.celularTextBox1.Name = "celularTextBox1";
            this.celularTextBox1.Size = new System.Drawing.Size(206, 22);
            this.celularTextBox1.TabIndex = 44;
            // 
            // cPFTextBox1
            // 
            this.cPFTextBox1.Location = new System.Drawing.Point(529, 115);
            this.cPFTextBox1.Name = "cPFTextBox1";
            this.cPFTextBox1.Size = new System.Drawing.Size(226, 22);
            this.cPFTextBox1.TabIndex = 45;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.Location = new System.Drawing.Point(25, 185);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(286, 22);
            this.enderecoTextBox.TabIndex = 46;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(500, 185);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(255, 22);
            this.emailTextBox.TabIndex = 48;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Models.Cliente);
            // 
            // data_nascimentoDateTimePicker
            // 
            this.data_nascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clienteBindingSource, "Data_nascimento", true));
            this.data_nascimentoDateTimePicker.Location = new System.Drawing.Point(320, 183);
            this.data_nascimentoDateTimePicker.Name = "data_nascimentoDateTimePicker";
            this.data_nascimentoDateTimePicker.Size = new System.Drawing.Size(174, 22);
            this.data_nascimentoDateTimePicker.TabIndex = 49;
            this.data_nascimentoDateTimePicker.ValueChanged += new System.EventHandler(this.data_nascimentoDateTimePicker_ValueChanged);
            // 
            // FormCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 414);
            this.Controls.Add(this.data_nascimentoDateTimePicker);
            this.Controls.Add(generoLabel1);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(data_nascimentoLabel1);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(cPFLabel1);
            this.Controls.Add(this.cPFTextBox1);
            this.Controls.Add(celularLabel1);
            this.Controls.Add(this.celularTextBox1);
            this.Controls.Add(nomeLabel1);
            this.Controls.Add(this.nomeTextBox1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de cliente";
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox nomeTextBox1;
        private System.Windows.Forms.TextBox celularTextBox1;
        private System.Windows.Forms.TextBox cPFTextBox1;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DateTimePicker data_nascimentoDateTimePicker;
    }
}