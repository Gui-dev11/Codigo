using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Boi : Animal
    {
        // Atributos específicos
        private string tipoCorte;
        private int nivelAgressividade;
        private string tipoCriacao;

        // Construtores
        public Boi() : base()
        {
        }

        public Boi(string nome, string especie, string raca, int idade,
                   string tipoCorte, int nivelAgressividade, string tipoCriacao)
                   : base(nome, especie, raca, idade)
        {
            this.tipoCorte = tipoCorte;
            this.nivelAgressividade = nivelAgressividade;
            this.tipoCriacao = tipoCriacao;
        }

        // Getters e Setters
        public string GetTipoCorte()
        {
            return tipoCorte;
        }

        public void SetTipoCorte(string tipoCorte)
        {
            this.tipoCorte = tipoCorte;
        }

        public int GetNivelAgressividade()
        {
            return nivelAgressividade;
        }

        public void SetNivelAgressividade(int nivelAgressividade)
        {
            this.nivelAgressividade = nivelAgressividade;
        }

        public string GetTipoCriacao()
        {
            return tipoCriacao;
        }

        public void SetTipoCriacao(string tipoCriacao)
        {
            this.tipoCriacao = tipoCriacao;
        }
    }
}
