using MySql.Data.MySqlClient;
using Mysqlx;
using MySqlX.XDevAPI;
using System.Data.Common;

namespace CRUD
{
	public partial class Cliente : Form
	{
		public Cliente()
		{
			InitializeComponent();
		}

			conexaobd conexaobd = new conexaobd();

		private void Form1_Load(object sender, EventArgs e)
		{
			var conexao = new MySqlConnection(conexaobd.strConexao);

			try
			{
				conexao.Open();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro na conexão com o banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void limpar()
		{
			txtNom.Text = "";
			txtTel.Text = "";
			txtEnd.Text = "";
			txtCpf.Text = "";
		}

		public void error(string ex)
		{
			MessageBox.Show("Erro no uso do comando, revise as informações inseridas. Erro MySql: " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var conexao = new MySqlConnection(conexaobd.strConexao);
			conexao.Open();

			try
			{
				string nome = txtNom.Text;
				string tel = txtTel.Text;
				string end = txtEnd.Text;
				string cpf = txtCpf.Text;

				string create = $"INSERT INTO cliente(nome, telefone, endereco, cpf) values ('{nome}', '{tel}', '{end}', '{cpf}')";

				var comando = new MySqlCommand(create, conexao);
				comando.ExecuteReader();

				limpar();
			}
			catch (Exception ex)
			{
				error(ex.Message);
			}

		}

		private void button2_Click(object sender, EventArgs e)
		{
			conexaobd conexaobd = new conexaobd();
			var conexao = new MySqlConnection(conexaobd.strConexao);
			conexao.Open();

			try
			{
				string cpf = txtCpf.Text;

				string create = "SELECT * FROM cliente where cpf = @cpf;";

				var comando = new MySqlCommand(create, conexao);
				comando.Parameters.AddWithValue("@cpf", cpf);

				using var myReader = comando.ExecuteReader();
				{
					while (myReader.Read())
					{
						txtNom.Text = myReader.GetString("nome");
						txtTel.Text = myReader.GetString("endereco");
						txtEnd.Text = myReader.GetString("telefone");
					}
				}
			}
			catch (Exception ex)
			{
				error(ex.Message);
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			conexaobd conexaobd = new conexaobd();
			var conexao = new MySqlConnection(conexaobd.strConexao);
			conexao.Open();

			try
			{
				string nome = txtNom.Text;
				string tel = txtTel.Text;
				string end = txtEnd.Text;
				string cpf = txtCpf.Text;

				string create = $"UPDATE cliente SET nome = '{nome}', telefone = '{tel}', endereco = '{end}' WHERE cpf = '{cpf}';";

				var comando = new MySqlCommand(create, conexao);

				using var myReader = comando.ExecuteReader();
				{
					while (myReader.Read())
					{
						txtNom.Text = myReader.GetString("nome");
						txtTel.Text = myReader.GetString("endereco");
						txtEnd.Text = myReader.GetString("telefone");
					}
				}

				limpar();
			}
			catch (Exception ex)
			{
				error(ex.Message);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			conexaobd conexaobd = new conexaobd();
			var conexao = new MySqlConnection(conexaobd.strConexao);
			conexao.Open();

			try
			{
				string cpf = txtCpf.Text;

				string create = "DELETE FROM cliente WHERE cpf = @cpf;";

				var comando = new MySqlCommand(create, conexao);
				comando.Parameters.AddWithValue("@cpf", cpf);

				comando.ExecuteReader();

				limpar();
			}
			catch (Exception ex)
			{
				error(ex.Message);
			}
		}
	}
}
