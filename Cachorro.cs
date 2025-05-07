using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Cachorro : Animal
    {
        // Atributos específicos
        private string porte;  // Ex: "Pequeno", "Médio", "Grande"
        private bool pedigree;
        private string treinamento;  // Ex: "Guarda", "Busca"

        // Construtores
        public Cachorro() : base()
        {
        }

        public Cachorro(string nome, string especie, string raca, int idade,
                       string porte, bool pedigree, string treinamento)
                       : base(nome, especie, raca, idade)
        {
            this.porte = porte;
            this.pedigree = pedigree;
            this.treinamento = treinamento;
        }

        // Getters e Setters
        public string GetPorte()
        {
            return porte;
        }

        public void SetPorte(string porte)
        {
            this.porte = porte;
        }

        public bool GetPedigree()
        {
            return pedigree;
        }

        public void SetPedigree(bool pedigree)
        {
            this.pedigree = pedigree;
        }

        public string GetTreinamento()
        {
            return treinamento;
        }

        public void SetTreinamento(string treinamento)
        {
            this.treinamento = treinamento;
        }
    }
}
