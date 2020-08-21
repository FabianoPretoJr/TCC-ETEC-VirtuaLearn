using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtuaLearn.BLL
{
    public class RespostaUsu
    {
        private int _IdResUsu;
        public int IdResUsu
        {
            get { return _IdResUsu; }
            set { _IdResUsu = value; }
        }

        private int _Resposta;
        public int Resposta
        {
            get { return _Resposta; }
            set { _Resposta = value; }
        }

        private int _IdPergunta;
        public int IdPergunta
        {
            get { return _IdPergunta; }
            set { _IdPergunta = value; }
        }

        private int _IdQuizz;
        public int IdQuizz
        {
            get { return _IdQuizz; }
            set { _IdQuizz = value; }
        }
    }
}