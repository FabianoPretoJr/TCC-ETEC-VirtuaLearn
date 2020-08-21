using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace VirtuaLearn.DAL
{
    public class AlunoDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.Aluno alu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();

            cmd.CommandText = @"INSERT INTO Aluno(Nome,Email,Cpf,Rg,Nascimento,Telefone,Rua_Av,Numero,Bairro,Cidade,Estado,Cep,Id_Login) VALUES(@nome,@email,@cpf,@rg,@nascimento,@telefone,@ruaav,@numero,@bairro,@cidade,@estado,@cep,@idlogin)";

            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = alu.Nome;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = alu.Email;
            cmd.Parameters.Add("@cpf", SqlDbType.Char).Value = alu.Cpf;
            cmd.Parameters.Add("@rg", SqlDbType.VarChar).Value = alu.Rg;
            cmd.Parameters.Add("@nascimento", SqlDbType.DateTime).Value = alu.Nascimento;
            cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = alu.Telefone;
            cmd.Parameters.Add("@ruaav", SqlDbType.VarChar).Value = alu.RuaAv;
            cmd.Parameters.Add("@numero", SqlDbType.VarChar).Value = alu.Numero;
            cmd.Parameters.Add("@bairro", SqlDbType.VarChar).Value = alu.Bairro;
            cmd.Parameters.Add("@cidade", SqlDbType.VarChar).Value = alu.Cidade;
            cmd.Parameters.Add("@estado", SqlDbType.Char).Value = alu.Estado;
            cmd.Parameters.Add("@cep", SqlDbType.Char).Value = alu.Cep;
            cmd.Parameters.Add("@idlogin", SqlDbType.Int).Value = alu.IdLogin;

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public DataTable Listar()
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Aluno, Nome, Email, Cpf, Rg, Nascimento, Telefone, Rua_Av, Numero, Bairro, Cidade, Estado, Cep, Id_Login FROM Aluno";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public DataTable Listar(BLL.Aluno alu) //ESSA LINHA É A ASSINATURA
        {
            DataTable dt = new DataTable();//Tabela de dados padrão C#(int, strin, double...)

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Aluno, Nome, Email, Cpf, Rg, Nascimento, Telefone, Rua_Av, Numero, Bairro, Cidade, Estado, Cep, Id_Login FROM Aluno WHERE Id_Login LIKE @idlogin";

            cmd.Parameters.AddWithValue("@idlogin", alu.IdLogin);   // ESSE É USADO NO FILTRAR DE PROFESSOR ESPECIFICO

            //Adaptador de dados SQL para C#
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);//Preenche fazendo a adaptação
            con.Desconectar();
            return dt;
        }

        /*public void Excluir(BLL.Cliente cli)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();

            cmd.CommandText = @"DELETE FROM TBCliente WHERE ID = @id";
            cmd.Parameters.AddWithValue("@id", cli.Id);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public void Atualizar(BLL.Cliente cli)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();

            cmd.CommandText = @"UPDATE TBCliente SET  NOME=@nome, CPF=@cpf, TELEFONE=@telefone, EMAIL=@email WHERE ID = @id";

            cmd.Parameters.AddWithValue("@nome", cli.Nome);
            cmd.Parameters.AddWithValue("@cpf", cli.CPF);
            cmd.Parameters.AddWithValue("@telefone", cli.Telefone);
            cmd.Parameters.AddWithValue("@email", cli.Email);
            cmd.Parameters.AddWithValue("@id", cli.Id);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }*/

        public BLL.Aluno PreencherPeloID(BLL.Aluno alu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Id_Aluno, Nome, Email, Cpf, Rg, Nascimento, Telefone, Rua_Av, Numero, Bairro, Cidade, Estado, Cep, Id_Login FROM Aluno WHERE Id_Login LIKE @idlogin";
            cmd.Parameters.AddWithValue("@idlogin", alu.IdLogin);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                alu.IdAluno = Convert.ToInt32(dr["Id_Aluno"]);
                alu.Nome = dr["Nome"].ToString();
                alu.Email = dr["Email"].ToString();
                alu.Cpf = dr["Cpf"].ToString();
                alu.Rg = dr["Rg"].ToString();
                alu.Nascimento = Convert.ToDateTime(dr["Nascimento"]);
                alu.Telefone = dr["Telefone"].ToString();
                alu.RuaAv = dr["Rua_Av"].ToString();
                alu.Numero = dr["Numero"].ToString();
                alu.Bairro = dr["Bairro"].ToString();
                alu.Cidade = dr["Cidade"].ToString();
                alu.Estado = dr["Estado"].ToString();
                alu.Cep = dr["Cep"].ToString();
                alu.IdLogin = Convert.ToInt32(dr["Id_Login"]);
                dr.Close();
            }
            else
            {
                alu.IdLogin = 0;
            }
            con.Desconectar();
            return alu;
        }
    }
}