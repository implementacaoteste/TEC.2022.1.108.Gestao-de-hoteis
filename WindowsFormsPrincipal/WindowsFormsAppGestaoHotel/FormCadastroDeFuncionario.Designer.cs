namespace WindowsFormsPrincipal1
{
    partial class FormCadastroDeFuncionario
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
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label data_nascimentoLabel;
            System.Windows.Forms.Label nomeUsuarioLabel;
            System.Windows.Forms.Label confirmar_senhaLabel;
            System.Windows.Forms.Label senhaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroDeFuncionario));
            this.buttonSalvarFuncionario = new System.Windows.Forms.Button();
            this.buttonCancelarCadastro = new System.Windows.Forms.Button();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.nomeUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sexoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxConfirmarSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.cPFMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.celularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.data_nascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            nomeLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            data_nascimentoLabel = new System.Windows.Forms.Label();
            nomeUsuarioLabel = new System.Windows.Forms.Label();
            confirmar_senhaLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            nomeLabel.Location = new System.Drawing.Point(59, 84);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(64, 25);
            nomeLabel.TabIndex = 1;
            nomeLabel.Text = "Nome";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            emailLabel.Location = new System.Drawing.Point(651, 165);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(67, 25);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "E-mail";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            cPFLabel.Location = new System.Drawing.Point(437, 86);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(52, 25);
            cPFLabel.TabIndex = 3;
            cPFLabel.Text = "CPF";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            celularLabel.Location = new System.Drawing.Point(627, 87);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(74, 25);
            celularLabel.TabIndex = 5;
            celularLabel.Text = "Celular";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            enderecoLabel.Location = new System.Drawing.Point(219, 165);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(96, 25);
            enderecoLabel.TabIndex = 11;
            enderecoLabel.Text = "Endereço";
            // 
            // data_nascimentoLabel
            // 
            data_nascimentoLabel.AutoSize = true;
            data_nascimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            data_nascimentoLabel.Location = new System.Drawing.Point(820, 84);
            data_nascimentoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            data_nascimentoLabel.Name = "data_nascimentoLabel";
            data_nascimentoLabel.Size = new System.Drawing.Size(188, 25);
            data_nascimentoLabel.TabIndex = 7;
            data_nascimentoLabel.Text = "Data de Nascimento";
            // 
            // nomeUsuarioLabel
            // 
            nomeUsuarioLabel.AutoSize = true;
            nomeUsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            nomeUsuarioLabel.Location = new System.Drawing.Point(59, 244);
            nomeUsuarioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeUsuarioLabel.Name = "nomeUsuarioLabel";
            nomeUsuarioLabel.Size = new System.Drawing.Size(160, 25);
            nomeUsuarioLabel.TabIndex = 15;
            nomeUsuarioLabel.Text = "Nome de usuario";
            // 
            // confirmar_senhaLabel
            // 
            confirmar_senhaLabel.AutoSize = true;
            confirmar_senhaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            confirmar_senhaLabel.Location = new System.Drawing.Point(305, 324);
            confirmar_senhaLabel.Name = "confirmar_senhaLabel";
            confirmar_senhaLabel.Size = new System.Drawing.Size(156, 25);
            confirmar_senhaLabel.TabIndex = 20;
            confirmar_senhaLabel.Text = "Confirmar senha";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            senhaLabel.Location = new System.Drawing.Point(59, 324);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(70, 25);
            senhaLabel.TabIndex = 18;
            senhaLabel.Text = "Senha";
            // 
            // buttonSalvarFuncionario
            // 
            this.buttonSalvarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(179)))), ((int)(((byte)(122)))));
            this.buttonSalvarFuncionario.FlatAppearance.BorderSize = 0;
            this.buttonSalvarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvarFuncionario.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarFuncionario.ForeColor = System.Drawing.Color.White;
            this.buttonSalvarFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalvarFuncionario.Image")));
            this.buttonSalvarFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvarFuncionario.Location = new System.Drawing.Point(708, 380);
            this.buttonSalvarFuncionario.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSalvarFuncionario.Name = "buttonSalvarFuncionario";
            this.buttonSalvarFuncionario.Size = new System.Drawing.Size(152, 41);
            this.buttonSalvarFuncionario.TabIndex = 22;
            this.buttonSalvarFuncionario.Text = "SALVAR";
            this.buttonSalvarFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalvarFuncionario.UseVisualStyleBackColor = false;
            this.buttonSalvarFuncionario.Click += new System.EventHandler(this.buttonSalvarFuncionario_Click);
            // 
            // buttonCancelarCadastro
            // 
            this.buttonCancelarCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(77)))), ((int)(((byte)(87)))));
            this.buttonCancelarCadastro.FlatAppearance.BorderSize = 0;
            this.buttonCancelarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelarCadastro.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCadastro.ForeColor = System.Drawing.Color.White;
            this.buttonCancelarCadastro.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelarCadastro.Image")));
            this.buttonCancelarCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelarCadastro.Location = new System.Drawing.Point(873, 380);
            this.buttonCancelarCadastro.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCancelarCadastro.MinimumSize = new System.Drawing.Size(131, 34);
            this.buttonCancelarCadastro.Name = "buttonCancelarCadastro";
            this.buttonCancelarCadastro.Size = new System.Drawing.Size(186, 41);
            this.buttonCancelarCadastro.TabIndex = 23;
            this.buttonCancelarCadastro.Text = "CANCELAR";
            this.buttonCancelarCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelarCadastro.UseVisualStyleBackColor = false;
            this.buttonCancelarCadastro.Click += new System.EventHandler(this.buttonCancelarCadastro_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Nome", true));
            this.nomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nomeTextBox.Location = new System.Drawing.Point(64, 116);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.nomeTextBox.MinimumSize = new System.Drawing.Size(365, 30);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(365, 28);
            this.nomeTextBox.TabIndex = 2;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataSource = typeof(Models.Funcionario);
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.emailTextBox.Location = new System.Drawing.Point(656, 194);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.emailTextBox.MinimumSize = new System.Drawing.Size(365, 30);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(365, 28);
            this.emailTextBox.TabIndex = 14;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Endereco", true));
            this.enderecoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.enderecoTextBox.Location = new System.Drawing.Point(223, 194);
            this.enderecoTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.enderecoTextBox.MinimumSize = new System.Drawing.Size(365, 30);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(425, 28);
            this.enderecoTextBox.TabIndex = 12;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Senha", true));
            this.senhaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.senhaTextBox.Location = new System.Drawing.Point(64, 353);
            this.senhaTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.senhaTextBox.MinimumSize = new System.Drawing.Size(205, 30);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.Size = new System.Drawing.Size(205, 28);
            this.senhaTextBox.TabIndex = 19;
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.funcionarioBindingSource, "Ativo", true));
            this.ativoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ativoCheckBox.Location = new System.Drawing.Point(312, 273);
            this.ativoCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(95, 30);
            this.ativoCheckBox.TabIndex = 17;
            this.ativoCheckBox.Text = "Ativo";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // nomeUsuarioTextBox
            // 
            this.nomeUsuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "NomeUsuario", true));
            this.nomeUsuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nomeUsuarioTextBox.Location = new System.Drawing.Point(64, 273);
            this.nomeUsuarioTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.nomeUsuarioTextBox.MinimumSize = new System.Drawing.Size(205, 30);
            this.nomeUsuarioTextBox.Name = "nomeUsuarioTextBox";
            this.nomeUsuarioTextBox.Size = new System.Drawing.Size(205, 28);
            this.nomeUsuarioTextBox.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.funcionarioBindingSource, "IdSexo", true));
            this.comboBox1.DataSource = this.sexoBindingSource;
            this.comboBox1.DisplayMember = "Genero";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(64, 194);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox1.MinimumSize = new System.Drawing.Size(129, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 30);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "Id";
            // 
            // sexoBindingSource
            // 
            this.sexoBindingSource.DataSource = typeof(Models.Sexo);
            // 
            // textBoxConfirmarSenha
            // 
            this.textBoxConfirmarSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxConfirmarSenha.Location = new System.Drawing.Point(311, 357);
            this.textBoxConfirmarSenha.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxConfirmarSenha.MinimumSize = new System.Drawing.Size(205, 30);
            this.textBoxConfirmarSenha.Name = "textBoxConfirmarSenha";
            this.textBoxConfirmarSenha.PasswordChar = '*';
            this.textBoxConfirmarSenha.Size = new System.Drawing.Size(205, 28);
            this.textBoxConfirmarSenha.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(59, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Genero";
            // 
            // tituloLabel
            // 
            this.tituloLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.tituloLabel.Location = new System.Drawing.Point(0, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(1068, 68);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "Cadastro de Funcionário";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cPFMaskedTextBox
            // 
            this.cPFMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cPFMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "CPF", true));
            this.cPFMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cPFMaskedTextBox.Location = new System.Drawing.Point(443, 116);
            this.cPFMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cPFMaskedTextBox.Mask = "000,000,000-00";
            this.cPFMaskedTextBox.Name = "cPFMaskedTextBox";
            this.cPFMaskedTextBox.Size = new System.Drawing.Size(178, 28);
            this.cPFMaskedTextBox.TabIndex = 4;
            // 
            // celularMaskedTextBox
            // 
            this.celularMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.celularMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Celular", true));
            this.celularMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.celularMaskedTextBox.Location = new System.Drawing.Point(636, 116);
            this.celularMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.celularMaskedTextBox.Mask = "(99) 00000-0000";
            this.celularMaskedTextBox.Name = "celularMaskedTextBox";
            this.celularMaskedTextBox.Size = new System.Drawing.Size(183, 28);
            this.celularMaskedTextBox.TabIndex = 6;
            // 
            // data_nascimentoDateTimePicker
            // 
            this.data_nascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.funcionarioBindingSource, "Data_nascimento", true));
            this.data_nascimentoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.data_nascimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_nascimentoDateTimePicker.Location = new System.Drawing.Point(827, 116);
            this.data_nascimentoDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_nascimentoDateTimePicker.Name = "data_nascimentoDateTimePicker";
            this.data_nascimentoDateTimePicker.Size = new System.Drawing.Size(193, 28);
            this.data_nascimentoDateTimePicker.TabIndex = 8;
            // 
            // FormCadastroDeFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 430);
            this.Controls.Add(this.data_nascimentoDateTimePicker);
            this.Controls.Add(this.celularMaskedTextBox);
            this.Controls.Add(this.cPFMaskedTextBox);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(confirmar_senhaLabel);
            this.Controls.Add(this.textBoxConfirmarSenha);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(nomeUsuarioLabel);
            this.Controls.Add(this.nomeUsuarioTextBox);
            this.Controls.Add(data_nascimentoLabel);
            this.Controls.Add(this.ativoCheckBox);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(celularLabel);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.buttonCancelarCadastro);
            this.Controls.Add(this.buttonSalvarFuncionario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1086, 477);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1086, 477);
            this.Name = "FormCadastroDeFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOTELOGIX - Cadastro de Funcionário";
            this.Load += new System.EventHandler(this.FormCadastroDeFuncionario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadastroDeFuncionario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSalvarFuncionario;
        private System.Windows.Forms.Button buttonCancelarCadastro;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.TextBox nomeUsuarioTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxConfirmarSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.BindingSource sexoBindingSource;
        private System.Windows.Forms.MaskedTextBox cPFMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox celularMaskedTextBox;
        private System.Windows.Forms.DateTimePicker data_nascimentoDateTimePicker;
    }
}