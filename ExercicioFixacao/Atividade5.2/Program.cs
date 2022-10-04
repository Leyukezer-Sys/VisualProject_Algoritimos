// pedro tem 1,50m e cresce 2cm por ano, enquanto lucas 1,10m e cresce 3cm por ano

double idadePedro = 1.50, idadeLucas = 1.10;
int ano = 0;

while (idadePedro > idadeLucas)
{
    idadePedro = idadePedro + 0.02;
    idadeLucas = idadeLucas + 0.03;
    ano++;

    if (idadePedro == idadeLucas)
    {
        Console.WriteLine("a) em "+ano+" ano(s) Lucas e Pedro terão a mesma altura.");
    }else if (idadePedro < idadeLucas)
    {
        Console.WriteLine("b) em " + ano + " ano(s) Lucas será maior que Pedro.\n" +
                          "Não é possivel terem a mesma altura!");
    }
}