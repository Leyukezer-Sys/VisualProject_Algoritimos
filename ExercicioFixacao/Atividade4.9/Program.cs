// faça um programa que mostre se ele ficou para exame e,
// em caso positivo, que nota este aluno precisa obter,
// no exame, para passar de ano

//dados
double prova1=0, prova2=0,prova3 =0, media, mfinal, notaR;

//entrada
Console.WriteLine("----- Verificar nota do aluno -----");
Console.Write("Insira a nota da primeira prova do aluno: ");
prova1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Insira a nota da segunda prova do aluno: ");
prova2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Insira a nota da terceira prova do aluno: ");
prova3 = Convert.ToDouble(Console.ReadLine());

//processamento
media = (prova1+prova2+prova3) / 3;
if (media <7.0)
{
    notaR = 10 - media;
    Console.WriteLine("\n----- Exame do aluno -----\n" +
                      " !! O aluno precisa de "+notaR+" pontos no Exame para passar de ano !!\n");
    Console.Write("Insira a nota do Exame do aluno: ");
    double exame = Convert.ToDouble(Console.ReadLine());
    mfinal = (media + exame) / 2;
    if (mfinal<5.0)
    {
        Console.WriteLine("\n--- Resultado ---\n" +
                      "# Nota da prova 1: " + prova1 + "\n" +
                      "# Nota da prova 2: " + prova2 + "\n" +
                      "# Nota da prova 3: " + prova3 + "\n" +
                      "$ Nota da Média: " + media + "\n" +
                      "$ Nota do Exame: " + exame + "\n" +
                      "$ Média Final: " + mfinal + "\n" +
                      "!!! O Aluno foi Reprovado !!!");
    }
    else
    {
        Console.WriteLine("\n--- Resultado ---\n" +
                      "# Nota da prova 1: " + prova1 + "\n" +
                      "# Nota da prova 2: " + prova2 + "\n" +
                      "# Nota da prova 3: " + prova3 + "\n" +
                      "$ Nota da Média: " + media + "\n" +
                      "$ Nota do Exame: " + exame + "\n" +
                      "$ Média Final: " + mfinal + "\n" +
                      "!!! O Aluno foi Aprovado !!!");
    }
    
}
else
{
    mfinal = media;
    Console.WriteLine("\n--- Resultado ---\n" +
                      "# Nota da prova 1: "+prova1+"\n" +
                      "# Nota da prova 2: "+prova2+"\n" +
                      "# Nota da prova 3: "+prova3+"\n" +
                      "$ Nota da Média: " +media+"\n" +
                      "$ Média Final: "+mfinal + "\n" +
                      "!!! O Aluno foi Aprovado !!!");
}

Console.ReadKey();