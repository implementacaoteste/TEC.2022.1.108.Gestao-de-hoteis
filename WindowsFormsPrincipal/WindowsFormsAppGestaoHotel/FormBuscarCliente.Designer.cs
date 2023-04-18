﻿namespace WindowsFormsPrincipal1
{
    partial class FormBuscarCliente
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonExcluirCliente = new System.Windows.Forms.Button();
            this.buttonAlterarCliente = new System.Windows.Forms.Button();
            this.buttonAdicionarCliente = new System.Windows.Forms.Button();
            this.buttonBuscarCliente = new System.Windows.Forms.Button();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(135, 110);
            this.textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(506, 30);
            this.textBox.TabIndex = 1;
            // 
            // buttonExcluirCliente
            // 
            this.buttonExcluirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirCliente.Location = new System.Drawing.Point(1320, 110);
            this.buttonExcluirCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExcluirCliente.Name = "buttonExcluirCliente";
            this.buttonExcluirCliente.Size = new System.Drawing.Size(107, 34);
            this.buttonExcluirCliente.TabIndex = 8;
            this.buttonExcluirCliente.Text = "Excluir";
            this.buttonExcluirCliente.UseVisualStyleBackColor = true;
            this.buttonExcluirCliente.Click += new System.EventHandler(this.buttonExcluirCliente_Click);
            // 
            // buttonAlterarCliente
            // 
            this.buttonAlterarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlterarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterarCliente.Location = new System.Drawing.Point(1208, 110);
            this.buttonAlterarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAlterarCliente.Name = "buttonAlterarCliente";
            this.buttonAlterarCliente.Size = new System.Drawing.Size(107, 34);
            this.buttonAlterarCliente.TabIndex = 7;
            this.buttonAlterarCliente.Text = "Alterar";
            this.buttonAlterarCliente.UseVisualStyleBackColor = true;
            this.buttonAlterarCliente.Click += new System.EventHandler(this.buttonAlterarCliente_Click_1);
            // 
            // buttonAdicionarCliente
            // 
            this.buttonAdicionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarCliente.Location = new System.Drawing.Point(1096, 110);
            this.buttonAdicionarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdicionarCliente.Name = "buttonAdicionarCliente";
            this.buttonAdicionarCliente.Size = new System.Drawing.Size(107, 34);
            this.buttonAdicionarCliente.TabIndex = 6;
            this.buttonAdicionarCliente.Text = "Adicionar";
            this.buttonAdicionarCliente.UseVisualStyleBackColor = true;
            this.buttonAdicionarCliente.Click += new System.EventHandler(this.buttonAdicionarCliente_Click);
            // 
            // buttonBuscarCliente
            // 
            this.buttonBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarCliente.Location = new System.Drawing.Point(660, 110);
            this.buttonBuscarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarCliente.Name = "buttonBuscarCliente";
            this.buttonBuscarCliente.Size = new System.Drawing.Size(107, 34);
            this.buttonBuscarCliente.TabIndex = 5;
            this.buttonBuscarCliente.Text = "Buscar";
            this.buttonBuscarCliente.UseVisualStyleBackColor = true;
            this.buttonBuscarCliente.Click += new System.EventHandler(this.buttonBuscarCliente_Click);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Models.Cliente);
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.AllowUserToAddRows = false;
            this.clienteDataGridView.AllowUserToDeleteRows = false;
            this.clienteDataGridView.AllowUserToOrderColumns = true;
            this.clienteDataGridView.AutoGenerateColumns = false;
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7});
            this.clienteDataGridView.DataSource = this.clienteBindingSource;
            this.clienteDataGridView.Location = new System.Drawing.Point(15, 162);
            this.clienteDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.ReadOnly = true;
            this.clienteDataGridView.RowHeadersWidth = 47;
            this.clienteDataGridView.Size = new System.Drawing.Size(1412, 507);
            this.clienteDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CPF";
            this.dataGridViewTextBoxColumn3.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "E-mail";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 160;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Celular";
            this.dataGridViewTextBoxColumn5.HeaderText = "Celular";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Data_nascimento";
            this.dataGridViewTextBoxColumn7.HeaderText = "Data de Nascimento";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 135;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pesquisar";
            // 
            // FormBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clienteDataGridView);
            this.Controls.Add(this.buttonExcluirCliente);
            this.Controls.Add(this.buttonAlterarCliente);
            this.Controls.Add(this.buttonAdicionarCliente);
            this.Controls.Add(this.buttonBuscarCliente);
            this.Controls.Add(this.textBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1461, 728);
            this.MinimumSize = new System.Drawing.Size(1461, 728);
            this.Name = "FormBuscarCliente";
            this.Text = "HOTELOGIX - Consulta ao Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonExcluirCliente;
        private System.Windows.Forms.Button buttonAlterarCliente;
        private System.Windows.Forms.Button buttonAdicionarCliente;
        private System.Windows.Forms.Button buttonBuscarCliente;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}