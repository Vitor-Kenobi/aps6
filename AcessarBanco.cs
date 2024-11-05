using Microsoft.Data.Sqlite;
using OpenCvSharp;
using SQLitePCL;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.LinkLabel;
using System.Windows.Forms.Design.Behavior;
using System.Windows.Forms;

namespace CNPA
{
    public class AcessarBanco
    {
        //private static string projDir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        private static string projDir = Path.GetDirectoryName(Application.ExecutablePath);
        private string dbDir = projDir+@"\database\CNPAdb.db";
        public DataTable GetInvestigacoes(string perfil)
        {
            string comando = "";

            switch (perfil)
            {
                case "Público":
                    comando = "SELECT * FROM tblInvestigacoes WHERE classificacao='Baixa'";
                    break;
                case "Diretoria":
                    comando = "SELECT * FROM tblInvestigacoes WHERE classificacao='Baixa' OR classificacao='Média'";
                    break;
                case "Ministro":
                    comando = "SELECT * FROM tblInvestigacoes";
                    break;

            }

            DataTable dataTable = new DataTable();

            using (var connection = new SqliteConnection($"Data Source={dbDir}"))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = comando;

                using (var reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }

            return dataTable;
        }

        public void InserirUsuario(string cpf, string nome, string acesso)
        {
            
            using (var connection = new SqliteConnection($"Data Source={dbDir}"))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"INSERT INTO tblUsuarios(CPF,Nome,NivelAcesso) VAlUES($cpf,$nome,$acesso)";

                command.Parameters.AddWithValue("$cpf", cpf);
                command.Parameters.AddWithValue("$nome", nome);
                command.Parameters.AddWithValue("$acesso", acesso);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqliteException ex)
                {
                    MessageBox.Show("Usuário já existe!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            
        }

        public string[] GetUsuario(string cpf)
        {
            string comando = "SELECT Nome, NivelAcesso FROM tblUsuarios WHERE cpf=$cpf";
            string[] resultado = new string[2];

            using (var connection = new SqliteConnection($"Data Source={dbDir}"))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = comando;
                command.Parameters.AddWithValue("$cpf", cpf);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        resultado[0] = reader.GetString(0);
                        resultado[1] = reader.GetString(1);
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            return resultado;
        }
    }
}
