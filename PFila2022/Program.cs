using System;

namespace PFila2022
{
    internal class Program
    {
        static void Menu(FilaPessoa)
        {
            FilaPessoa contatos = new FilaPessoa();

            Console.Clear();
            Console.WriteLine("1 - Inserir na fila");
            Console.WriteLine("2 - Remover da fila");
            Console.WriteLine("3 - Imprimir a fila");
            Console.WriteLine("4 - Imprimir a quantidade de pessoa");
            Console.WriteLine("5 - Localizar pessoa na fila");
            Console.WriteLine("6 - Sair");
            Console.WriteLine("Escolha uma opção: ");

            int opc = int.Parse(Console.ReadLine());
            do
            {
                switch (opc)
                {
                    case 1:
                        contatos.Push(LerPessoa());
                        break;

                    case 2:
                        contatos.Pop();
                        break;

                    case 3:
                        contatos.Print();
                        break;

                    case 4:
                        Console.WriteLine("A fila possui {0} pessoa(s): ", contatos.Length());
                        break;

                    case 5:
                        string nome;
                        Console.WriteLine("Informe o nome da pessoa que deseja localizar: ");
                        nome = Console.ReadLine();
                        contatos.AcharPessoa(nome);
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opc != 0);
            Console.WriteLine("FIM!");
        }

        private static Pessoa LerPessoa()
        {
            Console.Clear();
            Console.WriteLine("CADASTRO DA PESSOA");
            Console.WriteLine("Informe o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o seu telefone: ");
            string telefone = Console.ReadLine();

            return new Pessoa(nome, idade, telefone);
        }

        static void Main(string[] args)
        {
            FilaPessoa contatos = new FilaPessoa();

            contatos.Print();
            contatos.Pop();
            contatos.Push(new Pessoa("Morango", 25, "7070"));
            //contatos.Push(new Pessoa("Baratão", 25, "7570"));
            contatos.Print();
            //contatos.Pop();
            //contatos.Print();
            //contatos.Pop();
            //contatos.Print();
            contatos.Length();
        }
    }
}
