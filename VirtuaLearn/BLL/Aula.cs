using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtuaLearn.BLL
{
    public class Aula
    {
        private int _IdAula;
        public int IdAula
        {
            get { return _IdAula; }
            set { _IdAula = value; }
        }

        private string _Nome;
        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        private string _Video;
        public string Video
        {
            get { return _Video; }
            set { _Video = value; }
        }

        private string _Material;
        public string Material
        {
            get { return _Material; }
            set { _Material = value; }
        }

        private string _Descricao;
        public string Descricao
        {
            get { return _Descricao; }
            set { _Descricao = value; }
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