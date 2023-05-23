namespace WindowsFormsAppGestaoHotel
{
    partial class FormConsultaQuartoDisponivel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaQuartoDisponivel));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscarQuartoDisp = new System.Windows.Forms.Button();
            this.quartoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quartoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeQSair = new System.Windows.Forms.DateTimePicker();
            this.radioButtonHoje = new System.Windows.Forms.RadioButton();
            this.radioButtonPeriodo = new System.Windows.Forms.RadioButton();
            this.labelEntrada = new System.Windows.Forms.Label();
            this.labelSair = new System.Windows.Forms.Label();
            this.dateTimeQEntrar = new System.Windows.Forms.DateTimePicker();
            this.comboBoxClasse = new System.Windows.Forms.ComboBox();
            this.labelClasse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.21818F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1191, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quartos Disponiveis";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBuscarQuartoDisp
            // 
            this.buttonBuscarQuartoDisp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBuscarQuartoDisp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscarQuartoDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarQuartoDisp.Image = global::WindowsFormsAppGestaoHotel.Properties.Resources.search;
            this.buttonBuscarQuartoDisp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscarQuartoDisp.Location = new System.Drawing.Point(537, 114);
            this.buttonBuscarQuartoDisp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBuscarQuartoDisp.Name = "buttonBuscarQuartoDisp";
            this.buttonBuscarQuartoDisp.Size = new System.Drawing.Size(135, 41);
            this.buttonBuscarQuartoDisp.TabIndex = 2;
            this.buttonBuscarQuartoDisp.Text = "Buscar";
            this.buttonBuscarQuartoDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscarQuartoDisp.UseVisualStyleBackColor = false;
            this.buttonBuscarQuartoDisp.Click += new System.EventHandler(this.buttonBuscarQuartoDisp_Click);
            // 
            // quartoBindingSource
            // 
            this.quartoBindingSource.DataSource = typeof(Models.Quarto);
            // 
            // quartoDataGridView
            // 
            this.quartoDataGridView.AutoGenerateColumns = false;
            this.quartoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quartoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn5});
            this.quartoDataGridView.DataSource = this.quartoBindingSource;
            this.quartoDataGridView.Location = new System.Drawing.Point(16, 180);
            this.quartoDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quartoDataGridView.Name = "quartoDataGridView";
            this.quartoDataGridView.RowHeadersWidth = 47;
            this.quartoDataGridView.Size = new System.Drawing.Size(1160, 366);
            this.quartoDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Numero";
            this.dataGridViewTextBoxColumn2.HeaderText = "Numero";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Classe";
            this.dataGridViewTextBoxColumn4.HeaderText = "Classe";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Valor_Diaria";
            this.dataGridViewTextBoxColumn6.HeaderText = "Valor da diaria";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn8.HeaderText = "Status";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 110;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Andar";
            this.dataGridViewTextBoxColumn9.HeaderText = "Andar";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn5.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dateTimeQSair
            // 
            this.dateTimeQSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeQSair.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeQSair.Location = new System.Drawing.Point(581, 121);
            this.dateTimeQSair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeQSair.Name = "dateTimeQSair";
            this.dateTimeQSair.Size = new System.Drawing.Size(145, 29);
            this.dateTimeQSair.TabIndex = 1;
            this.dateTimeQSair.Visible = false;
            // 
            // radioButtonHoje
            // 
            this.radioButtonHoje.AutoSize = true;
            this.radioButtonHoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHoje.Location = new System.Drawing.Point(35, 120);
            this.radioButtonHoje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonHoje.Name = "radioButtonHoje";
            this.radioButtonHoje.Size = new System.Drawing.Size(73, 29);
            this.radioButtonHoje.TabIndex = 5;
            this.radioButtonHoje.TabStop = true;
            this.radioButtonHoje.Text = "Hoje";
            this.radioButtonHoje.UseVisualStyleBackColor = true;
            this.radioButtonHoje.CheckedChanged += new System.EventHandler(this.radioButtonHoje_CheckedChanged);
            // 
            // radioButtonPeriodo
            // 
            this.radioButtonPeriodo.AutoSize = true;
            this.radioButtonPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPeriodo.Location = new System.Drawing.Point(116, 120);
            this.radioButtonPeriodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonPeriodo.Name = "radioButtonPeriodo";
            this.radioButtonPeriodo.Size = new System.Drawing.Size(100, 29);
            this.radioButtonPeriodo.TabIndex = 6;
            this.radioButtonPeriodo.TabStop = true;
            this.radioButtonPeriodo.Text = "Período";
            this.radioButtonPeriodo.UseVisualStyleBackColor = true;
            this.radioButtonPeriodo.CheckedChanged += new System.EventHandler(this.radioButtonPeriodo_CheckedChanged);
            // 
            // labelEntrada
            // 
            this.labelEntrada.AutoSize = true;
            this.labelEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntrada.Location = new System.Drawing.Point(261, 124);
            this.labelEntrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEntrada.Name = "labelEntrada";
            this.labelEntrada.Size = new System.Drawing.Size(75, 24);
            this.labelEntrada.TabIndex = 7;
            this.labelEntrada.Text = "Entrada";
            this.labelEntrada.Visible = false;
            // 
            // labelSair
            // 
            this.labelSair.AutoSize = true;
            this.labelSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSair.Location = new System.Drawing.Point(508, 124);
            this.labelSair.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSair.Name = "labelSair";
            this.labelSair.Size = new System.Drawing.Size(62, 24);
            this.labelSair.TabIndex = 7;
            this.labelSair.Text = "Saída:";
            this.labelSair.Visible = false;
            // 
            // dateTimeQEntrar
            // 
            this.dateTimeQEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeQEntrar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeQEntrar.Location = new System.Drawing.Point(348, 121);
            this.dateTimeQEntrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeQEntrar.Name = "dateTimeQEntrar";
            this.dateTimeQEntrar.Size = new System.Drawing.Size(144, 29);
            this.dateTimeQEntrar.TabIndex = 1;
            this.dateTimeQEntrar.Visible = false;
            // 
            // comboBoxClasse
            // 
            this.comboBoxClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClasse.FormattingEnabled = true;
            this.comboBoxClasse.Items.AddRange(new object[] {
            "Standard",
            "Master",
            "Deluxe"});
            this.comboBoxClasse.Location = new System.Drawing.Point(348, 118);
            this.comboBoxClasse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxClasse.Name = "comboBoxClasse";
            this.comboBoxClasse.Size = new System.Drawing.Size(160, 32);
            this.comboBoxClasse.TabIndex = 8;
            // 
            // labelClasse
            // 
            this.labelClasse.AutoSize = true;
            this.labelClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClasse.Location = new System.Drawing.Point(263, 123);
            this.labelClasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClasse.Name = "labelClasse";
            this.labelClasse.Size = new System.Drawing.Size(71, 24);
            this.labelClasse.TabIndex = 7;
            this.labelClasse.Text = "Classe:";
            // 
            // FormConsultaQuartoDisponivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 560);
            this.Controls.Add(this.comboBoxClasse);
            this.Controls.Add(this.labelClasse);
            this.Controls.Add(this.labelSair);
            this.Controls.Add(this.labelEntrada);
            this.Controls.Add(this.radioButtonPeriodo);
            this.Controls.Add(this.radioButtonHoje);
            this.Controls.Add(this.quartoDataGridView);
            this.Controls.Add(this.buttonBuscarQuartoDisp);
            this.Controls.Add(this.dateTimeQEntrar);
            this.Controls.Add(this.dateTimeQSair);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormConsultaQuartoDisponivel";
            this.Text = "Consulta de Quartos disponíveis";
            this.Load += new System.EventHandler(this.FormConsultaQuartoDisponivel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscarQuartoDisp;
        private System.Windows.Forms.BindingSource quartoBindingSource;
        private System.Windows.Forms.DataGridView quartoDataGridView;
        private System.Windows.Forms.DateTimePicker dateTimeQSair;
        private System.Windows.Forms.RadioButton radioButtonHoje;
        private System.Windows.Forms.RadioButton radioButtonPeriodo;
        private System.Windows.Forms.Label labelEntrada;
        private System.Windows.Forms.Label labelSair;
        private System.Windows.Forms.DateTimePicker dateTimeQEntrar;
        private System.Windows.Forms.ComboBox comboBoxClasse;
        private System.Windows.Forms.Label labelClasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}