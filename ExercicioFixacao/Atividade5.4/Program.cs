// A partir de um conjunto de numeros inteiros sequenciais,
// obtidos com base em dados fornecidos pelo usuário (numero inicial e final),
//apresente:

//dados 
int inicial, final, cont=0, contPar=0, contImp=0, contImp37=0,soma=0,somaPar=0,somaImp=0,somaImp37=0;
double media,mediaPar, mediaImp, mediaImp37;

//entrada
Console.WriteLine("----- Atividade 5.4 -----");
Console.Write("Insira o numero inicial: ");
inicial = Convert.ToInt32(Console.ReadLine());
Console.Write("Insira o numero inicial: ");
final = Convert.ToInt32(Console.ReadLine());

//processamento
for (int i = inicial; i <= final; i++)
{
    if (i > 0)
    {
        cont++;
        soma += i;
        if (i % 2 == 0)
        {
            contPar++;
            somaPar += i;
        }
        else
        {
            if (i % 3 == 0 && i % 7 == 0)
            {
                contImp37++;
                somaImp37 += i;
            }
            contImp++;
            somaImp += i;
            
        }
    }
}


media = soma / cont;
mediaPar = somaPar / contPar;
mediaImp = somaImp / contImp;
if (contImp37 == 0)
{
    mediaImp37 = somaImp37 / 1;
}
else
{
    mediaImp37 = somaImp37 / contImp37;
}

//saida
Console.WriteLine("\n--- Resposta ---\n" +
                  "a) Quantidade de numeros Inteiros e positivos: "+cont+"\n" +
                  "b) Quantidade de numeros Pares: " + contPar + "\n" +
                  "c) Quantidade de numeros Impares: " + contImp + "\n" +
                  "d) Quantidade de numeros Impares e divisiveis por 3 e 7: " + contImp37 + "\n" +
                  "e) Media da 'a': "+ media+"\n" +
                  "   Media da 'b': "+ mediaPar+"\n" +
                  "   Media da 'c': "+mediaImp+"\n" +
                  "   Media da 'd': "+mediaImp37);
