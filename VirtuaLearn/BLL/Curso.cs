using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtuaLearn.BLL
{
    public class Curso
    {
        private int _IdCurso;
        public int IdCurso
        {
            get { return _IdCurso; }
            set { _IdCurso = value; }
        }

        private string _Nome;
        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        private string _Descricao;
        public string Descricao
        {
            get { return _Descricao; }
            set { _Descricao = value; }
        }

        private decimal _Valor;
        public decimal Valor
        {
            get { return _Valor; }
            set { _Valor = value; }
        }

        private string _Horas;
        public string Horas
        {
            get { return _Horas; }
            set { _Horas = value; }
        }

        private string _Imagem;
        public string Imagem
        {
            get { return _Imagem; }
            set { _Imagem = value; }
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