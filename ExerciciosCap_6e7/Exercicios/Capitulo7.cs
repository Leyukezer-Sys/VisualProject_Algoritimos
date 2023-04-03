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
                    numbers = OrdernarVetor(numbers);
                    foreach (int item in numbers)
                    {
                        Console.Write($"|{item}");
                    }
                }
                else if (op == 2)
                {
                    Console.WriteLine("Ordem Decrescente: ");
                    numbers = OrdernarVetor(numbers, "DEC");
                    foreach (int item in numbers)
                    {
                        Console.Write($"|{item}");
                    }
                }
                else
                {
                    Console.WriteLine("Opção Não Identificada(Padrão): ");
                    numbers = OrdernarVetor(numbers);
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
                                      "digite 2 -> Mostrar os números multiplos de 5 da matriz\n" +
                                      "digite 3 -> Mostrar os números ordenados");
                    Console.Write("R: ");
                    int op = int.Parse(Console.ReadLine());
                    if (op == 1)
                    {
                        matrizPar = GerarMatrizMultiploN(matrizA, contPar, 2);
                        Console.Write("\nMatriz Numeros Pares: ");
                        foreach (int item in matrizPar)
                        {
                            Console.Write($"|{item}");
                        }
                    }
                    else
                    if (op == 2)
                    {
                        matrizCinco = GerarMatrizMultiploN(matrizA, contCinco, 2);
                        Console.Write("\nMatriz Multiplos de 5: ");
                        foreach (int item in matrizCinco)
                        {
                            Console.Write($"|{item}");
                        }
                    }
                    else
                    if (op == 3)
                    {
                        matrizA = OrdernarVetor(matrizA); ;
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
                        ConversorMoeda("R$");
                    }
                    if (op == 2)
                    {
                        ConversorMoeda("$");
                    }
                    if (op == 3)
                    {
                        ConversorMoeda("£");
                    }
                    if (op == 4)
                    {
                        ConversorMoeda("fr");
                    }
                    if (op == 5)
                    {
                        ConversorMoeda("¥");
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
                vetor = SortearValoresVetor(n);
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
                    int multiplo7 = ContadorMatrizMultiploN(vetor,7);
                    Console.WriteLine($"Dentro do Vetor estão {multiplo7} numeros multiplo de 7.");
                }
                else Console.WriteLine("Resposta não identificado!");


                Console.WriteLine("*Deseja Refazer o exercício? (Sim,Nao)(S,N)");
                continua = Console.ReadLine().ToUpper();
            } while (continua.Equals("SIM") || continua.Equals("S"));
        }

        public int[] OrdernarVetor(int[] matriz, string forma)
        {
            if (forma == "CRE")
            {
                Array.Sort(matriz);
            }
            else if (forma == "DEC")
            {
                Array.Sort(matriz);
                Array.Reverse(matriz);
            }

            return matriz;
        }
        public int[] OrdernarVetor(int[] matriz)
        {

            Array.Sort(matriz);


            return matriz;
        }
        public int[] GerarMatrizMultiploN(int[] matrizExtracao, int tamanho, int multiploDe)
        {
            int[] matrizN = new int[tamanho];
            int indice = 0;
            for (int i = 0; i < matrizExtracao.Length; i++)
            {
                if (matrizExtracao[i] % multiploDe == 0)
                {
                    matrizN[indice] = matrizExtracao[i];
                    indice++;
                }
            }
            return matrizN;
        }
        public double[] GerarMatrizMultiploN(double[] matrizExtracao, int tamanho, int multiploDe)
        {
            double[] matrizN = new double[tamanho];
            int indice = 0;
            for (int i = 0; i < matrizExtracao.Length; i++)
            {
                if (matrizExtracao[i] % multiploDe == 0)
                {
                    matrizN[indice] = matrizExtracao[i];
                    indice++;
                }
            }
            return matrizN;
        }
        public void ConversorMoeda(string moeda)
        {
            double real = 0.0, libra = 0.0, dolar = 0.0, franco = 0.0, iene = 0.0;
            Console.WriteLine("*Digite seu valor:");
            if (moeda == "R$")
            {
                Console.Write("R$ ");
                real = double.Parse(Console.ReadLine());

                dolar = real * 0.1975;
                libra = real * 0.16;
                franco = real * 0.18;
                iene = real * 26.22;
            }
            else
            if (moeda == "$")
            {
                Console.Write("$ ");
                dolar = double.Parse(Console.ReadLine());

                real = dolar * 5.06;
                libra = dolar * 0.81;
                franco = dolar * 0.91;
                iene = dolar * 132.78;
            }
            else
            if (moeda == "£")
            {
                Console.Write("£ ");
                libra = double.Parse(Console.ReadLine());

                dolar = libra * 1.2346;
                real = libra * 6.25;
                franco = libra * 1.13;
                iene = libra * 163.91;
            }
            else
            if (moeda == "fr")
            {
                Console.Write("fr ");
                franco = double.Parse(Console.ReadLine());

                dolar = franco * 1.0946;
                libra = franco * 0.89;
                real = franco * 5.53;
                iene = franco * 145.13;
            }
            else
            if (moeda == "¥")
            {
                Console.Write("¥ ");
                iene = double.Parse(Console.ReadLine());

                dolar = iene * 0.007575;
                libra = iene * 0.0062;
                franco = iene * 0.0069;
                real = iene * 0.038;
            }
            else
            {
                Console.Write("R$ ");
                real = double.Parse(Console.ReadLine());

                dolar = real * 0.1975;
                libra = real * 0.16;
                franco = real * 0.18;
                iene = real * 26.22;
            }

            Console.WriteLine("-- Conversão --\n" +
                $"Real: R${real.ToString("N2")}\n" +
                $"Dólar: ${dolar.ToString("N2")}\n" +
                $"Libra: £{libra.ToString("N2")}\n" +
                $"Franco: fr{franco.ToString("N2")}\n" +
                $"Iene: ¥{iene.ToString("N2")}");
        }
        public int[] SortearValoresVetor(int tamanho)
        {
            int[] numbers = new int[tamanho];
            Random sortear = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = sortear.Next(100);
            }
            return numbers;
        }
        public int ContadorMatrizMultiploN(int[] matrizExtracao, int multiplo)
        {
            int contador = 0;
            for (int i = 0; i < matrizExtracao.Length; i++)
            {
                if (matrizExtracao[i] % multiplo == 0)
                {
                    contador++;
                }
            }
            return contador;
        }
    }
}
