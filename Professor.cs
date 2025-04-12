using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Professor
    {
        private string NomeCompleto, MatriculaFuncional, EmailCorporativo, DisciplinaPrincipal;
        private DateTime DataNascimento;
        private decimal Salario;


        public string GetNomeCompleto()
        {
            return this.NomeCompleto;
        }

        public void SetNomeCompleto(string nomeCompleto)
        {
            this.NomeCompleto = nomeCompleto;
        }


        public string GetMatriculaFuncional()
        {
            return this.MatriculaFuncional;    
        }

        public void SetMatriculaFuncional(string matriculaFuncional)
        {
            this.MatriculaFuncional = matriculaFuncional;
        }

        public string GetEmailCorporativo()
        {
            return this.EmailCorporativo;
        }

        public void SetEmailCorporativo(string emailCorporativo)
        {
            this.EmailCorporativo = emailCorporativo;
        }

        public string GetDisciplinaPrincipal()
        {
            return this.DisciplinaPrincipal;
        }

        public void SetDisciplinaPrincipal(string disciplinaPrincipal)
        {
            this.DisciplinaPrincipal = disciplinaPrincipal;
        }

        public DateTime GetDataNascimento()
        {
            return this.DataNascimento;
        }


        public void SetDataNascimento(DateTime dataNascimento)
        {
            this.DataNascimento = dataNascimento;
        }

        public decimal GetSalario()
        {
            return this.Salario;
        }

        public void SetSalario(decimal salario)
        {
            this.Salario = salario;
        }

    }
}
