namespace WindowsFormsAppGestaoHotel
{
    partial class FormCadastroDiaria
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
            System.Windows.Forms.Label data_EntradaLabel;
            System.Windows.Forms.Label data_SaidaLabel;
            System.Windows.Forms.Label id_clienteLabel;
            System.Windows.Forms.Label id_funcionarioLabel;
            System.Windows.Forms.Label id_PagamentoLabel;
            System.Windows.Forms.Label valor_TotalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroDiaria));
            this.diariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_EntradaTextBox = new System.Windows.Forms.TextBox();
            this.data_SaidaTextBox = new System.Windows.Forms.TextBox();
            this.id_clienteTextBox = new System.Windows.Forms.TextBox();
            this.id_funcionarioTextBox = new System.Windows.Forms.TextBox();
            this.id_PagamentoTextBox = new System.Windows.Forms.TextBox();
            this.valor_TotalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSelecionarFuncionario = new System.Windows.Forms.Button();
            this.buttonSelecionarCliente = new System.Windows.Forms.Button();
            this.buttonSelecionarPagamento = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            data_EntradaLabel = new System.Windows.Forms.Label();
            data_SaidaLabel = new System.Windows.Forms.Label();
            id_clienteLabel = new System.Windows.Forms.Label();
            id_funcionarioLabel = new System.Windows.Forms.Label();
            id_PagamentoLabel = new System.Windows.Forms.Label();
            valor_TotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diariaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // data_EntradaLabel
            // 
            data_EntradaLabel.AutoSize = true;
            data_EntradaLabel.Location = new System.Drawing.Point(45, 110);
            data_EntradaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            data_EntradaLabel.Name = "data_EntradaLabel";
            data_EntradaLabel.Size = new System.Drawing.Size(88, 13);
            data_EntradaLabel.TabIndex = 1;
            data_EntradaLabel.Text = "Data da Entrada:";
            // 
            // data_SaidaLabel
            // 
            data_SaidaLabel.AutoSize = true;
            data_SaidaLabel.Location = new System.Drawing.Point(55, 144);
            data_SaidaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            data_SaidaLabel.Name = "data_SaidaLabel";
            data_SaidaLabel.Size = new System.Drawing.Size(78, 13);
            data_SaidaLabel.TabIndex = 2;
            data_SaidaLabel.Text = "Data da Saida:";
            // 
            // id_clienteLabel
            // 
            id_clienteLabel.AutoSize = true;
            id_clienteLabel.Location = new System.Drawing.Point(281, 144);
            id_clienteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            id_clienteLabel.Name = "id_clienteLabel";
            id_clienteLabel.Size = new System.Drawing.Size(67, 13);
            id_clienteLabel.TabIndex = 4;
            id_clienteLabel.Text = "Cód. Cliente:";
            // 
            // id_funcionarioLabel
            // 
            id_funcionarioLabel.AutoSize = true;
            id_funcionarioLabel.Location = new System.Drawing.Point(260, 112);
            id_funcionarioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            id_funcionarioLabel.Name = "id_funcionarioLabel";
            id_funcionarioLabel.Size = new System.Drawing.Size(90, 13);
            id_funcionarioLabel.TabIndex = 6;
            id_funcionarioLabel.Text = "Cód. Funcionario:";
            // 
            // id_PagamentoLabel
            // 
            id_PagamentoLabel.AutoSize = true;
            id_PagamentoLabel.Location = new System.Drawing.Point(260, 181);
            id_PagamentoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            id_PagamentoLabel.Name = "id_PagamentoLabel";
            id_PagamentoLabel.Size = new System.Drawing.Size(89, 13);
            id_PagamentoLabel.TabIndex = 8;
            id_PagamentoLabel.Text = "Cód. Pagamento:";
            // 
            // valor_TotalLabel
            // 
            valor_TotalLabel.AutoSize = true;
            valor_TotalLabel.Location = new System.Drawing.Point(72, 177);
            valor_TotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            valor_TotalLabel.Name = "valor_TotalLabel";
            valor_TotalLabel.Size = new System.Drawing.Size(61, 13);
            valor_TotalLabel.TabIndex = 10;
            valor_TotalLabel.Text = "Valor Total:";
            // 
            // diariaBindingSource
            // 
            this.diariaBindingSource.DataSource = typeof(Models.Diaria);
            // 
            // data_EntradaTextBox
            // 
            this.data_EntradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diariaBindingSource, "Data_Entrada", true));
            this.data_EntradaTextBox.Location = new System.Drawing.Point(137, 107);
            this.data_EntradaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.data_EntradaTextBox.Name = "data_EntradaTextBox";
            this.data_EntradaTextBox.Size = new System.Drawing.Size(76, 20);
            this.data_EntradaTextBox.TabIndex = 2;
            // 
            // data_SaidaTextBox
            // 
            this.data_SaidaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diariaBindingSource, "Data_Saida", true));
            this.data_SaidaTextBox.Location = new System.Drawing.Point(137, 139);
            this.data_SaidaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.data_SaidaTextBox.Name = "data_SaidaTextBox";
            this.data_SaidaTextBox.Size = new System.Drawing.Size(76, 20);
            this.data_SaidaTextBox.TabIndex = 3;
            // 
            // id_clienteTextBox
            // 
            this.id_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diariaBindingSource, "Id_cliente", true));
            this.id_clienteTextBox.Location = new System.Drawing.Point(347, 141);
            this.id_clienteTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.id_clienteTextBox.Name = "id_clienteTextBox";
            this.id_clienteTextBox.Size = new System.Drawing.Size(76, 20);
            this.id_clienteTextBox.TabIndex = 5;
            // 
            // id_funcionarioTextBox
            // 
            this.id_funcionarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diariaBindingSource, "Id_funcionario", true));
            this.id_funcionarioTextBox.Location = new System.Drawing.Point(347, 110);
            this.id_funcionarioTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.id_funcionarioTextBox.Name = "id_funcionarioTextBox";
            this.id_funcionarioTextBox.Size = new System.Drawing.Size(76, 20);
            this.id_funcionarioTextBox.TabIndex = 7;
            // 
            // id_PagamentoTextBox
            // 
            this.id_PagamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diariaBindingSource, "Id_Pagamento", true));
            this.id_PagamentoTextBox.Location = new System.Drawing.Point(347, 179);
            this.id_PagamentoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.id_PagamentoTextBox.Name = "id_PagamentoTextBox";
            this.id_PagamentoTextBox.Size = new System.Drawing.Size(76, 20);
            this.id_PagamentoTextBox.TabIndex = 9;
            // 
            // valor_TotalTextBox
            // 
            this.valor_TotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diariaBindingSource, "Valor_Total", true));
            this.valor_TotalTextBox.Location = new System.Drawing.Point(137, 174);
            this.valor_TotalTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.valor_TotalTextBox.Name = "valor_TotalTextBox";
            this.valor_TotalTextBox.Size = new System.Drawing.Size(76, 20);
            this.valor_TotalTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(158, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cadastro de Diária";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonSelecionarFuncionario
            // 
            this.buttonSelecionarFuncionario.Location = new System.Drawing.Point(427, 110);
            this.buttonSelecionarFuncionario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSelecionarFuncionario.Name = "buttonSelecionarFuncionario";
            this.buttonSelecionarFuncionario.Size = new System.Drawing.Size(68, 19);
            this.buttonSelecionarFuncionario.TabIndex = 13;
            this.buttonSelecionarFuncionario.Text = "Selecionar";
            this.buttonSelecionarFuncionario.UseVisualStyleBackColor = true;
            this.buttonSelecionarFuncionario.Click += new System.EventHandler(this.buttonSelecionarFuncionario_Click);
            // 
            // buttonSelecionarCliente
            // 
            this.buttonSelecionarCliente.Location = new System.Drawing.Point(428, 141);
            this.buttonSelecionarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSelecionarCliente.Name = "buttonSelecionarCliente";
            this.buttonSelecionarCliente.Size = new System.Drawing.Size(68, 19);
            this.buttonSelecionarCliente.TabIndex = 14;
            this.buttonSelecionarCliente.Text = "Selecionar";
            this.buttonSelecionarCliente.UseVisualStyleBackColor = true;
            this.buttonSelecionarCliente.Click += new System.EventHandler(this.buttonSelecionarCliente_Click);
            // 
            // buttonSelecionarPagamento
            // 
            this.buttonSelecionarPagamento.Location = new System.Drawing.Point(428, 181);
            this.buttonSelecionarPagamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSelecionarPagamento.Name = "buttonSelecionarPagamento";
            this.buttonSelecionarPagamento.Size = new System.Drawing.Size(68, 19);
            this.buttonSelecionarPagamento.TabIndex = 15;
            this.buttonSelecionarPagamento.Text = "Selecionar";
            this.buttonSelecionarPagamento.UseVisualStyleBackColor = true;
            this.buttonSelecionarPagamento.Click += new System.EventHandler(this.buttonSelecionarPagamento_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(428, 284);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(56, 19);
            this.buttonSalvar.TabIndex = 16;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(496, 284);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(56, 19);
            this.buttonCancelar.TabIndex = 17;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormCadastroDiaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonSelecionarPagamento);
            this.Controls.Add(this.buttonSelecionarCliente);
            this.Controls.Add(this.buttonSelecionarFuncionario);
            this.Controls.Add(this.label1);
            this.Controls.Add(valor_TotalLabel);
            this.Controls.Add(this.valor_TotalTextBox);
            this.Controls.Add(id_PagamentoLabel);
            this.Controls.Add(this.id_PagamentoTextBox);
            this.Controls.Add(id_funcionarioLabel);
            this.Controls.Add(this.id_funcionarioTextBox);
            this.Controls.Add(id_clienteLabel);
            this.Controls.Add(this.id_clienteTextBox);
            this.Controls.Add(data_SaidaLabel);
            this.Controls.Add(this.data_SaidaTextBox);
            this.Controls.Add(data_EntradaLabel);
            this.Controls.Add(this.data_EntradaTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroDiaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Diaria";
            this.Load += new System.EventHandler(this.FormCadastroDiaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diariaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource diariaBindingSource;
        private System.Windows.Forms.TextBox data_EntradaTextBox;
        private System.Windows.Forms.TextBox data_SaidaTextBox;
        private System.Windows.Forms.TextBox id_clienteTextBox;
        private System.Windows.Forms.TextBox id_funcionarioTextBox;
        private System.Windows.Forms.TextBox id_PagamentoTextBox;
        private System.Windows.Forms.TextBox valor_TotalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSelecionarFuncionario;
        private System.Windows.Forms.Button buttonSelecionarCliente;
        private System.Windows.Forms.Button buttonSelecionarPagamento;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}