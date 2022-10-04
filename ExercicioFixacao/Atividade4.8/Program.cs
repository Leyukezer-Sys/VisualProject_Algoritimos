// De acordo o número inserido pelo usuario,
// verifique se ele é múltiplo de 3, ou múltiplo de 7.

double nu;

//entrada
Console.WriteLine("---- Verificar número é multiplo de 3 ou 7 ----");
Console.Write("Digite um número para verificação: ");
nu = Convert.ToDouble(Console.ReadLine());

//processamento
if (nu%3 == 0)
{
    Console.WriteLine("\n---- Resposta ----\n" +
                      "O número " + nu + " é\n" +
                      "um Número multiplo de 3");
}
if (nu%7 == 0)
{
    Console.WriteLine("\n---- Resposta ----\n" +
                      "O número " + nu + " é\n" +
                      "um Número multiplo de 7");
}
else
{
    Console.WriteLine("\n---- Resposta ----\n" +
                      "O número " + nu + "\n" +
                      "Não é multiplo de 3 nem de 7!");
}