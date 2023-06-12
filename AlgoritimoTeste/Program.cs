/*
 Orientações:
1) A avaliação deve ser feita no computador e enviado pelo AVA.
2) A interpretação das questões faz parte da avaliação.
3) A avaliação vale 50 (cinquenta) pontos, ou seja 50 % do valor da nota do
bimestre.
1) Seu José, tem uma fazenda com criação de gado. Crie uma
Lista contendo o cadastro do gado da sua propriedade: código,
raça, cor, descrição, sexo, peso, idade. (10)
2) Faça o encadeamento da lista simplesmente encadeada. (10)
3) Faça uma função que calcule a quantos animais são de cada
sexo. (10)
4) Faça uma função que calcule o valor de cada animal baseado
no valor da arroba (considere o peso do gado vivo, R$ 220,00
por cada 30kg). (05)
5) Mostre todos elementos da lista. (05)
6) Faça duas consultas, onde o usuário pode consultar por raça ou
idade. (05)
7) Faça um menu, onde o usuário possa escolher quais opções ele
vai usar: adicionar na lista, consultar por raça ou idade, lista
todos elementos da lista com a quantidade de cadastros na
lista. (05)
 */

using System;
using static AlgoritimoTeste.Lista;

string cond = "S";
int op = 0, rese = 0;

do
{
    Console.WriteLine("==== Fazenda Feliz ====\n" +
        "MENU\n" +
        "Escolha sua opção:\n" +
        "1 - Adicionar novo animal do Gado\n" +
        "2 - Listar os Animais por Sexo\n" +
        "3 - Listar todos os Animais Cadastrados\n" +
        "4 - Consultar Animal\n" +
        "0 - Sair");
    if (rese == 1)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(" -- Insira apenas número --");
        Console.ResetColor();
        Console.ReadKey();
        Console.Write("\r");
        Console.Write(new string(' ', Console.BufferWidth - 1));
        Console.Write("\r");
        Console.Write("R: ");
        try
        {
            op = int.Parse(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.Clear();
            rese = 1;
            continue;
        }
    }
    else if (rese == 2)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(" -- Escolha uma opção Válida --\b");
        Console.ResetColor();
        Console.ReadKey();
        Console.Write("\r");
        Console.Write(new string(' ', Console.BufferWidth - 1));
        Console.Write("\r");
        Console.Write("R: ");
        try
        {
            op = int.Parse(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.Clear();
            rese = 1;
            continue;
        }
    }
    else
    {
        Console.Write("R: ");
        try
        {
            op = int.Parse(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.Clear();
            rese = 1;
            continue;
        }
    }

    switch (op)
    {
        default:

            Console.Clear();
            rese = 2;
            continue;
        case 0:
            cond = "";
            continue;
        case 1:

            NovoAnimal();

            break;
        case 2:
            Console.WriteLine("Escolha uma opção:\n" +
                "1 - Listar os Animais Feminino\n" +
                "2 - Listar os Animais Masculino\n" +
                "3 - Listar os Animais Feminino e Masculino");
            Console.Write("R: ");
            int op3 = int.Parse(Console.ReadLine());
            if (op3 == 1)
            {
                ListarAnimaisSexo("F");
            }else
            if (op3 == 2)
            {
                ListarAnimaisSexo("M");
            }
            else
            {
                ListarAnimaisSexo();
            }

            break;
        case 3:

            ListarAnimais();

            break;
        case 4:

            Console.WriteLine("Escolha uma opção:\n" +
                "1 - Consultar por idade\n" +
                "2 - consultar por raça\n" +
                "3 - Consultar por idade e raça");
            Console.Write("R: ");
            int op2 = int.Parse(Console.ReadLine());
            if (op2 == 1)
            {
                Console.Write("Qual a idade do Animal(s): ");
                int? pesq = int.Parse(Console.ReadLine());
                ListarAnimais(pesq);
            }
            if (op2 == 2)
            {
                Console.Write("Qual a raça do Animal(s): ");
                string pesq = Console.ReadLine();
                ListarAnimais(pesq);
            }
            if (op2 == 3)
            {
                Console.Write("Qual a idade do Animal(s): ");
                int? pesq = int.Parse(Console.ReadLine());
                Console.Write("Qual a raça do Animal(s): ");
                string pesq2 = Console.ReadLine();
                ListarAnimais(pesq, pesq2);
            }

            break;
    }

    Console.WriteLine("\nDeseja Retornar ao Menu? (s/n)");
    cond = Console.ReadLine().ToUpper();

} while (cond == "S" || cond == "SIM");