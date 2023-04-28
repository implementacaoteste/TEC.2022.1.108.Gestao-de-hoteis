namespace WindowsFormsPrincipal1
{
    partial class FormConsultaQuarto
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
            System.Windows.Forms.Label labelQuarto;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaQuarto));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.quartoDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quartoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            labelQuarto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quartoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelQuarto
            // 
            labelQuarto.AutoEllipsis = true;
            labelQuarto.Dock = System.Windows.Forms.DockStyle.Top;
            labelQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            labelQuarto.Location = new System.Drawing.Point(0, 0);
            labelQuarto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelQuarto.Name = "labelQuarto";
            labelQuarto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            labelQuarto.Size = new System.Drawing.Size(729, 46);
            labelQuarto.TabIndex = 2;
            labelQuarto.Text = "QUARTO";
            labelQuarto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 82);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(378, 27);
            this.textBox1.TabIndex = 1;
            // 
            // quartoDataGridView
            // 
            this.quartoDataGridView.AllowUserToAddRows = false;
            this.quartoDataGridView.AllowUserToDeleteRows = false;
            this.quartoDataGridView.AllowUserToOrderColumns = true;
            this.quartoDataGridView.AutoGenerateColumns = false;
            this.quartoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quartoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.quartoDataGridView.DataSource = this.quartoBindingSource;
            this.quartoDataGridView.Location = new System.Drawing.Point(11, 120);
            this.quartoDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.quartoDataGridView.Name = "quartoDataGridView";
            this.quartoDataGridView.ReadOnly = true;
            this.quartoDataGridView.RowHeadersWidth = 51;
            this.quartoDataGridView.RowTemplate.Height = 24;
            this.quartoDataGridView.Size = new System.Drawing.Size(709, 259);
            this.quartoDataGridView.TabIndex = 5;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = global::WindowsFormsAppGestaoHotel.Properties.Resources.close;
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(614, 80);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(106, 33);
            this.buttonCancelar.TabIndex = 0;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Numero";
            this.dataGridViewTextBoxColumn2.HeaderText = "Número";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_Classe";
            this.dataGridViewTextBoxColumn3.FillWeight = 51.85076F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Código da Classe";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn4.FillWeight = 111.9789F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Valor_Diaria";
            this.dataGridViewTextBoxColumn5.FillWeight = 11.77997F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Valor da Diaria";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 115;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Id_Status";
            this.dataGridViewTextBoxColumn6.FillWeight = 224.3901F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Código da Status";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // quartoBindingSource
            // 
            this.quartoBindingSource.DataSource = typeof(Models.Quarto);
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionar.Image = global::WindowsFormsAppGestaoHotel.Properties.Resources.select;
            this.buttonSelecionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelecionar.Location = new System.Drawing.Point(488, 80);
            this.buttonSelecionar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(122, 33);
            this.buttonSelecionar.TabIndex = 0;
            this.buttonSelecionar.Text = "Selecionar ";
            this.buttonSelecionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.buttonSelecionar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Image = global::WindowsFormsAppGestaoHotel.Properties.Resources.search;
            this.buttonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscar.Location = new System.Drawing.Point(393, 80);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(91, 33);
            this.buttonBuscar.TabIndex = 0;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // FormConsultaQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 390);
            this.Controls.Add(this.quartoDataGridView);
            this.Controls.Add(labelQuarto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.buttonBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormConsultaQuarto";
            this.Text = "Consulta de Quarto";
            ((System.ComponentModel.ISupportInitialize)(this.quartoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.BindingSource quartoBindingSource;
        private System.Windows.Forms.DataGridView quartoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}