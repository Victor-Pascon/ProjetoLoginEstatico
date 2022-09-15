namespace ProjetoCalculos
{
    partial class frmSistemaDeLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSistemaDeLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbSenhaVisivel = new System.Windows.Forms.PictureBox();
            this.pbSenhaInvisivel = new System.Windows.Forms.PictureBox();
            this.pbSair = new System.Windows.Forms.PictureBox();
            this.btnDeslogar = new System.Windows.Forms.Button();
            this.pbJuliaLogin = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pbDanielLogin = new System.Windows.Forms.PictureBox();
            this.pbKevinLogin = new System.Windows.Forms.PictureBox();
            this.pbMariLogin = new System.Windows.Forms.PictureBox();
            this.pbVictorLogin = new System.Windows.Forms.PictureBox();
            this.pbImagemDeLogin = new System.Windows.Forms.PictureBox();
            this.lblRecuperar = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSenhaVisivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSenhaInvisivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJuliaLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDanielLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKevinLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMariLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVictorLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemDeLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.pbSenhaVisivel);
            this.panel1.Controls.Add(this.pbSenhaInvisivel);
            this.panel1.Controls.Add(this.pbSair);
            this.panel1.Controls.Add(this.btnDeslogar);
            this.panel1.Controls.Add(this.pbJuliaLogin);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.pbDanielLogin);
            this.panel1.Controls.Add(this.pbKevinLogin);
            this.panel1.Controls.Add(this.pbMariLogin);
            this.panel1.Controls.Add(this.pbVictorLogin);
            this.panel1.Controls.Add(this.pbImagemDeLogin);
            this.panel1.Controls.Add(this.lblRecuperar);
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Controls.Add(this.txtLogin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEntrar);
            this.panel1.Location = new System.Drawing.Point(85, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 267);
            this.panel1.TabIndex = 0;
            // 
            // pbSenhaVisivel
            // 
            this.pbSenhaVisivel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSenhaVisivel.Image = global::ProjetoCalculos.Properties.Resources.senha_visivel;
            this.pbSenhaVisivel.Location = new System.Drawing.Point(521, 106);
            this.pbSenhaVisivel.Name = "pbSenhaVisivel";
            this.pbSenhaVisivel.Size = new System.Drawing.Size(31, 29);
            this.pbSenhaVisivel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSenhaVisivel.TabIndex = 17;
            this.pbSenhaVisivel.TabStop = false;
            this.pbSenhaVisivel.Click += new System.EventHandler(this.pbSenhaVisivel_Click);
            // 
            // pbSenhaInvisivel
            // 
            this.pbSenhaInvisivel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSenhaInvisivel.Image = global::ProjetoCalculos.Properties.Resources.senha_invisivel;
            this.pbSenhaInvisivel.Location = new System.Drawing.Point(521, 106);
            this.pbSenhaInvisivel.Name = "pbSenhaInvisivel";
            this.pbSenhaInvisivel.Size = new System.Drawing.Size(31, 29);
            this.pbSenhaInvisivel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSenhaInvisivel.TabIndex = 16;
            this.pbSenhaInvisivel.TabStop = false;
            this.pbSenhaInvisivel.Visible = false;
            this.pbSenhaInvisivel.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbSair
            // 
            this.pbSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSair.Image = global::ProjetoCalculos.Properties.Resources.Botao_Sair;
            this.pbSair.Location = new System.Drawing.Point(549, 3);
            this.pbSair.Name = "pbSair";
            this.pbSair.Size = new System.Drawing.Size(40, 33);
            this.pbSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSair.TabIndex = 1;
            this.pbSair.TabStop = false;
            this.pbSair.Click += new System.EventHandler(this.pbSair_Click);
            // 
            // btnDeslogar
            // 
            this.btnDeslogar.Enabled = false;
            this.btnDeslogar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeslogar.Location = new System.Drawing.Point(318, 172);
            this.btnDeslogar.Name = "btnDeslogar";
            this.btnDeslogar.Size = new System.Drawing.Size(102, 36);
            this.btnDeslogar.TabIndex = 15;
            this.btnDeslogar.Text = "Deslogar";
            this.btnDeslogar.UseVisualStyleBackColor = true;
            this.btnDeslogar.Click += new System.EventHandler(this.btnDeslogar_Click);
            // 
            // pbJuliaLogin
            // 
            this.pbJuliaLogin.Image = global::ProjetoCalculos.Properties.Resources.Julia_Login;
            this.pbJuliaLogin.Location = new System.Drawing.Point(21, 57);
            this.pbJuliaLogin.Name = "pbJuliaLogin";
            this.pbJuliaLogin.Size = new System.Drawing.Size(170, 149);
            this.pbJuliaLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbJuliaLogin.TabIndex = 14;
            this.pbJuliaLogin.TabStop = false;
            this.pbJuliaLogin.Visible = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.Location = new System.Drawing.Point(436, 172);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(88, 36);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // pbDanielLogin
            // 
            this.pbDanielLogin.Image = global::ProjetoCalculos.Properties.Resources.Daniel_Login;
            this.pbDanielLogin.Location = new System.Drawing.Point(22, 57);
            this.pbDanielLogin.Name = "pbDanielLogin";
            this.pbDanielLogin.Size = new System.Drawing.Size(170, 151);
            this.pbDanielLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDanielLogin.TabIndex = 12;
            this.pbDanielLogin.TabStop = false;
            this.pbDanielLogin.Visible = false;
            // 
            // pbKevinLogin
            // 
            this.pbKevinLogin.Image = global::ProjetoCalculos.Properties.Resources.Kevin_Login;
            this.pbKevinLogin.Location = new System.Drawing.Point(21, 57);
            this.pbKevinLogin.Name = "pbKevinLogin";
            this.pbKevinLogin.Size = new System.Drawing.Size(170, 151);
            this.pbKevinLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKevinLogin.TabIndex = 11;
            this.pbKevinLogin.TabStop = false;
            this.pbKevinLogin.Visible = false;
            // 
            // pbMariLogin
            // 
            this.pbMariLogin.Image = global::ProjetoCalculos.Properties.Resources.Mari_Login;
            this.pbMariLogin.Location = new System.Drawing.Point(19, 57);
            this.pbMariLogin.Name = "pbMariLogin";
            this.pbMariLogin.Size = new System.Drawing.Size(173, 151);
            this.pbMariLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMariLogin.TabIndex = 10;
            this.pbMariLogin.TabStop = false;
            this.pbMariLogin.Visible = false;
            // 
            // pbVictorLogin
            // 
            this.pbVictorLogin.Image = global::ProjetoCalculos.Properties.Resources.Perfil_Victor_removebg_preview__1_;
            this.pbVictorLogin.Location = new System.Drawing.Point(21, 59);
            this.pbVictorLogin.Name = "pbVictorLogin";
            this.pbVictorLogin.Size = new System.Drawing.Size(170, 147);
            this.pbVictorLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVictorLogin.TabIndex = 9;
            this.pbVictorLogin.TabStop = false;
            this.pbVictorLogin.Visible = false;
            // 
            // pbImagemDeLogin
            // 
            this.pbImagemDeLogin.Image = global::ProjetoCalculos.Properties.Resources.Avatar_Login_removebg_preview;
            this.pbImagemDeLogin.Location = new System.Drawing.Point(21, 59);
            this.pbImagemDeLogin.Name = "pbImagemDeLogin";
            this.pbImagemDeLogin.Size = new System.Drawing.Size(170, 147);
            this.pbImagemDeLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemDeLogin.TabIndex = 8;
            this.pbImagemDeLogin.TabStop = false;
            this.pbImagemDeLogin.Click += new System.EventHandler(this.pbImagemDeLogin_Click);
            // 
            // lblRecuperar
            // 
            this.lblRecuperar.AutoSize = true;
            this.lblRecuperar.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblRecuperar.Location = new System.Drawing.Point(412, 148);
            this.lblRecuperar.Name = "lblRecuperar";
            this.lblRecuperar.Size = new System.Drawing.Size(108, 15);
            this.lblRecuperar.TabIndex = 7;
            this.lblRecuperar.Text = "Recuperar a senha?";
            this.lblRecuperar.Click += new System.EventHandler(this.lblRecuperar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSenha.Location = new System.Drawing.Point(305, 106);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(219, 29);
            this.txtSenha.TabIndex = 6;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLogin.Location = new System.Drawing.Point(305, 59);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(219, 29);
            this.txtLogin.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(223, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(223, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login: ";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEntrar.Location = new System.Drawing.Point(221, 170);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(79, 37);
            this.btnEntrar.TabIndex = 1;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // frmSistemaDeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(769, 437);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSistemaDeLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login de Acesso";
            this.Load += new System.EventHandler(this.frmSistemaDeLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSenhaVisivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSenhaInvisivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJuliaLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDanielLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKevinLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMariLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVictorLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemDeLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pbImagemDeLogin;
        private Label lblRecuperar;
        private TextBox txtSenha;
        private TextBox txtLogin;
        private Label label2;
        private Label label1;
        private Button btnEntrar;
        private PictureBox pbVictorLogin;
        private PictureBox pbMariLogin;
        private PictureBox pbDanielLogin;
        private PictureBox pbKevinLogin;
        private Button btnLimpar;
        private PictureBox pbJuliaLogin;
        private Button btnDeslogar;
        private PictureBox pbSair;
        private PictureBox pbSenhaInvisivel;
        private PictureBox pbSenhaVisivel;
    }
}