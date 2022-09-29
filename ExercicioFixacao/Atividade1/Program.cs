// Leia 4 valores e calcule a soma
//dado
double v1 = 0, v2 = 0, v3 = 0, v4 = 0;
//entrada
Console.WriteLine("--- Calcular ---");
Console.Write("Digite o valor 1: ");
v1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o valor 2: ");
v2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o valor 3: ");
v3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o valor 4: ");
v4 = Convert.ToDouble(Console.ReadLine());

//pocessamento
double soma = v1 + v2 + v3 + v4;

//saida
Console.WriteLine("------ Soma ------\n" +
                  "# Resultado: "+soma);

Console.ReadKey();