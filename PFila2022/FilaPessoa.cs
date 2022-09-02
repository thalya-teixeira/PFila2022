using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFila2022
{
    internal class FilaPessoa
    {
        public Pessoa HEAD { get; set; }
        public Pessoa TAIL { get; set; }

        public FilaPessoa()
        {
            HEAD = TAIL = null;
        }

        public void Push(Pessoa aux) //inserir eu olho para a calda
        {
            if (Vazia())
                HEAD = TAIL = aux;
            else
            {
                TAIL.Proximo = aux; //o proximo que a calda esta apontando ira receber o aux
                TAIL = aux;
            }
            Console.WriteLine("Inserido com sucesso!");
            Console.ReadKey();
        }

        public void Pop() //removendo eu olho a cabeça
        {
            if (Vazia())
            {
                Console.WriteLine("Impossível remover! Fila vazia");
            }
            else
            {
                HEAD = HEAD.Proximo;
                if (HEAD == null)
                    TAIL = null;
                Console.WriteLine("Elemento removido!");
            }
            Console.ReadKey();
        }

        public void Print()
        {
            if (Vazia())
                Console.WriteLine("Fila vazia!");
            else
            {
                Pessoa aux = HEAD; //aux do tipo pessoa que refenrecia a cabrca
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;
                } while (aux != null);
                Console.WriteLine("FIM DA IMPRESSÃO!");
            }
            Console.ReadKey();
        }

        public void AcharPessoa(string nome)
        {
            if(Vazia())
                Console.WriteLine("Não foi possível encontrar.");
            else
            {
                Pessoa aux = HEAD;
                bool achou = false;
                do
                {
                    if (aux.Nome == nome)
                    {
                        Console.WriteLine("Pessoa encontrada:");
                        Console.WriteLine(aux.ToString());
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        achou = true;
                    }
                    aux = aux.Proximo;
                }while(aux != null);
                if(!achou)
                    Console.WriteLine("Pessoa não foi localizada com esse nome: " + nome);
                else
                {
                    Console.WriteLine("FIM DA BUSCA");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
                
            }
        }

        public int Length()
        {
            if (Vazia())
            {
                Console.WriteLine("Nada por aqui!");
            }
            else
            {
                Pessoa aux = HEAD;
                int qtd = 0;
                do
                {
                    qtd++;
                    aux = aux.Proximo;
                }while(aux != null);
                Console.WriteLine($"A fila tem {qtd} pessoa(s)");
                return qtd;
            }
        }

        private bool Vazia()
        {
            if (HEAD == null && TAIL == null)
                return true;
            else
                return false;
        }
    }
}
