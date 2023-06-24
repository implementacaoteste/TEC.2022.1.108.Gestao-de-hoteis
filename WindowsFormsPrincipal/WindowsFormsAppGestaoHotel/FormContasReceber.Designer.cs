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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContasReceber));
            this.data_VencimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.contasReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.id_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.FuncionarioTextBox = new System.Windows.Forms.TextBox();
            this.receberCheckBox = new System.Windows.Forms.CheckBox();
            this.buttonSelecionarHospede = new System.Windows.Forms.Button();
            this.labelContasReceber = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.valorTextBox = new ComponentesDesktop.TextBoxDinheiro();
            data_VencimentoLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            id_ClienteLabel = new System.Windows.Forms.Label();
            id_FuncionarioLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // data_VencimentoLabel
            // 
            data_VencimentoLabel.AutoSize = true;
            data_VencimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            data_VencimentoLabel.Location = new System.Drawing.Point(319, 139);
            data_VencimentoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            data_VencimentoLabel.Name = "data_VencimentoLabel";
            data_VencimentoLabel.Size = new System.Drawing.Size(94, 20);
            data_VencimentoLabel.TabIndex = 1;
            data_VencimentoLabel.Text = "Vencimento";
            data_VencimentoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            descricaoLabel.Location = new System.Drawing.Point(7, 74);
            descricaoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(80, 20);
            descricaoLabel.TabIndex = 2;
            descricaoLabel.Text = "Descrição";
            descricaoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id_ClienteLabel
            // 
            id_ClienteLabel.AutoSize = true;
            id_ClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            id_ClienteLabel.Location = new System.Drawing.Point(7, 139);
            id_ClienteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            id_ClienteLabel.Name = "id_ClienteLabel";
            id_ClienteLabel.Size = new System.Drawing.Size(74, 20);
            id_ClienteLabel.TabIndex = 4;
            id_ClienteLabel.Text = "Hóspede";
            id_ClienteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id_FuncionarioLabel
            // 
            id_FuncionarioLabel.AutoSize = true;
            id_FuncionarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            id_FuncionarioLabel.Location = new System.Drawing.Point(7, 204);
            id_FuncionarioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            id_FuncionarioLabel.Name = "id_FuncionarioLabel";
            id_FuncionarioLabel.Size = new System.Drawing.Size(92, 20);
            id_FuncionarioLabel.TabIndex = 6;
            id_FuncionarioLabel.Text = "Funcionário";
            id_FuncionarioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            valorLabel.Location = new System.Drawing.Point(319, 74);
            valorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(46, 20);
            valorLabel.TabIndex = 8;
            valorLabel.Text = "Valor";
            valorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // data_VencimentoDateTimePicker
            // 
            this.data_VencimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contasReceberBindingSource, "Data_Vencimento", true));
            this.data_VencimentoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.data_VencimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_VencimentoDateTimePicker.Location = new System.Drawing.Point(323, 161);
            this.data_VencimentoDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.data_VencimentoDateTimePicker.Name = "data_VencimentoDateTimePicker";
            this.data_VencimentoDateTimePicker.Size = new System.Drawing.Size(140, 26);
            this.data_VencimentoDateTimePicker.TabIndex = 4;
            // 
            // contasReceberBindingSource
            // 
            this.contasReceberBindingSource.DataSource = typeof(Models.ContasReceber);
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "Descricao", true));
            this.descricaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.descricaoTextBox.Location = new System.Drawing.Point(11, 96);
            this.descricaoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(210, 26);
            this.descricaoTextBox.TabIndex = 0;
            // 
            // id_ClienteTextBox
            // 
            this.id_ClienteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "Id_Hospede", true));
            this.id_ClienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.id_ClienteTextBox.Location = new System.Drawing.Point(11, 161);
            this.id_ClienteTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.id_ClienteTextBox.Name = "id_ClienteTextBox";
            this.id_ClienteTextBox.Size = new System.Drawing.Size(210, 26);
            this.id_ClienteTextBox.TabIndex = 1;
            // 
            // FuncionarioTextBox
            // 
            this.FuncionarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FuncionarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "Id_Funcionario", true));
            this.FuncionarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FuncionarioTextBox.Location = new System.Drawing.Point(11, 226);
            this.FuncionarioTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FuncionarioTextBox.Name = "FuncionarioTextBox";
            this.FuncionarioTextBox.Size = new System.Drawing.Size(210, 26);
            this.FuncionarioTextBox.TabIndex = 2;
            // 
            // receberCheckBox
            // 
            this.receberCheckBox.AutoSize = true;
            this.receberCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.contasReceberBindingSource, "Receber", true));
            this.receberCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.receberCheckBox.Location = new System.Drawing.Point(323, 226);
            this.receberCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.receberCheckBox.Name = "receberCheckBox";
            this.receberCheckBox.Size = new System.Drawing.Size(96, 24);
            this.receberCheckBox.TabIndex = 5;
            this.receberCheckBox.Text = "Recebido";
            this.receberCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.receberCheckBox.UseVisualStyleBackColor = true;
            // 
            // buttonSelecionarHospede
            // 
            this.buttonSelecionarHospede.BackColor = System.Drawing.Color.Transparent;
            this.buttonSelecionarHospede.FlatAppearance.BorderSize = 0;
            this.buttonSelecionarHospede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelecionarHospede.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSelecionarHospede.Image = global::WindowsFormsAppGestaoHotel.Properties.Resources.search_bk;
            this.buttonSelecionarHospede.Location = new System.Drawing.Point(229, 159);
            this.buttonSelecionarHospede.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelecionarHospede.Name = "buttonSelecionarHospede";
            this.buttonSelecionarHospede.Size = new System.Drawing.Size(30, 30);
            this.buttonSelecionarHospede.TabIndex = 12;
            this.buttonSelecionarHospede.UseVisualStyleBackColor = false;
            this.buttonSelecionarHospede.Click += new System.EventHandler(this.buttonSelecionarHospede_Click);
            // 
            // labelContasReceber
            // 
            this.labelContasReceber.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelContasReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContasReceber.Location = new System.Drawing.Point(0, 0);
            this.labelContasReceber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContasReceber.Name = "labelContasReceber";
            this.labelContasReceber.Size = new System.Drawing.Size(476, 65);
            this.labelContasReceber.TabIndex = 13;
            this.labelContasReceber.Text = "Cadastrar Conta à Receber";
            this.labelContasReceber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(179)))), ((int)(((byte)(122)))));
            this.buttonSalvar.FlatAppearance.BorderSize = 0;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.ForeColor = System.Drawing.Color.White;
            this.buttonSalvar.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalvar.Image")));
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(189, 286);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(120, 33);
            this.buttonSalvar.TabIndex = 6;
            this.buttonSalvar.Text = "SALVAR";
            this.buttonSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(77)))), ((int)(((byte)(87)))));
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(313, 286);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(150, 33);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // valorTextBox
            // 
            this.valorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "Valor", true));
            this.valorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.valorTextBox.Location = new System.Drawing.Point(323, 96);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(140, 26);
            this.valorTextBox.TabIndex = 3;
            this.valorTextBox.Text = "R$ 0,00";
            this.valorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(476, 330);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.labelContasReceber);
            this.Controls.Add(this.buttonSelecionarHospede);
            this.Controls.Add(this.receberCheckBox);
            this.Controls.Add(valorLabel);
            this.Controls.Add(id_FuncionarioLabel);
            this.Controls.Add(this.FuncionarioTextBox);
            this.Controls.Add(id_ClienteLabel);
            this.Controls.Add(this.id_ClienteTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(data_VencimentoLabel);
            this.Controls.Add(this.data_VencimentoDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(492, 390);
            this.MinimizeBox = false;
            this.Name = "FormContasReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOTELOGIX - Cadastro de Conta à Receber";
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
        private System.Windows.Forms.TextBox FuncionarioTextBox;
        private System.Windows.Forms.CheckBox receberCheckBox;
        private System.Windows.Forms.Button buttonSelecionarHospede;
        private System.Windows.Forms.Label labelContasReceber;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private ComponentesDesktop.TextBoxDinheiro valorTextBox;
    }
}