using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace VirtuaLearn.DAL
{
    public class PerguntaDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.Pergunta pe)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"INSERT INTO Pergunta(Questao, Res1, Res2, Res3, Res4, Certa, Id_Quizz, Id_Professor, Id_Adm) VALUES (@questao, @res1, @res2, @res3, @res4, @certa, @idquizz, @idprofessor, @idadm)";

            cmd.Parameters.AddWithValue("@questao", pe.Questao);
            cmd.Parameters.AddWithValue("@RES1", pe.Res1);
            cmd.Parameters.AddWithValue("@res2", pe.Res2);
            cmd.Parameters.AddWithValue("@res3", pe.Res3);
            cmd.Parameters.AddWithValue("@res4", pe.Res4);
            cmd.Parameters.AddWithValue("certa", pe.Certa);
            cmd.Parameters.AddWithValue("idquizz", pe.IdQuizz);
            cmd.Parameters.AddWithValue("@idprofessor", pe.IdProfessor);
            cmd.Parameters.AddWithValue("idadm", pe.IdAdm);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public void Cadastrar1(BLL.Pergunta pe)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"INSERT INTO Pergunta(Questao, Res1, Res2, Res3, Res4, Certa, Id_Quizz, Id_Adm) VALUES (@questao, @res1, @res2, @res3, @res4, @certa, @idquizz, @idadm)";

            cmd.Parameters.AddWithValue("@questao", pe.Questao);
            cmd.Parameters.AddWithValue("@RES1", pe.Res1);
            cmd.Parameters.AddWithValue("@res2", pe.Res2);
            cmd.Parameters.AddWithValue("@res3", pe.Res3);
            cmd.Parameters.AddWithValue("@res4", pe.Res4);
            cmd.Parameters.AddWithValue("certa", pe.Certa);
            cmd.Parameters.AddWithValue("idquizz", pe.IdQuizz);
            cmd.Parameters.AddWithValue("idadm", pe.IdAdm);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public DataTable Listar()
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Pergunta, Questao, Res1, Res2, Res3, Res4, Certa, Id_Quizz, Id_Professor FROM Pergunta";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public DataTable Listar(BLL.Pergunta pe)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Pergunta, Questao, Res1, Res2, Res3, Res4, Certa, Id_Quizz, Id_Professor FROM Pergunta WHERE Questao LIKE @questao and Id_Professor = @idprofessor and Id_Quizz = @idquizz";

            cmd.Parameters.AddWithValue("@questao", "%" + pe.Questao + "%");
            cmd.Parameters.AddWithValue("@idprofessor", pe.IdProfessor);
            cmd.Parameters.AddWithValue("@idquizz", pe.IdQuizz);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public DataTable Listar1(BLL.Pergunta pe)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Pergunta, Questao, Res1, Res2, Res3, Res4, Certa, Id_Quizz, Id_Professor FROM Pergunta WHERE Id_Professor = @idprofessor and Id_Quizz = @idquizz";

            cmd.Parameters.AddWithValue("@idprofessor", pe.IdProfessor);
            cmd.Parameters.AddWithValue("@idquizz", pe.IdQuizz);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public DataTable Listar2(BLL.Pergunta pe)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Pergunta, Questao, Res1, Res2, Res3, Res4, Certa, Id_Quizz, Id_Professor FROM Pergunta WHERE Questao LIKE @questao and Id_Quizz = @idquizz";

            cmd.Parameters.AddWithValue("@questao", "%" + pe.Questao + "%");
            cmd.Parameters.AddWithValue("@idquizz", pe.IdQuizz);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public DataTable Listar3(BLL.Pergunta pe)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Pergunta, Questao, Res1, Res2, Res3, Res4, Certa, Id_Quizz, Id_Professor FROM Pergunta WHERE Id_Quizz = @idquizz";

            cmd.Parameters.AddWithValue("@idquizz", pe.IdQuizz);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public void Excluir(BLL.Pergunta pe)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"DELETE FROM Pergunta WHERE Id_Pergunta = @idpergunta";

            cmd.Parameters.AddWithValue("@idpergunta", pe.IdPergunta);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public BLL.Pergunta PreencherPeloID(BLL.Pergunta pe)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Pergunta, Questao, Res1, Res2, Res3, Res4, Certa, Id_Quizz, Id_Professor, Id_Adm FROM Pergunta WHERE Id_Pergunta LIKE @idpergunta";
            cmd.Parameters.AddWithValue("@idpergunta", pe.IdPergunta);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                pe.IdPergunta = Convert.ToInt32(dr["Id_Pergunta"]);
                pe.Questao = dr["Questao"].ToString();
                pe.Res1 = dr["Res1"].ToString();
                pe.Res2 = dr["Res2"].ToString();
                pe.Res3 = dr["Res3"].ToString();
                pe.Res4 = dr["Res4"].ToString();
                pe.Certa = dr["Certa"].ToString();
                pe.IdQuizz = Convert.ToInt32(dr["Id_Quizz"]);
                pe.IdProfessor = Convert.ToInt32(dr["Id_Professor"]);
                pe.IdAdm = Convert.ToInt32(dr["Id_Adm"]);
                dr.Close();
            }
            else
            {
                pe.IdPergunta = 0;
            }

            con.Desconectar();
            return pe;
        }

        public BLL.Pergunta PreencherPeloID2(BLL.Pergunta pe)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Pergunta, Questao, Res1, Res2, Res3, Res4, Certa, Id_Quizz, Id_Professor, Id_Adm FROM Pergunta WHERE Id_quizz LIKE @idquizz";
            cmd.Parameters.AddWithValue("@idquizz", pe.IdQuizz);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                pe.IdPergunta = Convert.ToInt32(dr["Id_Pergunta"]);
                pe.Questao = dr["Questao"].ToString();
                pe.Res1 = dr["Res1"].ToString();
                pe.Res2 = dr["Res2"].ToString();
                pe.Res3 = dr["Res3"].ToString();
                pe.Res4 = dr["Res4"].ToString();
                pe.Certa = dr["Certa"].ToString();
                pe.IdQuizz = Convert.ToInt32(dr["Id_Quizz"]);

                if (dr["Id_Professor"] is DBNull)
                {
                    pe.IdProfessor = 0;
                }
                else
                {
                    pe.IdProfessor = Convert.ToInt32(dr["Id_Professor"]);
                }

                pe.IdAdm = Convert.ToInt32(dr["Id_Adm"]);
                dr.Close();
            }
            else
            {
                pe.IdPergunta = 0;
            }

            con.Desconectar();
            return pe;
        }

        public BLL.Pergunta PreencherPeloID1(BLL.Pergunta pe)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Pergunta, Questao, Res1, Res2, Res3, Res4, Certa, Id_Quizz, Id_Adm FROM Pergunta WHERE Id_Pergunta LIKE @idpergunta";
            cmd.Parameters.AddWithValue("@idpergunta", pe.IdPergunta);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                pe.IdPergunta = Convert.ToInt32(dr["Id_Pergunta"]);
                pe.Questao = dr["Questao"].ToString();
                pe.Res1 = dr["Res1"].ToString();
                pe.Res2 = dr["Res2"].ToString();
                pe.Res3 = dr["Res3"].ToString();
                pe.Res4 = dr["Res4"].ToString();
                pe.Certa = dr["Certa"].ToString();
                pe.IdQuizz = Convert.ToInt32(dr["Id_Quizz"]);
                pe.IdAdm = Convert.ToInt32(dr["Id_Adm"]);
                dr.Close();
            }
            else
            {
                pe.IdPergunta = 0;
            }

            con.Desconectar();
            return pe;
        }

        public void Atualizar(BLL.Pergunta pe)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"UPDATE Pergunta SET Questao = @questao, Res1 = @res1, Res2 = @res2, Res3 = @res3, Res4 = @res4, Certa = @Certa WHERE Id_Pergunta = @idpergunta";

            cmd.Parameters.AddWithValue("idpergunta", pe.IdPergunta);
            cmd.Parameters.AddWithValue("@questao", pe.Questao);
            cmd.Parameters.AddWithValue("@res1", pe.Res1);
            cmd.Parameters.AddWithValue("@res2", pe.Res2);
            cmd.Parameters.AddWithValue("@res3", pe.Res3);
            cmd.Parameters.AddWithValue("@res4", pe.Res4);
            cmd.Parameters.AddWithValue("@certa", pe.Certa);
            cmd.Parameters.AddWithValue("@idquizz", pe.IdQuizz);
            cmd.Parameters.AddWithValue("@idprofessr", pe.IdProfessor);
            cmd.Parameters.AddWithValue("@idadm", pe.IdAdm);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }
    }
}