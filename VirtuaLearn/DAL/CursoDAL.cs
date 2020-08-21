using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace VirtuaLearn.DAL
{
    public class CursoDAL
    {

        Conexao con = new Conexao();

        public void Cadastrar(BLL.Curso cu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"INSERT INTO Curso(Imagem, Nome, Valor, Horas, Descricao, Id_Professor, Id_Adm) VALUES (@imagem, @nome, @valor, @horas, @descricao, @idprofessor, @idadm)";

            cmd.Parameters.AddWithValue("@imagem", cu.Imagem);
            cmd.Parameters.AddWithValue("@nome", cu.Nome);
            cmd.Parameters.AddWithValue("@valor", cu.Valor);
            cmd.Parameters.AddWithValue("@horas", cu.Horas);
            cmd.Parameters.AddWithValue("@descricao", cu.Descricao);
            cmd.Parameters.AddWithValue("@idprofessor", cu.IdProfessor);
            cmd.Parameters.AddWithValue("idadm", cu.IdAdm);

            cmd.ExecuteNonQuery(); // EXECUTAR O COMANDO
            con.Desconectar();
        }

        public void Cadastrar1(BLL.Curso cu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"INSERT INTO Curso(Imagem, Nome, Valor, Horas, Descricao, Id_Adm) VALUES (@imagem, @nome, @valor, @horas, @descricao, @idadm)";

            cmd.Parameters.AddWithValue("@imagem", cu.Imagem);
            cmd.Parameters.AddWithValue("@nome", cu.Nome);
            cmd.Parameters.AddWithValue("@valor", cu.Valor);
            cmd.Parameters.AddWithValue("@horas", cu.Horas);
            cmd.Parameters.AddWithValue("@descricao", cu.Descricao);
            cmd.Parameters.AddWithValue("@idadm", cu.IdAdm);

            cmd.ExecuteNonQuery(); // EXECUTAR O COMANDO
            con.Desconectar();
        }

        public DataTable Listar()   //LISTAR DO PAGE LOAD DE ADM
        {
            DataTable dt = new DataTable();//Tabela de Dados padrão c#(int,string, float,...)

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Curso, Imagem, Nome, Valor, Horas, Descricao, Id_Professor, Id_Adm FROM Curso";

            //ADAPTADOR de dados SQL --> C#
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);//Preenche fazendo a adaptação
            con.Desconectar();
            return dt;
        }

        public DataTable Listar(BLL.Curso cu) //ESSA LINHA É A ASSINATURA
        {
            DataTable dt = new DataTable();//Tabela de dados padrão C#(int, strin, double...)

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Curso, Imagem, Nome, Valor, Horas, Descricao, Id_Professor FROM Curso WHERE Nome LIKE @nome and Id_Professor = @idprofessor";

            cmd.Parameters.AddWithValue("@nome", "%" + cu.Nome + "%");
            cmd.Parameters.AddWithValue("@idprofessor", cu.IdProfessor);   // ESSE É USADO NO FILTRAR DE PROFESSOR ESPECIFICO

            //Adaptador de dados SQL para C#
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);//Preenche fazendo a adaptação
            con.Desconectar();
            return dt;
        }

        public DataTable Listar2(BLL.Curso cu) //ESSA LINHA É A ASSINATURA
        {
            DataTable dt = new DataTable();//Tabela de dados padrão C#(int, strin, double...)

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Curso, Imagem, Nome, Valor, Horas, Descricao, Id_Professor, Id_Adm FROM Curso WHERE Nome LIKE @nome";

            cmd.Parameters.AddWithValue("@nome", "%" + cu.Nome + "%");   // ESSE É USADO NO FILTRAR DE ADM

            //Adaptador de dados SQL para C#
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);//Preenche fazendo a adaptação
            con.Desconectar();
            return dt;
        }

        public DataTable Listar1(BLL.Curso cu) //ESSA LINHA É A ASSINATURA
        {
            DataTable dt = new DataTable();//Tabela de dados padrão C#(int, strin, double...)

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Curso, Imagem, Nome, Valor, Horas, Descricao, Id_Professor FROM Curso WHERE Id_Professor = @idprofessor";

            cmd.Parameters.AddWithValue("@idprofessor", cu.IdProfessor);  // LISTAR DO PAGE LOAD DE PROFESSOR ESPECIFICO

            //Adaptador de dados SQL para C#
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);//Preenche fazendo a adaptação
            con.Desconectar();
            return dt;
        }

        public void Excluir(BLL.Curso cu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"DELETE FROM Curso WHERE Id_Curso = @id";

            cmd.Parameters.AddWithValue("@id", cu.IdCurso);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public BLL.Curso PreencherPeloID(BLL.Curso cu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Curso, Imagem, Nome, Valor, Horas, Descricao, Id_Professor FROM Curso WHERE Id_Curso = @idcurso";
            cmd.Parameters.AddWithValue("@idcurso", cu.IdCurso);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                cu.IdCurso = Convert.ToInt32(dr["Id_Curso"]);
                cu.Nome = dr["Nome"].ToString();
                cu.Imagem = dr["Imagem"].ToString();
                cu.Valor = Convert.ToDecimal(dr["Valor"]);
                cu.Horas = dr["Horas"].ToString();
                cu.Descricao = dr["Descricao"].ToString();
                cu.IdProfessor = Convert.ToInt32(dr["Id_Professor"]);
                dr.Close();
            }
            else
            {
                cu.IdCurso = 0;
            }

            con.Desconectar();
            return cu;
        }

        public BLL.Curso PreencherPeloID1(BLL.Curso cu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Curso, Imagem, Nome, Valor, Horas, Descricao, Id_Adm FROM Curso WHERE Id_Curso = @idcurso";
            cmd.Parameters.AddWithValue("@idcurso", cu.IdCurso);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                cu.IdCurso = Convert.ToInt32(dr["Id_Curso"]);
                cu.Nome = dr["Nome"].ToString();
                cu.Imagem = dr["Imagem"].ToString();
                cu.Valor = Convert.ToDecimal(dr["Valor"]);
                cu.Horas = dr["Horas"].ToString();
                cu.Descricao = dr["Descricao"].ToString();
                cu.IdAdm = Convert.ToInt32(dr["Id_Adm"]);
                dr.Close();
            }
            else
            {
                cu.IdCurso = 0;
            }

            con.Desconectar();
            return cu;
        }

        public void Atualizar(BLL.Curso cu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"UPDATE Curso SET Imagem = @imagem, Nome = @nome, Valor = @valor, Horas = @horas, Descricao = @descricao WHERE Id_Curso = @idcurso";

            cmd.Parameters.AddWithValue("@idcurso", cu.IdCurso);
            cmd.Parameters.AddWithValue("@imagem", cu.Imagem);
            cmd.Parameters.AddWithValue("@nome", cu.Nome);
            cmd.Parameters.AddWithValue("@valor", cu.Valor);
            cmd.Parameters.AddWithValue("@horas", cu.Horas);
            cmd.Parameters.AddWithValue("@descricao", cu.Descricao);
            cmd.Parameters.AddWithValue("@idprofessor", cu.IdProfessor);
            cmd.Parameters.AddWithValue("idadm", cu.IdAdm);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        /*public void Atualizar1(BLL.Curso cu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"UPDATE Curso SET Imagem = @imagem, Nome = @nome, Valor = @valor, Horas = @horas, Descricao = @descricao WHERE Id_Curso = @idcurso";

            cmd.Parameters.AddWithValue("@idcurso", cu.IdCurso);
            cmd.Parameters.AddWithValue("@imagem", cu.Imagem);
            cmd.Parameters.AddWithValue("@nome", cu.Nome);
            cmd.Parameters.AddWithValue("@valor", cu.Valor);
            cmd.Parameters.AddWithValue("@horas", cu.Horas);
            cmd.Parameters.AddWithValue("@descricao", cu.Descricao);


            cmd.ExecuteNonQuery();
            con.Desconectar();
        }*/


        public BLL.Curso AcharCurso(BLL.Curso cu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Curso, Imagem, Nome, Valor, Horas, Descricao, Id_Professor, Id_Adm FROM Curso WHERE Id_Curso = @idcurso";
            cmd.Parameters.AddWithValue("@idcurso", cu.IdCurso);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {

                dr.Read();
                cu.IdCurso = Convert.ToInt32(dr["Id_Curso"]);
                cu.Nome = dr["Nome"].ToString();
                cu.Imagem = dr["Imagem"].ToString();
                cu.Valor = Convert.ToDecimal(dr["Valor"]);
                cu.Horas = dr["Horas"].ToString();
                cu.Descricao = dr["Descricao"].ToString();

                if (dr["Id_Professor"] is DBNull)
                {
                    cu.IdProfessor = 0;
                }
                else
                {
                    cu.IdProfessor = Convert.ToInt32(dr["Id_Professor"]);
                }

                cu.IdAdm = Convert.ToInt32(dr["Id_Adm"]);

                dr.Close();

            }
            else
            {
                cu.IdCurso = 0;
            }

            con.Desconectar();
            return cu;
        }
    }
}