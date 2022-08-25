// EXERCICIO = criar uma tela de login

using System;
using System.IO;

namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Bem vindo ao sistema de login");
            Console.WriteLine("Digite 1 para logar");
            Console.WriteLine("Digite 2 para cadastrar");
            Console.WriteLine("Digite 3 para sair");
            bool sair = false;
            while(!sair)
            {
                int opcao = 0;
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine("valor inválido, tente novamente");
                }

                switch(opcao)
                {
                    case 1:
                        // logar
                        break;
                    case 2:
                        // cadastrar
                        break;
                    case 3:
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente");
                        break;
                
                }
            }
        }
    }
}
