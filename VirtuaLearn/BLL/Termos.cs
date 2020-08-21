using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtuaLearn.BLL
{
    public class Termos
    {
        private int _IdTermos;
        public int IdTermos
        {
            get { return _IdTermos; }
            set { _IdTermos = value; }
        }

        private string _TermosUso;
        public string TermosUso
        {
            get { return _TermosUso; }
            set { _TermosUso = value; }
        }
    }
}