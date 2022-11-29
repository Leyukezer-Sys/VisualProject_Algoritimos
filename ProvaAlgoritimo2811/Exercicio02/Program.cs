// Tire a média dos números de 1 a 100 a imprima
// o valor da média.
int soma = 0;
double media;
for (int i = 0; i <= 100; i++)
{
    soma += i;
}

media = (double)soma / 100;

Console.WriteLine($@"Exercicio 02

Média dos Números de 1 a 100 é {media}");