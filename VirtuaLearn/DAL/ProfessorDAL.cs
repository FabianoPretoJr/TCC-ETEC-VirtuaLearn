
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace VirtuaLearn.DAL
{
    public class ProfessorDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.Professor pro)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"INSERT INTO Professor(Nome, Email, Telefone, Descricao, Foto, cpf, Id_Login) VALUES (@nome, @email, @telefone, @descricao, @foto, @cpf, @idlogin)";

            cmd.Parameters.AddWithValue("@nome", pro.Nome);
            cmd.Parameters.AddWithValue("@email", pro.Email);
            cmd.Parameters.AddWithValue("@telefone", pro.Telefone);
            cmd.Parameters.AddWithValue("@descricao", pro.Descricao);
            cmd.Parameters.AddWithValue("@foto", pro.Foto);
            cmd.Parameters.AddWithValue("@cpf", pro.Cpf);
            cmd.Parameters.AddWithValue("@idlogin", pro.IdLogin);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public DataTable Listar()
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Professor, Nome, Email, Telefone, Descricao, Foto, cpf, Id_Login from Professor";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public DataTable Listar(BLL.Professor pro)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Professor, Nome, Email, Telefone, Descricao, Foto, cpf, Id_Login from Professor WHERE Nome LIKE @nome";

            cmd.Parameters.AddWithValue("@nome", "%" + pro.Nome + "%");

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public int AcharProf(BLL.Professor pro)
        {
            int la = 1;

            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Professor, Nome, Email, Telefone, Descricao, Foto, cpf, Id_Login from Professor WHERE Id_Login LIKE @idlogin";

            cmd.Parameters.AddWithValue("@idlogin", pro.IdLogin);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                pro.IdProfessor = Convert.ToInt32(dr["Id_Professor"]);
                pro.Nome = dr["Nome"].ToString();
                pro.Email = dr["Email"].ToString();
                pro.Telefone = dr["Telefone"].ToString();
                pro.Descricao = dr["Descricao"].ToString();
                pro.Foto = dr["Foto"].ToString();
                pro.Cpf = dr["Cpf"].ToString();
                pro.IdLogin = Convert.ToInt32(dr["Id_Login"]);
                dr.Close();
            }
            else
            {
                pro.IdLogin = 0; //tava antes idprofessor
            }

            con.Desconectar();
            return la;
        }

        public void Excluir(BLL.Professor pro)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"DELETE FROM Professor WHERE Id_Professor = @idprofessor";

            cmd.Parameters.AddWithValue("@idprofessor", pro.IdProfessor);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public BLL.Professor PreencherPeloID(BLL.Professor pro)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Professor, Nome, Email, Telefone, Descricao, Foto, cpf, Id_Login from Professor Where Id_Login = @idlogin";
            cmd.Parameters.AddWithValue("@idlogin", pro.IdLogin);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                pro.IdProfessor = Convert.ToInt32(dr["Id_Professor"]);
                pro.Nome = dr["Nome"].ToString();
                pro.Email = dr["Email"].ToString();
                pro.Telefone = dr["Telefone"].ToString();
                pro.Descricao = dr["Descricao"].ToString();
                pro.Foto = dr["Foto"].ToString();
                pro.Cpf = dr["Cpf"].ToString();
                pro.IdLogin = Convert.ToInt32(dr["Id_Login"]);
                dr.Close();
            }
            else
            {
                pro.IdProfessor = 0;
            }

            con.Desconectar();
            return pro;
        }

        public void Atualizar(BLL.Professor pro)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"UPDATE Professor SET Nome = @nome, Email = @email, Telefone = @telefone , Descricao = @descricao, Foto = @foto, Cpf = @cpf WHERE Id_Professor = @idprofessor";

            cmd.Parameters.AddWithValue("@idprofessor", pro.IdProfessor);
            cmd.Parameters.AddWithValue("@nome", pro.Nome);
            cmd.Parameters.AddWithValue("@email", pro.Email);
            cmd.Parameters.AddWithValue("@telefone", pro.Telefone);
            cmd.Parameters.AddWithValue("@descricao", pro.Descricao);
            cmd.Parameters.AddWithValue("@foto", pro.Foto);
            cmd.Parameters.AddWithValue("@cpf", pro.Cpf);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }
    }
}