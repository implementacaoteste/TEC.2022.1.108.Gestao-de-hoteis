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
            System.Windows.Forms.Label data_VencimentoLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label id_ClienteLabel;
            System.Windows.Forms.Label id_FuncionarioLabel;
            System.Windows.Forms.Label valorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContaPagar));
            this.tituloLabel = new System.Windows.Forms.Label();
            this.data_VencimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.contasPagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.id_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.id_FuncionarioTextBox = new System.Windows.Forms.TextBox();
            this.pagarCheckBox = new System.Windows.Forms.CheckBox();
            this.buttonSelecionar_cliente = new System.Windows.Forms.Button();
            this.buttonCancelarCadastro = new System.Windows.Forms.Button();
            this.buttonSalvarFuncionario = new System.Windows.Forms.Button();
            this.textBoxDinheiro = new ComponentesDesktop.TextBoxDinheiro();
            data_VencimentoLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            id_ClienteLabel = new System.Windows.Forms.Label();
            id_FuncionarioLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contasPagarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // data_VencimentoLabel
            // 
            data_VencimentoLabel.AutoSize = true;
            data_VencimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_VencimentoLabel.Location = new System.Drawing.Point(320, 136);
            data_VencimentoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            data_VencimentoLabel.Name = "data_VencimentoLabel";
            data_VencimentoLabel.Size = new System.Drawing.Size(94, 20);
            data_VencimentoLabel.TabIndex = 10;
            data_VencimentoLabel.Text = "Vencimento";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.Location = new System.Drawing.Point(7, 74);
            descricaoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(80, 20);
            descricaoLabel.TabIndex = 1;
            descricaoLabel.Text = "Descrição";
            // 
            // id_ClienteLabel
            // 
            id_ClienteLabel.AutoSize = true;
            id_ClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_ClienteLabel.Location = new System.Drawing.Point(7, 136);
            id_ClienteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            id_ClienteLabel.Name = "id_ClienteLabel";
            id_ClienteLabel.Size = new System.Drawing.Size(74, 20);
            id_ClienteLabel.TabIndex = 3;
            id_ClienteLabel.Text = "Hóspede";
            // 
            // id_FuncionarioLabel
            // 
            id_FuncionarioLabel.AutoSize = true;
            id_FuncionarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_FuncionarioLabel.Location = new System.Drawing.Point(7, 194);
            id_FuncionarioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            id_FuncionarioLabel.Name = "id_FuncionarioLabel";
            id_FuncionarioLabel.Size = new System.Drawing.Size(92, 20);
            id_FuncionarioLabel.TabIndex = 6;
            id_FuncionarioLabel.Text = "Funcionário";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorLabel.Location = new System.Drawing.Point(320, 74);
            valorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(46, 20);
            valorLabel.TabIndex = 8;
            valorLabel.Text = "Valor";
            // 
            // tituloLabel
            // 
            this.tituloLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.tituloLabel.Location = new System.Drawing.Point(0, 0);
            this.tituloLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(476, 55);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "Cadastrar Conta à Pagar";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // data_VencimentoDateTimePicker
            // 
            this.data_VencimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contasPagarBindingSource, "Data_Vencimento", true));
            this.data_VencimentoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_VencimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_VencimentoDateTimePicker.Location = new System.Drawing.Point(324, 158);
            this.data_VencimentoDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.data_VencimentoDateTimePicker.Name = "data_VencimentoDateTimePicker";
            this.data_VencimentoDateTimePicker.Size = new System.Drawing.Size(140, 26);
            this.data_VencimentoDateTimePicker.TabIndex = 11;
            // 
            // contasPagarBindingSource
            // 
            this.contasPagarBindingSource.DataSource = typeof(Models.ContasPagar);
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasPagarBindingSource, "Descricao", true));
            this.descricaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTextBox.Location = new System.Drawing.Point(11, 98);
            this.descricaoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(210, 26);
            this.descricaoTextBox.TabIndex = 2;
            // 
            // id_ClienteTextBox
            // 
            this.id_ClienteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasPagarBindingSource, "Id_Hospede", true));
            this.id_ClienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_ClienteTextBox.Location = new System.Drawing.Point(11, 158);
            this.id_ClienteTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.id_ClienteTextBox.Name = "id_ClienteTextBox";
            this.id_ClienteTextBox.Size = new System.Drawing.Size(210, 26);
            this.id_ClienteTextBox.TabIndex = 4;
            // 
            // id_FuncionarioTextBox
            // 
            this.id_FuncionarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_FuncionarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasPagarBindingSource, "Id_Funcionario", true));
            this.id_FuncionarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_FuncionarioTextBox.Location = new System.Drawing.Point(11, 216);
            this.id_FuncionarioTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.id_FuncionarioTextBox.Name = "id_FuncionarioTextBox";
            this.id_FuncionarioTextBox.Size = new System.Drawing.Size(210, 26);
            this.id_FuncionarioTextBox.TabIndex = 7;
            // 
            // pagarCheckBox
            // 
            this.pagarCheckBox.AutoSize = true;
            this.pagarCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.contasPagarBindingSource, "Pagar", true));
            this.pagarCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagarCheckBox.Location = new System.Drawing.Point(324, 218);
            this.pagarCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pagarCheckBox.Name = "pagarCheckBox";
            this.pagarCheckBox.Size = new System.Drawing.Size(65, 24);
            this.pagarCheckBox.TabIndex = 12;
            this.pagarCheckBox.Text = "Pago";
            this.pagarCheckBox.UseVisualStyleBackColor = true;
            // 
            // buttonSelecionar_cliente
            // 
            this.buttonSelecionar_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(93)))), ((int)(((byte)(168)))));
            this.buttonSelecionar_cliente.FlatAppearance.BorderSize = 0;
            this.buttonSelecionar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelecionar_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionar_cliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelecionar_cliente.Image")));
            this.buttonSelecionar_cliente.Location = new System.Drawing.Point(228, 156);
            this.buttonSelecionar_cliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSelecionar_cliente.Name = "buttonSelecionar_cliente";
            this.buttonSelecionar_cliente.Size = new System.Drawing.Size(30, 30);
            this.buttonSelecionar_cliente.TabIndex = 5;
            this.buttonSelecionar_cliente.UseVisualStyleBackColor = false;
            this.buttonSelecionar_cliente.Click += new System.EventHandler(this.buttonSelecionar_cliente_Click);
            // 
            // buttonCancelarCadastro
            // 
            this.buttonCancelarCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(77)))), ((int)(((byte)(87)))));
            this.buttonCancelarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelarCadastro.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCadastro.ForeColor = System.Drawing.Color.White;
            this.buttonCancelarCadastro.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelarCadastro.Image")));
            this.buttonCancelarCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelarCadastro.Location = new System.Drawing.Point(314, 288);
            this.buttonCancelarCadastro.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCancelarCadastro.MinimumSize = new System.Drawing.Size(98, 28);
            this.buttonCancelarCadastro.Name = "buttonCancelarCadastro";
            this.buttonCancelarCadastro.Size = new System.Drawing.Size(150, 33);
            this.buttonCancelarCadastro.TabIndex = 14;
            this.buttonCancelarCadastro.Text = "CANCELAR";
            this.buttonCancelarCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelarCadastro.UseVisualStyleBackColor = false;
            this.buttonCancelarCadastro.Click += new System.EventHandler(this.buttonCancelarCadastro_Click);
            // 
            // buttonSalvarFuncionario
            // 
            this.buttonSalvarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(179)))), ((int)(((byte)(122)))));
            this.buttonSalvarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvarFuncionario.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarFuncionario.ForeColor = System.Drawing.Color.White;
            this.buttonSalvarFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalvarFuncionario.Image")));
            this.buttonSalvarFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvarFuncionario.Location = new System.Drawing.Point(189, 288);
            this.buttonSalvarFuncionario.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSalvarFuncionario.Name = "buttonSalvarFuncionario";
            this.buttonSalvarFuncionario.Size = new System.Drawing.Size(120, 33);
            this.buttonSalvarFuncionario.TabIndex = 13;
            this.buttonSalvarFuncionario.Text = "SALVAR";
            this.buttonSalvarFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalvarFuncionario.UseVisualStyleBackColor = false;
            this.buttonSalvarFuncionario.Click += new System.EventHandler(this.buttonSalvarFuncionario_Click);
            // 
            // textBoxDinheiro
            // 
            this.textBoxDinheiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDinheiro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasPagarBindingSource, "Valor", true));
            this.textBoxDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxDinheiro.Location = new System.Drawing.Point(324, 99);
            this.textBoxDinheiro.Name = "textBoxDinheiro";
            this.textBoxDinheiro.Size = new System.Drawing.Size(140, 26);
            this.textBoxDinheiro.TabIndex = 9;
            this.textBoxDinheiro.Text = "R$ 0,00";
            this.textBoxDinheiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormContaPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(476, 330);
            this.Controls.Add(this.textBoxDinheiro);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.pagarCheckBox);
            this.Controls.Add(id_FuncionarioLabel);
            this.Controls.Add(this.id_FuncionarioTextBox);
            this.Controls.Add(id_ClienteLabel);
            this.Controls.Add(this.id_ClienteTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(data_VencimentoLabel);
            this.Controls.Add(this.data_VencimentoDateTimePicker);
            this.Controls.Add(this.buttonSelecionar_cliente);
            this.Controls.Add(this.buttonCancelarCadastro);
            this.Controls.Add(this.buttonSalvarFuncionario);
            this.Controls.Add(this.tituloLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormContaPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOTELOGIX - Cadastro de Conta à Pagar";
            this.Load += new System.EventHandler(this.FormContaPagar_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormContaPagar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.contasPagarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Button buttonCancelarCadastro;
        private System.Windows.Forms.Button buttonSalvarFuncionario;
        private System.Windows.Forms.Button buttonSelecionar_cliente;
        private System.Windows.Forms.BindingSource contasPagarBindingSource;
        private System.Windows.Forms.DateTimePicker data_VencimentoDateTimePicker;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox id_ClienteTextBox;
        private System.Windows.Forms.TextBox id_FuncionarioTextBox;
        private System.Windows.Forms.CheckBox pagarCheckBox;
        private ComponentesDesktop.TextBoxDinheiro textBoxDinheiro;
    }
}