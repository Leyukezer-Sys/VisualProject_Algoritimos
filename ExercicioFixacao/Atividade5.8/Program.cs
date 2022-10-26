// Leia 4 valores e calcule a soma
//dado
double v1 = 0, v2 = 0, v3 = 0, v4 = 0;
string cond = "S";

//entrada
while (cond.Equals("SIM") || cond.Equals("S") || cond.Equals("Y") || cond.Equals("YES")){
    Console.WriteLine("\n--- Calcular Soma de 4 valares ---");
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
                      "# Resultado: " + soma);

    Console.WriteLine("\n\nDeseja Continuar com outros valores?(sim/nao/s/n/yes/no/y/n)");
    Console.Write("R:. ");
    cond = Console.ReadLine();
    cond = cond.ToUpper();
}

Console.WriteLine("Obrigado por Testar a atividade!");

Console.ReadKey();