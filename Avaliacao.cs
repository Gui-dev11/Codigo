using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Avaliacao
    {
        private string descricao;
        private string tipo;
        private DateTime dataAplicacao;
        private double peso;
        private decimal valorMaximo;
        private string codigoDisciplinaAssociada;

        public string GetDescricao()
        {
            return descricao;
        }

        public void SetDescricao(string valor)
        {
            descricao = valor;
        }

        public string GetTipo()
        {
            return tipo;
        }

        public void SetTipo(string valor)
        {
            tipo = valor;
        }

        public DateTime GetDataAplicacao()
        {
            return dataAplicacao;
        }

        public void SetDataAplicacao(DateTime valor)
        {
            dataAplicacao = valor;
        }

        public double GetPeso()
        {
            return peso;
        }

        public void SetPeso(double valor)
        {
            peso = valor;
        }

        public decimal GetValorMaximo()
        {
            return valorMaximo;
        }

        public void SetValorMaximo(decimal valor)
        {
            valorMaximo = valor;
        }

        public string GetCodigoDisciplinaAssociada()
        {
            return codigoDisciplinaAssociada;
        }

        public void SetCodigoDisciplinaAssociada(string valor)
        {
            codigoDisciplinaAssociada = valor;
        }
    }

}
