using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TarefasDiarias
{
    class Tarefas
    {
        public int Id_Tarefas { get; set; }  
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Prazo { get; set; }
        public string Prioridade { get; set; }

        public bool CadastrarTarefa()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new conexaoBD().Conectar())
                {
                    string cadastrar = "INSERT INTO tarefa (Titulo, Descricao, Prazo, Prioridade) VALUES (@Titulo, @Descricao, @Prazo, @Prioridade)";
                    MySqlCommand comando = new MySqlCommand(cadastrar, conexaoBanco);
                    comando.Parameters.AddWithValue("@Titulo", Titulo);
                    comando.Parameters.AddWithValue("@Descricao", Descricao);
                    comando.Parameters.AddWithValue("@Prazo", Prazo);
                    comando.Parameters.AddWithValue("@Prioridade", Prioridade);

                    int resultado = comando.ExecuteNonQuery();
                    return resultado > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível cadastrar tarefa: " + ex.Message);
                return false;
            }
        }

        public bool EditarTarefas()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new conexaoBD().Conectar())
                {
                    string update = "UPDATE tarefa SET Titulo = @Titulo, Descricao = @Descricao, Prazo = @Prazo, Prioridade = @Prioridade WHERE Id_Tarefa = @Id_Tarefa";
                    MySqlCommand comando = new MySqlCommand(update, conexaoBanco);
                    comando.Parameters.AddWithValue("@Id_Tarefa", Id_Tarefas);
                    comando.Parameters.AddWithValue("@Titulo", Titulo);
                    comando.Parameters.AddWithValue("@Descricao", Descricao);
                    comando.Parameters.AddWithValue("@Prazo", Prazo);
                    comando.Parameters.AddWithValue("@Prioridade", Prioridade);

                    int resultado = comando.ExecuteNonQuery();
                    return resultado > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível editar a tarefa: " + ex.Message);
                return false;
            }
        }

        public bool ExcluirTarefa()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new conexaoBD().Conectar())
                {
                    string excluir = "DELETE FROM tarefa WHERE Id_tarefa = @Id_Tarefa";
                    MySqlCommand comando = new MySqlCommand(excluir, conexaoBanco);
                    comando.Parameters.AddWithValue("@Id_Tarefa", Id_Tarefas);
                    int resultado = comando.ExecuteNonQuery();
                    return resultado > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível excluir tarefa: " + ex.Message);
                return false;
            }
        }

        public static DataTable ListarTarefas()
        {
            DataTable tabela = new DataTable();
            try
            {
                using (MySqlConnection conexaoBanco = new conexaoBD().Conectar())
                {
                    string listar = "SELECT * FROM tarefa";
                    MySqlCommand comando = new MySqlCommand(listar, conexaoBanco);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    adaptador.Fill(tabela);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível listar tarefas: " + ex.Message);
                throw;
            }
            return tabela;
        }
    }
}
