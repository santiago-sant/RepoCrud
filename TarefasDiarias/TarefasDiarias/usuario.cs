
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text.RegularExpressions;


namespace TarefasDiarias
{
    class Usuario
    {
      
        private string nome;
        private string email;
        private string senha;


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public static string CriptografarSenha(string senha)
        {
            try
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }
                    return builder.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível criptografar a senha: " + ex.Message, "Erro - Método Criptografar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public static bool verificarEmail(string email)
        {
            string emailValido = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailValido);
            return regex.IsMatch(email);
        }

        public bool VerificarLogin()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new conexaoBD().Conectar())
                {
                    string verificar = "SELECT COUNT(*) FROM usuario WHERE Email = @Email AND Senha = @Senha";
                    MySqlCommand comando = new MySqlCommand(verificar, conexaoBanco);
                    comando.Parameters.AddWithValue("@Email", Email);
                    comando.Parameters.AddWithValue("@Senha", CriptografarSenha(Senha));

                    int resultado = Convert.ToInt32(comando.ExecuteScalar() ?? 0);
                    return resultado > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar o login: " + ex.Message);
                return false;
            }
        }

        public bool CadastrarUsuario()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new conexaoBD().Conectar())
                {
                    string SenhaCriptografada = CriptografarSenha(Senha);
                    string cadastrar = "INSERT INTO usuario (Nome, Email, Senha) VALUES (@Nome, @Email, @Senha)";
                    MySqlCommand comando = new MySqlCommand(cadastrar, conexaoBanco);
                    comando.Parameters.AddWithValue("@Nome", Nome);
                    comando.Parameters.AddWithValue("@Email", Email);
                    comando.Parameters.AddWithValue("@Senha", SenhaCriptografada);
                    int resultado = comando.ExecuteNonQuery();
                    return resultado > 0;
                }
                   
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nao foi possivel cadastar o usuário: " + ex.Message);
                return false;
            }
        }
    }
}
