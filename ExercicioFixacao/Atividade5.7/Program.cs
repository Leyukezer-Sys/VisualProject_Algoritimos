// Construa um algoritimo que encontre a mediana de uma sequencia de numeros inteiros
// fornecido pelo usuario o numero inicial e o numero final

int inicial, final, referenciai,referenciaj;
double mediana = 0.0;

Console.WriteLine("---- Atividade 5.7 ----");
Console.Write("Insira o numero inicial da sequencia: ");
inicial = Convert.ToInt32(Console.ReadLine());
Console.Write("Insira o numero Final da sequencia: ");
final = Convert.ToInt32(Console.ReadLine());

referenciaj = referenciai = final - inicial;
 
if (referenciai % 2 != 0)
{
    referenciai -= 1;
	referenciai /= 2;
	referenciaj = referenciai;
	referenciai += inicial;
	referenciaj = final - referenciaj;
}
else
{
    referenciai /= 2;
    referenciaj = referenciai;
    referenciai += inicial;
    referenciaj = final - referenciaj;
}

for (int i = inicial; i <= referenciai; i++)
{
	for (int j = final; j >= referenciaj; j--)
	{
		if (i == j)
		{
			mediana = i;
		}else
		{
			
			mediana = ((double) i + j) / 2;
		}

	}
}

Console.WriteLine("A mediana da saquencia é: " + mediana );