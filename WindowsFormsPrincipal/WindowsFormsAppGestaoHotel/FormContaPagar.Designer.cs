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
            System.Windows.Forms.Label pagarLabel;
            System.Windows.Forms.Label valorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContaPagar));
            this.tituloLabel = new System.Windows.Forms.Label();
            this.data_VencimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.contasPagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.id_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.id_FuncionarioTextBox = new System.Windows.Forms.TextBox();
            this.pagarCheckBox = new System.Windows.Forms.CheckBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.buttonSelecionar_funcionario = new System.Windows.Forms.Button();
            this.buttonSelecionar_cliente = new System.Windows.Forms.Button();
            this.buttonCancelarCadastro = new System.Windows.Forms.Button();
            this.buttonSalvarFuncionario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            data_VencimentoLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            id_ClienteLabel = new System.Windows.Forms.Label();
            id_FuncionarioLabel = new System.Windows.Forms.Label();
            pagarLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contasPagarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // data_VencimentoLabel
            // 
            data_VencimentoLabel.AutoSize = true;
            data_VencimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_VencimentoLabel.Location = new System.Drawing.Point(11, 87);
            data_VencimentoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            data_VencimentoLabel.Name = "data_VencimentoLabel";
            data_VencimentoLabel.Size = new System.Drawing.Size(143, 20);
            data_VencimentoLabel.TabIndex = 40;
            data_VencimentoLabel.Text = "Data Vencimento:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.Location = new System.Drawing.Point(63, 122);
            descricaoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(91, 20);
            descricaoLabel.TabIndex = 41;
            descricaoLabel.Text = "Descrição:";
            // 
            // id_ClienteLabel
            // 
            id_ClienteLabel.AutoSize = true;
            id_ClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_ClienteLabel.Location = new System.Drawing.Point(24, 165);
            id_ClienteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            id_ClienteLabel.Name = "id_ClienteLabel";
            id_ClienteLabel.Size = new System.Drawing.Size(130, 20);
            id_ClienteLabel.TabIndex = 42;
            id_ClienteLabel.Text = "Nome Hospede:";
            // 
            // id_FuncionarioLabel
            // 
            id_FuncionarioLabel.AutoSize = true;
            id_FuncionarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_FuncionarioLabel.Location = new System.Drawing.Point(4, 210);
            id_FuncionarioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            id_FuncionarioLabel.Name = "id_FuncionarioLabel";
            id_FuncionarioLabel.Size = new System.Drawing.Size(150, 20);
            id_FuncionarioLabel.TabIndex = 43;
            id_FuncionarioLabel.Text = "Nome Funcionario:";
            // 
            // pagarLabel
            // 
            pagarLabel.AutoSize = true;
            pagarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pagarLabel.Location = new System.Drawing.Point(430, 96);
            pagarLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            pagarLabel.Name = "pagarLabel";
            pagarLabel.Size = new System.Drawing.Size(47, 18);
            pagarLabel.TabIndex = 44;
            pagarLabel.Text = "Pago:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorLabel.Location = new System.Drawing.Point(434, 135);
            valorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(46, 18);
            valorLabel.TabIndex = 45;
            valorLabel.Text = "Valor:";
            // 
            // tituloLabel
            // 
            this.tituloLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.tituloLabel.Location = new System.Drawing.Point(0, 0);
            this.tituloLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(676, 55);
            this.tituloLabel.TabIndex = 30;
            this.tituloLabel.Text = "Nova Conta";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // data_VencimentoDateTimePicker
            // 
            this.data_VencimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contasPagarBindingSource, "Data_Vencimento", true));
            this.data_VencimentoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_VencimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_VencimentoDateTimePicker.Location = new System.Drawing.Point(163, 83);
            this.data_VencimentoDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.data_VencimentoDateTimePicker.Name = "data_VencimentoDateTimePicker";
            this.data_VencimentoDateTimePicker.Size = new System.Drawing.Size(119, 24);
            this.data_VencimentoDateTimePicker.TabIndex = 41;
            // 
            // contasPagarBindingSource
            // 
            this.contasPagarBindingSource.DataSource = typeof(Models.ContasPagar);
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasPagarBindingSource, "Descricao", true));
            this.descricaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTextBox.Location = new System.Drawing.Point(163, 122);
            this.descricaoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(212, 23);
            this.descricaoTextBox.TabIndex = 42;
            // 
            // id_ClienteTextBox
            // 
            this.id_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasPagarBindingSource, "Id_Cliente", true));
            this.id_ClienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_ClienteTextBox.Location = new System.Drawing.Point(163, 164);
            this.id_ClienteTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.id_ClienteTextBox.Name = "id_ClienteTextBox";
            this.id_ClienteTextBox.Size = new System.Drawing.Size(119, 23);
            this.id_ClienteTextBox.TabIndex = 43;
            // 
            // id_FuncionarioTextBox
            // 
            this.id_FuncionarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasPagarBindingSource, "Id_Funcionario", true));
            this.id_FuncionarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_FuncionarioTextBox.Location = new System.Drawing.Point(163, 207);
            this.id_FuncionarioTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.id_FuncionarioTextBox.Name = "id_FuncionarioTextBox";
            this.id_FuncionarioTextBox.Size = new System.Drawing.Size(119, 23);
            this.id_FuncionarioTextBox.TabIndex = 44;
            // 
            // pagarCheckBox
            // 
            this.pagarCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.contasPagarBindingSource, "Pagar", true));
            this.pagarCheckBox.Location = new System.Drawing.Point(484, 97);
            this.pagarCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.pagarCheckBox.Name = "pagarCheckBox";
            this.pagarCheckBox.Size = new System.Drawing.Size(78, 20);
            this.pagarCheckBox.TabIndex = 45;
            this.pagarCheckBox.UseVisualStyleBackColor = true;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasPagarBindingSource, "Valor", true));
            this.valorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTextBox.Location = new System.Drawing.Point(484, 133);
            this.valorTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(76, 23);
            this.valorTextBox.TabIndex = 46;
            // 
            // buttonSelecionar_funcionario
            // 
            this.buttonSelecionar_funcionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelecionar_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionar_funcionario.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelecionar_funcionario.Image")));
            this.buttonSelecionar_funcionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelecionar_funcionario.Location = new System.Drawing.Point(295, 205);
            this.buttonSelecionar_funcionario.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelecionar_funcionario.Name = "buttonSelecionar_funcionario";
            this.buttonSelecionar_funcionario.Size = new System.Drawing.Size(115, 26);
            this.buttonSelecionar_funcionario.TabIndex = 39;
            this.buttonSelecionar_funcionario.Text = "Selecionar";
            this.buttonSelecionar_funcionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSelecionar_funcionario.UseVisualStyleBackColor = true;
            this.buttonSelecionar_funcionario.Click += new System.EventHandler(this.buttonSelecionar_funcionario_Click);
            // 
            // buttonSelecionar_cliente
            // 
            this.buttonSelecionar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelecionar_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionar_cliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelecionar_cliente.Image")));
            this.buttonSelecionar_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelecionar_cliente.Location = new System.Drawing.Point(295, 162);
            this.buttonSelecionar_cliente.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelecionar_cliente.Name = "buttonSelecionar_cliente";
            this.buttonSelecionar_cliente.Size = new System.Drawing.Size(115, 26);
            this.buttonSelecionar_cliente.TabIndex = 39;
            this.buttonSelecionar_cliente.Text = "Selecionar";
            this.buttonSelecionar_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSelecionar_cliente.UseVisualStyleBackColor = true;
            this.buttonSelecionar_cliente.Click += new System.EventHandler(this.buttonSelecionar_cliente_Click);
            // 
            // buttonCancelarCadastro
            // 
            this.buttonCancelarCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCancelarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonCancelarCadastro.Image = global::WindowsFormsAppGestaoHotel.Properties.Resources.close_bk;
            this.buttonCancelarCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelarCadastro.Location = new System.Drawing.Point(543, 243);
            this.buttonCancelarCadastro.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCancelarCadastro.MinimumSize = new System.Drawing.Size(98, 28);
            this.buttonCancelarCadastro.Name = "buttonCancelarCadastro";
            this.buttonCancelarCadastro.Size = new System.Drawing.Size(124, 32);
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
            this.buttonSalvarFuncionario.Image = global::WindowsFormsAppGestaoHotel.Properties.Resources.save_bk;
            this.buttonSalvarFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvarFuncionario.Location = new System.Drawing.Point(433, 243);
            this.buttonSalvarFuncionario.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSalvarFuncionario.Name = "buttonSalvarFuncionario";
            this.buttonSalvarFuncionario.Size = new System.Drawing.Size(101, 32);
            this.buttonSalvarFuncionario.TabIndex = 31;
            this.buttonSalvarFuncionario.Text = "Salvar";
            this.buttonSalvarFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalvarFuncionario.UseVisualStyleBackColor = false;
            this.buttonSalvarFuncionario.Click += new System.EventHandler(this.buttonSalvarFuncionario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 47;
            // 
            // FormContaPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 284);
            this.Controls.Add(this.label1);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(pagarLabel);
            this.Controls.Add(this.pagarCheckBox);
            this.Controls.Add(id_FuncionarioLabel);
            this.Controls.Add(this.id_FuncionarioTextBox);
            this.Controls.Add(id_ClienteLabel);
            this.Controls.Add(this.id_ClienteTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(data_VencimentoLabel);
            this.Controls.Add(this.data_VencimentoDateTimePicker);
            this.Controls.Add(this.buttonSelecionar_funcionario);
            this.Controls.Add(this.buttonSelecionar_cliente);
            this.Controls.Add(this.buttonCancelarCadastro);
            this.Controls.Add(this.buttonSalvarFuncionario);
            this.Controls.Add(this.tituloLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormContaPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conta";
            this.Load += new System.EventHandler(this.FormContaPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contasPagarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Button buttonCancelarCadastro;
        private System.Windows.Forms.Button buttonSalvarFuncionario;
        private System.Windows.Forms.Button buttonSelecionar_cliente;
        private System.Windows.Forms.Button buttonSelecionar_funcionario;
        private System.Windows.Forms.BindingSource contasPagarBindingSource;
        private System.Windows.Forms.DateTimePicker data_VencimentoDateTimePicker;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox id_ClienteTextBox;
        private System.Windows.Forms.TextBox id_FuncionarioTextBox;
        private System.Windows.Forms.CheckBox pagarCheckBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.Label label1;
    }
}