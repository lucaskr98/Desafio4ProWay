using System.Data.SqlClient;

namespace Desafio4ProWay.Repository
{
    public class BaseRepository
    {
        const string STR_CONNECTION = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\smigo\Documents\Desafio4BD.mdf;Integrated Security = True; Connect Timeout = 30";

        public SqlConnection ObterConexao()
        {
            return new SqlConnection(STR_CONNECTION);
        }
    }
}
