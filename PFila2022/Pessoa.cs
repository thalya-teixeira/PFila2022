using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFila2022
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public Pessoa Proximo { get; set; }

        public Pessoa(string nome, int idade, string telefone)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Telefone = telefone;
            this.Proximo = null;
        }

        public override string ToString()
        {
            return "\nNome: " + Nome + "\nIdade: " + Idade + "\nTelefone: " + Telefone;
        }

        
    }
}


