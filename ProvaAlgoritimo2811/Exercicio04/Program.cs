// Faço um algoritmo que leia números até o usuário digitar 0, após
//finalizar, mostre quantos números lidos, a soma e quantos são
//ímpares

double valor = 0, soma= 0, cont=0, contImp=0;

Console.WriteLine("Exercicio 04");

do
{
    Console.Write("\nDigite um valor: ");
    valor = Convert.ToDouble(Console.ReadLine());

    if (valor != 0)
    {
        soma += valor;
        cont++;
        if (valor%2 != 0)
        {
            contImp++;
        }
    }
} while (valor != 0);
Console.WriteLine($@"Resultado: 
- Quantidade de números lidos: {cont}
- Soma dos números lidos: {soma}
- Quantidade de números Ímpares lidos: {contImp}");