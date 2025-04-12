using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Endereco
    {
        //atributos privados - private
        private string logradouro, bairro, cidade, cep, estado, numero, complemento;

        //acesso controlado, get para mostrar, set para receber os dados

        public string GetLogradouro()
        {

            return this.logradouro;
        }

        public void SetLogradouro(string Logradouro)
        {
             this.logradouro = Logradouro;
        }

        public string GetBairro()
        {
            return this.bairro;
        }

        public void SetBairro(string Bairro)
        {
            this.bairro = Bairro;
        }

        public string GetCidade()
        {
            return this.cidade;
        }

        public void SetCidade(string Cidade)
        {
            this.cidade = Cidade;
        }

        public string GetCep()
        {
            return this.cep;
        }

        public void SetCep(string Cep)
        {
            this.cep = Cep;
        }

        public string GetEstado()
        {
           return this.estado;
        }

        public void SetEstado(string Estado)
        {
            this.estado = Estado;
        }

        public string GetNumero()
        {
            return this.numero;
        }

        public void SetNumero(string Numero)
        {
            this.numero = Numero;
        }

        public string GetComplemento()
        {
            return this.complemento;
        }

        public void SetComplemento(string Complemento)
        {
            this.complemento = Complemento;
        }
    }
}
