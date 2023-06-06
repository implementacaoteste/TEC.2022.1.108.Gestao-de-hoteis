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
            // data_VencimentoLabel
            // 
            data_VencimentoLabel.AutoSize = true;
            data_VencimentoLabel.Location = new System.Drawing.Point(297, 124);
            data_VencimentoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            data_VencimentoLabel.Name = "data_VencimentoLabel";
            data_VencimentoLabel.Size = new System.Drawing.Size(92, 13);
            data_VencimentoLabel.TabIndex = 1;
            data_VencimentoLabel.Text = "Data Vencimento:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(327, 156);
            descricaoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(58, 13);
            descricaoLabel.TabIndex = 2;
            descricaoLabel.Text = "Descrição:";
            // 
            // id_ClienteLabel
            // 
            id_ClienteLabel.AutoSize = true;
            id_ClienteLabel.Location = new System.Drawing.Point(9, 126);
            id_ClienteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            id_ClienteLabel.Name = "id_ClienteLabel";
            id_ClienteLabel.Size = new System.Drawing.Size(73, 13);
            id_ClienteLabel.TabIndex = 4;
            id_ClienteLabel.Text = "Nome Cliente:";
            // 
            // id_FuncionarioLabel
            // 
            id_FuncionarioLabel.AutoSize = true;
            id_FuncionarioLabel.Location = new System.Drawing.Point(7, 158);
            id_FuncionarioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            id_FuncionarioLabel.Name = "id_FuncionarioLabel";
            id_FuncionarioLabel.Size = new System.Drawing.Size(65, 13);
            id_FuncionarioLabel.TabIndex = 6;
            id_FuncionarioLabel.Text = "Funcionario:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(46, 197);
            valorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 8;
            valorLabel.Text = "Valor:";
            // 
            // receberLabel
            // 
            receberLabel.AutoSize = true;
            receberLabel.Location = new System.Drawing.Point(334, 195);
            receberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            receberLabel.Name = "receberLabel";
            receberLabel.Size = new System.Drawing.Size(51, 13);
            receberLabel.TabIndex = 10;
            receberLabel.Text = "Receber:";
            // 
            // contasReceberBindingSource
            // 
            this.contasReceberBindingSource.DataSource = typeof(Models.ContasReceber);
            // 
            // data_VencimentoDateTimePicker
            // 
            this.data_VencimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contasReceberBindingSource, "Data_Vencimento", true));
            this.data_VencimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_VencimentoDateTimePicker.Location = new System.Drawing.Point(386, 121);
            this.data_VencimentoDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.data_VencimentoDateTimePicker.Name = "data_VencimentoDateTimePicker";
            this.data_VencimentoDateTimePicker.Size = new System.Drawing.Size(118, 20);
            this.data_VencimentoDateTimePicker.TabIndex = 2;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(386, 154);
            this.descricaoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(178, 20);
            this.descricaoTextBox.TabIndex = 3;
            // 
            // id_ClienteTextBox
            // 
            this.id_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "Id_Cliente", true));
            this.id_ClienteTextBox.Location = new System.Drawing.Point(82, 124);
            this.id_ClienteTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.id_ClienteTextBox.Name = "id_ClienteTextBox";
            this.id_ClienteTextBox.Size = new System.Drawing.Size(76, 20);
            this.id_ClienteTextBox.TabIndex = 5;
            // 
            // id_FuncionarioTextBox
            // 
            this.id_FuncionarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "Id_Funcionario", true));
            this.id_FuncionarioTextBox.Location = new System.Drawing.Point(82, 156);
            this.id_FuncionarioTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.id_FuncionarioTextBox.Name = "id_FuncionarioTextBox";
            this.id_FuncionarioTextBox.Size = new System.Drawing.Size(76, 20);
            this.id_FuncionarioTextBox.TabIndex = 7;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(82, 195);
            this.valorTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(76, 20);
            this.valorTextBox.TabIndex = 9;
            // 
            // receberCheckBox
            // 
            this.receberCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.contasReceberBindingSource, "Receber", true));
            this.receberCheckBox.Location = new System.Drawing.Point(386, 191);
            this.receberCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.receberCheckBox.Name = "receberCheckBox";
            this.receberCheckBox.Size = new System.Drawing.Size(78, 20);
            this.receberCheckBox.TabIndex = 11;
            this.receberCheckBox.UseVisualStyleBackColor = true;
            // 
            // buttonSelecionarCli
            // 
            this.buttonSelecionarCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(234)))), ((int)(((byte)(205)))));
            this.buttonSelecionarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelecionarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionarCli.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelecionarCli.Image")));
            this.buttonSelecionarCli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelecionarCli.Location = new System.Drawing.Point(170, 124);
            this.buttonSelecionarCli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSelecionarCli.Name = "buttonSelecionarCli";
            this.buttonSelecionarCli.Size = new System.Drawing.Size(115, 26);
            this.buttonSelecionarCli.TabIndex = 12;
            this.buttonSelecionarCli.Text = "Selecionar";
            this.buttonSelecionarCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSelecionarCli.UseVisualStyleBackColor = false;
            this.buttonSelecionarCli.Click += new System.EventHandler(this.buttonSelecionarCli_Click);
            // 
            // buttonSelecionarFun
            // 
            this.buttonSelecionarFun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(234)))), ((int)(((byte)(205)))));
            this.buttonSelecionarFun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelecionarFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionarFun.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelecionarFun.Image")));
            this.buttonSelecionarFun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelecionarFun.Location = new System.Drawing.Point(170, 154);
            this.buttonSelecionarFun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSelecionarFun.Name = "buttonSelecionarFun";
            this.buttonSelecionarFun.Size = new System.Drawing.Size(115, 26);
            this.buttonSelecionarFun.TabIndex = 12;
            this.buttonSelecionarFun.Text = "Selecionar";
            this.buttonSelecionarFun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSelecionarFun.UseVisualStyleBackColor = false;
            this.buttonSelecionarFun.Click += new System.EventHandler(this.buttonSelecionarFun_Click);
            // 
            // labelContasReceber
            // 
            this.labelContasReceber.AutoSize = true;
            this.labelContasReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContasReceber.Location = new System.Drawing.Point(146, 36);
            this.labelContasReceber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContasReceber.Name = "labelContasReceber";
            this.labelContasReceber.Size = new System.Drawing.Size(273, 37);
            this.labelContasReceber.TabIndex = 13;
            this.labelContasReceber.Text = "Contas a Receber";
            this.labelContasReceber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(183)))), ((int)(((byte)(219)))));
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Image = global::WindowsFormsAppGestaoHotel.Properties.Resources.save_bk;
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(351, 322);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(110, 33);
            this.buttonSalvar.TabIndex = 14;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = global::WindowsFormsAppGestaoHotel.Properties.Resources.close_bk;
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(469, 322);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(120, 33);
            this.buttonCancelar.TabIndex = 15;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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