using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Capitulo7
    {
        public void Exercicio1()
        {
            /*
             1.	Escreva um algoritmo para ordenar três números fornecidos pelo usuário,
            utilizando a passagem de parâmetros formais
             */
            string continua = "";
            int[] numbers = new int[3];
            do
            {
                Console.WriteLine("\n- Exercicio 01 - Capítulo 7\n");

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"Informe o {i + 1}º Valor: ");
                    numbers[i] = int.Parse(Console.ReadLine());
                }
                Array.Sort(numbers);
                Console.WriteLine("Mostrar em ordem:\n" +
                                  "+ Crestente => Digite 1\n" +
                                  "+ Decrescente => Digite 2");
                Console.Write("Opção: ");
                int op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    Console.WriteLine("Ordem Crencente(Padrão): ");
                    foreach (int item in numbers)
                    {
                        Console.Write($"|{item}");
                    }
                }
                else if (op == 2)
                {
                    Console.WriteLine("Ordem Decrescente: ");
                    Array.Reverse(numbers);
                    foreach (int item in numbers)
                    {
                        Console.Write($"|{item}");
                    }
                }
                else
                {
                    Console.WriteLine("Opção Não Identificada(Padrão): ");
                    foreach (int item in numbers)
                    {
                        Console.Write($"|{item}");
                    }
                }

                Console.WriteLine("*Deseja Refazer o exercício? (Sim,Nao)(S,N)");
                continua = Console.ReadLine().ToUpper();
            } while (continua.Equals("SIM") || continua.Equals("S"));
        }
        public void Exercicio2()
        {
            /*
             
             */

            string continua = "";
            do
            {
                Console.WriteLine("\n- Exercicio 02 - Capítulo 7\n");



                Console.WriteLine("*Deseja Refazer o exercício? (Sim,Nao)(S,N)");
                continua = Console.ReadLine().ToUpper();
            } while (continua.Equals("SIM") || continua.Equals("S"));
        }
        public void Exercicio3()
        {
            /*
             
             */

            string continua = "";
            do
            {
                Console.WriteLine("\n- Exercicio 01 - Capítulo 7\n");



                Console.WriteLine("*Deseja Refazer o exercício? (Sim,Nao)(S,N)");
                continua = Console.ReadLine().ToUpper();
            } while (continua.Equals("SIM") || continua.Equals("S"));
        }
        public void Exercicio4()
        {
            /*
             
             */

            string continua = "";
            do
            {
                Console.WriteLine("\n- Exercicio 01 - Capítulo 7\n");



                Console.WriteLine("*Deseja Refazer o exercício? (Sim,Nao)(S,N)");
                continua = Console.ReadLine().ToUpper();
            } while (continua.Equals("SIM") || continua.Equals("S"));
        }
        public void Exercicio5()
        {
            /*
             
             */

            string continua = "";
            do
            {
                Console.WriteLine("\n- Exercicio 01 - Capítulo 7\n");



                Console.WriteLine("*Deseja Refazer o exercício? (Sim,Nao)(S,N)");
                continua = Console.ReadLine().ToUpper();
            } while (continua.Equals("SIM") || continua.Equals("S"));
        }
        public void Exercicio8()
        {
            /*
             
             */

            string continua = "";
            do
            {
                Console.WriteLine("\n- Exercicio 01 - Capítulo 7\n");



                Console.WriteLine("*Deseja Refazer o exercício? (Sim,Nao)(S,N)");
                continua = Console.ReadLine().ToUpper();
            } while (continua.Equals("SIM") || continua.Equals("S"));
        }
        public void Exercicio9()
        {
            /*
             
             */

            string continua = "";
            do
            {
                Console.WriteLine("\n- Exercicio 01 - Capítulo 7\n");



                Console.WriteLine("*Deseja Refazer o exercício? (Sim,Nao)(S,N)");
                continua = Console.ReadLine().ToUpper();
            } while (continua.Equals("SIM") || continua.Equals("S"));
        }
    }
}
