// Um algoritimo que o usuario escolha se quer somar subtrair dividir ou multiplicar

double valor1, valor2;
int op;

Console.Write(@"Exercicio 07

Digite o Valor 1: ");
valor1 = Convert.ToDouble(Console.ReadLine());
Console.Write("\nDigite o Valor 2: ");
valor2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($@"
Escolha uma opção:
1 -> {valor1} + {valor2}
2 -> {valor1} - {valor2}
3 -> {valor1} * {valor2}
4 -> {valor1} / {valor2}");
Console.Write("R:. ");
op = Convert.ToInt32(Console.ReadLine());

switch (op)
{
    case 1:
        Console.WriteLine($"Resultado: "+(valor1 + valor2));
        break;
    case 2:
        Console.WriteLine($"Resultado: " + (valor1 - valor2));
        break;
    case 3:
        Console.WriteLine($"Resultado: " + (valor1 * valor2));
        break;
    case 4:
        Console.WriteLine($"Resultado: " + (valor1 / valor2));
        break;
    default:
        Console.WriteLine("Sua Escolha é invalida!");
        break;
}
