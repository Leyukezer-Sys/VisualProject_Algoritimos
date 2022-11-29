// Faça um algoritmo que leia um número inteiro e mostre uma
//mensagem indicando se este número é par ou ímpar, e se é
//positivo ou negativo

int valor;

Console.Write(@"Exercicio 03

Digite um valor para verificação: ");
valor = Convert.ToInt32(Console.ReadLine());

if (valor != 0)
{
    if (valor > 0)
    {
        if (valor%2 ==0)
        {
            Console.WriteLine("O valor digitado é Par e Positivo!");
        }else Console.WriteLine("O valor digitado é Ímpar e Positivo!");
    }else if (valor % 2 == 0)
    {
        Console.WriteLine("O valor digitado é Par e Negativo!");
    }
    else Console.WriteLine("O valor digitado é Ímpar e Negativo!");
}
else Console.WriteLine("O valor digitado é Neutro");