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
            double real = 0.0, dolar = 0.0, libra = 0.0,franco = 0.0,iene = 0.0;
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
                    Console.WriteLine("*Digite seu valor:");
                    if (op == 1)
                    {
                        Console.Write("R$ ");
                        real = double.Parse(Console.ReadLine());

                        dolar = real * 0.1975;
                        libra = real * 0.16;
                        franco = real * 0.18;
                        iene = real * 26.22;
                    }
                    if (op == 2)
                    {
                        Console.Write("$ ");
                        dolar = double.Parse(Console.ReadLine());

                        real = dolar * 5.06;
                        libra = dolar * 0.81;
                        franco = dolar * 0.91;
                        iene = dolar * 132.78;
                    }
                    if (op == 3)
                    {
                        Console.Write("£ ");
                        libra = double.Parse(Console.ReadLine());

                        dolar = libra * 1.2346;
                        real = libra * 6.25;
                        franco = libra * 1.13;
                        iene = libra * 163.91;
                    }
                    if (op == 4)
                    {
                        Console.Write("fr ");
                        franco = double.Parse(Console.ReadLine());

                        dolar = franco * 1.0946;
                        libra = franco * 0.89;
                        real = franco * 5.53;
                        iene = franco * 145.13;
                    }
                    if (op == 5)
                    {
                        Console.Write("¥ ");
                        iene = double.Parse(Console.ReadLine());

                        dolar = iene * 0.007575;
                        libra = iene * 0.0062;
                        franco = iene * 0.0069;
                        real = iene * 0.038;
                    }

                    Console.WriteLine("-- Conversão --\n" +
                        $"Real: R${real.ToString("N2")}\n" +
                        $"Dólar: ${dolar.ToString("N2")}\n" +
                        $"Libra: £{libra.ToString("N2")}\n" +
                        $"Franco: fr{franco.ToString("N2")}\n" +
                        $"Iene: ¥{iene.ToString("N2")}");
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

                if (n1%n2 == 0 )
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

            string continua = "";
            do
            {
                Console.WriteLine("\n- Exercicio 09 - Capítulo 7\n");



                Console.WriteLine("*Deseja Refazer o exercício? (Sim,Nao)(S,N)");
                continua = Console.ReadLine().ToUpper();
            } while (continua.Equals("SIM") || continua.Equals("S"));
        }
    }
}
