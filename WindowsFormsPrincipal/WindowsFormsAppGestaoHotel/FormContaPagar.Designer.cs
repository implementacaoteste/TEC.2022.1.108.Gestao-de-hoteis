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
            System.Windows.Forms.Label data_VencimentoLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label id_ClienteLabel;
            System.Windows.Forms.Label id_FuncionarioLabel;
            System.Windows.Forms.Label pagarLabel;
            System.Windows.Forms.Label valorLabel;
            this.tituloLabel = new System.Windows.Forms.Label();
            this.buttonCancelarCadastro = new System.Windows.Forms.Button();
            this.buttonSalvarFuncionario = new System.Windows.Forms.Button();
            this.contasPagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_VencimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.id_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.id_FuncionarioTextBox = new System.Windows.Forms.TextBox();
            this.pagarCheckBox = new System.Windows.Forms.CheckBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            data_VencimentoLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            id_ClienteLabel = new System.Windows.Forms.Label();
            id_FuncionarioLabel = new System.Windows.Forms.Label();
            pagarLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contasPagarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.tituloLabel.Location = new System.Drawing.Point(0, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(896, 68);
            this.tituloLabel.TabIndex = 30;
            this.tituloLabel.Text = "Nova Conta";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCancelarCadastro
            // 
            this.buttonCancelarCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCancelarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonCancelarCadastro.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelarCadastro.Image")));
            this.buttonCancelarCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelarCadastro.Location = new System.Drawing.Point(716, 289);
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
            this.buttonSalvarFuncionario.Location = new System.Drawing.Point(545, 289);
            this.buttonSalvarFuncionario.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSalvarFuncionario.Name = "buttonSalvarFuncionario";
            this.buttonSalvarFuncionario.Size = new System.Drawing.Size(135, 39);
            this.buttonSalvarFuncionario.TabIndex = 31;
            this.buttonSalvarFuncionario.Text = "Salvar";
            this.buttonSalvarFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalvarFuncionario.UseVisualStyleBackColor = false;
            this.buttonSalvarFuncionario.Click += new System.EventHandler(this.buttonSalvarFuncionario_Click);
            // 
            // contasPagarBindingSource
            // 
            this.contasPagarBindingSource.DataSource = typeof(Models.ContasPagar);
            // 
            // data_VencimentoLabel
            // 
            data_VencimentoLabel.AutoSize = true;
            data_VencimentoLabel.Location = new System.Drawing.Point(27, 116);
            data_VencimentoLabel.Name = "data_VencimentoLabel";
            data_VencimentoLabel.Size = new System.Drawing.Size(113, 16);
            data_VencimentoLabel.TabIndex = 32;
            data_VencimentoLabel.Text = "Data Vencimento:";
            // 
            // data_VencimentoDateTimePicker
            // 
            this.data_VencimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contasPagarBindingSource, "Data_Vencimento", true));
            this.data_VencimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_VencimentoDateTimePicker.Location = new System.Drawing.Point(146, 112);
            this.data_VencimentoDateTimePicker.Name = "data_VencimentoDateTimePicker";
            this.data_VencimentoDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.data_VencimentoDateTimePicker.TabIndex = 33;
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(68, 158);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(72, 16);
            descricaoLabel.TabIndex = 33;
            descricaoLabel.Text = "Descrição:";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasPagarBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(146, 155);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(100, 22);
            this.descricaoTextBox.TabIndex = 34;
            // 
            // id_ClienteLabel
            // 
            id_ClienteLabel.AutoSize = true;
            id_ClienteLabel.Location = new System.Drawing.Point(75, 204);
            id_ClienteLabel.Name = "id_ClienteLabel";
            id_ClienteLabel.Size = new System.Drawing.Size(65, 16);
            id_ClienteLabel.TabIndex = 34;
            id_ClienteLabel.Text = "Id Cliente:";
            // 
            // id_ClienteTextBox
            // 
            this.id_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasPagarBindingSource, "Id_Cliente", true));
            this.id_ClienteTextBox.Location = new System.Drawing.Point(146, 201);
            this.id_ClienteTextBox.Name = "id_ClienteTextBox";
            this.id_ClienteTextBox.Size = new System.Drawing.Size(100, 22);
            this.id_ClienteTextBox.TabIndex = 35;
            // 
            // id_FuncionarioLabel
            // 
            id_FuncionarioLabel.AutoSize = true;
            id_FuncionarioLabel.Location = new System.Drawing.Point(46, 250);
            id_FuncionarioLabel.Name = "id_FuncionarioLabel";
            id_FuncionarioLabel.Size = new System.Drawing.Size(94, 16);
            id_FuncionarioLabel.TabIndex = 35;
            id_FuncionarioLabel.Text = "Id Funcionario:";
            // 
            // id_FuncionarioTextBox
            // 
            this.id_FuncionarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasPagarBindingSource, "Id_Funcionario", true));
            this.id_FuncionarioTextBox.Location = new System.Drawing.Point(146, 247);
            this.id_FuncionarioTextBox.Name = "id_FuncionarioTextBox";
            this.id_FuncionarioTextBox.Size = new System.Drawing.Size(100, 22);
            this.id_FuncionarioTextBox.TabIndex = 36;
            // 
            // pagarLabel
            // 
            pagarLabel.AutoSize = true;
            pagarLabel.Location = new System.Drawing.Point(527, 119);
            pagarLabel.Name = "pagarLabel";
            pagarLabel.Size = new System.Drawing.Size(47, 16);
            pagarLabel.TabIndex = 36;
            pagarLabel.Text = "Pagar:";
            // 
            // pagarCheckBox
            // 
            this.pagarCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.contasPagarBindingSource, "Pagar", true));
            this.pagarCheckBox.Location = new System.Drawing.Point(580, 114);
            this.pagarCheckBox.Name = "pagarCheckBox";
            this.pagarCheckBox.Size = new System.Drawing.Size(104, 24);
            this.pagarCheckBox.TabIndex = 37;
            this.pagarCheckBox.UseVisualStyleBackColor = true;
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(532, 161);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(42, 16);
            valorLabel.TabIndex = 37;
            valorLabel.Text = "Valor:";
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasPagarBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(580, 158);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(100, 22);
            this.valorTextBox.TabIndex = 38;
            // 
            // FormContaPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 350);
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
            this.Controls.Add(this.buttonCancelarCadastro);
            this.Controls.Add(this.buttonSalvarFuncionario);
            this.Controls.Add(this.tituloLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormContaPagar";
            this.Text = "Conta";
            ((System.ComponentModel.ISupportInitialize)(this.contasPagarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Button buttonCancelarCadastro;
        private System.Windows.Forms.Button buttonSalvarFuncionario;
        private System.Windows.Forms.BindingSource contasPagarBindingSource;
        private System.Windows.Forms.DateTimePicker data_VencimentoDateTimePicker;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox id_ClienteTextBox;
        private System.Windows.Forms.TextBox id_FuncionarioTextBox;
        private System.Windows.Forms.CheckBox pagarCheckBox;
        private System.Windows.Forms.TextBox valorTextBox;
    }
}