using Desafio4ProWay.Repository;
using System.Data.SqlClient;

namespace Desafio4ProWay
{
    public class Database : BaseRepository
    {
        public bool VerificarExisitenciaTabelaJogos()
        {
            SqlConnection connection = ObterConexao();
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'JOGO'")
                {
                    Connection = connection
                };
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                bool existe = reader.Read();
                connection.Dispose();
                return existe;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public void CriarTabelasBancoDeDados()
        {
            if (!VerificarExisitenciaTabelaJogos())
            {
                SqlConnection connection = ObterConexao();
                try
                {
                    SqlCommand command = new SqlCommand(@"CREATE TABLE JOGO(
                                                    CODIGO INT PRIMARY KEY IDENTITY,
                                                    PLACAR INT,
                                                    MINIMOTEMPORADA INT,
                                                    MAXIMOTEMPORADA INT,
                                                    QUEBRARECORDEMINIMO INT,
                                                    QUEBRARECORDEMAXIMO INT
                                                    ); ")
                    {
                        Connection = connection
                    };
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Dispose();
                }
                finally
                {
                    connection.Dispose();
                }
            }
        }
    }
}

