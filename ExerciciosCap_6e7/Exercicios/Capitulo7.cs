using Exercicio6_2;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Capitulo7
    {
        Biblioteca bb = new Biblioteca();
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
                Console.WriteLine("Mostrar em ordem:\n" +
                                  "+ Crestente => Digite 1\n" +
                                  "+ Decrescente => Digite 2");
                Console.Write("Opção: ");
                int op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    Console.WriteLine("Ordem Crencente(Padrão): ");
                    numbers = bb.OrdernarVetor(numbers);
                    foreach (int item in numbers)
                    {
                        Console.Write($"|{item}");
                    }
                }
                else if (op == 2)
                {
                    Console.WriteLine("Ordem Decrescente: ");
                    numbers = bb.OrdernarVetor(numbers, "DEC");
                    foreach (int item in numbers)
                    {
                        Console.Write($"|{item}");
                    }
                }
                else
                {
                    Console.WriteLine("Opção Não Identificada(Padrão): ");
                    numbers = bb.OrdernarVetor(numbers);
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
             2.	Escreva um algoritmo para:
            a)	Preencher uma matriz A.
            b)	Ordenar os elementos da matriz A.
            c)	Gerar uma matriz somente com os números pares da matriz A.
            d)	Gerar uma matriz somente com os números múltiplos de 5.
            e)	Criar um menu para acessar os itens anteriores no programa principal.
             */

            string continua = "";
            int[] matrizA, matrizPar, matrizCinco;
            int contPar = 0, contCinco = 0;
            do
            {
                Console.WriteLine("\n- Exercicio 02 - Capítulo 7\n");
                Console.WriteLine("Quantos elementos serão preenchidos? (ex: 10)");
                Console.Write("R: ");
                int eleme = int.Parse(Console.ReadLine());
                matrizA = new int[eleme];
                Console.WriteLine("");
                for (int i = 0; i < matrizA.Length; i++)
                {
                    Console.Write($"Digite o {i + 1}º Valor da Matriz: ");
                    matrizA[i] = int.Parse(Console.ReadLine());                    
                }

                do
                {
                    Console.WriteLine("---- Menu ----\n" +
                                      "digite 1 -> Mostrar os números pares da matriz\n" +
                                      "digite 2 -> Mostrar os números multiplos de 5 da matriz\n" +
                                      "digite 3 -> Mostrar os números ordenados");
                    Console.Write("R: ");
                    int op = int.Parse(Console.ReadLine());
                    if (op == 1)
                    {
                        contPar = bb.ContadorMatrizMultiploN(matrizA, 2);
                        matrizPar = bb.GerarMatrizMultiploN(matrizA, contPar, 2);
                        Console.Write("\nMatriz Numeros Pares: ");
                        foreach (int item in matrizPar)
                        {
                            Console.Write($"|{item}");
                        }
                    }
                    else
                    if (op == 2)
                    {
                        contCinco = bb.ContadorMatrizMultiploN(matrizA, 5);
                        matrizCinco = bb.GerarMatrizMultiploN(matrizA, contCinco, 2);
                        Console.Write("\nMatriz Multiplos de 5: ");
                        foreach (int item in matrizCinco)
                        {
                            Console.Write($"|{item}");
                        }
                    }
                    else
                    if (op == 3)
                    {
                        matrizA = bb.OrdernarVetor(matrizA); ;
                        Console.Write("\nMatriz Ordenada: ");
                        foreach (int item in matrizA)
                        {
                            Console.Write($"|{item}");
                        }
                    }
                    else Console.WriteLine("Não identificado!");

                    Console.WriteLine("\nDeseja voltar ao Menu? (Sim,Nao)(S,N)");
                    continua = Console.ReadLine().ToUpper();
                } while (continua.Equals("SIM") || continua.Equals("S"));


                Console.WriteLine("*Deseja Refazer o exercício? (Sim,Nao)(S,N)");
                continua = Console.ReadLine().ToUpper();
            } while (continua.Equals("SIM") || continua.Equals("S"));
        }
        public void Exercicio3()
        {
            /*
             Elabore um algoritmo que seja capaz de fazer a conversão de um valor em real, 
            para o correspondente em dólar, libra, franco e iene, e vice-versa. 
            O programa deverá conter um menu com as opçóes e retornar os resultados para o programa principal, 
            encarregado da exibição dos resultados.
             */

            string continua = "";
            do
            {
                Console.WriteLine("\n- Exercicio 03 - Capítulo 7\n");
                Console.WriteLine("- MENU Conversões -\n" +
                                  "* Qual a sua moeda que deseja converter?\n" +
                                  "+Digite 1 -> Real(R$)\n" +
                                  "+Digite 2 -> Dólar($)\n" +
                                  "+Digite 3 -> Libra(£)\n" +
                                  "+Digite 4 -> Franco(fr)\n" +
                                  "+Digite 5 -> Iene(¥)\n");
                Console.Write("R: ");
                int op = int.Parse(Console.ReadLine());
                if (op < 1 || op > 5)
                {
                    Console.WriteLine("Opção Inválida!");
                }
                else
                {
                    if (op == 1)
                    {
                        bb.ConversorMoeda("R$");
                    }
                    if (op == 2)
                    {
                        bb.ConversorMoeda("$");
                    }
                    if (op == 3)
                    {
                        bb.ConversorMoeda("£");
                    }
                    if (op == 4)
                    {
                        bb.ConversorMoeda("fr");
                    }
                    if (op == 5)
                    {
                        bb.ConversorMoeda("¥");
                    }

                }


                Console.WriteLine("*Deseja Refazer o exercício? (Sim,Nao)(S,N)");
                continua = Console.ReadLine().ToUpper();
            } while (continua.Equals("SIM") || continua.Equals("S"));
        }
        public void Exercicio4()
        {
            /*
             4.	Construa um algoritmo que verifique se um dado número é divisível por outro, 
            sen- do que ambos devem ser fornecidos pelo usuário, usando a passagem de parâmetros formais, 
            com a exibição do resultado no programa principal.
             */

            string continua = "", resp = "";
            do
            {
                Console.WriteLine("\n- Exercicio 04 - Capítulo 7\n");

                Console.Write("Digite um Número: ");
                double n1 = double.Parse(Console.ReadLine());
                Console.Write("Digite um segundo Número: ");
                double n2 = double.Parse(Console.ReadLine());

                if (n1 % n2 == 0)
                {
                    resp += $"O numero {n1} é divisivel por {n2}\n";
                }
                else resp += $"O numero {n1} NÃO é divisivel por {n2}\n";

                if (n2 % n1 == 0)
                {
                    resp += $"O numero {n2} é divisivel por {n1}";
                }
                else resp += $"O numero {n2} NÃO é divisivel por {n1}"; ;

                Console.WriteLine("*Deseja Refazer o exercício? (Sim,Nao)(S,N)");
                continua = Console.ReadLine().ToUpper();
            } while (continua.Equals("SIM") || continua.Equals("S"));
        }
        public void Exercicio5()
        {
            /*
             5.	Faça um algoritmo que possibilite o arredondamento de um número real para um número inteiro, 
            seguindo o arredondamento padrão, utilizando a passagem por referência
             */

            string continua = "";
            do
            {
                Console.WriteLine("\n- Exercicio 05 - Capítulo 7\n");

                Console.Write("Insira um número (ex: 2,7): ");
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine($"\nNumero arredondado para inteiro: {number.ToString("N0")}");

                Console.WriteLine("*Deseja Refazer o exercício? (Sim,Nao)(S,N)");
                continua = Console.ReadLine().ToUpper();
            } while (continua.Equals("SIM") || continua.Equals("S"));
        }
        public void Exercicio8()
        {
            /*
             refaça o Exemplo 7.1 utilizando variaveis globais             
             */

            string continua = "";
            do
            {
                Console.WriteLine("\n- Exercicio 08 - Capítulo 7\n");



                Console.WriteLine("*Deseja Refazer o exercício? (Sim,Nao)(S,N)");
                continua = Console.ReadLine().ToUpper();
            } while (continua.Equals("SIM") || continua.Equals("S"));
        }
        public void Exercicio9()
        {
            /*
             Escreva uma função, para preencher um vetor, com 30 números inteiros sorteados 
            aleatoriamente. O vetor devera ser retornado ao programa principal, e vocé deve 
            acrescentar:
            a)	Um procedimento que recebe o vetor preenchido no item anterior, faz a ordenação dos elementos e apresenta o resultado 
            através de uma mensagem exibida ao usuário.
            b)	Uma funçáo que recebe o vetor preenchido no item a e que retorna a quantidade de números 
            múltiplos de 7 que existem no conjunto.
            c)	Escreva o programa principal e faça a chamada aos métodos criados nos itens a, b e c.

             */
            int n = 30;
            int[] vetor = new int[n];
            string continua = "", resp = "";
            do
            {
                Console.WriteLine("\n- Exercicio 09 - Capítulo 7\n");
                vetor = bb.SortearValoresVetor(n);
                Console.WriteLine("--- Menu Procedimentos ---\n" +
                    "+ digite 1 -> Mostrar o vetor preenchido por 30 numeros aleatórios\n" +
                    "+ digite 2 -> Quantidade de números Multiplos de 7\n");
                Console.Write("R: ");

                int op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    for (int i = 0; i < vetor.Length; i++)
                    {
                        resp += vetor[i] + " ";                        
                    }
                    Console.WriteLine(resp);
                }
                else if (op == 2)
                {
                    int multiplo7 = bb.ContadorMatrizMultiploN(vetor,7);
                    Console.WriteLine($"Dentro do Vetor estão {multiplo7} numeros multiplo de 7.");
                }
                else Console.WriteLine("Resposta não identificado!");


                Console.WriteLine("*Deseja Refazer o exercício? (Sim,Nao)(S,N)");
                continua = Console.ReadLine().ToUpper();
            } while (continua.Equals("SIM") || continua.Equals("S"));
        }
    }
}
