using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtuaLearn.BLL
{
    public class Aluno
    {
        private int _IdAluno;         //Fabiano //Serello
        public int IdAluno
        {
            get { return _IdAluno; }
            set { _IdAluno = value; }
        }

        private string _Nome;
        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        private string _Cpf;
        public string Cpf
        {
            get { return _Cpf; }
            set { _Cpf = value; }
        }

        private string _Rg;
        public string Rg
        {
            get { return _Rg; }
            set { _Rg = value; }
        }

        private DateTime _Nascimento;
        public DateTime Nascimento
        {
            get { return _Nascimento; }
            set { _Nascimento = value; }
        }

        private string _Telefone;
        public string Telefone
        {
            get { return _Telefone; }
            set { _Telefone = value; }
        }

        private string _RuaAV;
        public string RuaAv
        {
            get { return _RuaAV; }
            set { _RuaAV = value; }
        }

        private string _Numero;
        public string Numero
        {
            get { return _Numero; }
            set { _Numero = value; }
        }

        private string _Bairro;
        public string Bairro
        {
            get { return _Bairro; }
            set { _Bairro = value; }
        }

        private string _Cidade;
        public string Cidade
        {
            get { return _Cidade; }
            set { _Cidade = value; }
        }

        private string _Estado;
        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        private string _Cep;
        public string Cep
        {
            get { return _Cep; }
            set { _Cep = value; }
        }

        private int _IdLogin;
        public int IdLogin
        {
            get { return _IdLogin; }
            set { _IdLogin = value; }
        }
    }
}