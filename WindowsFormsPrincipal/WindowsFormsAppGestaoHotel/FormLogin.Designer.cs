namespace WindowsFormsPrincipal1
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxEntrar = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.linkLabelsuporte = new System.Windows.Forms.LinkLabel();
            this.buttonsSuporte = new System.Windows.Forms.Button();
            this.labelCadastro = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEntrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUsuario
            // 
            resources.ApplyResources(this.textBoxUsuario, "textBoxUsuario");
            this.textBoxUsuario.BackColor = System.Drawing.Color.White;
            this.textBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUsuario_KeyDown);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.BackColor = System.Drawing.Color.White;
            this.textBoxSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxSenha, "textBoxSenha");
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSenha_KeyDown);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::WindowsFormsAppGestaoHotel.Properties.Resources.Form_Login;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxEntrar
            // 
            resources.ApplyResources(this.pictureBoxEntrar, "pictureBoxEntrar");
            this.pictureBoxEntrar.Name = "pictureBoxEntrar";
            this.pictureBoxEntrar.TabStop = false;
            this.pictureBoxEntrar.Click += new System.EventHandler(this.pictureBoxEntrar_Click);
            // 
            // pictureBoxClose
            // 
            resources.ApplyResources(this.pictureBoxClose, "pictureBoxClose");
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // linkLabelsuporte
            // 
            resources.ApplyResources(this.linkLabelsuporte, "linkLabelsuporte");
            this.linkLabelsuporte.Name = "linkLabelsuporte";
            this.linkLabelsuporte.TabStop = true;
            this.linkLabelsuporte.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelsuporte_LinkClicked);
            // 
            // buttonsSuporte
            // 
            this.buttonsSuporte.BackColor = System.Drawing.Color.Teal;
            resources.ApplyResources(this.buttonsSuporte, "buttonsSuporte");
            this.buttonsSuporte.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonsSuporte.Name = "buttonsSuporte";
            this.buttonsSuporte.UseVisualStyleBackColor = false;
            this.buttonsSuporte.Click += new System.EventHandler(this.buttonsSuporte_Click);
            // 
            // labelCadastro
            // 
            resources.ApplyResources(this.labelCadastro, "labelCadastro");
            this.labelCadastro.BackColor = System.Drawing.Color.White;
            this.labelCadastro.Name = "labelCadastro";
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FormLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelCadastro);
            this.Controls.Add(this.buttonsSuporte);
            this.Controls.Add(this.linkLabelsuporte);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.pictureBoxEntrar);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEntrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxEntrar;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.LinkLabel linkLabelsuporte;
        private System.Windows.Forms.Button buttonsSuporte;
        private System.Windows.Forms.Label labelCadastro;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}