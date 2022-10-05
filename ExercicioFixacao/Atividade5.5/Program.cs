// Escreva um algoritimo que gere a sequência de fibonacci até o enesimo termo fornecido pelo usuario
//dados
int v = 1,vant = 0,soma, quant;

//entrada
Console.WriteLine("----- Gerador da sequência de fibonacci -----");
Console.Write("Insira Quantidade de termos a serem gerados: ");
quant = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= quant; i++)
{
    soma = v + vant;
    Console.WriteLine(i+"º valor:"+soma);
    vant = v;
    v = soma;  
}