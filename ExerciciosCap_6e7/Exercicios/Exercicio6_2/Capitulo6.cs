using Exercicio6_2;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Capitulo6
    {
        Biblioteca bb = new Biblioteca();
        public void Exercicio2()
        {
            //2.	Dadas as temperaturas que foram registradas, diariamente, durante uma semana, deseja-se determinar em quantos dias desta semana a temperatura esteve acima da média. A solução para este problema envolve os se- guintes passos:
            //a)	Obter os valores das temperaturas.
            //b)	Calcular a média desses valores.
            //c)	Verificar quantos deles sáo maiores que a média.

            double[] temperatura = new double[7];
            double media = 0.0, soma = 0.0, max = 0.0;
            int cont= 0;
            string dia = "", continua = "";
            do
            {
                Console.WriteLine("- Exercicio 02 - Capítulo 6\n");

                for (int i = 0; i < temperatura.Length; i++)
                {
                    dia = bb.DiaDaSemana(i);
                    Console.Write($"Qual a temperatura de {dia}: ");
                    temperatura[i] = double.Parse(Console.ReadLine());
                }
                soma = temperatura.Sum();
                media = soma / temperatura.Length;
                for (int i = 0; i < 7; i++)
                {
                    if (i != 0)
                    {
                        if (temperatura[i] > media)
                        {
                            cont++;
                        }
                        if (temperatura[i] > max)
                        {
                            max = temperatura[i];
                        }
                    }
                    else
                    {
                        max = temperatura[i];
                    }                    
                }
                Console.WriteLine($"** Média das Temperaturas: {media.ToString("N1")}ºC");
                Console.WriteLine($"** Quantidade de Temperaturas Acima da Média: {cont}");
                Console.WriteLine("*Deseja Refazer o exercício? (Sim,Nao)(S,N)");
                continua = Console.ReadLine().ToUpper();
            } while (continua.Equals("SIM") || continua.Equals("S"));
        }
        public void Exercicio3()
        {
            /* 
            3.Crie vetores para armazenar:
            a)	As vogais do alfabeto.
            b)  As alturas de um grupo de dez pessoas.
            c)	Os nomes dos meses do ano.
            */

            string[] vogais = new string[6], meses = new string[12];
            double[] altura = new double[10];
            string continua = "", resp = "";
            do
            {
                Console.WriteLine("- Exercicio 03 - Capítulo 6\n");
                Console.WriteLine("==== Vogais ====");
                for (int i = 0; i < vogais.Length; i++)
                {
                    Console.Write($"Qual a {i+1}ª vogal: ");
                    vogais[i] = Console.ReadLine();
                }
                Console.WriteLine("==== Altura de 10 Pessoas ====");
                for (int i = 0; i < altura.Length; i++)
                {
                    Console.Write($"Qual a altura da {i + 1}ª pessoa: ");
                    altura[i] = Double.Parse(Console.ReadLine());
                }
                Console.WriteLine("==== Meses do Ano ====");
                for (int i = 0; i < meses.Length; i++)
                {
                    Console.Write($"Qual o nome do {i + 1}º Mês: ");
                    meses[i] = Console.ReadLine();
                }
                resp = "- Vogais:";
                foreach (string item in vogais)
                {
                    resp += $" {item} |";
                }
                resp += "\n- Altura De 10 Pessoas(cm):";
                for (int i = 0;i < altura.Length; i++)
                {
                    resp += $"\n|{i+1}ª Pessoa - Altura: {altura[i]}cm|";
                }
                resp += "\n- Meses do ano:";
                for (int i = 0;i < meses.Length; i++)
                {
                    resp += $"\n|{i+1}º Mês: {meses[i]}|";
                }
                Console.WriteLine($"\n==== Seus Resultados ====\n" +
                    $" {resp}\n");
                Console.WriteLine("*Deseja Refazer o exercício? (Sim,Nao)(S,N)");
                continua = Console.ReadLine().ToUpper();
            } while (continua.Equals("SIM") || continua.Equals("S"));
        }
        public void Exercicio7()
        {
            /*
             7.	Codifique um algoritmo Histograma, que exiba um histograma da variação da tem- peratura durante a semana. Por exemplo, se as  temperaturas  forem  19O C,   21 °C,    25°C, 22OC,  20°C,  17°C  e  l 5°C,  de  domingo  a sábado, respectivamente, o algoritmo deve- rá exibir:
                D   : ■■■■■■■■■■■■■■■■■■■
                S   : ■■■■■■■■■■■■■■■■■■■■
                T   : ■■■■■■■■■■■■■■■■■■■■■■■■■
            Suponha que as temperaturas sejam todas positivas e que nenhuma seja maior que 80OC. Dica: crie uma rotina que exiba uma linha, com uma quantidade de caracteres de tamanho proporcional a temperatura.
             */
            double[] temperatura = new double[7];
            string dia = "", continua = "", resp = "";
            do
            {
                Console.WriteLine("- Exercicio 07 - Capítulo 6\n");

                for (int i = 0; i < temperatura.Length; i++)
                {
                    dia = bb.DiaDaSemana(i);
                    Console.Write($"Qual a temperatura de {dia}: ");
                    temperatura[i] = double.Parse(Console.ReadLine());
                    resp += $"\n{dia}: ";
                    for (int j = 0; j < temperatura[i]; j++)
                    {
                        resp += "■";
                    }
                    resp += $"|{temperatura[i]}ºC";
                }

                Console.WriteLine($"\nHistograma:{resp}\n");
                Console.WriteLine("*Deseja Refazer o exercício? (Sim,Nao)(S,N)");
                continua = Console.ReadLine().ToUpper();
            } while (continua.Equals("SIM") || continua.Equals("S"));
        }
    }
}
