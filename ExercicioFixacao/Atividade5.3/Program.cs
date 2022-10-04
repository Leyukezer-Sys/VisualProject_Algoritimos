// algoritimo que calcula e exiba a tabuada até o numero que for fornecido pelo usuario

int tabuada;

Console.WriteLine("---- Gerador de tabuada ----\n" +
                  "Digite um numero inteiro que repesente a ultima tabuada a ser gerada(ex: 5 -> para gerar até a tabuada do 5)");
Console.Write("Sua Resposta: ");
tabuada = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= tabuada; i++)
{
    for (int j = 0; j < 11; j++)
    {
        Console.WriteLine(i + " x " + j + " = " + (i * j));
    }
}