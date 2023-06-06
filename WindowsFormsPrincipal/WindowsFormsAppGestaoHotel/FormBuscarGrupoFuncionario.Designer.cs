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
            System.Windows.Forms.Label nomeGrupoLabel;
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label descricaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarGrupoFuncionario));
            this.grupoFuncionarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permissoesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonNome = new System.Windows.Forms.RadioButton();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.buttonBuscarGrupoFuncionario = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomeGrupoTextBox1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.buttonExcluirPermissao = new System.Windows.Forms.Button();
            this.buttonAdicionarPermissao = new System.Windows.Forms.Button();
            this.buttonExcluirGrupoFuncionario = new System.Windows.Forms.Button();
            this.buttonAlterarGrupoFuncionario = new System.Windows.Forms.Button();
            this.buttonAdicionarGrupoFuncionario = new System.Windows.Forms.Button();
            nomeGrupoLabel = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grupoFuncionarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoFuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeGrupoLabel
            // 
            nomeGrupoLabel.AutoSize = true;
            nomeGrupoLabel.Location = new System.Drawing.Point(9, 46);
            nomeGrupoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nomeGrupoLabel.Name = "nomeGrupoLabel";
            nomeGrupoLabel.Size = new System.Drawing.Size(84, 13);
            nomeGrupoLabel.TabIndex = 2;
            nomeGrupoLabel.Text = "Nome do Cargo:";
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(60, 23);
            idLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(32, 13);
            idLabel1.TabIndex = 0;
            idLabel1.Text = "Cód.:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(60, 26);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(32, 13);
            label2.TabIndex = 0;
            label2.Text = "Cód.:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(34, 46);
            descricaoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(58, 13);
            descricaoLabel.TabIndex = 2;
            descricaoLabel.Text = "Descrição:";
            // 
            // grupoFuncionarioDataGridView
            // 
            this.grupoFuncionarioDataGridView.AllowUserToAddRows = false;
            this.grupoFuncionarioDataGridView.AllowUserToDeleteRows = false;
            this.grupoFuncionarioDataGridView.AllowUserToOrderColumns = true;
            this.grupoFuncionarioDataGridView.AutoGenerateColumns = false;
            this.grupoFuncionarioDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grupoFuncionarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupoFuncionarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.grupoFuncionarioDataGridView.DataSource = this.grupoFuncionarioBindingSource;
            this.grupoFuncionarioDataGridView.Location = new System.Drawing.Point(4, 18);
            this.grupoFuncionarioDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.grupoFuncionarioDataGridView.Name = "grupoFuncionarioDataGridView";
            this.grupoFuncionarioDataGridView.ReadOnly = true;
            this.grupoFuncionarioDataGridView.RowHeadersVisible = false;
            this.grupoFuncionarioDataGridView.RowHeadersWidth = 51;
            this.grupoFuncionarioDataGridView.RowTemplate.Height = 24;
            this.grupoFuncionarioDataGridView.Size = new System.Drawing.Size(397, 218);
            this.grupoFuncionarioDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cód.";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeGrupo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cargos";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // grupoFuncionarioBindingSource
            // 
            this.grupoFuncionarioBindingSource.DataSource = typeof(Models.GrupoFuncionario);
            // 
            // permissoesDataGridView
            // 
            this.permissoesDataGridView.AllowUserToAddRows = false;
            this.permissoesDataGridView.AllowUserToDeleteRows = false;
            this.permissoesDataGridView.AllowUserToOrderColumns = true;
            this.permissoesDataGridView.AutoGenerateColumns = false;
            this.permissoesDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.permissoesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permissoesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4});
            this.permissoesDataGridView.DataSource = this.permissoesBindingSource;
            this.permissoesDataGridView.Location = new System.Drawing.Point(4, 18);
            this.permissoesDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.permissoesDataGridView.Name = "permissoesDataGridView";
            this.permissoesDataGridView.ReadOnly = true;
            this.permissoesDataGridView.RowHeadersVisible = false;
            this.permissoesDataGridView.RowHeadersWidth = 51;
            this.permissoesDataGridView.RowTemplate.Height = 24;
            this.permissoesDataGridView.Size = new System.Drawing.Size(318, 218);
            this.permissoesDataGridView.TabIndex = 0;
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
            // permissoesBindingSource
            // 
            this.permissoesBindingSource.DataMember = "Permissoes";
            this.permissoesBindingSource.DataSource = this.grupoFuncionarioBindingSource;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonTodos);
            this.groupBox1.Controls.Add(this.radioButtonNome);
            this.groupBox1.Controls.Add(this.textBoxBuscar);
            this.groupBox1.Controls.Add(this.buttonBuscarGrupoFuncionario);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(406, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar por";
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonTodos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonTodos.Location = new System.Drawing.Point(10, 17);
            this.radioButtonTodos.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(72, 22);
            this.radioButtonTodos.TabIndex = 0;
            this.radioButtonTodos.TabStop = true;
            this.radioButtonTodos.Text = "Todos";
            this.radioButtonTodos.UseVisualStyleBackColor = false;
            // 
            // radioButtonNome
            // 
            this.radioButtonNome.AutoSize = true;
            this.radioButtonNome.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonNome.Location = new System.Drawing.Point(95, 17);
            this.radioButtonNome.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonNome.Name = "radioButtonNome";
            this.radioButtonNome.Size = new System.Drawing.Size(70, 22);
            this.radioButtonNome.TabIndex = 1;
            this.radioButtonNome.TabStop = true;
            this.radioButtonNome.Text = "Cargo";
            this.radioButtonNome.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxBuscar.Location = new System.Drawing.Point(4, 47);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(363, 26);
            this.textBoxBuscar.TabIndex = 2;
            // 
            // buttonBuscarGrupoFuncionario
            // 
            this.buttonBuscarGrupoFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.buttonBuscarGrupoFuncionario.FlatAppearance.BorderSize = 0;
            this.buttonBuscarGrupoFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarGrupoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarGrupoFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarGrupoFuncionario.Image")));
            this.buttonBuscarGrupoFuncionario.Location = new System.Drawing.Point(371, 45);
            this.buttonBuscarGrupoFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscarGrupoFuncionario.Name = "buttonBuscarGrupoFuncionario";
            this.buttonBuscarGrupoFuncionario.Size = new System.Drawing.Size(30, 30);
            this.buttonBuscarGrupoFuncionario.TabIndex = 3;
            this.buttonBuscarGrupoFuncionario.UseVisualStyleBackColor = false;
            this.buttonBuscarGrupoFuncionario.Click += new System.EventHandler(this.buttonBuscarGrupoFuncionario_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grupoFuncionarioDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox2.Location = new System.Drawing.Point(9, 99);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(406, 240);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cargos cadastrados";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.permissoesDataGridView);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox3.Location = new System.Drawing.Point(428, 99);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(327, 240);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Permissões";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.idTextBox);
            this.groupBox5.Controls.Add(this.nomeGrupoTextBox1);
            this.groupBox5.Controls.Add(nomeGrupoLabel);
            this.groupBox5.Controls.Add(idLabel1);
            this.groupBox5.Location = new System.Drawing.Point(9, 356);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(406, 81);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dados do Cargo";
            // 
            // idTextBox
            // 
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoFuncionarioBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(95, 21);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(38, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // nomeGrupoTextBox1
            // 
            this.nomeGrupoTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeGrupoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoFuncionarioBindingSource, "NomeGrupo", true));
            this.nomeGrupoTextBox1.Location = new System.Drawing.Point(95, 44);
            this.nomeGrupoTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.nomeGrupoTextBox1.Name = "nomeGrupoTextBox1";
            this.nomeGrupoTextBox1.ReadOnly = true;
            this.nomeGrupoTextBox1.Size = new System.Drawing.Size(184, 20);
            this.nomeGrupoTextBox1.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.idTextBox1);
            this.groupBox4.Controls.Add(descricaoLabel);
            this.groupBox4.Controls.Add(this.descricaoTextBox);
            this.groupBox4.Controls.Add(label2);
            this.groupBox4.Location = new System.Drawing.Point(428, 356);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(327, 81);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dados da Permissão";
            // 
            // idTextBox1
            // 
            this.idTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.permissoesBindingSource, "Id", true));
            this.idTextBox1.Location = new System.Drawing.Point(95, 21);
            this.idTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.ReadOnly = true;
            this.idTextBox1.Size = new System.Drawing.Size(38, 20);
            this.idTextBox1.TabIndex = 1;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.permissoesBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(95, 45);
            this.descricaoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.ReadOnly = true;
            this.descricaoTextBox.Size = new System.Drawing.Size(184, 20);
            this.descricaoTextBox.TabIndex = 3;
            // 
            // buttonExcluirPermissao
            // 
            this.buttonExcluirPermissao.BackColor = System.Drawing.Color.IndianRed;
            this.buttonExcluirPermissao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluirPermissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirPermissao.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluirPermissao.Image")));
            this.buttonExcluirPermissao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExcluirPermissao.Location = new System.Drawing.Point(641, 460);
            this.buttonExcluirPermissao.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExcluirPermissao.Name = "buttonExcluirPermissao";
            this.buttonExcluirPermissao.Size = new System.Drawing.Size(120, 33);
            this.buttonExcluirPermissao.TabIndex = 9;
            this.buttonExcluirPermissao.Text = "Excluir";
            this.buttonExcluirPermissao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExcluirPermissao.UseVisualStyleBackColor = false;
            this.buttonExcluirPermissao.Click += new System.EventHandler(this.buttonExcluirPermissão_Click);
            this.buttonExcluirPermissao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonExcluirPermissao_KeyDown);
            // 
            // buttonAdicionarPermissao
            // 
            this.buttonAdicionarPermissao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(210)))), ((int)(((byte)(156)))));
            this.buttonAdicionarPermissao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionarPermissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarPermissao.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdicionarPermissao.Image")));
            this.buttonAdicionarPermissao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdicionarPermissao.Location = new System.Drawing.Point(507, 460);
            this.buttonAdicionarPermissao.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdicionarPermissao.Name = "buttonAdicionarPermissao";
            this.buttonAdicionarPermissao.Size = new System.Drawing.Size(128, 33);
            this.buttonAdicionarPermissao.TabIndex = 8;
            this.buttonAdicionarPermissao.Text = "Adicionar";
            this.buttonAdicionarPermissao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdicionarPermissao.UseVisualStyleBackColor = false;
            this.buttonAdicionarPermissao.Click += new System.EventHandler(this.buttonAdicionarPermissão_Click);
            // 
            // buttonExcluirGrupoFuncionario
            // 
            this.buttonExcluirGrupoFuncionario.BackColor = System.Drawing.Color.IndianRed;
            this.buttonExcluirGrupoFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluirGrupoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirGrupoFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluirGrupoFuncionario.Image")));
            this.buttonExcluirGrupoFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExcluirGrupoFuncionario.Location = new System.Drawing.Point(269, 460);
            this.buttonExcluirGrupoFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExcluirGrupoFuncionario.Name = "buttonExcluirGrupoFuncionario";
            this.buttonExcluirGrupoFuncionario.Size = new System.Drawing.Size(120, 33);
            this.buttonExcluirGrupoFuncionario.TabIndex = 6;
            this.buttonExcluirGrupoFuncionario.Text = "Excluir";
            this.buttonExcluirGrupoFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExcluirGrupoFuncionario.UseVisualStyleBackColor = false;
            this.buttonExcluirGrupoFuncionario.Click += new System.EventHandler(this.buttonExcluirGrupoFuncionario_Click);
            // 
            // buttonAlterarGrupoFuncionario
            // 
            this.buttonAlterarGrupoFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(183)))), ((int)(((byte)(219)))));
            this.buttonAlterarGrupoFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlterarGrupoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterarGrupoFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlterarGrupoFuncionario.Image")));
            this.buttonAlterarGrupoFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAlterarGrupoFuncionario.Location = new System.Drawing.Point(143, 460);
            this.buttonAlterarGrupoFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAlterarGrupoFuncionario.Name = "buttonAlterarGrupoFuncionario";
            this.buttonAlterarGrupoFuncionario.Size = new System.Drawing.Size(120, 33);
            this.buttonAlterarGrupoFuncionario.TabIndex = 5;
            this.buttonAlterarGrupoFuncionario.Text = "Alterar";
            this.buttonAlterarGrupoFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAlterarGrupoFuncionario.UseVisualStyleBackColor = false;
            this.buttonAlterarGrupoFuncionario.Click += new System.EventHandler(this.buttonAlterarGrupoFuncionario_Click);
            // 
            // buttonAdicionarGrupoFuncionario
            // 
            this.buttonAdicionarGrupoFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(210)))), ((int)(((byte)(156)))));
            this.buttonAdicionarGrupoFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionarGrupoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarGrupoFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdicionarGrupoFuncionario.Image")));
            this.buttonAdicionarGrupoFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdicionarGrupoFuncionario.Location = new System.Drawing.Point(9, 460);
            this.buttonAdicionarGrupoFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdicionarGrupoFuncionario.Name = "buttonAdicionarGrupoFuncionario";
            this.buttonAdicionarGrupoFuncionario.Size = new System.Drawing.Size(128, 33);
            this.buttonAdicionarGrupoFuncionario.TabIndex = 4;
            this.buttonAdicionarGrupoFuncionario.Text = "Adicionar";
            this.buttonAdicionarGrupoFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdicionarGrupoFuncionario.UseVisualStyleBackColor = false;
            this.buttonAdicionarGrupoFuncionario.Click += new System.EventHandler(this.buttonAdicionarGrupoFuncionario_Click);
            // 
            // FormBuscarGrupoFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(772, 506);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonExcluirPermissao);
            this.Controls.Add(this.buttonAdicionarPermissao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonExcluirGrupoFuncionario);
            this.Controls.Add(this.buttonAlterarGrupoFuncionario);
            this.Controls.Add(this.buttonAdicionarGrupoFuncionario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(788, 545);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(788, 545);
            this.Name = "FormBuscarGrupoFuncionario";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOTELOGIX - Buscar Cargos";
            this.Load += new System.EventHandler(this.FormBuscarGrupoFuncionario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormBuscarGrupoFuncionario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grupoFuncionarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoFuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAdicionarGrupoFuncionario;
        private System.Windows.Forms.Button buttonAlterarGrupoFuncionario;
        private System.Windows.Forms.Button buttonExcluirGrupoFuncionario;
        private System.Windows.Forms.BindingSource grupoFuncionarioBindingSource;
        private System.Windows.Forms.DataGridView grupoFuncionarioDataGridView;
        private System.Windows.Forms.BindingSource permissoesBindingSource;
        private System.Windows.Forms.DataGridView permissoesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.RadioButton radioButtonNome;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonBuscarGrupoFuncionario;
        private System.Windows.Forms.Button buttonExcluirPermissao;
        private System.Windows.Forms.Button buttonAdicionarPermissao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomeGrupoTextBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}