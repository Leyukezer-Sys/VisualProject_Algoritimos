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
             2.	Escreva um algoritmo para:
            a)	Preencher uma matriz A.
            b)	Ordenar os elementos da matriz A.
            c)	Gerar uma matriz somente com os números pares da matriz A.
            d)	Gerar uma matriz somente com os números múltiplos de 5.
            e)	Criar um menu para acessar os itens anteriores no programa principal.
             */

            string continua = "";
            int[] matrizA,matrizPar,matrizCinco;
            int contPar=0, contCinco=0;
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
                    if (matrizA[i] % 2 == 0)
                    {
                        contPar++;
                    }
                    if (matrizA[i] % 5 == 0)
                    {
                        contCinco++;
                    }
                }
                do
                {
                    Console.WriteLine("---- Menu ----\n" +
                                      "digite 1 -> Mostrar os números pares da matriz\n" +
                                      "digite 2 -> Mostrar os números multiplos de 5 da matriz");
                    Console.Write("R: ");
                    int op = int.Parse(Console.ReadLine());
                    if (op == 1)
                    {
                        matrizPar = new int[contPar];
                        int indice = 0;
                        for (int i = 0; i < matrizA.Length; i++)
                        {
                            if (matrizA[i] % 2 == 0)
                            {
                                matrizPar[indice] = matrizA[i];
                                indice++;
                            }
                        }
                        Console.Write("\nMatriz Numeros Pares: ");
                        foreach (int item in matrizPar)
                        {
                            Console.Write($"|{item}");
                        }
                    }else
                    if (op == 2)
                    {
                        matrizCinco = new int[contCinco];
                        int indice = 0;
                        for (int i = 0; i < matrizA.Length; i++)
                        {
                            if (matrizA[i] % 5 == 0)
                            {
                                matrizCinco[indice] = matrizA[i];
                                indice++;
                            }
                        }
                        Console.Write("\nMatriz Multiplos de 5: ");
                        foreach (int item in matrizCinco)
                        {
                            Console.Write($"|{item}");
                        }
                    }
                    else    Console.WriteLine("Não identificado!");
                    
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

            string continua = "";
            do
            {
                Console.WriteLine("\n- Exercicio 04 - Capítulo 7\n");



                Console.WriteLine("*Deseja Refazer o exercício? (Sim,Nao)(S,N)");
                continua = Console.ReadLine().ToUpper();
            } while (continua.Equals("SIM") || continua.Equals("S"));
        }
        public void Exercicio5()
        {
            /*
             5.	Faça um algoritmo que possibilite o arredon- damento de um número real para um núme- ro inteiro, 
            seguindo o arredondamento pa- dráo, utilizando a passagem por referência
             */

            string continua = "";
            do
            {
                Console.WriteLine("\n- Exercicio 05 - Capítulo 7\n");



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
            a)	Um procedimento que recebe o vetor preenchido no item anterior, faz a orde- nação dos elementos e apresenta o resul- tado através de uma mensagem exibida ao usuário.
            b)	Uma funçáo que recebe o vetor preen- chido no item a e que retorna a quan- tidade de números múltiplos de 7 que existem no conjunto.
            c)	Escreva o programa principal e faça a chamada aos métodos criados nos itens a, b e c.

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
