using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtuaLearn.BLL
{
    public class Pergunta
    {
        private int _IdPergunta;
        public int IdPergunta
        {
            get { return _IdPergunta; }
            set { _IdPergunta = value; }
        }

        private string _Questao;
        public string Questao
        {
            get { return _Questao; }
            set { _Questao = value; }
        }

        private string _Res1;
        public string Res1
        {
            get { return _Res1; }
            set { _Res1 = value; }
        }

        private string _Res2;
        public string Res2
        {
            get { return _Res2; }
            set { _Res2 = value; }
        }

        private string _Res3;
        public string Res3
        {
            get { return _Res3; }
            set { _Res3 = value; }
        }

        private string _Res4;
        public string Res4
        {
            get { return _Res4; }
            set { _Res4 = value; }
        }

        private string _Certa;
        public string Certa
        {
            get { return _Certa; }
            set { _Certa = value; }
        }

        private int _IdQuizz;
        public int IdQuizz
        {
            get { return _IdQuizz; }
            set { _IdQuizz = value; }
        }

        private int _IdProfessor;
        public int IdProfessor
        {
            get { return _IdProfessor; }
            set { _IdProfessor = value; }
        }

        private int _IdAdm;
        public int IdAdm
        {
            get { return _IdAdm; }
            set { _IdAdm = value; }
        }
    }
}