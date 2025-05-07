using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Cavalo : Animal
    {
        // Atributos específicos
        private string tipoCavalo;  // Ex: "Quarto de Milha", "Puro Sangue"
        private bool ferradura;
        private string disciplina;  // Ex: "Salto", "Corrida"

        // Construtores
        public Cavalo() : base()
        {
        }

        public Cavalo(string nome, string especie, string raca, int idade,
                     string tipoCavalo, bool ferradura, string disciplina)
                     : base(nome, especie, raca, idade)
        {
            this.tipoCavalo = tipoCavalo;
            this.ferradura = ferradura;
            this.disciplina = disciplina;
        }

        // Getters e Setters
        public string GetTipoCavalo()
        {
            return tipoCavalo;
        }

        public void SetTipoCavalo(string tipoCavalo)
        {
            this.tipoCavalo = tipoCavalo;
        }

        public bool GetFerradura()
        {
            return ferradura;
        }

        public void SetFerradura(bool ferradura)
        {
            this.ferradura = ferradura;
        }

        public string GetDisciplina()
        {
            return disciplina;
        }

        public void SetDisciplina(string disciplina)
        {
            this.disciplina = disciplina;
        }
    }
}
