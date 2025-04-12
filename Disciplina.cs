using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Disciplina
    {
        private string nome;
        private string codigo;
        private int cargaHoraria;
        private string descricaoEmenta;
        private string areaConhecimento;
        private int anoSerieRecomendada;

        // Métodos Get e Set

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string valor)
        {
            nome = valor;
        }

        public string GetCodigo()
        {
            return codigo;
        }

        public void SetCodigo(string valor)
        {
            codigo = valor;
        }

        public int GetCargaHoraria()
        {
            return cargaHoraria;
        }

        public void SetCargaHoraria(int valor)
        {
            cargaHoraria = valor;
        }

        public string GetDescricaoEmenta()
        {
            return descricaoEmenta;
        }

        public void SetDescricaoEmenta(string valor)
        {
            descricaoEmenta = valor;
        }

        public string GetAreaConhecimento()
        {
            return areaConhecimento;
        }

        public void SetAreaConhecimento(string valor)
        {
            areaConhecimento = valor;
        }

        public int GetAnoSerieRecomendada()
        {
            return anoSerieRecomendada;
        }

        public void SetAnoSerieRecomendada(int valor)
        {
            anoSerieRecomendada = valor;
        }
    }

}
