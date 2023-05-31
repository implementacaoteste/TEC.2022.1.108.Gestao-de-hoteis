namespace WindowsFormsAppGestaoHotel
{
    partial class FormContasReceber
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
            System.Windows.Forms.Label receberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContasReceber));
            this.contasReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_VencimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.id_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.id_FuncionarioTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.receberCheckBox = new System.Windows.Forms.CheckBox();
            this.buttonSelecionarCli = new System.Windows.Forms.Button();
            this.buttonSelecionarFun = new System.Windows.Forms.Button();
            this.labelContasReceber = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            data_VencimentoLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            id_ClienteLabel = new System.Windows.Forms.Label();
            id_FuncionarioLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            receberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contasReceberBindingSource
            // 
            this.contasReceberBindingSource.DataSource = typeof(Models.ContasReceber);
            // 
            // data_VencimentoLabel
            // 
            data_VencimentoLabel.AutoSize = true;
            data_VencimentoLabel.Location = new System.Drawing.Point(370, 153);
            data_VencimentoLabel.Name = "data_VencimentoLabel";
            data_VencimentoLabel.Size = new System.Drawing.Size(113, 16);
            data_VencimentoLabel.TabIndex = 1;
            data_VencimentoLabel.Text = "Data Vencimento:";
            // 
            // data_VencimentoDateTimePicker
            // 
            this.data_VencimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contasReceberBindingSource, "Data_Vencimento", true));
            this.data_VencimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_VencimentoDateTimePicker.Location = new System.Drawing.Point(489, 149);
            this.data_VencimentoDateTimePicker.Name = "data_VencimentoDateTimePicker";
            this.data_VencimentoDateTimePicker.Size = new System.Drawing.Size(156, 22);
            this.data_VencimentoDateTimePicker.TabIndex = 2;
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(411, 192);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(72, 16);
            descricaoLabel.TabIndex = 2;
            descricaoLabel.Text = "Descrição:";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(489, 189);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(236, 22);
            this.descricaoTextBox.TabIndex = 3;
            // 
            // id_ClienteLabel
            // 
            id_ClienteLabel.AutoSize = true;
            id_ClienteLabel.Location = new System.Drawing.Point(12, 155);
            id_ClienteLabel.Name = "id_ClienteLabel";
            id_ClienteLabel.Size = new System.Drawing.Size(91, 16);
            id_ClienteLabel.TabIndex = 4;
            id_ClienteLabel.Text = "Nome Cliente:";
            // 
            // id_ClienteTextBox
            // 
            this.id_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "Id_Cliente", true));
            this.id_ClienteTextBox.Location = new System.Drawing.Point(109, 152);
            this.id_ClienteTextBox.Name = "id_ClienteTextBox";
            this.id_ClienteTextBox.Size = new System.Drawing.Size(100, 22);
            this.id_ClienteTextBox.TabIndex = 5;
            // 
            // id_FuncionarioLabel
            // 
            id_FuncionarioLabel.AutoSize = true;
            id_FuncionarioLabel.Location = new System.Drawing.Point(9, 195);
            id_FuncionarioLabel.Name = "id_FuncionarioLabel";
            id_FuncionarioLabel.Size = new System.Drawing.Size(80, 16);
            id_FuncionarioLabel.TabIndex = 6;
            id_FuncionarioLabel.Text = "Funcionario:";
            // 
            // id_FuncionarioTextBox
            // 
            this.id_FuncionarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "Id_Funcionario", true));
            this.id_FuncionarioTextBox.Location = new System.Drawing.Point(109, 192);
            this.id_FuncionarioTextBox.Name = "id_FuncionarioTextBox";
            this.id_FuncionarioTextBox.Size = new System.Drawing.Size(100, 22);
            this.id_FuncionarioTextBox.TabIndex = 7;
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(61, 243);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(42, 16);
            valorLabel.TabIndex = 8;
            valorLabel.Text = "Valor:";
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(109, 240);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(100, 22);
            this.valorTextBox.TabIndex = 9;
            // 
            // receberLabel
            // 
            receberLabel.AutoSize = true;
            receberLabel.Location = new System.Drawing.Point(420, 240);
            receberLabel.Name = "receberLabel";
            receberLabel.Size = new System.Drawing.Size(63, 16);
            receberLabel.TabIndex = 10;
            receberLabel.Text = "Receber:";
            // 
            // receberCheckBox
            // 
            this.receberCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.contasReceberBindingSource, "Receber", true));
            this.receberCheckBox.Location = new System.Drawing.Point(489, 235);
            this.receberCheckBox.Name = "receberCheckBox";
            this.receberCheckBox.Size = new System.Drawing.Size(104, 24);
            this.receberCheckBox.TabIndex = 11;
            this.receberCheckBox.UseVisualStyleBackColor = true;
            // 
            // buttonSelecionarCli
            // 
            this.buttonSelecionarCli.Location = new System.Drawing.Point(227, 152);
            this.buttonSelecionarCli.Name = "buttonSelecionarCli";
            this.buttonSelecionarCli.Size = new System.Drawing.Size(119, 23);
            this.buttonSelecionarCli.TabIndex = 12;
            this.buttonSelecionarCli.Text = "Selecionar";
            this.buttonSelecionarCli.UseVisualStyleBackColor = true;
            this.buttonSelecionarCli.Click += new System.EventHandler(this.buttonSelecionarCli_Click);
            // 
            // buttonSelecionarFun
            // 
            this.buttonSelecionarFun.Location = new System.Drawing.Point(227, 189);
            this.buttonSelecionarFun.Name = "buttonSelecionarFun";
            this.buttonSelecionarFun.Size = new System.Drawing.Size(119, 23);
            this.buttonSelecionarFun.TabIndex = 12;
            this.buttonSelecionarFun.Text = "Selecionar";
            this.buttonSelecionarFun.UseVisualStyleBackColor = true;
            this.buttonSelecionarFun.Click += new System.EventHandler(this.buttonSelecionarFun_Click);
            // 
            // labelContasReceber
            // 
            this.labelContasReceber.AutoSize = true;
            this.labelContasReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContasReceber.Location = new System.Drawing.Point(195, 44);
            this.labelContasReceber.Name = "labelContasReceber";
            this.labelContasReceber.Size = new System.Drawing.Size(342, 46);
            this.labelContasReceber.TabIndex = 13;
            this.labelContasReceber.Text = "Contas a Receber";
            this.labelContasReceber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(650, 361);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 14;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(550, 361);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 15;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.labelContasReceber);
            this.Controls.Add(this.buttonSelecionarFun);
            this.Controls.Add(this.buttonSelecionarCli);
            this.Controls.Add(receberLabel);
            this.Controls.Add(this.receberCheckBox);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(id_FuncionarioLabel);
            this.Controls.Add(this.id_FuncionarioTextBox);
            this.Controls.Add(id_ClienteLabel);
            this.Controls.Add(this.id_ClienteTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(data_VencimentoLabel);
            this.Controls.Add(this.data_VencimentoDateTimePicker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormContasReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Contas a Receber";
            this.Load += new System.EventHandler(this.FormContasReceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource contasReceberBindingSource;
        private System.Windows.Forms.DateTimePicker data_VencimentoDateTimePicker;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox id_ClienteTextBox;
        private System.Windows.Forms.TextBox id_FuncionarioTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.CheckBox receberCheckBox;
        private System.Windows.Forms.Button buttonSelecionarCli;
        private System.Windows.Forms.Button buttonSelecionarFun;
        private System.Windows.Forms.Label labelContasReceber;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}