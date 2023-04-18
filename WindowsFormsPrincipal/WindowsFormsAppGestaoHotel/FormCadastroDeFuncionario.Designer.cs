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
            this.cPFTextBox = new System.Windows.Forms.TextBox();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.data_nascimentoTextBox = new System.Windows.Forms.TextBox();
            this.nomeUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxConfirmarSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.sexoBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            nomeLabel.Location = new System.Drawing.Point(67, 96);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(64, 25);
            nomeLabel.TabIndex = 30;
            nomeLabel.Text = "Nome";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            emailLabel.Location = new System.Drawing.Point(608, 163);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(67, 25);
            emailLabel.TabIndex = 31;
            emailLabel.Text = "E-mail";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            cPFLabel.Location = new System.Drawing.Point(440, 96);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(52, 25);
            cPFLabel.TabIndex = 32;
            cPFLabel.Text = "CPF";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            celularLabel.Location = new System.Drawing.Point(604, 96);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(74, 25);
            celularLabel.TabIndex = 33;
            celularLabel.Text = "Celular";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            enderecoLabel.Location = new System.Drawing.Point(226, 163);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(96, 25);
            enderecoLabel.TabIndex = 34;
            enderecoLabel.Text = "Endereço";
            // 
            // data_nascimentoLabel
            // 
            data_nascimentoLabel.AutoSize = true;
            data_nascimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            data_nascimentoLabel.Location = new System.Drawing.Point(773, 94);
            data_nascimentoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            data_nascimentoLabel.Name = "data_nascimentoLabel";
            data_nascimentoLabel.Size = new System.Drawing.Size(188, 25);
            data_nascimentoLabel.TabIndex = 37;
            data_nascimentoLabel.Text = "Data de Nascimento";
            // 
            // nomeUsuarioLabel
            // 
            nomeUsuarioLabel.AutoSize = true;
            nomeUsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            nomeUsuarioLabel.Location = new System.Drawing.Point(67, 247);
            nomeUsuarioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeUsuarioLabel.Name = "nomeUsuarioLabel";
            nomeUsuarioLabel.Size = new System.Drawing.Size(136, 25);
            nomeUsuarioLabel.TabIndex = 38;
            nomeUsuarioLabel.Text = "Nome Usuario";
            // 
            // confirmar_senhaLabel
            // 
            confirmar_senhaLabel.AutoSize = true;
            confirmar_senhaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            confirmar_senhaLabel.Location = new System.Drawing.Point(308, 323);
            confirmar_senhaLabel.Name = "confirmar_senhaLabel";
            confirmar_senhaLabel.Size = new System.Drawing.Size(156, 25);
            confirmar_senhaLabel.TabIndex = 42;
            confirmar_senhaLabel.Text = "Confirmar senha";
            // 
            // buttonSalvarFuncionario
            // 
            this.buttonSalvarFuncionario.AutoSize = true;
            this.buttonSalvarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarFuncionario.Location = new System.Drawing.Point(778, 351);
            this.buttonSalvarFuncionario.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSalvarFuncionario.Name = "buttonSalvarFuncionario";
            this.buttonSalvarFuncionario.Size = new System.Drawing.Size(90, 30);
            this.buttonSalvarFuncionario.TabIndex = 11;
            this.buttonSalvarFuncionario.Text = "Salvar";
            this.buttonSalvarFuncionario.UseVisualStyleBackColor = true;
            this.buttonSalvarFuncionario.Click += new System.EventHandler(this.buttonSalvarFuncionario_Click);
            // 
            // buttonCancelarCadastro
            // 
            this.buttonCancelarCadastro.AutoSize = true;
            this.buttonCancelarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCadastro.Location = new System.Drawing.Point(888, 351);
            this.buttonCancelarCadastro.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCancelarCadastro.Name = "buttonCancelarCadastro";
            this.buttonCancelarCadastro.Size = new System.Drawing.Size(90, 30);
            this.buttonCancelarCadastro.TabIndex = 12;
            this.buttonCancelarCadastro.Text = "Cancelar";
            this.buttonCancelarCadastro.UseVisualStyleBackColor = true;
            this.buttonCancelarCadastro.Click += new System.EventHandler(this.buttonCancelarCadastro_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Nome", true));
            this.nomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nomeTextBox.Location = new System.Drawing.Point(72, 123);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.nomeTextBox.MinimumSize = new System.Drawing.Size(365, 30);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(365, 30);
            this.nomeTextBox.TabIndex = 0;
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
            this.emailTextBox.Location = new System.Drawing.Point(613, 190);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.emailTextBox.MinimumSize = new System.Drawing.Size(365, 30);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(365, 30);
            this.emailTextBox.TabIndex = 6;
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "CPF", true));
            this.cPFTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cPFTextBox.Location = new System.Drawing.Point(446, 123);
            this.cPFTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.cPFTextBox.MinimumSize = new System.Drawing.Size(150, 30);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(150, 30);
            this.cPFTextBox.TabIndex = 1;
            // 
            // celularTextBox
            // 
            this.celularTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.celularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Celular", true));
            this.celularTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.celularTextBox.Location = new System.Drawing.Point(611, 123);
            this.celularTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.celularTextBox.MinimumSize = new System.Drawing.Size(150, 30);
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(150, 30);
            this.celularTextBox.TabIndex = 2;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Endereco", true));
            this.enderecoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.enderecoTextBox.Location = new System.Drawing.Point(231, 190);
            this.enderecoTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.enderecoTextBox.MinimumSize = new System.Drawing.Size(365, 30);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(365, 30);
            this.enderecoTextBox.TabIndex = 5;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Senha", true));
            this.senhaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.senhaTextBox.Location = new System.Drawing.Point(72, 351);
            this.senhaTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.senhaTextBox.MinimumSize = new System.Drawing.Size(205, 30);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(205, 30);
            this.senhaTextBox.TabIndex = 8;
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.funcionarioBindingSource, "Ativo", true));
            this.ativoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ativoCheckBox.Location = new System.Drawing.Point(313, 275);
            this.ativoCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(90, 29);
            this.ativoCheckBox.TabIndex = 10;
            this.ativoCheckBox.Text = "Ativo";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // data_nascimentoTextBox
            // 
            this.data_nascimentoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.data_nascimentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Data_nascimento", true));
            this.data_nascimentoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.data_nascimentoTextBox.Location = new System.Drawing.Point(778, 123);
            this.data_nascimentoTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.data_nascimentoTextBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.data_nascimentoTextBox.Name = "data_nascimentoTextBox";
            this.data_nascimentoTextBox.Size = new System.Drawing.Size(200, 30);
            this.data_nascimentoTextBox.TabIndex = 3;
            // 
            // nomeUsuarioTextBox
            // 
            this.nomeUsuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "NomeUsuario", true));
            this.nomeUsuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nomeUsuarioTextBox.Location = new System.Drawing.Point(72, 275);
            this.nomeUsuarioTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.nomeUsuarioTextBox.MinimumSize = new System.Drawing.Size(205, 30);
            this.nomeUsuarioTextBox.Name = "nomeUsuarioTextBox";
            this.nomeUsuarioTextBox.Size = new System.Drawing.Size(205, 30);
            this.nomeUsuarioTextBox.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.funcionarioBindingSource, "IdSexo", true));
            this.comboBox1.DataSource = this.sexoBindingSource;
            this.comboBox1.DisplayMember = "Genero";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(72, 190);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox1.MinimumSize = new System.Drawing.Size(130, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 30);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "Id";
            // 
            // textBoxConfirmarSenha
            // 
            this.textBoxConfirmarSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxConfirmarSenha.Location = new System.Drawing.Point(313, 351);
            this.textBoxConfirmarSenha.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxConfirmarSenha.MinimumSize = new System.Drawing.Size(205, 30);
            this.textBoxConfirmarSenha.Name = "textBoxConfirmarSenha";
            this.textBoxConfirmarSenha.Size = new System.Drawing.Size(205, 30);
            this.textBoxConfirmarSenha.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(69, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Genero";
            // 
            // tituloLabel
            // 
            this.tituloLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.tituloLabel.Location = new System.Drawing.Point(0, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(1062, 65);
            this.tituloLabel.TabIndex = 44;
            this.tituloLabel.Text = "Cadastro de Funcionário";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sexoBindingSource
            // 
            this.sexoBindingSource.DataSource = typeof(Models.Sexo);
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            senhaLabel.Location = new System.Drawing.Point(70, 323);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(70, 25);
            senhaLabel.TabIndex = 44;
            senhaLabel.Text = "Senha";
            // 
            // FormCadastroDeFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 433);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(confirmar_senhaLabel);
            this.Controls.Add(this.textBoxConfirmarSenha);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(nomeUsuarioLabel);
            this.Controls.Add(this.nomeUsuarioTextBox);
            this.Controls.Add(data_nascimentoLabel);
            this.Controls.Add(this.data_nascimentoTextBox);
            this.Controls.Add(this.ativoCheckBox);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(celularLabel);
            this.Controls.Add(this.celularTextBox);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.buttonCancelarCadastro);
            this.Controls.Add(this.buttonSalvarFuncionario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroDeFuncionario";
            this.Text = "HOTELOGIX - Cadastro de Funcionário";
            this.Load += new System.EventHandler(this.FormCadastroDeFuncionario_Load_1);
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
        private System.Windows.Forms.TextBox cPFTextBox;
        private System.Windows.Forms.TextBox celularTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.TextBox data_nascimentoTextBox;
        private System.Windows.Forms.TextBox nomeUsuarioTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxConfirmarSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.BindingSource sexoBindingSource;
    }
}