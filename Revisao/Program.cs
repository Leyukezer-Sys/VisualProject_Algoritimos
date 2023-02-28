using Microsoft.Win32.SafeHandles;

class Exercicio_1
{
    static void Main() 
    {
        //Crie um programa que peça 10 números inteiros e apresente: a média, a soma e o menor. (10)

        int number;
        double media, soma = 0, menor = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Insira o {i + 1}º Valor: ");
            number = Convert.ToInt32(Console.ReadLine());
            soma += number;
            if (i == 0) menor = number;

            if (number < menor)
            {
                menor = number;
            }

        }
        media = soma / 10;
        Console.WriteLine($"Resultado:\n" +
                          $"Média: {media}\n" +
                          $"Soma: {soma}\n" +
                          $"menor: {menor}");
    }
    
}