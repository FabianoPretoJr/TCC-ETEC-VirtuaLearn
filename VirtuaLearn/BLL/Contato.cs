using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtuaLearn.BLL
{
    public class Contato
    {
        private int _IdContato;
        public int Idcurso
        {
            get { return _IdContato; }
            set { _IdContato = value; }
        }

        private string _Nome;
        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        private string _Sobrenome;
        public string Sobrenome
        {
            get { return _Sobrenome; }
            set { _Sobrenome = value; }
        }

        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        private string _Duvida;
        public string Duvida
        {
            get { return _Duvida; }
            set { _Duvida = value; }
        }
    }
}