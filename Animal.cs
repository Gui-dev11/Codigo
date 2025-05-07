using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Animal
    {

        //atributos
        private string nome;
        private string especie;
        private string raca;
        private int idade;

        //construtores
        public Animal()
        {
        }

        public Animal(string nome, string especie, string raca, int idade)
        {
            this.nome = nome;
            this.especie = especie;
            this.raca = raca;
            this.idade = idade;
        }


        //getters e setters
        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetEspecie()
        {
            return especie;
        }

        public void SetEspecie(string especie)
        {
            this.especie = especie;
        }

        public string GetRaca()
        {
            return raca;
        }

        public void SetRaca(string raca)
        {
            this.raca = raca;
        }

        public int GetIdade()
        {
            return idade;
        }

        public void SetIdade(int idade)
        {
            this.idade = idade;
        }
    }
}
