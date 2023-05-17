namespace WindowsFormsAppGestaoHotel
{
    partial class FormContaPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContaPagar));
            this.FormaPagamentoComboBox = new System.Windows.Forms.ComboBox();
            this.pagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelFormaPagamento = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.DescriçãoTextBox = new System.Windows.Forms.TextBox();
            this.ConcluidoCheckBox = new System.Windows.Forms.CheckBox();
            this.labelConta = new System.Windows.Forms.Label();
            this.ContaComboBox = new System.Windows.Forms.ComboBox();
            this.CategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.EmissaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.VencimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelEmissao = new System.Windows.Forms.Label();
            this.labelVencimento = new System.Windows.Forms.Label();
            this.ValorTextBox = new System.Windows.Forms.TextBox();
            this.labelValor = new System.Windows.Forms.Label();
            this.ParcelarCheckBox = new System.Windows.Forms.CheckBox();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.statusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCancelarCadastro = new System.Windows.Forms.Button();
            this.buttonSalvarFuncionario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FormaPagamentoComboBox
            // 
            this.FormaPagamentoComboBox.DataSource = this.pagamentoBindingSource;
            this.FormaPagamentoComboBox.DisplayMember = "Forma_pagamento";
            this.FormaPagamentoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.FormaPagamentoComboBox.FormattingEnabled = true;
            this.FormaPagamentoComboBox.Location = new System.Drawing.Point(48, 196);
            this.FormaPagamentoComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.FormaPagamentoComboBox.MinimumSize = new System.Drawing.Size(129, 0);
            this.FormaPagamentoComboBox.Name = "FormaPagamentoComboBox";
            this.FormaPagamentoComboBox.Size = new System.Drawing.Size(220, 30);
            this.FormaPagamentoComboBox.TabIndex = 11;
            this.FormaPagamentoComboBox.ValueMember = "Id";
            // 
            // pagamentoBindingSource
            // 
            this.pagamentoBindingSource.DataSource = typeof(Models.Pagamento);
            // 
            // labelFormaPagamento
            // 
            this.labelFormaPagamento.AutoSize = true;
            this.labelFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFormaPagamento.Location = new System.Drawing.Point(43, 171);
            this.labelFormaPagamento.Name = "labelFormaPagamento";
            this.labelFormaPagamento.Size = new System.Drawing.Size(198, 25);
            this.labelFormaPagamento.TabIndex = 12;
            this.labelFormaPagamento.Text = "Forma de pagamento";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDescricao.Location = new System.Drawing.Point(43, 95);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(99, 25);
            this.labelDescricao.TabIndex = 13;
            this.labelDescricao.Text = "Descrição";
            // 
            // DescriçãoTextBox
            // 
            this.DescriçãoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriçãoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DescriçãoTextBox.Location = new System.Drawing.Point(48, 120);
            this.DescriçãoTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.DescriçãoTextBox.MinimumSize = new System.Drawing.Size(365, 30);
            this.DescriçãoTextBox.Name = "DescriçãoTextBox";
            this.DescriçãoTextBox.Size = new System.Drawing.Size(689, 30);
            this.DescriçãoTextBox.TabIndex = 14;
            // 
            // ConcluidoCheckBox
            // 
            this.ConcluidoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ConcluidoCheckBox.Location = new System.Drawing.Point(751, 120);
            this.ConcluidoCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.ConcluidoCheckBox.Name = "ConcluidoCheckBox";
            this.ConcluidoCheckBox.Size = new System.Drawing.Size(155, 30);
            this.ConcluidoCheckBox.TabIndex = 18;
            this.ConcluidoCheckBox.Text = "Concluído?";
            this.ConcluidoCheckBox.UseVisualStyleBackColor = true;
            // 
            // labelConta
            // 
            this.labelConta.AutoSize = true;
            this.labelConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelConta.Location = new System.Drawing.Point(279, 171);
            this.labelConta.Name = "labelConta";
            this.labelConta.Size = new System.Drawing.Size(65, 25);
            this.labelConta.TabIndex = 19;
            this.labelConta.Text = "Conta";
            // 
            // ContaComboBox
            // 
            this.ContaComboBox.DisplayMember = "Genero";
            this.ContaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ContaComboBox.FormattingEnabled = true;
            this.ContaComboBox.Location = new System.Drawing.Point(284, 196);
            this.ContaComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.ContaComboBox.MinimumSize = new System.Drawing.Size(129, 0);
            this.ContaComboBox.Name = "ContaComboBox";
            this.ContaComboBox.Size = new System.Drawing.Size(453, 30);
            this.ContaComboBox.TabIndex = 20;
            this.ContaComboBox.ValueMember = "Id";
            // 
            // CategoriaComboBox
            // 
            this.CategoriaComboBox.DisplayMember = "Genero";
            this.CategoriaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CategoriaComboBox.FormattingEnabled = true;
            this.CategoriaComboBox.Location = new System.Drawing.Point(48, 272);
            this.CategoriaComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.CategoriaComboBox.MinimumSize = new System.Drawing.Size(129, 0);
            this.CategoriaComboBox.Name = "CategoriaComboBox";
            this.CategoriaComboBox.Size = new System.Drawing.Size(216, 30);
            this.CategoriaComboBox.TabIndex = 21;
            this.CategoriaComboBox.ValueMember = "Id";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCategoria.Location = new System.Drawing.Point(45, 247);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(97, 25);
            this.labelCategoria.TabIndex = 22;
            this.labelCategoria.Text = "Categoria";
            // 
            // EmissaoDateTimePicker
            // 
            this.EmissaoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.EmissaoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EmissaoDateTimePicker.Location = new System.Drawing.Point(284, 270);
            this.EmissaoDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmissaoDateTimePicker.Name = "EmissaoDateTimePicker";
            this.EmissaoDateTimePicker.Size = new System.Drawing.Size(219, 28);
            this.EmissaoDateTimePicker.TabIndex = 23;
            // 
            // VencimentoDateTimePicker
            // 
            this.VencimentoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.VencimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.VencimentoDateTimePicker.Location = new System.Drawing.Point(518, 270);
            this.VencimentoDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VencimentoDateTimePicker.Name = "VencimentoDateTimePicker";
            this.VencimentoDateTimePicker.Size = new System.Drawing.Size(219, 28);
            this.VencimentoDateTimePicker.TabIndex = 24;
            // 
            // labelEmissao
            // 
            this.labelEmissao.AutoSize = true;
            this.labelEmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEmissao.Location = new System.Drawing.Point(279, 243);
            this.labelEmissao.Name = "labelEmissao";
            this.labelEmissao.Size = new System.Drawing.Size(87, 25);
            this.labelEmissao.TabIndex = 25;
            this.labelEmissao.Text = "Emissão";
            // 
            // labelVencimento
            // 
            this.labelVencimento.AutoSize = true;
            this.labelVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelVencimento.Location = new System.Drawing.Point(513, 243);
            this.labelVencimento.Name = "labelVencimento";
            this.labelVencimento.Size = new System.Drawing.Size(116, 25);
            this.labelVencimento.TabIndex = 26;
            this.labelVencimento.Text = "Vencimento";
            // 
            // ValorTextBox
            // 
            this.ValorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ValorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ValorTextBox.Location = new System.Drawing.Point(48, 339);
            this.ValorTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.ValorTextBox.MinimumSize = new System.Drawing.Size(205, 30);
            this.ValorTextBox.Name = "ValorTextBox";
            this.ValorTextBox.Size = new System.Drawing.Size(220, 30);
            this.ValorTextBox.TabIndex = 27;
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelValor.Location = new System.Drawing.Point(45, 314);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(58, 25);
            this.labelValor.TabIndex = 28;
            this.labelValor.Text = "Valor";
            // 
            // ParcelarCheckBox
            // 
            this.ParcelarCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ParcelarCheckBox.Location = new System.Drawing.Point(284, 337);
            this.ParcelarCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.ParcelarCheckBox.Name = "ParcelarCheckBox";
            this.ParcelarCheckBox.Size = new System.Drawing.Size(155, 30);
            this.ParcelarCheckBox.TabIndex = 29;
            this.ParcelarCheckBox.Text = "Parcelar";
            this.ParcelarCheckBox.UseVisualStyleBackColor = true;
            // 
            // tituloLabel
            // 
            this.tituloLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.tituloLabel.Location = new System.Drawing.Point(0, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(923, 68);
            this.tituloLabel.TabIndex = 30;
            this.tituloLabel.Text = "Novo pagamento";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusesBindingSource
            // 
            this.statusesBindingSource.DataSource = typeof(Models.Statuses);
            // 
            // buttonCancelarCadastro
            // 
            this.buttonCancelarCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCancelarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonCancelarCadastro.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelarCadastro.Image")));
            this.buttonCancelarCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelarCadastro.Location = new System.Drawing.Point(741, 378);
            this.buttonCancelarCadastro.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCancelarCadastro.MinimumSize = new System.Drawing.Size(131, 34);
            this.buttonCancelarCadastro.Name = "buttonCancelarCadastro";
            this.buttonCancelarCadastro.Size = new System.Drawing.Size(165, 39);
            this.buttonCancelarCadastro.TabIndex = 32;
            this.buttonCancelarCadastro.Text = "Cancelar";
            this.buttonCancelarCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelarCadastro.UseVisualStyleBackColor = false;
            this.buttonCancelarCadastro.Click += new System.EventHandler(this.buttonCancelarCadastro_Click);
            // 
            // buttonSalvarFuncionario
            // 
            this.buttonSalvarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonSalvarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSalvarFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalvarFuncionario.Image")));
            this.buttonSalvarFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvarFuncionario.Location = new System.Drawing.Point(595, 378);
            this.buttonSalvarFuncionario.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSalvarFuncionario.Name = "buttonSalvarFuncionario";
            this.buttonSalvarFuncionario.Size = new System.Drawing.Size(135, 39);
            this.buttonSalvarFuncionario.TabIndex = 31;
            this.buttonSalvarFuncionario.Text = "Salvar";
            this.buttonSalvarFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalvarFuncionario.UseVisualStyleBackColor = false;
            this.buttonSalvarFuncionario.Click += new System.EventHandler(this.buttonSalvarFuncionario_Click);
            // 
            // FormContaPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 436);
            this.Controls.Add(this.buttonCancelarCadastro);
            this.Controls.Add(this.buttonSalvarFuncionario);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.ParcelarCheckBox);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.ValorTextBox);
            this.Controls.Add(this.labelVencimento);
            this.Controls.Add(this.labelEmissao);
            this.Controls.Add(this.VencimentoDateTimePicker);
            this.Controls.Add(this.EmissaoDateTimePicker);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.CategoriaComboBox);
            this.Controls.Add(this.ContaComboBox);
            this.Controls.Add(this.labelConta);
            this.Controls.Add(this.ConcluidoCheckBox);
            this.Controls.Add(this.DescriçãoTextBox);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.labelFormaPagamento);
            this.Controls.Add(this.FormaPagamentoComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormContaPagar";
            this.Text = "Pagamento";
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource pagamentoBindingSource;
        private System.Windows.Forms.ComboBox FormaPagamentoComboBox;
        private System.Windows.Forms.Label labelFormaPagamento;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox DescriçãoTextBox;
        private System.Windows.Forms.CheckBox ConcluidoCheckBox;
        private System.Windows.Forms.Label labelConta;
        private System.Windows.Forms.ComboBox ContaComboBox;
        private System.Windows.Forms.ComboBox CategoriaComboBox;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.DateTimePicker EmissaoDateTimePicker;
        private System.Windows.Forms.DateTimePicker VencimentoDateTimePicker;
        private System.Windows.Forms.Label labelEmissao;
        private System.Windows.Forms.Label labelVencimento;
        private System.Windows.Forms.TextBox ValorTextBox;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.CheckBox ParcelarCheckBox;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.BindingSource statusesBindingSource;
        private System.Windows.Forms.Button buttonCancelarCadastro;
        private System.Windows.Forms.Button buttonSalvarFuncionario;
    }
}