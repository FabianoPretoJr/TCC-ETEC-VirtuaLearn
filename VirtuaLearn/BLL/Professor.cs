using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtuaLearn.BLL
{
    public class Professor
    {
        private int _IdProfessor;
        public int IdProfessor
        {
            get { return _IdProfessor; }
            set { _IdProfessor = value; }
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

        private string _Telefone;
        public string Telefone
        {
            get { return _Telefone; }
            set { _Telefone = value; }
        }

        private string _Descricao;
        public string Descricao
        {
            get { return _Descricao; }
            set { _Descricao = value; }
        }

        private string _Foto;
        public string Foto
        {
            get { return _Foto; }
            set { _Foto = value; }
        }

        private string _Cpf;
        public string Cpf
        {
            get { return _Cpf; }
            set { _Cpf = value; }
        }

        private int _IdLogin;
        public int IdLogin
        {
            get { return _IdLogin; }
            set { _IdLogin = value; }
        }
    }
}