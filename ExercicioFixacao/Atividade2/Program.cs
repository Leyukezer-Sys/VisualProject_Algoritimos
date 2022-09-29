// Leia 3 valores e calcule a media aritimetica

//dados
double v1 = 0, v2 = 0, v3 = 0;
//entrada
Console.WriteLine("--- Calcular Média ---");
Console.Write("Digite o valor 1: ");
v1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o valor 2: ");
v2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o valor 3: ");
v3 = Convert.ToDouble(Console.ReadLine());

//pocessamento
double media = (v1 + v2 + v3)/3;

//saida
Console.WriteLine("------ Média Aritimética ------\n" +
                  "# Resultado: " + media);

Console.ReadKey();