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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroDiaria));
            this.diariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valor_TotalTextBox = new System.Windows.Forms.TextBox();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.buttonSelecionarFuncionario = new System.Windows.Forms.Button();
            this.buttonSelecionarCliente = new System.Windows.Forms.Button();
            this.buttonSelecionarPagamento = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.funcionarioTextBox = new System.Windows.Forms.TextBox();
            this.id_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.id_PagamentoTextBox = new System.Windows.Forms.TextBox();
            this.data_EntradaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.data_SaidaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSelecionarQuarto = new System.Windows.Forms.Button();
            this.quartosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            data_EntradaLabel = new System.Windows.Forms.Label();
            data_SaidaLabel = new System.Windows.Forms.Label();
            id_clienteLabel = new System.Windows.Forms.Label();
            id_funcionarioLabel = new System.Windows.Forms.Label();
            id_PagamentoLabel = new System.Windows.Forms.Label();
            valor_TotalLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // data_EntradaLabel
            // 
            data_EntradaLabel.AutoSize = true;
            data_EntradaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_EntradaLabel.Location = new System.Drawing.Point(521, 111);
            data_EntradaLabel.Name = "data_EntradaLabel";
            data_EntradaLabel.Size = new System.Drawing.Size(159, 25);
            data_EntradaLabel.TabIndex = 1;
            data_EntradaLabel.Text = "Data da Entrada:";
            // 
            // data_SaidaLabel
            // 
            data_SaidaLabel.AutoSize = true;
            data_SaidaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_SaidaLabel.Location = new System.Drawing.Point(544, 181);
            data_SaidaLabel.Name = "data_SaidaLabel";
            data_SaidaLabel.Size = new System.Drawing.Size(142, 25);
            data_SaidaLabel.TabIndex = 2;
            data_SaidaLabel.Text = "Data da Saida:";
            // 
            // id_clienteLabel
            // 
            id_clienteLabel.AutoSize = true;
            id_clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_clienteLabel.Location = new System.Drawing.Point(67, 177);
            id_clienteLabel.Name = "id_clienteLabel";
            id_clienteLabel.Size = new System.Drawing.Size(126, 25);
            id_clienteLabel.TabIndex = 4;
            id_clienteLabel.Text = "Cód. Cliente:";
            // 
            // id_funcionarioLabel
            // 
            id_funcionarioLabel.AutoSize = true;
            id_funcionarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_funcionarioLabel.Location = new System.Drawing.Point(16, 106);
            id_funcionarioLabel.Name = "id_funcionarioLabel";
            id_funcionarioLabel.Size = new System.Drawing.Size(167, 25);
            id_funcionarioLabel.TabIndex = 6;
            id_funcionarioLabel.Text = "Cód. Funcionario:";
            // 
            // id_PagamentoLabel
            // 
            id_PagamentoLabel.AutoSize = true;
            id_PagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_PagamentoLabel.Location = new System.Drawing.Point(20, 246);
            id_PagamentoLabel.Name = "id_PagamentoLabel";
            id_PagamentoLabel.Size = new System.Drawing.Size(165, 25);
            id_PagamentoLabel.TabIndex = 8;
            id_PagamentoLabel.Text = "Cód. Pagamento:";
            // 
            // valor_TotalLabel
            // 
            valor_TotalLabel.AutoSize = true;
            valor_TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valor_TotalLabel.Location = new System.Drawing.Point(579, 251);
            valor_TotalLabel.Name = "valor_TotalLabel";
            valor_TotalLabel.Size = new System.Drawing.Size(113, 25);
            valor_TotalLabel.TabIndex = 10;
            valor_TotalLabel.Text = "Valor Total:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(60, 313);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(125, 25);
            label1.TabIndex = 24;
            label1.Text = "Cód. Quarto:";
            // 
            // diariaBindingSource
            // 
            this.diariaBindingSource.DataSource = typeof(Models.Diaria);
            // 
            // valor_TotalTextBox
            // 
            this.valor_TotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diariaBindingSource, "Valor_Total", true));
            this.valor_TotalTextBox.Location = new System.Drawing.Point(721, 254);
            this.valor_TotalTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valor_TotalTextBox.Name = "valor_TotalTextBox";
            this.valor_TotalTextBox.Size = new System.Drawing.Size(155, 22);
            this.valor_TotalTextBox.TabIndex = 11;
            // 
            // tituloLabel
            // 
            this.tituloLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tituloLabel.Location = new System.Drawing.Point(0, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(907, 68);
            this.tituloLabel.TabIndex = 12;
            this.tituloLabel.Text = "Cadastro de Diária";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonSelecionarFuncionario
            // 
            this.buttonSelecionarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionarFuncionario.Location = new System.Drawing.Point(371, 108);
            this.buttonSelecionarFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelecionarFuncionario.Name = "buttonSelecionarFuncionario";
            this.buttonSelecionarFuncionario.Size = new System.Drawing.Size(117, 31);
            this.buttonSelecionarFuncionario.TabIndex = 13;
            this.buttonSelecionarFuncionario.Text = "Selecionar";
            this.buttonSelecionarFuncionario.UseVisualStyleBackColor = true;
            this.buttonSelecionarFuncionario.Click += new System.EventHandler(this.buttonSelecionarFuncionario_Click);
            // 
            // buttonSelecionarCliente
            // 
            this.buttonSelecionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionarCliente.Location = new System.Drawing.Point(371, 181);
            this.buttonSelecionarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelecionarCliente.Name = "buttonSelecionarCliente";
            this.buttonSelecionarCliente.Size = new System.Drawing.Size(117, 31);
            this.buttonSelecionarCliente.TabIndex = 14;
            this.buttonSelecionarCliente.Text = "Selecionar";
            this.buttonSelecionarCliente.UseVisualStyleBackColor = true;
            this.buttonSelecionarCliente.Click += new System.EventHandler(this.buttonSelecionarCliente_Click);
            // 
            // buttonSelecionarPagamento
            // 
            this.buttonSelecionarPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionarPagamento.Location = new System.Drawing.Point(371, 249);
            this.buttonSelecionarPagamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelecionarPagamento.Name = "buttonSelecionarPagamento";
            this.buttonSelecionarPagamento.Size = new System.Drawing.Size(117, 31);
            this.buttonSelecionarPagamento.TabIndex = 15;
            this.buttonSelecionarPagamento.Text = "Selecionar";
            this.buttonSelecionarPagamento.UseVisualStyleBackColor = true;
            this.buttonSelecionarPagamento.Click += new System.EventHandler(this.buttonSelecionarPagamento_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Image = global::WindowsFormsAppGestaoHotel.Properties.Resources.save;
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(581, 396);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(135, 41);
            this.buttonSalvar.TabIndex = 16;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = global::WindowsFormsAppGestaoHotel.Properties.Resources.close;
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(727, 396);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(165, 41);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // funcionarioTextBox
            // 
            this.funcionarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diariaBindingSource, "Funcionario", true));
            this.funcionarioTextBox.Location = new System.Drawing.Point(224, 111);
            this.funcionarioTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.funcionarioTextBox.Name = "funcionarioTextBox";
            this.funcionarioTextBox.Size = new System.Drawing.Size(140, 22);
            this.funcionarioTextBox.TabIndex = 18;
            // 
            // id_ClienteTextBox
            // 
            this.id_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diariaBindingSource, "Nome_Cliente", true));
            this.id_ClienteTextBox.Location = new System.Drawing.Point(224, 180);
            this.id_ClienteTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_ClienteTextBox.Name = "id_ClienteTextBox";
            this.id_ClienteTextBox.Size = new System.Drawing.Size(140, 22);
            this.id_ClienteTextBox.TabIndex = 19;
            // 
            // id_PagamentoTextBox
            // 
            this.id_PagamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diariaBindingSource, "Pagamento", true));
            this.id_PagamentoTextBox.Location = new System.Drawing.Point(224, 251);
            this.id_PagamentoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_PagamentoTextBox.Name = "id_PagamentoTextBox";
            this.id_PagamentoTextBox.Size = new System.Drawing.Size(140, 22);
            this.id_PagamentoTextBox.TabIndex = 20;
            // 
            // data_EntradaDateTimePicker
            // 
            this.data_EntradaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.diariaBindingSource, "Data_Entrada", true));
            this.data_EntradaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_EntradaDateTimePicker.Location = new System.Drawing.Point(721, 114);
            this.data_EntradaDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_EntradaDateTimePicker.Name = "data_EntradaDateTimePicker";
            this.data_EntradaDateTimePicker.Size = new System.Drawing.Size(155, 22);
            this.data_EntradaDateTimePicker.TabIndex = 21;
            // 
            // data_SaidaDateTimePicker
            // 
            this.data_SaidaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.diariaBindingSource, "Data_Saida", true));
            this.data_SaidaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_SaidaDateTimePicker.Location = new System.Drawing.Point(717, 183);
            this.data_SaidaDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_SaidaDateTimePicker.Name = "data_SaidaDateTimePicker";
            this.data_SaidaDateTimePicker.Size = new System.Drawing.Size(159, 22);
            this.data_SaidaDateTimePicker.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartosBindingSource, "Numero", true));
            this.textBox1.Location = new System.Drawing.Point(224, 316);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 22);
            this.textBox1.TabIndex = 26;
            // 
            // buttonSelecionarQuarto
            // 
            this.buttonSelecionarQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionarQuarto.Location = new System.Drawing.Point(371, 314);
            this.buttonSelecionarQuarto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelecionarQuarto.Name = "buttonSelecionarQuarto";
            this.buttonSelecionarQuarto.Size = new System.Drawing.Size(117, 31);
            this.buttonSelecionarQuarto.TabIndex = 25;
            this.buttonSelecionarQuarto.Text = "Selecionar";
            this.buttonSelecionarQuarto.UseVisualStyleBackColor = true;
            this.buttonSelecionarQuarto.Click += new System.EventHandler(this.buttonSelecionarQuarto_Click_1);
            // 
            // quartosBindingSource
            // 
            this.quartosBindingSource.DataMember = "Quartos";
            this.quartosBindingSource.DataSource = this.diariaBindingSource;
            // 
            // FormCadastroDiaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(907, 447);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonSelecionarQuarto);
            this.Controls.Add(label1);
            this.Controls.Add(this.data_SaidaDateTimePicker);
            this.Controls.Add(this.data_EntradaDateTimePicker);
            this.Controls.Add(this.id_PagamentoTextBox);
            this.Controls.Add(this.id_ClienteTextBox);
            this.Controls.Add(this.funcionarioTextBox);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonSelecionarPagamento);
            this.Controls.Add(this.buttonSelecionarCliente);
            this.Controls.Add(this.buttonSelecionarFuncionario);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(valor_TotalLabel);
            this.Controls.Add(this.valor_TotalTextBox);
            this.Controls.Add(id_PagamentoLabel);
            this.Controls.Add(id_funcionarioLabel);
            this.Controls.Add(id_clienteLabel);
            this.Controls.Add(data_SaidaLabel);
            this.Controls.Add(data_EntradaLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(925, 494);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(925, 494);
            this.Name = "FormCadastroDiaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Diaria";
            this.Load += new System.EventHandler(this.FormCadastroDiaria_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadastroDiaria_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.diariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource diariaBindingSource;
        private System.Windows.Forms.TextBox valor_TotalTextBox;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Button buttonSelecionarFuncionario;
        private System.Windows.Forms.Button buttonSelecionarCliente;
        private System.Windows.Forms.Button buttonSelecionarPagamento;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox funcionarioTextBox;
        private System.Windows.Forms.TextBox id_ClienteTextBox;
        private System.Windows.Forms.TextBox id_PagamentoTextBox;
        private System.Windows.Forms.DateTimePicker data_EntradaDateTimePicker;
        private System.Windows.Forms.DateTimePicker data_SaidaDateTimePicker;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSelecionarQuarto;
        private System.Windows.Forms.BindingSource quartosBindingSource;
    }
}