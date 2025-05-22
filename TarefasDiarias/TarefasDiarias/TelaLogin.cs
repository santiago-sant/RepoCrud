namespace TarefasDiarias
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtEmail.Text.Equals("") && !txtSenha.Text.Equals(""))
                {
                    Usuario usuario = new Usuario();
                    usuario.Email = txtEmail.Text;
                    usuario.Senha = txtSenha.Text;


                    if (usuario.VerificarLogin())
                    {
                        MessageBox.Show("Login realizado com sucesso!");
                        TelaCrud tela = new TelaCrud();
                        tela.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos!");
                        txtEmail.Clear();
                        txtSenha.Clear();
                    }

                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel acessar o sistema! " + ex.Message, "Erro - Método btnEntrar_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
