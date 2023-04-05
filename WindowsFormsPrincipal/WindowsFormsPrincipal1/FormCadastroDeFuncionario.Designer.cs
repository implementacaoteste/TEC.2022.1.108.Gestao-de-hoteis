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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroDeFuncionario));
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCelular = new System.Windows.Forms.TextBox();
            this.labelCelular = new System.Windows.Forms.Label();
            this.textBoxEndereço = new System.Windows.Forms.TextBox();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.labelNomeDeUsuario = new System.Windows.Forms.Label();
            this.textBoxNomeDeUsuario = new System.Windows.Forms.TextBox();
            this.textBoxDataDeNascimento = new System.Windows.Forms.TextBox();
            this.labelDataDeNascimento = new System.Windows.Forms.Label();
            this.textBoxSexo = new System.Windows.Forms.TextBox();
            this.labelSexo = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.checkBoxAtivo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(68, 144);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(269, 22);
            this.textBoxNome.TabIndex = 1;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(65, 125);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(44, 16);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome";
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Location = new System.Drawing.Point(343, 144);
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(198, 22);
            this.textBoxCPF.TabIndex = 1;
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(349, 125);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(33, 16);
            this.labelCPF.TabIndex = 2;
            this.labelCPF.Text = "CPF";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(68, 218);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(195, 22);
            this.textBoxEmail.TabIndex = 1;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(65, 199);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(45, 16);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(800, 65);
            this.label2.TabIndex = 25;
            this.label2.Text = "Cadastro de funcionário";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxCelular
            // 
            this.textBoxCelular.Location = new System.Drawing.Point(547, 144);
            this.textBoxCelular.Name = "textBoxCelular";
            this.textBoxCelular.Size = new System.Drawing.Size(185, 22);
            this.textBoxCelular.TabIndex = 1;
            // 
            // labelCelular
            // 
            this.labelCelular.AutoSize = true;
            this.labelCelular.Location = new System.Drawing.Point(544, 125);
            this.labelCelular.Name = "labelCelular";
            this.labelCelular.Size = new System.Drawing.Size(49, 16);
            this.labelCelular.TabIndex = 2;
            this.labelCelular.Text = "Celular";
            // 
            // textBoxEndereço
            // 
            this.textBoxEndereço.Location = new System.Drawing.Point(269, 218);
            this.textBoxEndereço.Name = "textBoxEndereço";
            this.textBoxEndereço.Size = new System.Drawing.Size(231, 22);
            this.textBoxEndereço.TabIndex = 1;
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(266, 199);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(66, 16);
            this.labelEndereco.TabIndex = 2;
            this.labelEndereco.Text = "Endereço";
            // 
            // labelNomeDeUsuario
            // 
            this.labelNomeDeUsuario.AutoSize = true;
            this.labelNomeDeUsuario.Location = new System.Drawing.Point(503, 199);
            this.labelNomeDeUsuario.Name = "labelNomeDeUsuario";
            this.labelNomeDeUsuario.Size = new System.Drawing.Size(110, 16);
            this.labelNomeDeUsuario.TabIndex = 27;
            this.labelNomeDeUsuario.Text = "Nome de usuário";
            this.labelNomeDeUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNomeDeUsuario
            // 
            this.textBoxNomeDeUsuario.Location = new System.Drawing.Point(506, 218);
            this.textBoxNomeDeUsuario.Name = "textBoxNomeDeUsuario";
            this.textBoxNomeDeUsuario.Size = new System.Drawing.Size(226, 22);
            this.textBoxNomeDeUsuario.TabIndex = 26;
            // 
            // textBoxDataDeNascimento
            // 
            this.textBoxDataDeNascimento.Location = new System.Drawing.Point(68, 303);
            this.textBoxDataDeNascimento.Name = "textBoxDataDeNascimento";
            this.textBoxDataDeNascimento.Size = new System.Drawing.Size(195, 22);
            this.textBoxDataDeNascimento.TabIndex = 26;
            // 
            // labelDataDeNascimento
            // 
            this.labelDataDeNascimento.AutoSize = true;
            this.labelDataDeNascimento.Location = new System.Drawing.Point(65, 284);
            this.labelDataDeNascimento.Name = "labelDataDeNascimento";
            this.labelDataDeNascimento.Size = new System.Drawing.Size(127, 16);
            this.labelDataDeNascimento.TabIndex = 27;
            this.labelDataDeNascimento.Text = "Data de nascimento";
            this.labelDataDeNascimento.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxSexo
            // 
            this.textBoxSexo.Location = new System.Drawing.Point(269, 303);
            this.textBoxSexo.Name = "textBoxSexo";
            this.textBoxSexo.Size = new System.Drawing.Size(136, 22);
            this.textBoxSexo.TabIndex = 26;
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(266, 284);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(38, 16);
            this.labelSexo.TabIndex = 27;
            this.labelSexo.Text = "Sexo";
            this.labelSexo.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(411, 303);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(253, 22);
            this.textBoxSenha.TabIndex = 26;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(408, 284);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(46, 16);
            this.labelSenha.TabIndex = 27;
            this.labelSenha.Text = "Senha";
            this.labelSenha.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.AutoSize = true;
            this.checkBoxAtivo.Location = new System.Drawing.Point(670, 303);
            this.checkBoxAtivo.Name = "checkBoxAtivo";
            this.checkBoxAtivo.Size = new System.Drawing.Size(59, 20);
            this.checkBoxAtivo.TabIndex = 28;
            this.checkBoxAtivo.Text = "Ativo";
            this.checkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // FormCadastroDeFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxAtivo);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.labelDataDeNascimento);
            this.Controls.Add(this.labelNomeDeUsuario);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxSexo);
            this.Controls.Add(this.textBoxDataDeNascimento);
            this.Controls.Add(this.textBoxNomeDeUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.labelCelular);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxEndereço);
            this.Controls.Add(this.textBoxCelular);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxCPF);
            this.Controls.Add(this.textBoxNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroDeFuncionario";
            this.Text = "Cadastro de funcionários";
            this.Load += new System.EventHandler(this.FormCadastroDeFuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxCPF;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCelular;
        private System.Windows.Forms.Label labelCelular;
        private System.Windows.Forms.TextBox textBoxEndereço;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.Label labelNomeDeUsuario;
        private System.Windows.Forms.TextBox textBoxNomeDeUsuario;
        private System.Windows.Forms.TextBox textBoxDataDeNascimento;
        private System.Windows.Forms.Label labelDataDeNascimento;
        private System.Windows.Forms.TextBox textBoxSexo;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.CheckBox checkBoxAtivo;
    }
}