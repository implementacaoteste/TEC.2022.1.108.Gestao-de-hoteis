namespace WindowsFormsPrincipal1
{
    partial class FormConsultaClasse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaClasse));
            this.label1 = new System.Windows.Forms.Label();
            this.classeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Selecionar = new System.Windows.Forms.Button();
            this.classeDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(194, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Classe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // classeBindingSource
            // 
            this.classeBindingSource.DataSource = typeof(Models.Classe);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(382, 89);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 3;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(673, 360);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            this.buttonCancelar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonCancelar_KeyDown);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(358, 22);
            this.textBox1.TabIndex = 4;
            // 
            // Selecionar
            // 
            this.Selecionar.Location = new System.Drawing.Point(473, 89);
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.Size = new System.Drawing.Size(103, 23);
            this.Selecionar.TabIndex = 3;
            this.Selecionar.Text = "Selecionar";
            this.Selecionar.UseVisualStyleBackColor = true;
            // 
            // classeDataGridView1
            // 
            this.classeDataGridView1.AllowUserToAddRows = false;
            this.classeDataGridView1.AllowUserToDeleteRows = false;
            this.classeDataGridView1.AllowUserToOrderColumns = true;
            this.classeDataGridView1.AutoGenerateColumns = false;
            this.classeDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classeDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.classeDataGridView1.DataSource = this.classeBindingSource;
            this.classeDataGridView1.Location = new System.Drawing.Point(0, 118);
            this.classeDataGridView1.Name = "classeDataGridView1";
            this.classeDataGridView1.ReadOnly = true;
            this.classeDataGridView1.RowHeadersWidth = 51;
            this.classeDataGridView1.RowTemplate.Height = 24;
            this.classeDataGridView1.Size = new System.Drawing.Size(947, 220);
            this.classeDataGridView1.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // FormConsultaClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 451);
            this.Controls.Add(this.classeDataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.Selecionar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultaClasse";
            this.Text = "Consulta de Classe";
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource classeBindingSource;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Selecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView classeDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}