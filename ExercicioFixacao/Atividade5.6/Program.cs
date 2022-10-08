using System;
// escreva um algoritimo que, a partir de um numero "n" fornecido pelo usuario,
﻿// escreva um algoritimo que, a partir de um numero "n" fornecido pelo usuario,
//execute os calculos a seguir enquanto "n" for diferente de 1
//a) se n for par n = n ÷ 2
//b) se n for impar n = n × 3 + 1

//dados

double n;

Console.WriteLine("----- Atividade 5.6 -----");
Console.Write("Insira um Numero: ");
n = Convert.ToDouble(Console.ReadLine());

//processamento
while (n != 1)
{
	if (n % 2 == 0)
	{
		n = n / 2;
		Console.WriteLine(n);
	}
	else
	{
		n = n * 3 + 1;
		Console.WriteLine(n);
	}
}