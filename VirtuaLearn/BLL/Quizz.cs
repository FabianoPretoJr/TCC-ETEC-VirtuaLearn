using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtuaLearn.BLL
{
    public class Quizz
    {
        private int _IdQuizz;
        public int IdQuizz
        {
            get { return _IdQuizz; }
            set { _IdQuizz = value; }
        }

        private string _Nome;
        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        private int _IdCurso;
        public int IdCurso
        {
            get { return _IdCurso; }
            set { _IdCurso = value; }
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