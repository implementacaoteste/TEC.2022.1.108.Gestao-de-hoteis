namespace WindowsFormsAppGestaoHotel
{
    partial class FormBuscarDiaria
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label data_EntradaLabel;
            System.Windows.Forms.Label id_clienteLabel;
            System.Windows.Forms.Label id_funcionarioLabel;
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label valor_DiariaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarDiaria));
            this.radioButtonDT_EN = new System.Windows.Forms.RadioButton();
            this.radioButtonNome = new System.Windows.Forms.RadioButton();
            this.radioButtonCPF = new System.Windows.Forms.RadioButton();
            this.textBoxDt_En = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.diariaDataGridView = new System.Windows.Forms.DataGridView();
            this.diariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quartosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quartosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.data_EntradaTextBox = new System.Windows.Forms.TextBox();
            this.id_clienteTextBox = new System.Windows.Forms.TextBox();
            this.id_funcionarioTextBox = new System.Windows.Forms.TextBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.valor_DiariaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonADCDiaria = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonExcluirDiaria = new System.Windows.Forms.Button();
            this.buttonADCquarto = new System.Windows.Forms.Button();
            this.buttonExcluirQuarto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            data_EntradaLabel = new System.Windows.Forms.Label();
            id_clienteLabel = new System.Windows.Forms.Label();
            id_funcionarioLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            valor_DiariaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diariaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonDT_EN
            // 
            this.radioButtonDT_EN.AutoSize = true;
            this.radioButtonDT_EN.Location = new System.Drawing.Point(43, 12);
            this.radioButtonDT_EN.Name = "radioButtonDT_EN";
            this.radioButtonDT_EN.Size = new System.Drawing.Size(126, 20);
            this.radioButtonDT_EN.TabIndex = 0;
            this.radioButtonDT_EN.TabStop = true;
            this.radioButtonDT_EN.Text = "Data da Entrada";
            this.radioButtonDT_EN.UseVisualStyleBackColor = true;
            // 
            // radioButtonNome
            // 
            this.radioButtonNome.AutoSize = true;
            this.radioButtonNome.Location = new System.Drawing.Point(43, 88);
            this.radioButtonNome.Name = "radioButtonNome";
            this.radioButtonNome.Size = new System.Drawing.Size(65, 20);
            this.radioButtonNome.TabIndex = 0;
            this.radioButtonNome.TabStop = true;
            this.radioButtonNome.Text = "Nome";
            this.radioButtonNome.UseVisualStyleBackColor = true;
            // 
            // radioButtonCPF
            // 
            this.radioButtonCPF.AutoSize = true;
            this.radioButtonCPF.Location = new System.Drawing.Point(166, 88);
            this.radioButtonCPF.Name = "radioButtonCPF";
            this.radioButtonCPF.Size = new System.Drawing.Size(54, 20);
            this.radioButtonCPF.TabIndex = 0;
            this.radioButtonCPF.TabStop = true;
            this.radioButtonCPF.Text = "CPF";
            this.radioButtonCPF.UseVisualStyleBackColor = true;
            // 
            // textBoxDt_En
            // 
            this.textBoxDt_En.Location = new System.Drawing.Point(43, 51);
            this.textBoxDt_En.Name = "textBoxDt_En";
            this.textBoxDt_En.Size = new System.Drawing.Size(226, 22);
            this.textBoxDt_En.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(43, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(226, 22);
            this.textBox2.TabIndex = 2;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(285, 128);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 3;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // diariaDataGridView
            // 
            this.diariaDataGridView.AllowUserToAddRows = false;
            this.diariaDataGridView.AllowUserToDeleteRows = false;
            this.diariaDataGridView.AllowUserToOrderColumns = true;
            this.diariaDataGridView.AutoGenerateColumns = false;
            this.diariaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.diariaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.diariaDataGridView.DataSource = this.diariaBindingSource;
            this.diariaDataGridView.Location = new System.Drawing.Point(11, 189);
            this.diariaDataGridView.Name = "diariaDataGridView";
            this.diariaDataGridView.ReadOnly = true;
            this.diariaDataGridView.RowHeadersWidth = 51;
            this.diariaDataGridView.RowTemplate.Height = 24;
            this.diariaDataGridView.Size = new System.Drawing.Size(600, 220);
            this.diariaDataGridView.TabIndex = 7;
            // 
            // diariaBindingSource
            // 
            this.diariaBindingSource.DataSource = typeof(Models.Diaria);
            // 
            // quartosBindingSource
            // 
            this.quartosBindingSource.DataMember = "Quartos";
            this.quartosBindingSource.DataSource = this.diariaBindingSource;
            // 
            // quartosDataGridView
            // 
            this.quartosDataGridView.AllowUserToAddRows = false;
            this.quartosDataGridView.AllowUserToDeleteRows = false;
            this.quartosDataGridView.AllowUserToOrderColumns = true;
            this.quartosDataGridView.AutoGenerateColumns = false;
            this.quartosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quartosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.quartosDataGridView.DataSource = this.quartosBindingSource;
            this.quartosDataGridView.Location = new System.Drawing.Point(629, 189);
            this.quartosDataGridView.Name = "quartosDataGridView";
            this.quartosDataGridView.ReadOnly = true;
            this.quartosDataGridView.RowHeadersWidth = 51;
            this.quartosDataGridView.RowTemplate.Height = 24;
            this.quartosDataGridView.Size = new System.Drawing.Size(428, 220);
            this.quartosDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Numero";
            this.dataGridViewTextBoxColumn7.HeaderText = "Número";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn9.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Valor_Diaria";
            this.dataGridViewTextBoxColumn10.HeaderText = "Valor da Diária";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.FillWeight = 35F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Cód.";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 55;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_cliente";
            this.dataGridViewTextBoxColumn2.FillWeight = 40F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 72;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Data_Entrada";
            this.dataGridViewTextBoxColumn4.FillWeight = 60F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Data da Entrada";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Id_funcionario";
            this.dataGridViewTextBoxColumn5.FillWeight = 50F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Funcionário";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Data_Saida";
            this.dataGridViewTextBoxColumn6.FillWeight = 60F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Data da Saida";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 193;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(40, 474);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(54, 16);
            idLabel.TabIndex = 8;
            idLabel.Text = "Código:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diariaBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(103, 474);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTextBox.TabIndex = 9;
            // 
            // data_EntradaLabel
            // 
            data_EntradaLabel.AutoSize = true;
            data_EntradaLabel.Location = new System.Drawing.Point(8, 533);
            data_EntradaLabel.Name = "data_EntradaLabel";
            data_EntradaLabel.Size = new System.Drawing.Size(89, 16);
            data_EntradaLabel.TabIndex = 10;
            data_EntradaLabel.Text = "Data Entrada:";
            // 
            // data_EntradaTextBox
            // 
            this.data_EntradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diariaBindingSource, "Data_Entrada", true));
            this.data_EntradaTextBox.Location = new System.Drawing.Point(103, 530);
            this.data_EntradaTextBox.Name = "data_EntradaTextBox";
            this.data_EntradaTextBox.Size = new System.Drawing.Size(309, 22);
            this.data_EntradaTextBox.TabIndex = 11;
            // 
            // id_clienteLabel
            // 
            id_clienteLabel.AutoSize = true;
            id_clienteLabel.Location = new System.Drawing.Point(43, 502);
            id_clienteLabel.Name = "id_clienteLabel";
            id_clienteLabel.Size = new System.Drawing.Size(51, 16);
            id_clienteLabel.TabIndex = 12;
            id_clienteLabel.Text = "Cliente:";
            // 
            // id_clienteTextBox
            // 
            this.id_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diariaBindingSource, "Id_cliente", true));
            this.id_clienteTextBox.Location = new System.Drawing.Point(103, 502);
            this.id_clienteTextBox.Name = "id_clienteTextBox";
            this.id_clienteTextBox.Size = new System.Drawing.Size(100, 22);
            this.id_clienteTextBox.TabIndex = 13;
            // 
            // id_funcionarioLabel
            // 
            id_funcionarioLabel.AutoSize = true;
            id_funcionarioLabel.Location = new System.Drawing.Point(209, 505);
            id_funcionarioLabel.Name = "id_funcionarioLabel";
            id_funcionarioLabel.Size = new System.Drawing.Size(80, 16);
            id_funcionarioLabel.TabIndex = 14;
            id_funcionarioLabel.Text = "Funcionário:";
            // 
            // id_funcionarioTextBox
            // 
            this.id_funcionarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diariaBindingSource, "Id_funcionario", true));
            this.id_funcionarioTextBox.Location = new System.Drawing.Point(295, 502);
            this.id_funcionarioTextBox.Name = "id_funcionarioTextBox";
            this.id_funcionarioTextBox.Size = new System.Drawing.Size(117, 22);
            this.id_funcionarioTextBox.TabIndex = 15;
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(649, 477);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(58, 16);
            numeroLabel.TabIndex = 16;
            numeroLabel.Text = "Número:";
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartosBindingSource, "Numero", true));
            this.numeroTextBox.Location = new System.Drawing.Point(713, 474);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(142, 22);
            this.numeroTextBox.TabIndex = 17;
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(635, 508);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(72, 16);
            descricaoLabel.TabIndex = 18;
            descricaoLabel.Text = "Descrição:";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartosBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(713, 505);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(142, 22);
            this.descricaoTextBox.TabIndex = 19;
            // 
            // valor_DiariaLabel
            // 
            valor_DiariaLabel.AutoSize = true;
            valor_DiariaLabel.Location = new System.Drawing.Point(607, 536);
            valor_DiariaLabel.Name = "valor_DiariaLabel";
            valor_DiariaLabel.Size = new System.Drawing.Size(100, 16);
            valor_DiariaLabel.TabIndex = 20;
            valor_DiariaLabel.Text = "Valor da Diária:";
            // 
            // valor_DiariaTextBox
            // 
            this.valor_DiariaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartosBindingSource, "Valor_Diaria", true));
            this.valor_DiariaTextBox.Location = new System.Drawing.Point(713, 533);
            this.valor_DiariaTextBox.Name = "valor_DiariaTextBox";
            this.valor_DiariaTextBox.Size = new System.Drawing.Size(142, 22);
            this.valor_DiariaTextBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Dados da Diária";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(634, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Dados do Quarto";
            // 
            // buttonADCDiaria
            // 
            this.buttonADCDiaria.Location = new System.Drawing.Point(19, 637);
            this.buttonADCDiaria.Name = "buttonADCDiaria";
            this.buttonADCDiaria.Size = new System.Drawing.Size(75, 23);
            this.buttonADCDiaria.TabIndex = 24;
            this.buttonADCDiaria.Text = "Adicionar";
            this.buttonADCDiaria.UseVisualStyleBackColor = true;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(97, 637);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(81, 23);
            this.buttonAlterar.TabIndex = 24;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            // 
            // buttonExcluirDiaria
            // 
            this.buttonExcluirDiaria.Location = new System.Drawing.Point(188, 637);
            this.buttonExcluirDiaria.Name = "buttonExcluirDiaria";
            this.buttonExcluirDiaria.Size = new System.Drawing.Size(81, 23);
            this.buttonExcluirDiaria.TabIndex = 24;
            this.buttonExcluirDiaria.Text = "Excluir";
            this.buttonExcluirDiaria.UseVisualStyleBackColor = true;
            // 
            // buttonADCquarto
            // 
            this.buttonADCquarto.Location = new System.Drawing.Point(884, 637);
            this.buttonADCquarto.Name = "buttonADCquarto";
            this.buttonADCquarto.Size = new System.Drawing.Size(81, 23);
            this.buttonADCquarto.TabIndex = 24;
            this.buttonADCquarto.Text = "Adicionar";
            this.buttonADCquarto.UseVisualStyleBackColor = true;
            // 
            // buttonExcluirQuarto
            // 
            this.buttonExcluirQuarto.Location = new System.Drawing.Point(975, 637);
            this.buttonExcluirQuarto.Name = "buttonExcluirQuarto";
            this.buttonExcluirQuarto.Size = new System.Drawing.Size(81, 23);
            this.buttonExcluirQuarto.TabIndex = 24;
            this.buttonExcluirQuarto.Text = "Excluir";
            this.buttonExcluirQuarto.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Cadastro de Diária";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(638, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Quarto";
            // 
            // FormBuscarDiaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 685);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonExcluirQuarto);
            this.Controls.Add(this.buttonADCquarto);
            this.Controls.Add(this.buttonExcluirDiaria);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonADCDiaria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(valor_DiariaLabel);
            this.Controls.Add(this.valor_DiariaTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(numeroLabel);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(id_funcionarioLabel);
            this.Controls.Add(this.id_funcionarioTextBox);
            this.Controls.Add(id_clienteLabel);
            this.Controls.Add(this.id_clienteTextBox);
            this.Controls.Add(data_EntradaLabel);
            this.Controls.Add(this.data_EntradaTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.quartosDataGridView);
            this.Controls.Add(this.diariaDataGridView);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxDt_En);
            this.Controls.Add(this.radioButtonCPF);
            this.Controls.Add(this.radioButtonNome);
            this.Controls.Add(this.radioButtonDT_EN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBuscarDiaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Buscar de Diária";
            this.Load += new System.EventHandler(this.FormBuscarDiaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diariaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonDT_EN;
        private System.Windows.Forms.RadioButton radioButtonNome;
        private System.Windows.Forms.RadioButton radioButtonCPF;
        private System.Windows.Forms.TextBox textBoxDt_En;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.BindingSource diariaBindingSource;
        private System.Windows.Forms.DataGridView diariaDataGridView;
        private System.Windows.Forms.BindingSource quartosBindingSource;
        private System.Windows.Forms.DataGridView quartosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox data_EntradaTextBox;
        private System.Windows.Forms.TextBox id_clienteTextBox;
        private System.Windows.Forms.TextBox id_funcionarioTextBox;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox valor_DiariaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonADCDiaria;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonExcluirDiaria;
        private System.Windows.Forms.Button buttonADCquarto;
        private System.Windows.Forms.Button buttonExcluirQuarto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}