using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace VirtuaLearn.DAL
{
    public class QuizzDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.Quizz zz)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"INSERT INTO Quizz(Nome, Id_Curso, Id_Professor, Id_Adm) VALUES (@nome, @idCurso, @idprofessor, @idadm)";

            cmd.Parameters.AddWithValue("@nome", zz.Nome);
            cmd.Parameters.AddWithValue("@idcurso", zz.IdCurso);
            cmd.Parameters.AddWithValue("@idprofessor", zz.IdProfessor);
            cmd.Parameters.AddWithValue("idadm", zz.IdAdm);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public void Cadastrar1(BLL.Quizz zz)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"INSERT INTO Quizz(Nome, Id_Curso, Id_Adm) VALUES (@nome, @idCurso, @idadm)";

            cmd.Parameters.AddWithValue("@nome", zz.Nome);
            cmd.Parameters.AddWithValue("@idcurso", zz.IdCurso);
            cmd.Parameters.AddWithValue("idadm", zz.IdAdm);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public DataTable Listar()
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Quizz, Nome, Id_Curso, Id_Professor, Id_Adm FROM Quizz";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public DataTable Listar(BLL.Quizz zz)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Quizz, Nome, Id_Curso, Id_Professor FROM Quizz WHERE Nome LIKE @nome and Id_Professor = @idprofessor";

            cmd.Parameters.AddWithValue("@nome", "%" + zz.Nome + "%");
            cmd.Parameters.AddWithValue("@idprofessor", zz.IdProfessor);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public DataTable Listar1(BLL.Quizz zz)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Quizz, Nome, Id_Curso, Id_Professor FROM Quizz WHERE Id_Professor = @idprofessor";

            cmd.Parameters.AddWithValue("@idprofessor", zz.IdProfessor);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public DataTable Listar2(BLL.Quizz zz)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Quizz, Nome, Id_Curso, Id_Professor, Id_Adm FROM Quizz WHERE Nome LIKE @nome";

            cmd.Parameters.AddWithValue("@nome", "%" + zz.Nome + "%");

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public void Excluir(BLL.Quizz zz)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"DELETE FROM Quizz WHERE Id_Quizz = @idquizz";

            cmd.Parameters.AddWithValue("@idquizz", zz.IdQuizz);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public BLL.Quizz PreencherPeloID(BLL.Quizz zz)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Quizz, Nome, Id_Curso, Id_Professor, Id_Adm FROM Quizz WHERE Id_Quizz LIKE @idquizz";
            cmd.Parameters.AddWithValue("@idquizz", zz.IdQuizz);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                zz.IdQuizz = Convert.ToInt32(dr["Id_Quizz"]);
                zz.Nome = dr["Nome"].ToString();
                zz.IdCurso = Convert.ToInt32(dr["Id_Curso"]);

                if (dr["Id_Professor"] is DBNull)
                {
                    zz.IdProfessor = 0;
                }
                else
                {
                    zz.IdProfessor = Convert.ToInt32(dr["Id_Professor"]);
                }

                zz.IdAdm = Convert.ToInt32(dr["Id_Adm"]);
                dr.Close();
            }
            else
            {
                zz.IdQuizz = 0;
            }
            con.Desconectar();
            return zz;
        }

        public void Atualizar(BLL.Quizz zz)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"UPDATE Quizz SET Nome = @nome WHERE Id_Quizz = @idquizz";

            cmd.Parameters.AddWithValue("@idquizz", zz.IdQuizz);
            cmd.Parameters.AddWithValue("@nome", zz.Nome);
            cmd.Parameters.AddWithValue("@idcurso", zz.IdCurso);
            cmd.Parameters.AddWithValue("@idprofessor", zz.IdProfessor);
            cmd.Parameters.AddWithValue("@idadm", zz.IdAdm);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }
    }
}