// Crie um pragrama que peça 20 numeros e apresente a media
// a soma e o maior

double numeros, soma=0, media=0, maior=0;
Console.WriteLine("Exercicio 01\n");

for (int i = 0; i < 20; i++)
{
    Console.Write($"Digite o {(i+1)}º Valor: ");
    numeros = Convert.ToDouble(Console.ReadLine());
    soma += numeros;
    if (i == 0)
    {
        maior = numeros;
    }else if (numeros > maior)  maior = numeros ;
}
media = soma / 20;
Console.WriteLine($@"Resultado: 
@ soma dos numeros: {soma}|
@ média dos numeros: {media}|
@ maior valor: {maior}");

Console.ReadKey();