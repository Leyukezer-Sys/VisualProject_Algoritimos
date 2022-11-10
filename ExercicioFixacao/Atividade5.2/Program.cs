// pedro tem 1,50m e cresce 2cm por ano, enquanto lucas 1,10m e cresce 3cm por ano

double idadePedro = 150, idadeLucas = 110;
string statusA = "", statusB = "";
int ano = 0;

do
{
    idadePedro = idadePedro + 002;
    idadeLucas = idadeLucas + 003;
    ano++;

    if (idadePedro == idadeLucas)
    {
        statusA = "a) em " + ano + " ano(s) Lucas e Pedro terão a mesma altura.";
    }
    else
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
} while (idadePedro >= idadeLucas);

Console.WriteLine(statusA+"\n"+statusB);