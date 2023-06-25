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
            this.pagarCheckBox = new System.Windows.Forms.CheckBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.buttonSelecionar_funcionario = new System.Windows.Forms.Button();
            this.buttonSelecionar_cliente = new System.Windows.Forms.Button();
            this.buttonCancelarCadastro = new System.Windows.Forms.Button();
            this.buttonSalvarFuncionario = new System.Windows.Forms.Button();
            this.nome_HospedeLabelHosp = new System.Windows.Forms.Label();
            this.nome_funcionarioLabelNome = new System.Windows.Forms.Label();
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
            data_VencimentoLabel.Size = new System.Drawing.Size(125, 18);
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
            descricaoLabel.Size = new System.Drawing.Size(80, 18);
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
            id_ClienteLabel.Size = new System.Drawing.Size(117, 18);
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
            id_FuncionarioLabel.Size = new System.Drawing.Size(135, 18);
            id_FuncionarioLabel.TabIndex = 43;
            id_FuncionarioLabel.Text = "Nome Funcionario:";
            // 
            // pagarLabel
            // 
            pagarLabel.AutoSize = true;
            pagarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pagarLabel.Location = new System.Drawing.Point(444, 89);
            pagarLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            pagarLabel.Name = "pagarLabel";
            pagarLabel.Size = new System.Drawing.Size(45, 17);
            pagarLabel.TabIndex = 44;
            pagarLabel.Text = "Pago:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorLabel.Location = new System.Drawing.Point(444, 135);
            valorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(45, 17);
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
            this.tituloLabel.Size = new System.Drawing.Size(687, 55);
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
            this.data_VencimentoDateTimePicker.Size = new System.Drawing.Size(119, 22);
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
            this.descricaoTextBox.Size = new System.Drawing.Size(212, 21);
            this.descricaoTextBox.TabIndex = 42;
            // 
            // pagarCheckBox
            // 
            this.pagarCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.contasPagarBindingSource, "Pagar", true));
            this.pagarCheckBox.Location = new System.Drawing.Point(498, 90);
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
            this.valorTextBox.Location = new System.Drawing.Point(494, 133);
            this.valorTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(76, 21);
            this.valorTextBox.TabIndex = 46;
            // 
            // buttonSelecionar_funcionario
            // 
            this.buttonSelecionar_funcionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(234)))), ((int)(((byte)(205)))));
            this.buttonSelecionar_funcionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelecionar_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionar_funcionario.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelecionar_funcionario.Image")));
            this.buttonSelecionar_funcionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelecionar_funcionario.Location = new System.Drawing.Point(290, 207);
            this.buttonSelecionar_funcionario.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelecionar_funcionario.Name = "buttonSelecionar_funcionario";
            this.buttonSelecionar_funcionario.Size = new System.Drawing.Size(115, 26);
            this.buttonSelecionar_funcionario.TabIndex = 39;
            this.buttonSelecionar_funcionario.Text = "Selecionar";
            this.buttonSelecionar_funcionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSelecionar_funcionario.UseVisualStyleBackColor = false;
            this.buttonSelecionar_funcionario.Click += new System.EventHandler(this.buttonSelecionar_funcionario_Click);
            // 
            // buttonSelecionar_cliente
            // 
            this.buttonSelecionar_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(234)))), ((int)(((byte)(205)))));
            this.buttonSelecionar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelecionar_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionar_cliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelecionar_cliente.Image")));
            this.buttonSelecionar_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelecionar_cliente.Location = new System.Drawing.Point(290, 162);
            this.buttonSelecionar_cliente.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelecionar_cliente.Name = "buttonSelecionar_cliente";
            this.buttonSelecionar_cliente.Size = new System.Drawing.Size(115, 26);
            this.buttonSelecionar_cliente.TabIndex = 39;
            this.buttonSelecionar_cliente.Text = "Selecionar";
            this.buttonSelecionar_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSelecionar_cliente.UseVisualStyleBackColor = false;
            this.buttonSelecionar_cliente.Click += new System.EventHandler(this.buttonSelecionar_cliente_Click);
            // 
            // buttonCancelarCadastro
            // 
            this.buttonCancelarCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCancelarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCadastro.Image = global::WindowsFormsAppGestaoHotel.Properties.Resources.close_bk;
            this.buttonCancelarCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelarCadastro.Location = new System.Drawing.Point(547, 242);
            this.buttonCancelarCadastro.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCancelarCadastro.MinimumSize = new System.Drawing.Size(98, 28);
            this.buttonCancelarCadastro.Name = "buttonCancelarCadastro";
            this.buttonCancelarCadastro.Size = new System.Drawing.Size(120, 33);
            this.buttonCancelarCadastro.TabIndex = 32;
            this.buttonCancelarCadastro.Text = "Cancelar";
            this.buttonCancelarCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelarCadastro.UseVisualStyleBackColor = false;
            this.buttonCancelarCadastro.Click += new System.EventHandler(this.buttonCancelarCadastro_Click);
            // 
            // buttonSalvarFuncionario
            // 
            this.buttonSalvarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(183)))), ((int)(((byte)(219)))));
            this.buttonSalvarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarFuncionario.Image = global::WindowsFormsAppGestaoHotel.Properties.Resources.save_bk;
            this.buttonSalvarFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvarFuncionario.Location = new System.Drawing.Point(429, 242);
            this.buttonSalvarFuncionario.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSalvarFuncionario.Name = "buttonSalvarFuncionario";
            this.buttonSalvarFuncionario.Size = new System.Drawing.Size(110, 33);
            this.buttonSalvarFuncionario.TabIndex = 31;
            this.buttonSalvarFuncionario.Text = "Salvar";
            this.buttonSalvarFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalvarFuncionario.UseVisualStyleBackColor = false;
            this.buttonSalvarFuncionario.Click += new System.EventHandler(this.buttonSalvarFuncionario_Click);
            // 
            // nome_HospedeLabelHosp
            // 
            this.nome_HospedeLabelHosp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nome_HospedeLabelHosp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nome_HospedeLabelHosp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasPagarBindingSource, "Nome_Hospede", true));
            this.nome_HospedeLabelHosp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_HospedeLabelHosp.Location = new System.Drawing.Point(162, 166);
            this.nome_HospedeLabelHosp.Name = "nome_HospedeLabelHosp";
            this.nome_HospedeLabelHosp.Size = new System.Drawing.Size(120, 20);
            this.nome_HospedeLabelHosp.TabIndex = 48;
            this.nome_HospedeLabelHosp.Click += new System.EventHandler(this.nome_HospedeLabelHosp_Click);
            // 
            // nome_funcionarioLabelNome
            // 
            this.nome_funcionarioLabelNome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nome_funcionarioLabelNome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nome_funcionarioLabelNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasPagarBindingSource, "Nome_funcionario", true));
            this.nome_funcionarioLabelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_funcionarioLabelNome.Location = new System.Drawing.Point(162, 211);
            this.nome_funcionarioLabelNome.Name = "nome_funcionarioLabelNome";
            this.nome_funcionarioLabelNome.Size = new System.Drawing.Size(120, 20);
            this.nome_funcionarioLabelNome.TabIndex = 49;
            this.nome_funcionarioLabelNome.Click += new System.EventHandler(this.nome_funcionarioLabelNome_Click);
            // 
            // FormContaPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 296);
            this.Controls.Add(this.nome_funcionarioLabelNome);
            this.Controls.Add(this.nome_HospedeLabelHosp);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(pagarLabel);
            this.Controls.Add(this.pagarCheckBox);
            this.Controls.Add(id_FuncionarioLabel);
            this.Controls.Add(id_ClienteLabel);
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
        private System.Windows.Forms.CheckBox pagarCheckBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.Label nome_HospedeLabelHosp;
        private System.Windows.Forms.Label nome_funcionarioLabelNome;
    }
}