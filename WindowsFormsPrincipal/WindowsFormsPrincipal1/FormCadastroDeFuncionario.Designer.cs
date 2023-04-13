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
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label data_nascimentoLabel;
            System.Windows.Forms.Label nomeUsuarioLabel;
            System.Windows.Forms.Label ativoLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroDeFuncionario));
            this.buttonSalvarFuncionario = new System.Windows.Forms.Button();
            this.buttonCancelarCadastro = new System.Windows.Forms.Button();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.cPFTextBox = new System.Windows.Forms.TextBox();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.sexosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.data_nascimentoTextBox = new System.Windows.Forms.TextBox();
            this.nomeUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.generoComboBox = new System.Windows.Forms.ComboBox();
            this.textBoxConfirmarSenha = new System.Windows.Forms.TextBox();
            this.confirmar_senhaLabel = new System.Windows.Forms.Label();
            this.generoLabel = new System.Windows.Forms.Label();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            data_nascimentoLabel = new System.Windows.Forms.Label();
            nomeUsuarioLabel = new System.Windows.Forms.Label();
            ativoLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            nomeLabel.Location = new System.Drawing.Point(46, 106);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(64, 25);
            nomeLabel.TabIndex = 13;
            nomeLabel.Text = "Nome";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            emailLabel.Location = new System.Drawing.Point(641, 170);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(67, 25);
            emailLabel.TabIndex = 14;
            emailLabel.Text = "E-mail";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            cPFLabel.Location = new System.Drawing.Point(431, 106);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(52, 25);
            cPFLabel.TabIndex = 15;
            cPFLabel.Text = "CPF";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            celularLabel.Location = new System.Drawing.Point(641, 106);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(74, 25);
            celularLabel.TabIndex = 16;
            celularLabel.Text = "Celular";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            enderecoLabel.Location = new System.Drawing.Point(207, 171);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(96, 25);
            enderecoLabel.TabIndex = 17;
            enderecoLabel.Text = "Endereço";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            senhaLabel.Location = new System.Drawing.Point(46, 309);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(70, 25);
            senhaLabel.TabIndex = 22;
            senhaLabel.Text = "Senha";
            // 
            // data_nascimentoLabel
            // 
            data_nascimentoLabel.AutoSize = true;
            data_nascimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            data_nascimentoLabel.Location = new System.Drawing.Point(831, 106);
            data_nascimentoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            data_nascimentoLabel.Name = "data_nascimentoLabel";
            data_nascimentoLabel.Size = new System.Drawing.Size(158, 25);
            data_nascimentoLabel.TabIndex = 19;
            data_nascimentoLabel.Text = "Data nascimento";
            // 
            // nomeUsuarioLabel
            // 
            nomeUsuarioLabel.AutoSize = true;
            nomeUsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            nomeUsuarioLabel.Location = new System.Drawing.Point(44, 245);
            nomeUsuarioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeUsuarioLabel.Name = "nomeUsuarioLabel";
            nomeUsuarioLabel.Size = new System.Drawing.Size(136, 25);
            nomeUsuarioLabel.TabIndex = 21;
            nomeUsuarioLabel.Text = "Nome Usuario";
            // 
            // ativoLabel1
            // 
            ativoLabel1.AutoSize = true;
            ativoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            ativoLabel1.Location = new System.Drawing.Point(531, 338);
            ativoLabel1.Name = "ativoLabel1";
            ativoLabel1.Size = new System.Drawing.Size(56, 25);
            ativoLabel1.TabIndex = 20;
            ativoLabel1.Text = "Ativo";
            // 
            // buttonSalvarFuncionario
            // 
            this.buttonSalvarFuncionario.AutoSize = true;
            this.buttonSalvarFuncionario.BackColor = System.Drawing.Color.White;
            this.buttonSalvarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSalvarFuncionario.Location = new System.Drawing.Point(755, 418);
            this.buttonSalvarFuncionario.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSalvarFuncionario.Name = "buttonSalvarFuncionario";
            this.buttonSalvarFuncionario.Size = new System.Drawing.Size(100, 37);
            this.buttonSalvarFuncionario.TabIndex = 11;
            this.buttonSalvarFuncionario.Text = "Salvar";
            this.buttonSalvarFuncionario.UseVisualStyleBackColor = false;
            this.buttonSalvarFuncionario.Click += new System.EventHandler(this.buttonSalvarFuncionario_Click);
            // 
            // buttonCancelarCadastro
            // 
            this.buttonCancelarCadastro.AutoSize = true;
            this.buttonCancelarCadastro.BackColor = System.Drawing.Color.White;
            this.buttonCancelarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonCancelarCadastro.Location = new System.Drawing.Point(901, 418);
            this.buttonCancelarCadastro.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCancelarCadastro.Name = "buttonCancelarCadastro";
            this.buttonCancelarCadastro.Size = new System.Drawing.Size(110, 37);
            this.buttonCancelarCadastro.TabIndex = 12;
            this.buttonCancelarCadastro.Text = "Cancelar";
            this.buttonCancelarCadastro.UseVisualStyleBackColor = false;
            this.buttonCancelarCadastro.Click += new System.EventHandler(this.buttonCancelarCadastro_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Nome", true));
            this.nomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nomeTextBox.Location = new System.Drawing.Point(51, 131);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.nomeTextBox.MinimumSize = new System.Drawing.Size(360, 30);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(360, 30);
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
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emailTextBox.Location = new System.Drawing.Point(646, 197);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.emailTextBox.MinimumSize = new System.Drawing.Size(365, 30);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(365, 30);
            this.emailTextBox.TabIndex = 1;
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "CPF", true));
            this.cPFTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cPFTextBox.Location = new System.Drawing.Point(437, 131);
            this.cPFTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.cPFTextBox.MinimumSize = new System.Drawing.Size(175, 30);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(175, 30);
            this.cPFTextBox.TabIndex = 2;
            // 
            // celularTextBox
            // 
            this.celularTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.celularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Celular", true));
            this.celularTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.celularTextBox.Location = new System.Drawing.Point(646, 131);
            this.celularTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.celularTextBox.MinimumSize = new System.Drawing.Size(160, 30);
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(160, 30);
            this.celularTextBox.TabIndex = 3;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Endereco", true));
            this.enderecoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.enderecoTextBox.Location = new System.Drawing.Point(213, 197);
            this.enderecoTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.enderecoTextBox.MinimumSize = new System.Drawing.Size(400, 30);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(400, 30);
            this.enderecoTextBox.TabIndex = 4;
            // 
            // sexosBindingSource
            // 
            this.sexosBindingSource.DataMember = "Sexos";
            this.sexosBindingSource.DataSource = this.funcionarioBindingSource;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Senha", true));
            this.senhaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.senhaTextBox.Location = new System.Drawing.Point(49, 338);
            this.senhaTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.senhaTextBox.MinimumSize = new System.Drawing.Size(195, 30);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(195, 30);
            this.senhaTextBox.TabIndex = 8;
            // 
            // data_nascimentoTextBox
            // 
            this.data_nascimentoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.data_nascimentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Data_nascimento", true));
            this.data_nascimentoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.data_nascimentoTextBox.Location = new System.Drawing.Point(836, 131);
            this.data_nascimentoTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.data_nascimentoTextBox.MinimumSize = new System.Drawing.Size(175, 30);
            this.data_nascimentoTextBox.Name = "data_nascimentoTextBox";
            this.data_nascimentoTextBox.Size = new System.Drawing.Size(175, 30);
            this.data_nascimentoTextBox.TabIndex = 6;
            // 
            // nomeUsuarioTextBox
            // 
            this.nomeUsuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "NomeUsuario", true));
            this.nomeUsuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nomeUsuarioTextBox.Location = new System.Drawing.Point(49, 272);
            this.nomeUsuarioTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.nomeUsuarioTextBox.MinimumSize = new System.Drawing.Size(195, 30);
            this.nomeUsuarioTextBox.Name = "nomeUsuarioTextBox";
            this.nomeUsuarioTextBox.Size = new System.Drawing.Size(195, 30);
            this.nomeUsuarioTextBox.TabIndex = 7;
            // 
            // generoComboBox
            // 
            this.generoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sexosBindingSource, "Genero", true));
            this.generoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.generoComboBox.FormattingEnabled = true;
            this.generoComboBox.Location = new System.Drawing.Point(49, 198);
            this.generoComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.generoComboBox.MinimumSize = new System.Drawing.Size(120, 0);
            this.generoComboBox.Name = "generoComboBox";
            this.generoComboBox.Size = new System.Drawing.Size(150, 30);
            this.generoComboBox.TabIndex = 5;
            // 
            // textBoxConfirmarSenha
            // 
            this.textBoxConfirmarSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxConfirmarSenha.Location = new System.Drawing.Point(288, 338);
            this.textBoxConfirmarSenha.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxConfirmarSenha.MinimumSize = new System.Drawing.Size(195, 30);
            this.textBoxConfirmarSenha.Name = "textBoxConfirmarSenha";
            this.textBoxConfirmarSenha.Size = new System.Drawing.Size(195, 30);
            this.textBoxConfirmarSenha.TabIndex = 9;
            // 
            // confirmar_senhaLabel
            // 
            this.confirmar_senhaLabel.AutoSize = true;
            this.confirmar_senhaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.confirmar_senhaLabel.Location = new System.Drawing.Point(283, 309);
            this.confirmar_senhaLabel.Name = "confirmar_senhaLabel";
            this.confirmar_senhaLabel.Size = new System.Drawing.Size(156, 25);
            this.confirmar_senhaLabel.TabIndex = 23;
            this.confirmar_senhaLabel.Text = "Confirmar senha";
            // 
            // generoLabel
            // 
            this.generoLabel.AutoSize = true;
            this.generoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.generoLabel.Location = new System.Drawing.Point(44, 170);
            this.generoLabel.Name = "generoLabel";
            this.generoLabel.Size = new System.Drawing.Size(77, 25);
            this.generoLabel.TabIndex = 18;
            this.generoLabel.Text = "Genero";
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.AutoSize = true;
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.funcionarioBindingSource, "Ativo", true));
            this.ativoCheckBox.Location = new System.Drawing.Point(595, 345);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(18, 17);
            this.ativoCheckBox.TabIndex = 10;
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // labelTitulo
            // 
            this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(0, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(1062, 75);
            this.labelTitulo.TabIndex = 24;
            this.labelTitulo.Text = "Cadastro de Funcionário";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormCadastroDeFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 483);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(ativoLabel1);
            this.Controls.Add(this.ativoCheckBox);
            this.Controls.Add(this.generoLabel);
            this.Controls.Add(this.confirmar_senhaLabel);
            this.Controls.Add(this.textBoxConfirmarSenha);
            this.Controls.Add(this.generoComboBox);
            this.Controls.Add(nomeUsuarioLabel);
            this.Controls.Add(this.nomeUsuarioTextBox);
            this.Controls.Add(data_nascimentoLabel);
            this.Controls.Add(this.data_nascimentoTextBox);
            this.Controls.Add(senhaLabel);
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
            this.Text = "HOTELOGIX - Cadastro de Funcionários";
            this.Load += new System.EventHandler(this.FormCadastroDeFuncionario_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexosBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource sexosBindingSource;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.TextBox data_nascimentoTextBox;
        private System.Windows.Forms.TextBox nomeUsuarioTextBox;
        private System.Windows.Forms.ComboBox generoComboBox;
        private System.Windows.Forms.TextBox textBoxConfirmarSenha;
        private System.Windows.Forms.Label confirmar_senhaLabel;
        private System.Windows.Forms.Label generoLabel;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.Label labelTitulo;
    }
}