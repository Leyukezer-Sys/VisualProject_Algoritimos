using Exercicios;

string resposta = "S";
Capitulo6 exer = new Capitulo6();

do
{
    Console.Clear();
    Console.WriteLine("=========== EXERCICIOS CAPITULOS 6 E 7 ===========\n" +
                      "- Índice Exercícios Capitulo 6:\n" +
                      "+ Exercício 2 => Digite 1\n" +
                      "+ Exercício 3 => Digite 2\n" +
                      "+ Exercício 7 => Digite 3\n" +
                      "+ Exercício 8 => Digite 4\n" +
                      "+ Exercício 9 => Digite 5\n" +
                      "- Índice Exercícios Capitulo 7:\n" +
                      "+ Exercício 1 => Digite 6\n" +
                      "+ Exercício 2 => Digite 7\n" +
                      "+ Exercício 3 => Digite 8\n" +
                      "+ Exercício 4 => Digite 9\n" +
                      "+ Exercício 5 => Digite 10\n" +
                      "+ Exercício 8 => Digite 11\n" +
                      "+ Exercício 9 => Digite 12\n");
    Console.Write("Sua Escolha: ");
    int op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 1:
            exer.Exercicio2();
            break;
        case 2:
            exer.Exercicio3();
            break;
        case 3:
            exer.Exercicio7();
            break;
        default:
            Console.WriteLine("Selecione uma opção Válida");
            Console.ReadKey();
            continue;
    }
    Console.WriteLine("Deseja Realizar Outro Exercício? (Sim,Nao)(S,N)");
    resposta = Console.ReadLine().ToUpper();
} while (resposta.Equals("SIM") || resposta.Equals("S"));


