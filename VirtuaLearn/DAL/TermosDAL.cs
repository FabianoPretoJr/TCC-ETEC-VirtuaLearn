using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace VirtuaLearn.DAL
{
    public class TermosDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.Termos te)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();

            cmd.CommandText = @"INSERT INTO Termos(Termos) VALUES (@termos)";
            cmd.Parameters.AddWithValue("@termos", te.TermosUso);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public BLL.Termos PreencherPeloID(BLL.Termos te)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Termos, Termos FROM Termos WHERE  Id_Termos = @idtermos";
            cmd.Parameters.AddWithValue("@idtermos", te.IdTermos);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                te.IdTermos = Convert.ToInt32(dr["Id_Termos"]);
                te.TermosUso = dr["Termos"].ToString();
                dr.Close();
            }
            else
            {
                te.IdTermos = 0;
            }

            con.Desconectar();
            return te;
        }

        public void Atualizar(BLL.Termos te)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"UPDATE Termos SET Termos = @termos WHERE Id_Termos = @idtermos";

            cmd.Parameters.AddWithValue("@idtermos", te.IdTermos);
            cmd.Parameters.AddWithValue("@termos", te.TermosUso);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }
    }
}