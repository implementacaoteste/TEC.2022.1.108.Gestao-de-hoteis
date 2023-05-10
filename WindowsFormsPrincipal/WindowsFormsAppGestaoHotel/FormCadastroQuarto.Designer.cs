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
            this.valor_DiariaTextBox = new System.Windows.Forms.TextBox();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.classeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.andarTextBox = new System.Windows.Forms.TextBox();
            this.ClasseComboBox = new System.Windows.Forms.ComboBox();
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
            descricaoLabel.Location = new System.Drawing.Point(148, 202);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(99, 25);
            descricaoLabel.TabIndex = 11;
            descricaoLabel.Text = "Descrição";
            // 
            // id_StatusLabel
            // 
            id_StatusLabel.AutoSize = true;
            id_StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_StatusLabel.Location = new System.Drawing.Point(308, 118);
            id_StatusLabel.Name = "id_StatusLabel";
            id_StatusLabel.Size = new System.Drawing.Size(68, 25);
            id_StatusLabel.TabIndex = 5;
            id_StatusLabel.Text = "Status";
            // 
            // id_ClasseLabel
            // 
            id_ClasseLabel.AutoSize = true;
            id_ClasseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_ClasseLabel.Location = new System.Drawing.Point(452, 114);
            id_ClasseLabel.Name = "id_ClasseLabel";
            id_ClasseLabel.Size = new System.Drawing.Size(73, 25);
            id_ClasseLabel.TabIndex = 7;
            id_ClasseLabel.Text = "Classe";
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numeroLabel.Location = new System.Drawing.Point(31, 119);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(81, 25);
            numeroLabel.TabIndex = 1;
            numeroLabel.Text = "Numero";
            // 
            // valor_DiariaLabel
            // 
            valor_DiariaLabel.AutoSize = true;
            valor_DiariaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valor_DiariaLabel.Location = new System.Drawing.Point(148, 119);
            valor_DiariaLabel.Name = "valor_DiariaLabel";
            valor_DiariaLabel.Size = new System.Drawing.Size(113, 25);
            valor_DiariaLabel.TabIndex = 3;
            valor_DiariaLabel.Text = "Valor Diária";
            // 
            // andarLabel
            // 
            andarLabel.AutoSize = true;
            andarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            andarLabel.Location = new System.Drawing.Point(31, 202);
            andarLabel.Name = "andarLabel";
            andarLabel.Size = new System.Drawing.Size(65, 25);
            andarLabel.TabIndex = 9;
            andarLabel.Text = "Andar";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartoBindingSource, "Descricao", true));
            this.descricaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.descricaoTextBox.Location = new System.Drawing.Point(153, 231);
            this.descricaoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(434, 77);
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
            // valor_DiariaTextBox
            // 
            this.valor_DiariaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valor_DiariaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartoBindingSource, "Valor_Diaria", true));
            this.valor_DiariaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.valor_DiariaTextBox.Location = new System.Drawing.Point(153, 154);
            this.valor_DiariaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valor_DiariaTextBox.Name = "valor_DiariaTextBox";
            this.valor_DiariaTextBox.Size = new System.Drawing.Size(145, 30);
            this.valor_DiariaTextBox.TabIndex = 4;
            this.valor_DiariaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tituloLabel
            // 
            this.tituloLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tituloLabel.Location = new System.Drawing.Point(0, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(624, 91);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "Cadastro de Quarto";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Image = global::WindowsFormsAppGestaoHotel.Properties.Resources.save;
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(284, 352);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSalvar.MinimumSize = new System.Drawing.Size(145, 39);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(145, 39);
            this.buttonSalvar.TabIndex = 13;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = global::WindowsFormsAppGestaoHotel.Properties.Resources.close;
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(443, 350);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.MinimumSize = new System.Drawing.Size(145, 39);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(145, 39);
            this.buttonCancelar.TabIndex = 14;
            this.buttonCancelar.Text = "Cancelar";
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
            this.StatusComboBox.Location = new System.Drawing.Point(313, 155);
            this.StatusComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(129, 30);
            this.StatusComboBox.TabIndex = 6;
            this.StatusComboBox.ValueMember = "Id";
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartoBindingSource, "Numero", true));
            this.numeroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numeroTextBox.Location = new System.Drawing.Point(36, 154);
            this.numeroTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(101, 30);
            this.numeroTextBox.TabIndex = 2;
            this.numeroTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // andarTextBox
            // 
            this.andarTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.andarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartoBindingSource, "Andar", true));
            this.andarTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.andarTextBox.Location = new System.Drawing.Point(36, 231);
            this.andarTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.andarTextBox.Name = "andarTextBox";
            this.andarTextBox.Size = new System.Drawing.Size(101, 30);
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
            this.ClasseComboBox.Location = new System.Drawing.Point(457, 155);
            this.ClasseComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClasseComboBox.Name = "ClasseComboBox";
            this.ClasseComboBox.Size = new System.Drawing.Size(129, 30);
            this.ClasseComboBox.TabIndex = 8;
            this.ClasseComboBox.ValueMember = "Id";
            // 
            // FormCadastroQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(624, 401);
            this.Controls.Add(this.ClasseComboBox);
            this.Controls.Add(andarLabel);
            this.Controls.Add(this.andarTextBox);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(valor_DiariaLabel);
            this.Controls.Add(this.valor_DiariaTextBox);
            this.Controls.Add(numeroLabel);
            this.Controls.Add(id_ClasseLabel);
            this.Controls.Add(id_StatusLabel);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 494);
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
        private System.Windows.Forms.TextBox valor_DiariaTextBox;
        private System.Windows.Forms.BindingSource statusesBindingSource;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.BindingSource classeBindingSource;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.TextBox andarTextBox;
        private System.Windows.Forms.ComboBox ClasseComboBox;
    }
}