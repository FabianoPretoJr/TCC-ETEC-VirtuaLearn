using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace VirtuaLearn.DAL
{
    public class RespostaUsuDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.RespostaUsu re)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"INSERT INTO ResUsu(Id_ResUsu, Resposta, Id_Pergunta, Id_Quizz) VALUES (@idresusu, @resposta, @idpergunta, @idquizz)";

            cmd.Parameters.AddWithValue("@idresusu", re.IdResUsu);
            cmd.Parameters.AddWithValue("@resposta", re.Resposta);
            cmd.Parameters.AddWithValue("@idpergunta", re.IdPergunta);
            cmd.Parameters.AddWithValue("@idquizz", re.IdQuizz);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public DataTable Listar()
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_ResUsu, Resposta, Id_Pergunta, Id_Quizz FROM ResUsu";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }
    }
}