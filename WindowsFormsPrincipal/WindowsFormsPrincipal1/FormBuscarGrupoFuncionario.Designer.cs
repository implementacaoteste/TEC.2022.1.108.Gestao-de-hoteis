namespace WindowsFormsPrincipal1
{
    partial class FormBuscarGrupoFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarGrupoFuncionario));
            this.buttonBuscarGrupoFuncionario = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonAdicionarGrupoFuncionario = new System.Windows.Forms.Button();
            this.buttonAlterarGrupoFuncionario = new System.Windows.Forms.Button();
            this.buttonExcluirGrupoFuncionario = new System.Windows.Forms.Button();
            this.grupoFuncionarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permissoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permissoesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdicionarPermissão = new System.Windows.Forms.Button();
            this.buttonExcluirPermissão = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grupoFuncionarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoFuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBuscarGrupoFuncionario
            // 
            this.buttonBuscarGrupoFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarGrupoFuncionario.Location = new System.Drawing.Point(577, 93);
            this.buttonBuscarGrupoFuncionario.Name = "buttonBuscarGrupoFuncionario";
            this.buttonBuscarGrupoFuncionario.Size = new System.Drawing.Size(75, 30);
            this.buttonBuscarGrupoFuncionario.TabIndex = 1;
            this.buttonBuscarGrupoFuncionario.Text = "Buscar";
            this.buttonBuscarGrupoFuncionario.UseVisualStyleBackColor = true;
            this.buttonBuscarGrupoFuncionario.Click += new System.EventHandler(this.buttonBuscarGrupoFuncionario_Click);
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(12, 93);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(559, 30);
            this.textBox.TabIndex = 0;
            // 
            // buttonAdicionarGrupoFuncionario
            // 
            this.buttonAdicionarGrupoFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionarGrupoFuncionario.Location = new System.Drawing.Point(658, 93);
            this.buttonAdicionarGrupoFuncionario.Name = "buttonAdicionarGrupoFuncionario";
            this.buttonAdicionarGrupoFuncionario.Size = new System.Drawing.Size(85, 30);
            this.buttonAdicionarGrupoFuncionario.TabIndex = 2;
            this.buttonAdicionarGrupoFuncionario.Text = "Adicionar";
            this.buttonAdicionarGrupoFuncionario.UseVisualStyleBackColor = true;
            this.buttonAdicionarGrupoFuncionario.Click += new System.EventHandler(this.buttonAdicionarGrupoFuncionario_Click);
            // 
            // buttonAlterarGrupoFuncionario
            // 
            this.buttonAlterarGrupoFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlterarGrupoFuncionario.Location = new System.Drawing.Point(749, 93);
            this.buttonAlterarGrupoFuncionario.Name = "buttonAlterarGrupoFuncionario";
            this.buttonAlterarGrupoFuncionario.Size = new System.Drawing.Size(75, 30);
            this.buttonAlterarGrupoFuncionario.TabIndex = 3;
            this.buttonAlterarGrupoFuncionario.Text = "Alterar";
            this.buttonAlterarGrupoFuncionario.UseVisualStyleBackColor = true;
            this.buttonAlterarGrupoFuncionario.Click += new System.EventHandler(this.buttonAlterarGrupoFuncionario_Click);
            // 
            // buttonExcluirGrupoFuncionario
            // 
            this.buttonExcluirGrupoFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluirGrupoFuncionario.Location = new System.Drawing.Point(830, 93);
            this.buttonExcluirGrupoFuncionario.Name = "buttonExcluirGrupoFuncionario";
            this.buttonExcluirGrupoFuncionario.Size = new System.Drawing.Size(75, 30);
            this.buttonExcluirGrupoFuncionario.TabIndex = 4;
            this.buttonExcluirGrupoFuncionario.Text = "Excluir";
            this.buttonExcluirGrupoFuncionario.UseVisualStyleBackColor = true;
            this.buttonExcluirGrupoFuncionario.Click += new System.EventHandler(this.buttonExcluirGrupoFuncionario_Click);
            // 
            // grupoFuncionarioDataGridView
            // 
            this.grupoFuncionarioDataGridView.AllowUserToAddRows = false;
            this.grupoFuncionarioDataGridView.AllowUserToDeleteRows = false;
            this.grupoFuncionarioDataGridView.AllowUserToOrderColumns = true;
            this.grupoFuncionarioDataGridView.AutoGenerateColumns = false;
            this.grupoFuncionarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupoFuncionarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.grupoFuncionarioDataGridView.DataSource = this.grupoFuncionarioBindingSource;
            this.grupoFuncionarioDataGridView.Location = new System.Drawing.Point(12, 140);
            this.grupoFuncionarioDataGridView.Name = "grupoFuncionarioDataGridView";
            this.grupoFuncionarioDataGridView.ReadOnly = true;
            this.grupoFuncionarioDataGridView.RowHeadersWidth = 51;
            this.grupoFuncionarioDataGridView.RowTemplate.Height = 24;
            this.grupoFuncionarioDataGridView.Size = new System.Drawing.Size(893, 521);
            this.grupoFuncionarioDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeGrupo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Grupo de Funcionários";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // grupoFuncionarioBindingSource
            // 
            this.grupoFuncionarioBindingSource.DataSource = typeof(Models.GrupoFuncionario);
            // 
            // permissoesBindingSource
            // 
            this.permissoesBindingSource.DataMember = "Permissoes";
            this.permissoesBindingSource.DataSource = this.grupoFuncionarioBindingSource;
            // 
            // permissoesDataGridView
            // 
            this.permissoesDataGridView.AllowUserToAddRows = false;
            this.permissoesDataGridView.AllowUserToDeleteRows = false;
            this.permissoesDataGridView.AllowUserToOrderColumns = true;
            this.permissoesDataGridView.AutoGenerateColumns = false;
            this.permissoesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permissoesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4});
            this.permissoesDataGridView.DataSource = this.permissoesBindingSource;
            this.permissoesDataGridView.Location = new System.Drawing.Point(911, 140);
            this.permissoesDataGridView.Name = "permissoesDataGridView";
            this.permissoesDataGridView.ReadOnly = true;
            this.permissoesDataGridView.RowHeadersWidth = 51;
            this.permissoesDataGridView.RowTemplate.Height = 24;
            this.permissoesDataGridView.Size = new System.Drawing.Size(373, 521);
            this.permissoesDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // buttonAdicionarPermissão
            // 
            this.buttonAdicionarPermissão.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionarPermissão.Location = new System.Drawing.Point(1118, 93);
            this.buttonAdicionarPermissão.Name = "buttonAdicionarPermissão";
            this.buttonAdicionarPermissão.Size = new System.Drawing.Size(85, 30);
            this.buttonAdicionarPermissão.TabIndex = 5;
            this.buttonAdicionarPermissão.Text = "Adicionar";
            this.buttonAdicionarPermissão.UseVisualStyleBackColor = true;
            // 
            // buttonExcluirPermissão
            // 
            this.buttonExcluirPermissão.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluirPermissão.Location = new System.Drawing.Point(1209, 93);
            this.buttonExcluirPermissão.Name = "buttonExcluirPermissão";
            this.buttonExcluirPermissão.Size = new System.Drawing.Size(75, 30);
            this.buttonExcluirPermissão.TabIndex = 6;
            this.buttonExcluirPermissão.Text = "Excluir";
            this.buttonExcluirPermissão.UseVisualStyleBackColor = true;
            // 
            // FormBuscarGrupoFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 681);
            this.Controls.Add(this.permissoesDataGridView);
            this.Controls.Add(this.grupoFuncionarioDataGridView);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.buttonExcluirPermissão);
            this.Controls.Add(this.buttonExcluirGrupoFuncionario);
            this.Controls.Add(this.buttonAdicionarPermissão);
            this.Controls.Add(this.buttonAlterarGrupoFuncionario);
            this.Controls.Add(this.buttonAdicionarGrupoFuncionario);
            this.Controls.Add(this.buttonBuscarGrupoFuncionario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBuscarGrupoFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOTELOGIX - Consulta de Grupo de Funcionários";
            ((System.ComponentModel.ISupportInitialize)(this.grupoFuncionarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoFuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscarGrupoFuncionario;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonAdicionarGrupoFuncionario;
        private System.Windows.Forms.Button buttonAlterarGrupoFuncionario;
        private System.Windows.Forms.Button buttonExcluirGrupoFuncionario;
        private System.Windows.Forms.BindingSource grupoFuncionarioBindingSource;
        private System.Windows.Forms.DataGridView grupoFuncionarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource permissoesBindingSource;
        private System.Windows.Forms.DataGridView permissoesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button buttonAdicionarPermissão;
        private System.Windows.Forms.Button buttonExcluirPermissão;
    }
}