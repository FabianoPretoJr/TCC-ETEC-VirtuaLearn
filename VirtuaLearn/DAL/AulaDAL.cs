using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace VirtuaLearn.DAL
{
    public class AulaDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.Aula au)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();

            cmd.CommandText = @"INSERT INTO Aula(Nome, Video, Material, Descricao, Id_Curso, Id_Professor, Id_Adm) VALUES (@nome, @video, @material, @descricao, @idcurso, @idprofessor, @idadm)";
            cmd.Parameters.AddWithValue("@nome", au.Nome);
            cmd.Parameters.AddWithValue("@video", au.Video);
            cmd.Parameters.AddWithValue("@material", au.Material);
            cmd.Parameters.AddWithValue("@descricao", au.Descricao);
            cmd.Parameters.AddWithValue("@idcurso", au.IdCurso);
            cmd.Parameters.AddWithValue("@idprofessor", au.IdProfessor);
            cmd.Parameters.AddWithValue("@idadm", au.IdAdm);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public void Cadastrar1(BLL.Aula au)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();

            cmd.CommandText = @"INSERT INTO Aula(Nome, Video, Material, Descricao, Id_Curso, Id_Adm) VALUES (@nome, @video, @material, @descricao, @idcurso, @idadm)";
            cmd.Parameters.AddWithValue("@nome", au.Nome);
            cmd.Parameters.AddWithValue("@video", au.Video);
            cmd.Parameters.AddWithValue("@material", au.Material);
            cmd.Parameters.AddWithValue("@descricao", au.Descricao);
            cmd.Parameters.AddWithValue("@idcurso", au.IdCurso);
            cmd.Parameters.AddWithValue("@idadm", au.IdAdm);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public DataTable Listar()
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Aula, Nome, Video, Material, Descricao, Id_Curso, Id_Professor, Id_Adm FROM Aula";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public DataTable Listar(BLL.Aula au)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Aula, Nome, Video, Material, Descricao, Id_Curso, Id_Professor FROM Aula WHERE Nome LIKE @nome and Id_Professor = @idprofessor";

            cmd.Parameters.AddWithValue("@nome", "%" + au.Nome + "%");
            cmd.Parameters.AddWithValue("@idprofessor", au.IdProfessor);   // LISTAR DO FILTRAR DE PROFESSOR ESPECIFICO

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public DataTable Listar1(BLL.Aula au)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Aula, Nome, Video, Material, Descricao, Id_Curso, Id_Professor FROM Aula WHERE Id_Professor = @idprofessor";

            cmd.Parameters.AddWithValue("@idprofessor", au.IdProfessor);  //LISTAR PAGE LOAD PROFESSOR ESPECIFICO

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public DataTable Listar2(BLL.Aula au)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Aula, Nome, Video, Material, Descricao, Id_Curso, Id_Professor, Id_Adm FROM Aula WHERE Nome LIKE @nome";

            cmd.Parameters.AddWithValue("@nome", "%" + au.Nome + "%");  // LISTAR DO FILTRAR DE ADM

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public void Excluir(BLL.Aula au)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"DELETE FROM Aula WHERE Id_Aula = @idaula";

            cmd.Parameters.AddWithValue("@idaula", au.IdAula);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public BLL.Aula PreencherPeloID(BLL.Aula au)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Aula, Nome, Video, Material, Descricao, Id_Curso, Id_Professor FROM Aula WHERE  Id_Aula = @idaula";
            cmd.Parameters.AddWithValue("@idaula", au.IdAula);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                au.IdAula = Convert.ToInt32(dr["Id_Aula"]);
                au.Nome = dr["Nome"].ToString();
                au.Video = dr["Video"].ToString();
                au.Material = dr["Material"].ToString();
                au.Descricao = dr["Descricao"].ToString();
                au.IdCurso = Convert.ToInt32(dr["Id_Curso"]);
                au.IdProfessor = Convert.ToInt32(dr["Id_Professor"]);
                dr.Close();
            }
            else
            {
                au.IdAula = 0;
            }

            con.Desconectar();
            return au;
        }

        public BLL.Aula PreencherPeloID1(BLL.Aula au)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Aula, Nome, Video, Material, Descricao, Id_Curso, Id_Adm FROM Aula WHERE  Id_Aula = @idaula";
            cmd.Parameters.AddWithValue("@idaula", au.IdAula);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                au.IdAula = Convert.ToInt32(dr["Id_Aula"]);
                au.Nome = dr["Nome"].ToString();
                au.Video = dr["Video"].ToString();
                au.Material = dr["Material"].ToString();
                au.Descricao = dr["Descricao"].ToString();
                au.IdCurso = Convert.ToInt32(dr["Id_Curso"]);
                au.IdAdm = Convert.ToInt32(dr["Id_Adm"]);

                dr.Close();
            }
            else
            {
                au.IdAula = 0;
            }

            con.Desconectar();
            return au;
        }

        public void Atualizar(BLL.Aula au)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"UPDATE Aula SET Nome = @nome, Video = @video, Material = @material, Descricao = @descricao WHERE Id_Aula = @idaula";

            cmd.Parameters.AddWithValue("@idaula", au.IdAula);
            cmd.Parameters.AddWithValue("@Nome", au.Nome);
            cmd.Parameters.AddWithValue("@video", au.Video);
            cmd.Parameters.AddWithValue("@material", au.Material);
            cmd.Parameters.AddWithValue("@descricao", au.Descricao);
            cmd.Parameters.AddWithValue("@idcurso", au.IdCurso);
            cmd.Parameters.AddWithValue("@idprofessor", au.IdProfessor);
            cmd.Parameters.AddWithValue("@idadm", au.IdAdm);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }
    }
}