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
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.cpfTextBox = new System.Windows.Forms.TextBox();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.data_nascimentoTextBox = new System.Windows.Forms.TextBox();
            this.generoComboBox = new System.Windows.Forms.ComboBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.buttonCancelarCadastroCliente = new System.Windows.Forms.Button();
            this.buttonSalvarCadastroCliente = new System.Windows.Forms.Button();
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
            nomeLabel.Location = new System.Drawing.Point(34, 133);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(64, 25);
            nomeLabel.TabIndex = 52;
            nomeLabel.Text = "Nome";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            celularLabel.Location = new System.Drawing.Point(558, 133);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(74, 25);
            celularLabel.TabIndex = 54;
            celularLabel.Text = "Celular";
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            cpfLabel.Location = new System.Drawing.Point(402, 133);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(52, 25);
            cpfLabel.TabIndex = 55;
            cpfLabel.Text = "CPF";
            // 
            // data_nascimentoLabel
            // 
            data_nascimentoLabel.AutoSize = true;
            data_nascimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            data_nascimentoLabel.Location = new System.Drawing.Point(717, 133);
            data_nascimentoLabel.Name = "data_nascimentoLabel";
            data_nascimentoLabel.Size = new System.Drawing.Size(188, 25);
            data_nascimentoLabel.TabIndex = 58;
            data_nascimentoLabel.Text = "Data de Nascimento";
            // 
            // generoLabel
            // 
            generoLabel.AutoSize = true;
            generoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            generoLabel.Location = new System.Drawing.Point(30, 227);
            generoLabel.Name = "generoLabel";
            generoLabel.Size = new System.Drawing.Size(77, 25);
            generoLabel.TabIndex = 60;
            generoLabel.Text = "Gênero";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            enderecoLabel.Location = new System.Drawing.Point(187, 227);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(96, 25);
            enderecoLabel.TabIndex = 62;
            enderecoLabel.Text = "Endereço";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            emailLabel.Location = new System.Drawing.Point(582, 227);
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
            this.tituloLabel.Size = new System.Drawing.Size(989, 65);
            this.tituloLabel.TabIndex = 50;
            this.tituloLabel.Text = "Cadastro de Cliente";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nomeTextBox.Location = new System.Drawing.Point(35, 161);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.nomeTextBox.MinimumSize = new System.Drawing.Size(365, 30);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(365, 28);
            this.nomeTextBox.TabIndex = 51;
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpfTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cpfTextBox.Location = new System.Drawing.Point(407, 161);
            this.cpfTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.cpfTextBox.MinimumSize = new System.Drawing.Size(150, 30);
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(150, 28);
            this.cpfTextBox.TabIndex = 56;
            // 
            // celularTextBox
            // 
            this.celularTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.celularTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.celularTextBox.Location = new System.Drawing.Point(563, 161);
            this.celularTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.celularTextBox.MinimumSize = new System.Drawing.Size(150, 30);
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(150, 28);
            this.celularTextBox.TabIndex = 57;
            // 
            // data_nascimentoTextBox
            // 
            this.data_nascimentoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.data_nascimentoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.data_nascimentoTextBox.Location = new System.Drawing.Point(722, 161);
            this.data_nascimentoTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.data_nascimentoTextBox.MinimumSize = new System.Drawing.Size(150, 30);
            this.data_nascimentoTextBox.Name = "data_nascimentoTextBox";
            this.data_nascimentoTextBox.Size = new System.Drawing.Size(230, 28);
            this.data_nascimentoTextBox.TabIndex = 57;
            // 
            // generoComboBox
            // 
            this.generoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "IdSexo", true));
            this.generoComboBox.DataSource = this.sexoBindingSource;
            this.generoComboBox.DisplayMember = "Genero";
            this.generoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.generoComboBox.FormattingEnabled = true;
            this.generoComboBox.Location = new System.Drawing.Point(35, 252);
            this.generoComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.generoComboBox.MinimumSize = new System.Drawing.Size(130, 0);
            this.generoComboBox.Name = "generoComboBox";
            this.generoComboBox.Size = new System.Drawing.Size(145, 30);
            this.generoComboBox.TabIndex = 59;
            this.generoComboBox.ValueMember = "Id";
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enderecoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.enderecoTextBox.Location = new System.Drawing.Point(192, 252);
            this.enderecoTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.enderecoTextBox.MinimumSize = new System.Drawing.Size(365, 30);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(385, 28);
            this.enderecoTextBox.TabIndex = 61;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.emailTextBox.Location = new System.Drawing.Point(587, 252);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.emailTextBox.MinimumSize = new System.Drawing.Size(365, 30);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(365, 28);
            this.emailTextBox.TabIndex = 63;
            // 
            // buttonCancelarCadastroCliente
            // 
            this.buttonCancelarCadastroCliente.AutoSize = true;
            this.buttonCancelarCadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelarCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCadastroCliente.Location = new System.Drawing.Point(862, 370);
            this.buttonCancelarCadastroCliente.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCancelarCadastroCliente.Name = "buttonCancelarCadastroCliente";
            this.buttonCancelarCadastroCliente.Size = new System.Drawing.Size(90, 30);
            this.buttonCancelarCadastroCliente.TabIndex = 66;
            this.buttonCancelarCadastroCliente.Text = "Cancelar";
            this.buttonCancelarCadastroCliente.UseVisualStyleBackColor = true;
            this.buttonCancelarCadastroCliente.Click += new System.EventHandler(this.buttonCancelarCadastroCliente_Click);
            // 
            // buttonSalvarCadastroCliente
            // 
            this.buttonSalvarCadastroCliente.AutoSize = true;
            this.buttonSalvarCadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvarCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarCadastroCliente.Location = new System.Drawing.Point(756, 370);
            this.buttonSalvarCadastroCliente.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSalvarCadastroCliente.Name = "buttonSalvarCadastroCliente";
            this.buttonSalvarCadastroCliente.Size = new System.Drawing.Size(90, 30);
            this.buttonSalvarCadastroCliente.TabIndex = 65;
            this.buttonSalvarCadastroCliente.Text = "Salvar";
            this.buttonSalvarCadastroCliente.UseVisualStyleBackColor = true;
            this.buttonSalvarCadastroCliente.Click += new System.EventHandler(this.buttonSalvarCadastroCliente_Click);
            // 
            // FormCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(989, 445);
            this.Controls.Add(this.buttonCancelarCadastroCliente);
            this.Controls.Add(this.buttonSalvarCadastroCliente);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(generoLabel);
            this.Controls.Add(this.generoComboBox);
            this.Controls.Add(data_nascimentoLabel);
            this.Controls.Add(this.data_nascimentoTextBox);
            this.Controls.Add(this.celularTextBox);
            this.Controls.Add(this.cpfTextBox);
            this.Controls.Add(cpfLabel);
            this.Controls.Add(celularLabel);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
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
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox cpfTextBox;
        private System.Windows.Forms.TextBox celularTextBox;
        private System.Windows.Forms.TextBox data_nascimentoTextBox;
        private System.Windows.Forms.ComboBox generoComboBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button buttonCancelarCadastroCliente;
        private System.Windows.Forms.Button buttonSalvarCadastroCliente;
    }
}