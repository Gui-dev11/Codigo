using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Escola
    {
        private string nome;
        private string endereco;
        private string cnpj;
        private string tipo;
        private string categoria;


        public string GetNome()
        {
            return this.nome;
        }

        public void SetNome(string Nome)
        {
            this.nome = Nome;
        }

        public string GetEndereco()
        {
            return endereco;
        }

        public void SetEndereco(string Endereco)
        {
            this.endereco = Endereco;
        }

        public string GetCnpj()
        {
            return this.cnpj;
        }

        public void SetCnpj(string Cnpj)
        {
            this.cnpj = Cnpj;
        }

        public string GetTipo()
        {
            return this.tipo;
        }

        public void SetTipo(string Tipo)
        {
            this.tipo = Tipo;
        }

        public string GetCategoria()
        {
            return this.categoria;
        }

        public void SetCategoria(string Categoria)
        {
            this.categoria = Categoria;
        }
    }
}
