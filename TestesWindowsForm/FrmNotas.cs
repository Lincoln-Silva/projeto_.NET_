using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TestesWindowsForm
{
    public partial class FrmNotas : Form
    {
        double media;

        public FrmNotas()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                media = (Convert.ToDouble(txtNota1Sem.Text) + Convert.ToDouble(txtNota2Sem.Text)) / 2;
                StatusAluno(media);

                //Cria a string de conexão com o banco de dados SkyOne, servidor localhost
                string connectionString = "Server=localhost;Database=SkyOne;Trusted_Connection=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        //Abre a conexão com o banco de dados
                        connection.Open();

                        //Insere as informações do aluno no banco de dados
                        InserirAluno(connection, txtNomeAluno.Text, Convert.ToDouble(txtNota1Sem.Text.Replace('.', ',')), Convert.ToDouble(txtNota2Sem.Text.Replace('.', ',')), DateTime.Now.Year);

                        MessageBox.Show("Informações do aluno inseridas com sucesso.");

                        //Fecha a conexão com o banco de dados
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocorreu um erro ao inserir as informações dos alunos: {ex.Message}", "Erro SQL");
                    }
                }
            }
        }

        //Volta a tela ao estado inicial (campos vazios e mensagens iniciais)
        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            txtNomeAluno.Text = String.Empty;
            txtNota1Sem.Text = String.Empty;
            txtNota2Sem.Text = String.Empty;

            lblNomeAlunoObrigatorio.Visible = false;
            lblNota1SemObrigatorio.Visible = false;
            lblNota2SemObrigatorio.Visible = false;

            lblAprovado.ForeColor = Color.Gray;
            lblAprovado.Text = "Nota não enviada.";
        }

        //Verifica se os campos obrigatórios foram preenchidos
        private bool ValidaCampos()
        {
            Boolean valido = true;

            if (String.IsNullOrEmpty(txtNomeAluno.Text))
            {
                lblNomeAlunoObrigatorio.Visible = true;
                valido = false;
            }
            else
            {
                lblNomeAlunoObrigatorio.Visible = false;
            }

            if (String.IsNullOrEmpty(txtNota1Sem.Text))
            {
                lblNota1SemObrigatorio.Visible = true;
                valido = false;
            }
            else
            {
                lblNota1SemObrigatorio.Visible = false;
            }

            if (String.IsNullOrEmpty(txtNota2Sem.Text))
            {
                lblNota2SemObrigatorio.Visible = true;
                valido = false;
            }
            else
            {
                lblNota2SemObrigatorio.Visible = false;
            }

            return valido;
        }

        //Verifica qual é o Status do Aluno
        private void StatusAluno(double pMedia)
        {
            if (pMedia < 6.5)
            {
                lblAprovado.ForeColor = Color.Red;
                lblAprovado.Text = "Reprovado";
            }
            else if (pMedia >= 6.5)
            {
                lblAprovado.ForeColor = Color.Green;
                lblAprovado.Text = "Aprovado";
            }            
        }

        private void txtNota1Sem_Validating(object sender, CancelEventArgs e)
        {
            //Verifica se o campo txtNota2Sem está preenchido com um número válido ou vazio, cancela operação se não tiver
            if (!double.TryParse(txtNota1Sem.Text, out double a) && !String.IsNullOrEmpty(txtNota1Sem.Text))
            {
                e.Cancel = true;
            }
        }

        private void txtNota2Sem_Validating(object sender, CancelEventArgs e)
        {
            //Verifica se o campo txtNota2Sem está preenchido com um número válido ou vazio, cancela operação se não tiver
            if (!double.TryParse(txtNota2Sem.Text, out double a) && !String.IsNullOrEmpty(txtNota2Sem.Text))
            {
                e.Cancel = true;
            }
        }

        static void InserirAluno(SqlConnection connection, string nome, double nota1Semestre, double nota2Semestre, int anoLancamento)
        {
            string query = "INSERT INTO Alunos (Nome, Nota1Semestre, Nota2Semestre, AnoLancamento) " +
                           "VALUES (@Nome, @Nota1Semestre, @Nota2Semestre, @AnoLancamento)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nome", nome);
                command.Parameters.AddWithValue("@Nota1Semestre", nota1Semestre);
                command.Parameters.AddWithValue("@Nota2Semestre", nota2Semestre);
                command.Parameters.AddWithValue("@AnoLancamento", anoLancamento);

                command.ExecuteNonQuery();
            }
        }
    }
}
