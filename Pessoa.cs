using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Pessoa
    {
        private string nome;
        private string dataNas;
        private string cpf;
        private Endereco endereco;


        public string GetNome()
        {
            return this.nome;
        }

        public void SetNome(string Nome)
        {
            this.nome = Nome;
        }

        public string GetDataNas()
        {
            return this.dataNas;
        }

        public void SetDataNas(string DataNas)
        {
            this.dataNas = DataNas;
        }

        public string GetCpf()
        {
            return this.cpf;
        }

        public void SetCpf(string Cpf)
        {
            this.cpf = Cpf;
        }

        public Endereco GetEndereco()
        {
            return this.endereco;
        }

        public void SetEndereco(Endereco Endereco)
        {
            this.endereco = Endereco;
        }
    }
}
