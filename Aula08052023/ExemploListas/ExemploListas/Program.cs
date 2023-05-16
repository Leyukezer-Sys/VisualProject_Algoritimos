using ExemploListas;
using System.Diagnostics;

//5º colocar namespace
//6º criar os elementos da lista
Aluno novo = null, inicio = null, lista = null, aux = null;
int op = 0;
string cond = "";
//7º inserir os dados dos elementos
do
{

    Console.WriteLine("** Escolha Sua Opção:\n" +
        "   1 - Para Cadastrar\n" +
        "   2 - Para Listar Todos\n" +
        "   3 - Para Consultar um Aluno\n" +
        "   0 - Sair");
    Console.Write("R: ");
    op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 1:
            //8º Novo elemento
            novo = new Aluno();

            Console.Write("\nDigite o nome do aluno: ");
            novo.nome = Console.ReadLine();
            Console.Write("Digite o cpf do aluno: ");
            novo.cpf = Console.ReadLine();
            Console.Write("Digite o nota do aluno: ");
            novo.notas = new double[1];
            novo.notas[0] = double.Parse(Console.ReadLine());


            //9 encadeamento de lista
            //  9.1 colocar no inicio da lista
            if (inicio == null)
            {
                inicio = novo;
                inicio.prox = null;
            }
            //  9.2 colocar no 2º nó
            else
            {
                if (inicio.prox == null)
                {
                    lista = novo;
                    inicio.prox = lista;
                    lista.prox = null;
                }

                lista.prox = novo;
                lista = novo;
                lista.prox = null;
            }
            break;
        case 2:
            //10º consultar lista
            aux = inicio;

            //11ºpercorrer a lista
            while (aux != null)
            {
                Console.WriteLine($"Notas do Aluno(a) {aux.nome}|{aux.cpf}: {aux.notas[0]}");
                aux = aux.prox;
            }
            break;
        case 3:
            Console.WriteLine("** Escolha:\n" +
        "   1 - Para Pesquisar Nome\n" +
        "   2 - Para Pesquisar CPF");
            Console.Write("R: ");
            int pe = int.Parse(Console.ReadLine());
            if (pe == 1)
            {
                Console.WriteLine("\nPesquise o nome do aluno(a): ");
                string pesq = Console.ReadLine().ToUpper();

                aux = inicio;

                while (aux != null)
                {
                    if (aux.nome.ToUpper() == pesq)
                    {
                        Console.WriteLine($"-- Notas do Aluno(a) {aux.nome}|{aux.cpf}: {aux.notas[0]} --");
                        break;
                    }
                    aux = aux.prox;
                }
            }
            if (pe == 2)
            {
                Console.WriteLine("\nPesquise o CPF do aluno(a): ");
                string pesq = Console.ReadLine().ToUpper();

                aux = inicio;

                while (aux != null)
                {
                    if (aux.cpf == pesq)
                    {
                        Console.WriteLine($"\nNotas do Aluno(a) {aux.nome}|{aux.cpf}: {aux.notas[0]}");
                        break;
                    }
                    aux = aux.prox;
                }
            }

            break;
    }
    if (op == 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("\n\nDeseja voltar pro menu? (s/n)(sim/nao)");
        cond = Console.ReadLine().ToUpper();
        if (cond.Equals("S") || cond.Equals("SIM"))
        {
            Console.Clear();
        }
    }
    
} while (cond.Equals("S")|| cond.Equals("SIM"));