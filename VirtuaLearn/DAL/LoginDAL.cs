using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace VirtuaLearn.DAL
{
    public class LoginDAL
    {
        Conexao con = new Conexao();

        public BLL.Login Login(BLL.Login lo)
        {
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();

            cmd.CommandText = @"select Id_Login, Usuario, Senha, Tipo from Login Where Usuario = @usuario and Senha = @senha";

            cmd.Parameters.AddWithValue("@usuario", lo.Usuario);
            cmd.Parameters.AddWithValue("@senha", lo.Senha);

            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                lo.IdLogin = Convert.ToInt32(dr["Id_Login"]);
                lo.Usuario = dr["Usuario"].ToString();
                lo.Senha = dr["Senha"].ToString();
                lo.Tipo = Convert.ToInt32(dr["Tipo"]);
            }
            else
            {
                lo.IdLogin = 0;
            }

            return lo;
        }

        public int Cadastrar(BLL.Login lo)
        {
            int Chave;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"INSERT INTO Login(Usuario, Senha, Tipo) VALUES (@usuario, @senha, @tipo) ; select scope_Identity() as Chave";

            cmd.Parameters.AddWithValue("@usuario", lo.Usuario);
            cmd.Parameters.AddWithValue("@senha", lo.Senha);
            cmd.Parameters.AddWithValue("@tipo", lo.Tipo);

            Chave = Convert.ToInt32(cmd.ExecuteScalar());
            con.Desconectar();

            return Chave;
        }

        public DataTable Listar()
        {
            DataTable dt = new DataTable();//Tabela de Dados padrão c#(int,string, float,...)

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Login, Usuario, Senha, Tipo FROM Login";

            //ADAPTADOR de dados SQL --> C#
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);//Preenche fazendo a adaptação
            con.Desconectar();
            return dt;
        }

        public DataTable Listar(BLL.Login lo) //ESSA LINHA É A ASSINATURA
        {
            DataTable dt = new DataTable();//Tabela de dados padrão C#(int, strin, double...)

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Login, Usuario, Senha, Tipo FROM Login WHERE Usuario LIKE @usuario";

            cmd.Parameters.AddWithValue("@usuario", "%" + lo.Usuario + "%");

            //Adaptador de dados SQL para C#
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);//Preenche fazendo a adaptação
            con.Desconectar();
            return dt;
        }

        public void Excluir(BLL.Login lo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"DELETE FROM Login WHERE Id_Login = @idlogin";

            cmd.Parameters.AddWithValue("@idlogin", lo.IdLogin);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public BLL.Login PreencherPeloID(BLL.Login lo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Login, Usuario, Senha, Tipo FROM Login WHERE  Id_Login = @idlogin";
            cmd.Parameters.AddWithValue("@idlogin", lo.IdLogin);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                lo.IdLogin = Convert.ToInt32(dr["Id_Login"]);
                lo.Usuario = dr["Usuario"].ToString();
                lo.Senha = dr["Senha"].ToString();
                lo.Tipo = Convert.ToInt32(dr["Tipo"]);
                dr.Close();
            }
            else
            {
                lo.IdLogin = 0;
            }

            con.Desconectar();
            return lo;
        }

        public BLL.Login PreencherPeloID1(BLL.Login lo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Login, Usuario, Senha, Tipo FROM Login WHERE Usuario = @usuario and Tipo = @tipo";
            cmd.Parameters.AddWithValue("@usuario", lo.Usuario);
            cmd.Parameters.AddWithValue("@tipo", lo.Tipo);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                lo.IdLogin = Convert.ToInt32(dr["Id_Login"]);
                lo.Usuario = dr["Usuario"].ToString();
                dr.Close();
            }
            else
            {
                lo.IdLogin = 0;
            }

            con.Desconectar();
            return lo;
        }

        public void Atualizar(BLL.Login lo)
        {
            //int Chave1;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"UPDATE Login SET Usuario = @usuario, Senha = @senha WHERE Id_Login = @idlogin";

            cmd.Parameters.AddWithValue("@idlogin", lo.IdLogin);
            cmd.Parameters.AddWithValue("@usuario", lo.Usuario);
            cmd.Parameters.AddWithValue("@senha", lo.Senha);

            //Chave1 = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.ExecuteNonQuery();
            con.Desconectar();

            //return Chave1;
        }

        public void Atualizar1(BLL.Login lo)
        {
            //int Chave1;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"UPDATE Login SET Senha = @senha WHERE Id_Login = @idlogin";

            cmd.Parameters.AddWithValue("@idlogin", lo.IdLogin);
            cmd.Parameters.AddWithValue("@senha", lo.Senha);

            //Chave1 = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.ExecuteNonQuery();
            con.Desconectar();

            //return Chave1;
        }
    }
}