using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Turma
    {
        private string codigoTurma;
        private int anoLetivo;
        private string semestrePeriodo;
        private string sala;
        private int maximoAlunos;
        private string turno;

        public string GetCodigoTurma()
        {
            return codigoTurma;
        }

        public void SetCodigoTurma(string valor)
        {
            codigoTurma = valor;
        }

        public int GetAnoLetivo()
        {
            return anoLetivo;
        }

        public void SetAnoLetivo(int valor)
        {
            anoLetivo = valor;
        }

        public string GetSemestrePeriodo()
        {
            return semestrePeriodo;
        }

        public void SetSemestrePeriodo(string valor)
        {
            semestrePeriodo = valor;
        }

        public string GetSala()
        {
            return sala;
        }

        public void SetSala(string valor)
        {
            sala = valor;
        }

        public int GetMaximoAlunos()
        {
            return maximoAlunos;
        }

        public void SetMaximoAlunos(int valor)
        {
            maximoAlunos = valor;
        }

        public string GetTurno()
        {
            return turno;
        }

        public void SetTurno(string valor)
        {
            turno = valor;
        }
    }

}
