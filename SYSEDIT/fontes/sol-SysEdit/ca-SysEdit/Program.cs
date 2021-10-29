//criei essa aplicação de Console para mostrar que diferentes tipos de aplicações conseguem usar a estrutura MVC já pronta do sistema

using System;
using cl_bll;
using cl_models;

namespace ca_SysEdit
{
    class Program
    {
        static void naoImplementado()
        {
            Console.Clear();
            Console.WriteLine("NÃO IMPLEMENTADO...");
            Console.WriteLine("\n'Pressione ENTER para continuar...'");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int op = 0;

            do
            {
                Console.WriteLine("\t\tSysEdit - Sistema de Gerenciamento de Editoras");
                Console.WriteLine("----------------------------------------------------------------------\n\n");

                Console.WriteLine("1- Cadastrar Autores");
                Console.WriteLine("2- Cadastrar Editoras - (SEM IMPLEMENTAÇÃO)");
                Console.WriteLine("3- Cadastrar Livros - (SEM IMPLEMENTAÇÃO)");
                Console.WriteLine("4- Cadastrar Usuários - (SEM IMPLEMENTAÇÃO)");
                Console.WriteLine("5- Sair\n");

                Console.Write("Selecione a opção desejada: ");
                op = int.Parse(Console.ReadLine());

                switch(op)
                {
                    case 1:
                        string nome, pseudonimo, obs;

                        Console.WriteLine("\n\n---CADASTRAR AUTORES---\n");

                        Console.Write("Nome: ");
                        nome = Console.ReadLine();

                        Console.Write("Pseudônimo: ");
                        pseudonimo = Console.ReadLine();

                        Console.Write("Observação: ");
                        obs = Console.ReadLine();

                        try
                        {
                            clsAutores autores = new clsAutores();
                            autores.Nome = nome;
                            autores.Pseudonimo = pseudonimo;
                            autores.Observacoes = obs;

                            clsAutoresBLL autoresBLL = new clsAutoresBLL();
                            autoresBLL.Salvar(autores);

                            Console.WriteLine("\n\nAutor salvo com sucesso!");
                            Console.WriteLine("\n'Pressione ENTER para continuar...'");
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("\n");
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine("\n'Pressione ENTER para continuar...'");
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("\n");
                        }

                        break;

                    case 2:
                        naoImplementado();
                        break;

                    case 3:
                        naoImplementado();
                        break;

                    case 4:
                        naoImplementado();
                        break;

                    case 5:
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("NÃO EXISTE");
                        Console.WriteLine("\n'Pressione ENTER para continuar...'");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("\n");
                        break;
                }
            }
            while (op != 5);
        }
    }
}