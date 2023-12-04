using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ListaContatoReborn
{
    public partial class ListaContatoReborn : Form
    {
        
        private List<Contato> ListaContatos = new List<Contato>();
       

        public ListaContatoReborn()
        {
            InitializeComponent();
            AtualizarExibição();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();

        }
        private void CriarComponente()
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txbNome.Text;
                string Email = txbEmail.Text;
                string Telefone = txbTelefone.Text;
                DateTime DataAniversario = dtpAniversario.Value;
                using (MySqlConnection connection = new ConexaoBD().ObterConexao())
            
            {
                connection.Open();
                string query = "INSERT INTO contatos(nome, email, telefone,data_aniversario) VALUES(@nome, @email,@telefone,@data_aniversario)";
                MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nome", nome);
                    command.Parameters.AddWithValue("@email", Email);
                    command.Parameters.AddWithValue("@telefone", Telefone);
                    command.Parameters.AddWithValue("@data_aniversario", DataAniversario);
                    command.ExecuteNonQuery();


                }
                LimparCampos();
                AtualizarExibição();

        }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar:"+ ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

    } 
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvContatos.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvContatos.SelectedRows[0];
                    int id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                    string nome = txbNome.Text;
                    string email = txbEmail.Text;
                    string Telefone = txbTelefone.Text;
                    DateTime DataAniversario = dtpAniversario.Value;
                    using (MySqlConnection connection = new ConexaoBD().ObterConexao())

                    {


                        connection.Open();

                        string query = "UPDATE contatos SET nome=@nome, email=@email, telefone=@telefone, data_aniversario=@data_aniversario WHERE id=@id";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@nome", nome);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@telefone", Telefone);
                        command.Parameters.AddWithValue("@data_aniversario", DataAniversario);
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                    LimparCampos();
                    AtualizarExibição();

                }
                else
                {
                    MessageBox.Show("Selecione um contato para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvContatos.SelectedRows.Count>0)
                {
                    DataGridViewRow selectedRow = dgvContatos.SelectedRows[0];
                    int Id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                    using (MySqlConnection connection = new ConexaoBD().ObterConexao())
                    {
                        connection.Open();
                        string query = "DELETE FROM contatos WHERE id=@id";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@id", Id);
                        command.ExecuteNonQuery();
                    }
                    LimparCampos();
                    AtualizarExibição();


                }
                else
                {
                    MessageBox.Show("Selecione um contato para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao remover:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void LimparCampos()
        {
            txbNome.Clear();
            txbEmail.Clear();
            txbTelefone.Clear();
            dtpAniversario.Value=DateTime.Now;
        }
        private void AtualizarExibição()
        {
            ListaContatos.Clear();
            using (MySqlConnection connection = new ConexaoBD().ObterConexao())
            {
                connection.Open();
                string query = "SELECT id, nome, email, telefone, data_aniversario FROM contatos";
                MySqlCommand command = new MySqlCommand(query, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Contato contato = new Contato()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Nome = reader["nome"].ToString(),
                            Email = reader["email"].ToString(),
                            Telefone = reader["telefone"].ToString(),
                            DataAniversario = Convert.ToDateTime(reader["data_aniversario"])
                        };
                        ListaContatos.Add(contato);
                    }



                }
                

                        
            }
            dgvContatos.DataSource = null;
            dgvContatos.DataSource = ListaContatos;
            
            

        }

        private void dgvContatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvContatos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvContatos.SelectedRows[0];

                // Preencher os campos do formulário com os dados da linha selecionada
                txbNome.Text = selectedRow.Cells["nome"].Value.ToString();
                txbEmail.Text = selectedRow.Cells["email"].Value.ToString();
                txbTelefone.Text = selectedRow.Cells["telefone"].Value.ToString();
                dtpAniversario.Value = Convert.ToDateTime(selectedRow.Cells["data_aniversario"].Value);
            }
        }
    }
}
