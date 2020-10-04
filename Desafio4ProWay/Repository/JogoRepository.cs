using Desafio4ProWay.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Desafio4ProWay.Repository
{
    public class JogoRepository : BaseRepository
    {
        public void CadastrarNovoJogo(JogoBE jogo)
        {
            SqlConnection connection = ObterConexao();
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO JOGO (PLACAR,MINIMOTEMPORADA,MAXIMOTEMPORADA,QUEBRARECORDEMINIMO,QUEBRARECORDEMAXIMO) VALUES (@PLACAR,@MINIMOTEMPORADA,@MAXIMOTEMPORADA,@QUEBRARECORDEMINIMO,@QUEBRARECORDEMAXIMO)");
                command.Parameters.AddWithValue("@PLACAR", jogo.Placar);
                command.Parameters.AddWithValue("@MINIMOTEMPORADA", jogo.MinimoTemporada);
                command.Parameters.AddWithValue("@MAXIMOTEMPORADA", jogo.MaximoTemporada);
                command.Parameters.AddWithValue("@QUEBRARECORDEMINIMO", jogo.QuebraRecordeMinimo);
                command.Parameters.AddWithValue("@QUEBRARECORDEMAXIMO", jogo.QuebraRecordeMaximo);
                connection.Open();
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
            finally
            {
                connection.Dispose();
            }
        }

        public List<JogoBE> ObterJogosCadastrados()
        {
            SqlConnection connection = ObterConexao();
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM JOGO")
                {
                    Connection = connection
                };
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<JogoBE> jogos = new List<JogoBE>();

                while (reader.Read())
                {
                    jogos.Add(new JogoBE()
                    {
                        Codigo = (int)reader["CODIGO"],
                        Placar = (int)reader["PLACAR"],
                        MinimoTemporada = (int)reader["MINIMOTEMPORADA"],
                        MaximoTemporada = (int)reader["MAXIMOTEMPORADA"],
                        QuebraRecordeMinimo = (int)reader["QUEBRARECORDEMINIMO"],
                        QuebraRecordeMaximo = (int)reader["QUEBRARECORDEMAXIMO"]

                    });

                }
                return jogos;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public int ObterPlacarMinimo()
        {
            int PlacarMinimo = 0;
            SqlConnection connection = ObterConexao();
            SqlCommand command = new SqlCommand("SELECT ISNULL(MIN(PLACAR),0) PLACAR FROM JOGO") {Connection = connection };
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if(reader.Read())
            {
                PlacarMinimo = (int)reader["PLACAR"];
            }

            return PlacarMinimo;
        }

        public int ObterPlacarMaximo()
        {
            int PlacarMaximo = 0;
            SqlConnection connection = ObterConexao();
            SqlCommand command = new SqlCommand("SELECT ISNULL(MAX(PLACAR),0) PLACAR FROM JOGO") { Connection = connection };
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                PlacarMaximo = (int)reader["PLACAR"];
            }

            return PlacarMaximo;
        }

        public int ObterRecordeMinimo()
        {
            int RecordeMinimo = 0;
            SqlConnection connection = ObterConexao();
            SqlCommand command = new SqlCommand("SELECT ISNULL(MAX(QUEBRARECORDEMINIMO),0) QUEBRARECORDEMINIMO FROM JOGO") { Connection = connection };
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                RecordeMinimo = (int)reader["QUEBRARECORDEMINIMO"];
            }

            return RecordeMinimo;
        }

        public int ObterRecordeMaximo()
        {
            int RecordeMaximo = 0;
            SqlConnection connection = ObterConexao();
            SqlCommand command = new SqlCommand("SELECT ISNULL(MAX(QUEBRARECORDEMAXIMO),0) QUEBRARECORDEMAXIMO FROM JOGO") { Connection = connection };
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                RecordeMaximo = (int)reader["QUEBRARECORDEMAXIMO"];
            }

            return RecordeMaximo;
        }

        public void DeletarDados()
        {
            SqlConnection connection = ObterConexao();
            SqlCommand command = new SqlCommand("DELETE FROM JOGO; DBCC CHECKIDENT ('[JOGO]', RESEED, 0)") { Connection = connection };
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}