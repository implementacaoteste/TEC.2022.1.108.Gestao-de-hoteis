namespace WindowsFormsPrincipal1
{
    partial class FormCadastroDeFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroDeFuncionario));
            this.labelCadastroDeFuncionario = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvarFuncionario = new System.Windows.Forms.Button();
            this.buttonCancelarCadastro = new System.Windows.Forms.Button();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCadastroDeFuncionario
            // 
            this.labelCadastroDeFuncionario.Location = new System.Drawing.Point(0, 0);
            this.labelCadastroDeFuncionario.Name = "labelCadastroDeFuncionario";
            this.labelCadastroDeFuncionario.Size = new System.Drawing.Size(100, 23);
            this.labelCadastroDeFuncionario.TabIndex = 29;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(601, 400);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 29;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(682, 400);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 29;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvarFuncionario
            // 
            this.buttonSalvarFuncionario.Location = new System.Drawing.Point(592, 374);
            this.buttonSalvarFuncionario.Name = "buttonSalvarFuncionario";
            this.buttonSalvarFuncionario.Size = new System.Drawing.Size(85, 23);
            this.buttonSalvarFuncionario.TabIndex = 30;
            this.buttonSalvarFuncionario.Text = "SALVAR";
            this.buttonSalvarFuncionario.UseVisualStyleBackColor = true;
            // 
            // buttonCancelarCadastro
            // 
            this.buttonCancelarCadastro.Location = new System.Drawing.Point(693, 374);
            this.buttonCancelarCadastro.Name = "buttonCancelarCadastro";
            this.buttonCancelarCadastro.Size = new System.Drawing.Size(89, 23);
            this.buttonCancelarCadastro.TabIndex = 30;
            this.buttonCancelarCadastro.Text = "CANCELAR";
            this.buttonCancelarCadastro.UseVisualStyleBackColor = true;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataSource = typeof(Models.Funcionario);
            // 
            // FormCadastroDeFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 420);
            this.Controls.Add(this.buttonCancelarCadastro);
            this.Controls.Add(this.buttonSalvarFuncionario);
            this.Controls.Add(this.labelCadastroDeFuncionario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroDeFuncionario";
            this.Text = "HOTELOGIX - Cadastro de Funcionários";
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelCadastroDeFuncionario;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSalvarFuncionario;
        private System.Windows.Forms.Button buttonCancelarCadastro;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
    }
}