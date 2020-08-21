using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtuaLearn.BLL
{
    public class Assinatura
    {
        private int _IdAss;
        public int IdAss
        {
            get { return _IdAss; }
            set { _IdAss = value; }
        }

        private string _StatusCurso;
        public string StatusCurso
        {
            get { return _StatusCurso; }
            set { _StatusCurso = value; }
        }

        private string _StatusCertificado;
        public string StatusCertificado
        {
            get { return _StatusCertificado; }
            set { _StatusCertificado = value; }
        }

        private string _DataComeco;
        public string DataComeco
        {
            get { return _DataComeco; }
            set { _DataComeco = value; }
        }

        private string _DataTermino;
        public string DataTermino
        {
            get { return _DataTermino; }
            set { _DataTermino = value; }
        }

        private string _Curso;
        public string Curso
        {
            get { return _Curso; }
            set { _Curso = value; }
        }

        private decimal _Pagamento;
        public decimal Pagamento
        {
            get { return _Pagamento; }
            set { _Pagamento = value; }
        }

        private int _IdAluno;
        public int IdAluno
        {
            get { return _IdAluno; }
            set { _IdAluno = value; }
        }
    }
}