using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Certifique-se de que o namespace correto está sendo usado
using TarefasDiarias; // Verifique se o namespace "Models" realmente existe no projeto


namespace TarefasDiarias
{
    public partial class TelaCrud : Form
    {
        public TelaCrud()
        {
            InitializeComponent();
        }

        private void CarregarTarefas()
        {
            try
            {
                dgvTarefas.DataSource = Tarefas.ListarTarefas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tarefas: " + ex.Message);
            }
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtTitulo.Text) && !string.IsNullOrWhiteSpace(txtDescricao.Text) && !string.IsNullOrWhiteSpace(cbPrioridades.Text))
                {
                    Tarefas novaTarefa = new Tarefas();
                    novaTarefa.Id_Tarefas = txtID.Text;
                    novaTarefa.Titulo = txtTitulo.Text;
                    novaTarefa.Descricao = txtDescricao.Text;
                    novaTarefa.Prazo = dtpPrazo.Value;
                    novaTarefa.Prioridade = cbPrioridades.Text;
                    if (novaTarefa.CadastrarTarefa())
                    {
                        MessageBox.Show("Tarefa cadastrada com sucesso!");
                        txtDescricao.Clear();
                        txtTitulo.Clear();
                        cbPrioridades.SelectedIndex = -1;
                        CarregarTarefas();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar tarefa.");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar tarefa: " + ex.Message);
            }
        }

        private void TelaCrud_Load(object sender, EventArgs e)
        {
            CarregarTarefas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {


                Tarefas tarefa = new Tarefas
                {
                    Id_Tarefas = int.Parse(txtID.Text),
                    Titulo = txtTitulo.Text,
                    Descricao = txtDescricao.Text,
                    Prazo = dtpPrazo.Value,
                    Prioridade = cbPrioridades.Text
                };

                if (tarefa.EditarTarefas())
                {
                    MessageBox.Show("Tarefa editada com sucesso!");
                    CarregarTarefas();
                    txtID.Clear();
                    txtTitulo.Clear();
                    txtDescricao.Clear();
                    cbPrioridades.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Erro ao editar tarefa.");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar tarefa: " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtTitulo.Text))
                {
                    Tarefas tarefa = new Tarefas { Id_Tarefas = int.Parse(txtID.Text) };

                    if (tarefa.ExcluirTarefa())
                    {
                        MessageBox.Show("Tarefa excluída com sucesso!");
                        txtID.Clear();
                        txtTitulo.Clear();
                        txtDescricao.Clear();
                        cbPrioridades.SelectedIndex = -1;
                        CarregarTarefas();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir tarefa.");
                    }
                }
                else
                {
                    MessageBox.Show("Informe o título da tarefa para excluir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir tarefa: " + ex.Message);
            }

        }

        private void dgvTarefas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvTarefas.Rows[e.RowIndex].Cells["Id_Tarefa"].Value != null)
            {
                DataGridViewRow row = dgvTarefas.Rows[e.RowIndex];

                txtID.Text = row.Cells["Id_Tarefa"].Value.ToString(); 
                txtTitulo.Text = row.Cells["Titulo"].Value.ToString();
                txtDescricao.Text = row.Cells["Descricao"].Value.ToString();

                if (DateTime.TryParse(row.Cells["Prazo"].Value.ToString(), out DateTime prazo))
                {
                    dtpPrazo.Value = prazo;
                }

                cbPrioridades.Text = row.Cells["Prioridade"].Value.ToString();
            }
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTitulo_TextChanged_1(object sender, EventArgs e)
        {

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
