using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace VirtuaLearn.DAL
{
    public class ContatoDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.Contato cont)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();

            cmd.CommandText = @"INSERT INTO Contato(Nome, Sobrenome, Email, Duvida) VALUES(@nome, @sobrenome, @email, @duvida)";

            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = cont.Nome;
            cmd.Parameters.Add("@sobrenome", SqlDbType.Char).Value = cont.Sobrenome;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = cont.Email;
            cmd.Parameters.Add("@duvida", SqlDbType.VarChar).Value = cont.Duvida;

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }
    }
}