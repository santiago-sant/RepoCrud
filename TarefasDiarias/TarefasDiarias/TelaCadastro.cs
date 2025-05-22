using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarefasDiarias
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !string.IsNullOrWhiteSpace(txtNome.Text) && !string.IsNullOrWhiteSpace(txtSenhas.Text))
                {
                    Usuario novoUsuario = new Usuario();
                    novoUsuario.Nome = txtNome.Text;
                    novoUsuario.Email = txtEmail.Text;
                    novoUsuario.Senha = txtSenhas.Text;

                    if (novoUsuario.CadastrarUsuario())
                    {
                        MessageBox.Show("Usuário cadastrado com sucesso!");
                        TelaLogin telaLogin = new TelaLogin();
                        telaLogin.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar usuário.");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message);
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
