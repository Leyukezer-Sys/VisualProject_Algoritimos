// Verifique se um numero fornecido pelo usuario é par ou impar

//dados
double nu;

//entrada
Console.WriteLine("---- Verificar número (par/impar) ----");
Console.Write("Digite um número para verificação: ");
nu = Convert.ToDouble(Console.ReadLine());

//processamento
if (nu%2 == 0)
{
    Console.WriteLine("\n---- Resposta ----\n" +
                      "O número " + nu + " é\n" +
                      "um Número Par");
}
else
{
    Console.WriteLine("\n---- Resposta ----\n" +
                      "O número " + nu + " é\n" +
                      "um Número ímpar");
}