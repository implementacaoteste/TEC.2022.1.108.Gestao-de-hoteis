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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label data_nascimentoLabel;
            System.Windows.Forms.Label generoLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroCliente));
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sexoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tituloLabel = new System.Windows.Forms.Label();
            this.generoComboBox = new System.Windows.Forms.ComboBox();
            this.buttonCancelarCadastroCliente = new System.Windows.Forms.Button();
            this.buttonSalvarCadastroCliente = new System.Windows.Forms.Button();
            this.cPFMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.celularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.data_nascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.emailTextBox1 = new System.Windows.Forms.TextBox();
            this.enderecoTextBox1 = new System.Windows.Forms.TextBox();
            this.nomeTextBox1 = new System.Windows.Forms.TextBox();
            nomeLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            data_nascimentoLabel = new System.Windows.Forms.Label();
            generoLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            nomeLabel.Location = new System.Drawing.Point(25, 123);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(64, 25);
            nomeLabel.TabIndex = 52;
            nomeLabel.Text = "Nome";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            celularLabel.Location = new System.Drawing.Point(557, 123);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(74, 25);
            celularLabel.TabIndex = 54;
            celularLabel.Text = "Celular";
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            cpfLabel.Location = new System.Drawing.Point(381, 123);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(52, 25);
            cpfLabel.TabIndex = 55;
            cpfLabel.Text = "CPF";
            // 
            // data_nascimentoLabel
            // 
            data_nascimentoLabel.AutoSize = true;
            data_nascimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            data_nascimentoLabel.Location = new System.Drawing.Point(735, 123);
            data_nascimentoLabel.Name = "data_nascimentoLabel";
            data_nascimentoLabel.Size = new System.Drawing.Size(188, 25);
            data_nascimentoLabel.TabIndex = 58;
            data_nascimentoLabel.Text = "Data de Nascimento";
            // 
            // generoLabel
            // 
            generoLabel.AutoSize = true;
            generoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            generoLabel.Location = new System.Drawing.Point(25, 217);
            generoLabel.Name = "generoLabel";
            generoLabel.Size = new System.Drawing.Size(77, 25);
            generoLabel.TabIndex = 60;
            generoLabel.Text = "Gênero";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            enderecoLabel.Location = new System.Drawing.Point(182, 217);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(96, 25);
            enderecoLabel.TabIndex = 62;
            enderecoLabel.Text = "Endereço";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            emailLabel.Location = new System.Drawing.Point(577, 217);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(67, 25);
            emailLabel.TabIndex = 64;
            emailLabel.Text = "E-mail";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Models.Cliente);
            // 
            // sexoBindingSource
            // 
            this.sexoBindingSource.DataSource = typeof(Models.Sexo);
            // 
            // tituloLabel
            // 
            this.tituloLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.tituloLabel.Location = new System.Drawing.Point(0, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(982, 65);
            this.tituloLabel.TabIndex = 50;
            this.tituloLabel.Text = "Cadastro de Cliente";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // generoComboBox
            // 
            this.generoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "IdSexo", true));
            this.generoComboBox.DataSource = this.sexoBindingSource;
            this.generoComboBox.DisplayMember = "Genero";
            this.generoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.generoComboBox.FormattingEnabled = true;
            this.generoComboBox.Location = new System.Drawing.Point(30, 242);
            this.generoComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.generoComboBox.MinimumSize = new System.Drawing.Size(130, 0);
            this.generoComboBox.Name = "generoComboBox";
            this.generoComboBox.Size = new System.Drawing.Size(145, 30);
            this.generoComboBox.TabIndex = 4;
            this.generoComboBox.ValueMember = "Id";
            // 
            // buttonCancelarCadastroCliente
            // 
            this.buttonCancelarCadastroCliente.AutoSize = true;
            this.buttonCancelarCadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelarCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonCancelarCadastroCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelarCadastroCliente.Image")));
            this.buttonCancelarCadastroCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelarCadastroCliente.Location = new System.Drawing.Point(802, 314);
            this.buttonCancelarCadastroCliente.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCancelarCadastroCliente.Name = "buttonCancelarCadastroCliente";
            this.buttonCancelarCadastroCliente.Size = new System.Drawing.Size(145, 40);
            this.buttonCancelarCadastroCliente.TabIndex = 8;
            this.buttonCancelarCadastroCliente.Text = "Cancelar";
            this.buttonCancelarCadastroCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelarCadastroCliente.UseVisualStyleBackColor = true;
            this.buttonCancelarCadastroCliente.Click += new System.EventHandler(this.buttonCancelarCadastroCliente_Click);
            // 
            // buttonSalvarCadastroCliente
            // 
            this.buttonSalvarCadastroCliente.AutoSize = true;
            this.buttonSalvarCadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvarCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSalvarCadastroCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalvarCadastroCliente.Image")));
            this.buttonSalvarCadastroCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvarCadastroCliente.Location = new System.Drawing.Point(651, 314);
            this.buttonSalvarCadastroCliente.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSalvarCadastroCliente.Name = "buttonSalvarCadastroCliente";
            this.buttonSalvarCadastroCliente.Size = new System.Drawing.Size(135, 40);
            this.buttonSalvarCadastroCliente.TabIndex = 7;
            this.buttonSalvarCadastroCliente.Text = "Salvar";
            this.buttonSalvarCadastroCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalvarCadastroCliente.UseVisualStyleBackColor = true;
            this.buttonSalvarCadastroCliente.Click += new System.EventHandler(this.buttonSalvarCadastroCliente_Click);
            // 
            // cPFMaskedTextBox
            // 
            this.cPFMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cPFMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "CPF", true));
            this.cPFMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cPFMaskedTextBox.Location = new System.Drawing.Point(386, 151);
            this.cPFMaskedTextBox.Mask = "000,000,000-00";
            this.cPFMaskedTextBox.Name = "cPFMaskedTextBox";
            this.cPFMaskedTextBox.Size = new System.Drawing.Size(170, 30);
            this.cPFMaskedTextBox.TabIndex = 1;
            // 
            // celularMaskedTextBox
            // 
            this.celularMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.celularMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Celular", true));
            this.celularMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.celularMaskedTextBox.Location = new System.Drawing.Point(562, 151);
            this.celularMaskedTextBox.Mask = "(99) 00000-0000";
            this.celularMaskedTextBox.Name = "celularMaskedTextBox";
            this.celularMaskedTextBox.Size = new System.Drawing.Size(170, 30);
            this.celularMaskedTextBox.TabIndex = 2;
            // 
            // data_nascimentoDateTimePicker
            // 
            this.data_nascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clienteBindingSource, "Data_nascimento", true));
            this.data_nascimentoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.data_nascimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_nascimentoDateTimePicker.Location = new System.Drawing.Point(740, 151);
            this.data_nascimentoDateTimePicker.Name = "data_nascimentoDateTimePicker";
            this.data_nascimentoDateTimePicker.Size = new System.Drawing.Size(207, 30);
            this.data_nascimentoDateTimePicker.TabIndex = 3;
            // 
            // emailTextBox1
            // 
            this.emailTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Email", true));
            this.emailTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emailTextBox1.Location = new System.Drawing.Point(582, 242);
            this.emailTextBox1.Name = "emailTextBox1";
            this.emailTextBox1.Size = new System.Drawing.Size(365, 30);
            this.emailTextBox1.TabIndex = 6;
            // 
            // enderecoTextBox1
            // 
            this.enderecoTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enderecoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Endereco", true));
            this.enderecoTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.enderecoTextBox1.Location = new System.Drawing.Point(187, 242);
            this.enderecoTextBox1.Name = "enderecoTextBox1";
            this.enderecoTextBox1.Size = new System.Drawing.Size(385, 30);
            this.enderecoTextBox1.TabIndex = 5;
            // 
            // nomeTextBox1
            // 
            this.nomeTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nome", true));
            this.nomeTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nomeTextBox1.Location = new System.Drawing.Point(30, 151);
            this.nomeTextBox1.Name = "nomeTextBox1";
            this.nomeTextBox1.Size = new System.Drawing.Size(350, 30);
            this.nomeTextBox1.TabIndex = 0;
            // 
            // FormCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 383);
            this.Controls.Add(this.nomeTextBox1);
            this.Controls.Add(this.enderecoTextBox1);
            this.Controls.Add(this.emailTextBox1);
            this.Controls.Add(this.data_nascimentoDateTimePicker);
            this.Controls.Add(this.celularMaskedTextBox);
            this.Controls.Add(this.cPFMaskedTextBox);
            this.Controls.Add(this.buttonCancelarCadastroCliente);
            this.Controls.Add(this.buttonSalvarCadastroCliente);
            this.Controls.Add(emailLabel);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(generoLabel);
            this.Controls.Add(this.generoComboBox);
            this.Controls.Add(data_nascimentoLabel);
            this.Controls.Add(cpfLabel);
            this.Controls.Add(celularLabel);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.tituloLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOTELOGIX - Cadastro de Cliente";
            this.Load += new System.EventHandler(this.FormCadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.BindingSource sexoBindingSource;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.ComboBox generoComboBox;
        private System.Windows.Forms.Button buttonCancelarCadastroCliente;
        private System.Windows.Forms.Button buttonSalvarCadastroCliente;
        private System.Windows.Forms.MaskedTextBox cPFMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox celularMaskedTextBox;
        private System.Windows.Forms.DateTimePicker data_nascimentoDateTimePicker;
        private System.Windows.Forms.TextBox emailTextBox1;
        private System.Windows.Forms.TextBox enderecoTextBox1;
        private System.Windows.Forms.TextBox nomeTextBox1;
    }
}