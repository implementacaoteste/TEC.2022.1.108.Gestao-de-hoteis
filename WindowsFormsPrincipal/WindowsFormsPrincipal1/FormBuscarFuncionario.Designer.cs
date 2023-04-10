namespace WindowsFormsPrincipal1
{
    partial class FormBuscarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarFuncionario));
            this.buttonBuscarFuncionario = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonExcluirFuncionário = new System.Windows.Forms.Button();
            this.buttonAlterarFuncionario = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonBuscarFuncionario
            // 
            this.buttonBuscarFuncionario.Location = new System.Drawing.Point(528, 166);
            this.buttonBuscarFuncionario.Name = "buttonBuscarFuncionario";
            this.buttonBuscarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarFuncionario.TabIndex = 0;
            this.buttonBuscarFuncionario.Text = "Buscar Funcionário";
            this.buttonBuscarFuncionario.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(609, 166);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(88, 23);
            this.buttonAdicionar.TabIndex = 0;
            this.buttonAdicionar.Text = "Adicionar Funcionário";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            // 
            // buttonExcluirFuncionário
            // 
            this.buttonExcluirFuncionário.Location = new System.Drawing.Point(703, 166);
            this.buttonExcluirFuncionário.Name = "buttonExcluirFuncionário";
            this.buttonExcluirFuncionário.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirFuncionário.TabIndex = 0;
            this.buttonExcluirFuncionário.Text = "Excluir Funcionário";
            this.buttonExcluirFuncionário.UseVisualStyleBackColor = true;
            // 
            // buttonAlterarFuncionario
            // 
            this.buttonAlterarFuncionario.Location = new System.Drawing.Point(784, 166);
            this.buttonAlterarFuncionario.Name = "buttonAlterarFuncionario";
            this.buttonAlterarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarFuncionario.TabIndex = 0;
            this.buttonAlterarFuncionario.Text = "Alterar Funcionario";
            this.buttonAlterarFuncionario.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(498, 22);
            this.textBox1.TabIndex = 1;
            // 
            // FormBuscarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonAlterarFuncionario);
            this.Controls.Add(this.buttonExcluirFuncionário);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.buttonBuscarFuncionario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBuscarFuncionario";
            this.Text = "HOTELOGIX - Consulta de Funcionários";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscarFuncionario;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonExcluirFuncionário;
        private System.Windows.Forms.Button buttonAlterarFuncionario;
        private System.Windows.Forms.TextBox textBox1;
    }
}