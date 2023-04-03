using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6_2
{
    public class Biblioteca
    {
        public string DiaDaSemana(int n)
        {
            string dia = "";
            if (n == 0)
            {
                dia = "Domingo      ";
            }
            else
            if (n == 1)
            {
                dia = "Segunda-Feira";
            }
            else
            if (n == 2)
            {
                dia = "Terça-Feira  ";
            }
            else
            if (n == 3)
            {
                dia = "Quarta-Feira ";
            }
            else
            if (n == 4)
            {
                dia = "Quinta-Feira ";
            }
            else
            if (n == 5)
            {
                dia = "Sexta-Feira  ";
            }
            else
            if (n == 6)
            {
                dia = "Sábado       ";
            }
            else
            {
                dia = "Indefinido";
            }
            return dia;
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
