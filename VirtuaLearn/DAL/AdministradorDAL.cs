using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace VirtuaLearn.DAL
{
    public class AdministradorDAL
    {
        Conexao con = new Conexao();

        public DataTable Listar()
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Adm, Nome, Email, Foto, Id_Login from Administrador";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public DataTable Listar(BLL.Administrador adm)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Adm, Nome, Email, Foto, Id_Login from Administrador WHERE Nome LIKE @nome";

            cmd.Parameters.AddWithValue("@nome", "%" + adm.Nome + "%");

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public void Excluir(BLL.Administrador adm)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"DELETE FROM Administrador WHERE Id_adm = @idadm";

            cmd.Parameters.AddWithValue("@idadm", adm.IdAdm);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public BLL.Administrador PreencherPeloID(BLL.Administrador adm)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Adm, Nome, Email, Foto, Id_Login from Administrador Where Id_Adm = @idadm";
            cmd.Parameters.AddWithValue("@idadm", adm.IdAdm);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                adm.IdAdm = Convert.ToInt32(dr["Id_Adm"]);
                adm.Nome = dr["Nome"].ToString();
                adm.Email = dr["Email"].ToString();
                adm.Foto = dr["Foto"].ToString();
                adm.IdLogin = Convert.ToInt32(dr["Id_login"]);
                dr.Close();
            }
            else
            {
                adm.IdAdm = 0;
            }

            con.Desconectar();
            return adm;
        }

        public void Atualizar(BLL.Administrador adm)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"UPDATE Administrador SET Nome = @nome, Email = @email, Foto = @foto WHERE Id_Adm = @idadm";

            cmd.Parameters.AddWithValue("idadm", adm.IdAdm);
            cmd.Parameters.AddWithValue("@nome", adm.Nome);
            cmd.Parameters.AddWithValue("@email", adm.Email);
            cmd.Parameters.AddWithValue("@foto", adm.Foto);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public int AcharAdm(BLL.Administrador adm)
        {
            int la = 1;

            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Adm, Nome, Email, Foto, Id_Login from Administrador WHERE Id_Login LIKE @idlogin";

            cmd.Parameters.AddWithValue("@idlogin", adm.IdLogin);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                adm.IdAdm = Convert.ToInt32(dr["Id_Adm"]);
                adm.Nome = dr["Nome"].ToString();
                adm.Email = dr["Email"].ToString();
                adm.Foto = dr["Foto"].ToString();
                adm.IdLogin = Convert.ToInt32(dr["Id_login"]);
                dr.Close();
            }
            else
            {
                adm.IdAdm = 0;
            }

            con.Desconectar();
            return la;
        }
    }
}