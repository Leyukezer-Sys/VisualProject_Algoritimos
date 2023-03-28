using Exercicios;

string resposta = "S";
Capitulo6 exer = new Capitulo6();
Capitulo7 exerc = new Capitulo7();

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
                      "+ Exercício 9 => Digite 12\n" +
                      "- Índice Extra:\n" +
                      "+ Exercício 6.10 => Digite 13");
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
        case 4:
            exer.Exercicio8();
            break;
        case 5:
            exer.Exercicio9();
            break;
        case 6:
            exerc.Exercicio1();
            break;
        case 7:
            exerc.Exercicio2();
            break;
        case 8:
            exerc.Exercicio3();
            break;
        case 9:
            exerc.Exercicio4();
            break;
        case 10:
            exerc.Exercicio5();
            break;
        case 11:
            exerc.Exercicio8();
            break;
        case 12:
            exerc.Exercicio9();
            break;
        case 13:
            exer.Exercicio10();
            break;
        default:
            Console.WriteLine("Selecione uma opção Válida");
            Console.ReadKey();
            continue;
    }
    Console.WriteLine("Deseja Realizar Outro Exercício? (Sim,Nao)(S,N)");
    resposta = Console.ReadLine().ToUpper();
} while (resposta.Equals("SIM") || resposta.Equals("S"));


