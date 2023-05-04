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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroQuarto));
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.quartoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.statusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.valor_DiariaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.id_ClasseComboBox = new System.Windows.Forms.ComboBox();
            this.classeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            descricaoLabel = new System.Windows.Forms.Label();
            id_StatusLabel = new System.Windows.Forms.Label();
            id_ClasseLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            valor_DiariaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.Location = new System.Drawing.Point(28, 98);
            descricaoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(99, 24);
            descricaoLabel.TabIndex = 1;
            descricaoLabel.Text = "Descrição:";
            // 
            // id_StatusLabel
            // 
            id_StatusLabel.AutoSize = true;
            id_StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_StatusLabel.Location = new System.Drawing.Point(62, 158);
            id_StatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            id_StatusLabel.Name = "id_StatusLabel";
            id_StatusLabel.Size = new System.Drawing.Size(65, 24);
            id_StatusLabel.TabIndex = 3;
            id_StatusLabel.Text = "Status:";
            // 
            // id_ClasseLabel
            // 
            id_ClasseLabel.AutoSize = true;
            id_ClasseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_ClasseLabel.Location = new System.Drawing.Point(244, 158);
            id_ClasseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            id_ClasseLabel.Name = "id_ClasseLabel";
            id_ClasseLabel.Size = new System.Drawing.Size(71, 24);
            id_ClasseLabel.TabIndex = 5;
            id_ClasseLabel.Text = "Classe:";
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numeroLabel.Location = new System.Drawing.Point(43, 216);
            numeroLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(84, 24);
            numeroLabel.TabIndex = 7;
            numeroLabel.Text = "Numero:";
            // 
            // valor_DiariaLabel
            // 
            valor_DiariaLabel.AutoSize = true;
            valor_DiariaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valor_DiariaLabel.Location = new System.Drawing.Point(16, 274);
            valor_DiariaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            valor_DiariaLabel.Name = "valor_DiariaLabel";
            valor_DiariaLabel.Size = new System.Drawing.Size(111, 24);
            valor_DiariaLabel.TabIndex = 9;
            valor_DiariaLabel.Text = "Valor Diaria:";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartoBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(131, 102);
            this.descricaoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(338, 20);
            this.descricaoTextBox.TabIndex = 2;
            // 
            // quartoBindingSource
            // 
            this.quartoBindingSource.DataSource = typeof(Models.Quarto);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.quartoBindingSource, "Id_Status", true));
            this.comboBoxStatus.DataSource = this.statusesBindingSource;
            this.comboBoxStatus.DisplayMember = "Status";
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(131, 161);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(92, 21);
            this.comboBoxStatus.TabIndex = 7;
            this.comboBoxStatus.ValueMember = "Id";
            // 
            // statusesBindingSource
            // 
            this.statusesBindingSource.DataSource = typeof(Models.Statuses);
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartoBindingSource, "Numero", true));
            this.numeroTextBox.Location = new System.Drawing.Point(131, 220);
            this.numeroTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(99, 20);
            this.numeroTextBox.TabIndex = 8;
            // 
            // valor_DiariaTextBox
            // 
            this.valor_DiariaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartoBindingSource, "Valor_Diaria", true));
            this.valor_DiariaTextBox.Location = new System.Drawing.Point(131, 278);
            this.valor_DiariaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.valor_DiariaTextBox.Name = "valor_DiariaTextBox";
            this.valor_DiariaTextBox.Size = new System.Drawing.Size(109, 20);
            this.valor_DiariaTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 74);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cadastro de Quarto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Image = global::WindowsFormsAppGestaoHotel.Properties.Resources.save;
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(359, 322);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(101, 33);
            this.buttonSalvar.TabIndex = 12;
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
            this.buttonCancelar.Location = new System.Drawing.Point(465, 322);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(124, 33);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // id_ClasseComboBox
            // 
            this.id_ClasseComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartoBindingSource, "Id_Classe", true));
            this.id_ClasseComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.quartoBindingSource, "Id_Status", true));
            this.id_ClasseComboBox.DataSource = this.classeBindingSource;
            this.id_ClasseComboBox.DisplayMember = "Descricao";
            this.id_ClasseComboBox.FormattingEnabled = true;
            this.id_ClasseComboBox.Location = new System.Drawing.Point(315, 158);
            this.id_ClasseComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.id_ClasseComboBox.Name = "id_ClasseComboBox";
            this.id_ClasseComboBox.Size = new System.Drawing.Size(92, 21);
            this.id_ClasseComboBox.TabIndex = 13;
            this.id_ClasseComboBox.ValueMember = "Id";
            // 
            // classeBindingSource
            // 
            this.classeBindingSource.DataSource = typeof(Models.Classe);
            // 
            // FormCadastroQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.id_ClasseComboBox);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(valor_DiariaLabel);
            this.Controls.Add(this.valor_DiariaTextBox);
            this.Controls.Add(numeroLabel);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(id_ClasseLabel);
            this.Controls.Add(id_StatusLabel);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(618, 410);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(618, 410);
            this.Name = "FormCadastroQuarto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Quarto";
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource quartoBindingSource;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.TextBox valor_DiariaTextBox;
        private System.Windows.Forms.BindingSource statusesBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.ComboBox id_ClasseComboBox;
        private System.Windows.Forms.BindingSource classeBindingSource;
    }
}