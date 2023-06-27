namespace WindowsFormsPrincipal1
{
    partial class FormCadastroQuarto
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
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label id_StatusLabel;
            System.Windows.Forms.Label id_ClasseLabel;
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label valor_DiariaLabel;
            System.Windows.Forms.Label andarLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroQuarto));
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.quartoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tituloLabel = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.classeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.andarTextBox = new System.Windows.Forms.TextBox();
            this.ClasseComboBox = new System.Windows.Forms.ComboBox();
            this.textBoxDinheiro1 = new ComponentesDesktop.TextBoxDinheiro();
            descricaoLabel = new System.Windows.Forms.Label();
            id_StatusLabel = new System.Windows.Forms.Label();
            id_ClasseLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            valor_DiariaLabel = new System.Windows.Forms.Label();
            andarLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.Location = new System.Drawing.Point(99, 139);
            descricaoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(80, 20);
            descricaoLabel.TabIndex = 11;
            descricaoLabel.Text = "Descrição";
            // 
            // id_StatusLabel
            // 
            id_StatusLabel.AutoSize = true;
            id_StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_StatusLabel.Location = new System.Drawing.Point(213, 75);
            id_StatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            id_StatusLabel.Name = "id_StatusLabel";
            id_StatusLabel.Size = new System.Drawing.Size(56, 20);
            id_StatusLabel.TabIndex = 5;
            id_StatusLabel.Text = "Status";
            // 
            // id_ClasseLabel
            // 
            id_ClasseLabel.AutoSize = true;
            id_ClasseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_ClasseLabel.Location = new System.Drawing.Point(323, 75);
            id_ClasseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            id_ClasseLabel.Name = "id_ClasseLabel";
            id_ClasseLabel.Size = new System.Drawing.Size(114, 20);
            id_ClasseLabel.TabIndex = 7;
            id_ClasseLabel.Text = "Tipo de Quarto";
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numeroLabel.Location = new System.Drawing.Point(11, 75);
            numeroLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(65, 20);
            numeroLabel.TabIndex = 1;
            numeroLabel.Text = "Número";
            // 
            // valor_DiariaLabel
            // 
            valor_DiariaLabel.AutoSize = true;
            valor_DiariaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valor_DiariaLabel.Location = new System.Drawing.Point(99, 75);
            valor_DiariaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            valor_DiariaLabel.Name = "valor_DiariaLabel";
            valor_DiariaLabel.Size = new System.Drawing.Size(91, 20);
            valor_DiariaLabel.TabIndex = 3;
            valor_DiariaLabel.Text = "Valor Diária";
            // 
            // andarLabel
            // 
            andarLabel.AutoSize = true;
            andarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            andarLabel.Location = new System.Drawing.Point(11, 139);
            andarLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            andarLabel.Name = "andarLabel";
            andarLabel.Size = new System.Drawing.Size(52, 20);
            andarLabel.TabIndex = 9;
            andarLabel.Text = "Andar";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartoBindingSource, "Descricao", true));
            this.descricaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.descricaoTextBox.Location = new System.Drawing.Point(103, 163);
            this.descricaoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(326, 63);
            this.descricaoTextBox.TabIndex = 12;
            // 
            // quartoBindingSource
            // 
            this.quartoBindingSource.DataSource = typeof(Models.Quarto);
            // 
            // statusesBindingSource
            // 
            this.statusesBindingSource.DataSource = typeof(Models.Statuses);
            // 
            // tituloLabel
            // 
            this.tituloLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tituloLabel.Location = new System.Drawing.Point(0, 0);
            this.tituloLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(447, 66);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "Cadastro de Quarto";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.buttonSalvar.Location = new System.Drawing.Point(145, 246);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSalvar.MinimumSize = new System.Drawing.Size(109, 32);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(120, 33);
            this.buttonSalvar.TabIndex = 13;
            this.buttonSalvar.Text = "SALVAR";
            this.buttonSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(77)))), ((int)(((byte)(87)))));
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(279, 246);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelar.MinimumSize = new System.Drawing.Size(109, 32);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(150, 33);
            this.buttonCancelar.TabIndex = 14;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // classeBindingSource
            // 
            this.classeBindingSource.DataSource = typeof(Models.Classe);
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.quartoBindingSource, "Id_Status", true));
            this.StatusComboBox.DataSource = this.statusesBindingSource;
            this.StatusComboBox.DisplayMember = "Status";
            this.StatusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(217, 100);
            this.StatusComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(98, 26);
            this.StatusComboBox.TabIndex = 6;
            this.StatusComboBox.ValueMember = "Id";
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartoBindingSource, "Numero", true));
            this.numeroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numeroTextBox.Location = new System.Drawing.Point(15, 100);
            this.numeroTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(76, 26);
            this.numeroTextBox.TabIndex = 2;
            this.numeroTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // andarTextBox
            // 
            this.andarTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.andarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartoBindingSource, "Andar", true));
            this.andarTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.andarTextBox.Location = new System.Drawing.Point(15, 163);
            this.andarTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.andarTextBox.Name = "andarTextBox";
            this.andarTextBox.Size = new System.Drawing.Size(76, 26);
            this.andarTextBox.TabIndex = 10;
            this.andarTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ClasseComboBox
            // 
            this.ClasseComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.quartoBindingSource, "Id_Classe", true));
            this.ClasseComboBox.DataSource = this.classeBindingSource;
            this.ClasseComboBox.DisplayMember = "Descricao";
            this.ClasseComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ClasseComboBox.FormattingEnabled = true;
            this.ClasseComboBox.Location = new System.Drawing.Point(327, 100);
            this.ClasseComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.ClasseComboBox.Name = "ClasseComboBox";
            this.ClasseComboBox.Size = new System.Drawing.Size(98, 26);
            this.ClasseComboBox.TabIndex = 8;
            this.ClasseComboBox.ValueMember = "Id";
            // 
            // textBoxDinheiro1
            // 
            this.textBoxDinheiro1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDinheiro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDinheiro1.Location = new System.Drawing.Point(103, 100);
            this.textBoxDinheiro1.Name = "textBoxDinheiro1";
            this.textBoxDinheiro1.Size = new System.Drawing.Size(100, 26);
            this.textBoxDinheiro1.TabIndex = 15;
            this.textBoxDinheiro1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormCadastroQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(447, 290);
            this.Controls.Add(this.textBoxDinheiro1);
            this.Controls.Add(this.ClasseComboBox);
            this.Controls.Add(andarLabel);
            this.Controls.Add(this.andarTextBox);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(valor_DiariaLabel);
            this.Controls.Add(numeroLabel);
            this.Controls.Add(id_ClasseLabel);
            this.Controls.Add(id_StatusLabel);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(618, 409);
            this.MinimizeBox = false;
            this.Name = "FormCadastroQuarto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Quarto";
            this.Load += new System.EventHandler(this.FormCadastroQuarto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadastroQuarto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource quartoBindingSource;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.BindingSource statusesBindingSource;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.BindingSource classeBindingSource;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.TextBox andarTextBox;
        private System.Windows.Forms.ComboBox ClasseComboBox;
        private ComponentesDesktop.TextBoxDinheiro textBoxDinheiro1;
    }
}