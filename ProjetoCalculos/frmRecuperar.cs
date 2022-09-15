using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCalculos
{
    public partial class frmRecuperarSenha : Form
    {
        public frmRecuperarSenha()
        {
            InitializeComponent();
        }

        private void btnRecuperarLogin_Click(object sender, EventArgs e)
        {
            if (txtRecuperacaoLogin.Text == "Victor Pascon")
            {
                lblDigiteLogin.Visible = false;
                lblPergunta.Visible = true;

                lblPergunta.Text = "Qual o nome da minha gatinha?";

                txtRecuperacaoLogin.Visible = false;
                txtResposta.Visible = true;

                btnRecuperarLogin.Enabled = false;
                btnAltenticar.Enabled = true;
                btnDeslogar.Enabled = true;

                pbImagemDeLoginRecuperacao.Visible = false;
                pbVictorPascon.Visible = true;
            }

            else if (txtRecuperacaoLogin.Text == "Marilaine Pascon")
            {
                lblDigiteLogin.Visible = false;
                lblPergunta.Visible = true;

                lblPergunta.Text = "Qual o apelido carinhoso do Victor?";

                txtRecuperacaoLogin.Visible = false;
                txtResposta.Visible = true;

                btnRecuperarLogin.Enabled = false;
                btnAltenticar.Enabled = true;
                btnDeslogar.Enabled = true;

                pbImagemDeLoginRecuperacao.Visible = false;
                pbRecuperarMari.Visible = true;
            }

            else if (txtRecuperacaoLogin.Text == "Ethan Kevin")
            {
                lblDigiteLogin.Visible = false;
                lblPergunta.Visible = true;

                lblPergunta.Text = "Qual a linguagem de programação eu vou usar?";

                txtRecuperacaoLogin.Visible = false;
                txtResposta.Visible = true;

                pbImagemDeLoginRecuperacao.Visible = false;
                pbRecuperarKevin.Visible = true;

                btnRecuperarLogin.Enabled = false;
                btnAltenticar.Enabled = true;
                btnDeslogar.Enabled = true;

                
            }

            else if (txtRecuperacaoLogin.Text == "Claudio Daniel")
            {
                lblDigiteLogin.Visible = false;
                lblPergunta.Visible = true;
                
                lblPergunta.Text = "Qual o melhor personagem de todos?";

                txtRecuperacaoLogin.Visible = false;
                txtResposta.Visible = true;

                btnRecuperarLogin.Enabled = false;
                btnAltenticar.Enabled = true;
                btnDeslogar.Enabled = true;

                pbImagemDeLoginRecuperacao.Visible = false;
                pbRecuperarDaniel.Visible = true;
            }

            else if (txtRecuperacaoLogin.Text == "Juba")
            {
                lblDigiteLogin.Visible = false;
                lblPergunta.Visible = true;

                lblPergunta.Text = "Qual o nome do meu namorado no SV?";

                txtRecuperacaoLogin.Visible = false;
                txtResposta.Visible = true;

                btnRecuperarLogin.Visible = false;
                pbImagemDeLoginRecuperacao.Visible = false;
                
                
                btnAltenticar.Visible = true;
                btnDeslogar.Enabled = true;

            }

            else
            {
                MessageBox.Show("Esse login não é valido!", 
                                "Mensagem de Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

        }

        private void txtRecuperacaoLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAltenticar_Click(object sender, EventArgs e)
        {
            if (txtResposta.Text == "Rose" &&txtRecuperacaoLogin.Text == "Victor Pascon")
            {
                MessageBox.Show("Olá Victor Pascon, a sua senha é '310721'. Tente não esquecer desta vez!",
                                "Recuperação de Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (txtResposta.Text == "Mozo" &&txtRecuperacaoLogin.Text == "Marilaine Pascon")
            {
                MessageBox.Show("Olá Marilaine Pascon, a sua senha é '310721'. Tente não esquecer desta vez!",
                                "Recuperação de Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (txtResposta.Text == "C++" &&txtRecuperacaoLogin.Text == "Ethan Kevin")
            {
                MessageBox.Show("Olá Ethan Kevin, a sua senha é 'mc kevinho'. Tente não esquecer desta vez!",
                                "Recuperação de Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (txtResposta.Text == "Capitão Patria" &&txtRecuperacaoLogin.Text == "Claudio Daniel")
            {
                MessageBox.Show("Olá Carlos Daniel, a sua senha é 'capitão patria é o melhor'. Tente não esquecer desta vez!",
                                "Recuperação de Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (txtResposta.Text == "Alex" &&txtRecuperacaoLogin.Text == "Juba")
            {
                MessageBox.Show("Olá Julia Juba, a sua senha é 'alex love'. Tente não esquecer desta vez!",
                                "Recuperação de Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Pergunta de recuperação respondida incorretamente, por favor, tente novamente!",
                                "Recuperação Invalidada", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pbImagemDeLoginRecuperacao.Visible = true;
            
            if (txtRecuperacaoLogin.Visible = false)
            {
                txtRecuperacaoLogin.Text = "";
                txtResposta.Text = "";
            }

            else
            {
                txtResposta.Text = "";
            }

        }

        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            pbVictorPascon.Visible = false;
            pbRecuperarMari.Visible = false;
            pbRecuperarKevin.Visible = false;
            pbRecuperarDaniel.Visible = false;
            pbRecuperarJulia.Visible = false;

            lblDigiteLogin.Visible = true;
            lblPergunta.Visible = false;
            
            txtRecuperacaoLogin.Visible = true;
            txtResposta.Visible = false;

            txtRecuperacaoLogin.Text = "";
            txtResposta.Text = "";

            btnAltenticar.Enabled = false;
            btnDeslogar.Enabled = false;
            btnRecuperarLogin.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
