using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ListaContatoReborn
{
    public class ConexaoBD
    {

        private const string Server = "localhost"; // ou 127.0.0.1
        private const string Database = "listacontatos";
        private const string User = "root";
        private const string Password = "";
        private const string Port = "3306";

        private static string ConnectionString =>
            $"Server={Server};Database={Database};User ID={User};Password={Password};Port={Port};";

        public MySqlConnection ObterConexao()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}