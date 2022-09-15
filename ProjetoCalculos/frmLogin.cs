namespace ProjetoCalculos
{
    public partial class frmSistemaDeLogin : Form
    {
        public frmSistemaDeLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" &&txtSenha.Text == "")
            {
                MessageBox.Show("Por favor digite o seu login e senha!",
                                "Aviso Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

            else if (txtLogin.Text == "Victor Pascon" &&txtSenha.Text == "310721")
            {
                MessageBox.Show("Seja muito bem-vindo",
                                "Login Aprovado", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                pbImagemDeLogin.Visible = false;
                pbVictorLogin.Visible = true;

                btnEntrar.Enabled = false;
                btnDeslogar.Enabled = true;
            }

            else if (txtLogin.Text == "Marilaine Pascon" &&txtSenha.Text == "310721")
            {
                MessageBox.Show("Seja muito bem-vindo",
                                "Login Aprovado", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                pbImagemDeLogin.Visible = false;
                pbMariLogin.Visible = true;

                btnEntrar.Enabled = false;
                btnDeslogar.Enabled = true;
            }

            else if (txtLogin.Text == "Claudio Daniel" &&txtSenha.Text == ("capitão patria é o melhor"))
            {
                MessageBox.Show("Seja muito bem-vindo",
                                "Login Aprovado", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                pbImagemDeLogin.Visible = false;
                pbDanielLogin.Visible = true;

                btnEntrar.Enabled = false;
                btnDeslogar.Enabled = true;
            }

            else if (txtLogin.Text == "Ethan Kevin" &&txtSenha.Text == "mc kevinho")
            {
                MessageBox.Show("Seja muito bem-vindo",
                                "Login Aprovado", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                pbImagemDeLogin.Visible = false;
                pbKevinLogin.Visible = true;

                btnEntrar.Enabled = false;
                btnDeslogar.Enabled = true;
            }

            else if  (txtLogin.Text == "Juba" &&txtSenha.Text == "alex love")
            {
                MessageBox.Show("Seja muito bem-vindo",
                                "Login Aprovado", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                pbImagemDeLogin.Visible = false;
                pbJuliaLogin.Visible = true;

                btnEntrar.Enabled = false;
                btnDeslogar.Enabled = true;
            }

            else
            {
                MessageBox.Show("Login ou Senha incorretos, tente novamente!",
                                "Login invalido", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                pbVictorLogin.Visible = false;
                pbDanielLogin.Visible = false;
                pbMariLogin.Visible = false;
                pbKevinLogin.Visible = false;
                pbImagemDeLogin.Visible = true;

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }

        private void lblRecuperar_Click(object sender, EventArgs e)
        {
            frmRecuperarSenha Recuperar = new frmRecuperarSenha();
            Recuperar.ShowDialog();
        }

        private void pbImagemDeLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void frmSistemaDeLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtSenha.Text = "";

        }

        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            pbVictorLogin.Visible = false;
            pbMariLogin.Visible = false;
            pbKevinLogin.Visible = false;
            pbDanielLogin.Visible = false;
            pbJuliaLogin.Visible = false;
            pbImagemDeLogin.Visible = true;

            txtLogin.Text = "";
            txtSenha.Text = "";

            btnDeslogar.Enabled = false;
            btnEntrar.Enabled = true;
        }

        private void pbSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbOlharSenha_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pbSenhaInvisivel.Visible = false;
            pbSenhaVisivel.Visible = true;

            txtSenha.UseSystemPasswordChar = false;

        }

        private void pbSenhaVisivel_Click(object sender, EventArgs e)
        {
            pbSenhaVisivel.Visible = false;
            pbSenhaInvisivel.Visible = true;

            txtSenha.UseSystemPasswordChar = true;

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}