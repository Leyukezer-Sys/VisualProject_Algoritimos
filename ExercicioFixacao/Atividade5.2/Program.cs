// pedro tem 1,50m e cresce 2cm por ano, enquanto lucas 1,10m e cresce 3cm por ano

double idadePedro = 1.50, idadeLucas = 1.10;
string statusA = "", statusB = "";
int ano = 0;

while (idadePedro > idadeLucas)
{
    idadePedro = idadePedro + 0.02;
    idadeLucas = idadeLucas + 0.03;
    ano++;

    if (idadePedro == idadeLucas)
    {
        statusA = "a) em "+ano+" ano(s) Lucas e Pedro terão a mesma altura.";
    }else
    {
        statusA = "a) Não é possivel terem a mesma altura!";
    }
    if (idadePedro < idadeLucas)
    {
        statusB = "b) em " + ano + " ano(s) Lucas será maior que Pedro.";
    }
    else
    {
        statusB = "b) Não é possivel o Lucar ser mais alto que Pedro!";
    }
}

Console.WriteLine(statusA+"\n"+statusB);