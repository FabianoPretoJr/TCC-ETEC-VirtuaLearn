using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtuaLearn.BLL
{
    public class Administrador
    {
        private int _IdAdm;
        public int IdAdm
        {
            get { return _IdAdm; }
            set { _IdAdm = value; }
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

        private string _Foto;
        public string Foto
        {
            get { return _Foto; }
            set { _Foto = value; }
        }

        private int _IdLogin;
        public int IdLogin
        {
            get { return _IdLogin; }
            set { _IdLogin = value; }
        }
    }
}