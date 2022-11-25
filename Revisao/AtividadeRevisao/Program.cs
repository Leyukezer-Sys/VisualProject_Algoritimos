string condicaoAtv="";
do {
    {
        // Crie um programa que peça 10 números inteiros e apresente: a
        //média, a soma e o menor. (10)
        Console.WriteLine(@"========= Atividade 01 Revisao da Prova =========
- Um Programa que apresenta a soma, a média e o menor numero de 10 numeros inteiros...");
        int valor, soma=0, menor=0;
        double media;
        for (int i = 1; i < 11; i++)
        {
            Console.Write(@$"
* Insira o {i}º Valor: ");
            valor = Convert.ToInt32(Console.ReadLine());
            soma += valor;
            if (i == 1)
            {
                menor = valor;
            }
            else if (menor > valor)
            {
                menor = valor;
            }
        }
        media = (double)soma / 10;
        Console.WriteLine($@"
----------- Resultado -----------
soma: {soma}
média: {media}
menor valor: {menor}
---------------------------------");

        Console.ReadKey();
        Console.Clear();
    }

    {
        //Some os números de 1 a 100 a imprima o valor
        Console.WriteLine(@"========= Atividade 02 Revisao da Prova =========
- Um Programa que apresenta a soma do número 1 ao 100...");
        int soma=0;
        for (int i = 0; i <= 100; i++)
        {
            soma += i;
        }
        Console.WriteLine($@"
----------- Resultado -----------
soma: {soma}
---------------------------------");
        Console.ReadKey();
        Console.Clear();
    }

    {
        //Faça um algoritmo que leia um número inteiro e mostre uma
        //mensagem indicando se este número é par ou ímpar, e se é
        //positivo ou negativo.
        Console.WriteLine(@"========= Atividade 03 Revisao da Prova =========
- Um Programa que Leia um Numero Inteiro e mostre se é par ou ímpar e se é positivo ou negativo...");
        int valor = 0;
        string Resultado = "";

        Console.Write(@$"
* Insira o Valor a Verificar: ");
        valor = Convert.ToInt32(Console.ReadLine());
        if (valor == 0)
        {
            Resultado = "O Número é Neutro";
        }
        else if (valor %2 == 0)
        {
            Resultado = "O número é Par ";
            if (valor > 0)
            {
                Resultado += "e Positivo";
            }
            else
            {
                Resultado += "e Negativo";
            }
        }
        else
        {
            Resultado = "O número é Ímpar ";
            if (valor > 0)
            {
                Resultado += "e Positivo";
            }
            else
            {
                Resultado += "e Negativo";
            }
        }

        Console.WriteLine($@"
----------- Resultado -----------
{Resultado}
---------------------------------");
        Console.ReadKey();
        Console.Clear();

    }

    {
        //Faço um algoritmo que leia números até o usuário digitar 0, após
        //finalizar, mostre quantos números lidos, a soma e quantos são pares
        Console.WriteLine(@"========= Atividade 04 Revisao da Prova =========
- Um Programa que apresenta quantidade de numeros lidos e a quantidade de numeros lidos Pares...");
        int contNumeros = 0, contPar = 0;
        double valor, soma = 0;
        do {
            Console.Write(@$"
* Insira um Valor: ");
            valor = Convert.ToDouble(Console.ReadLine());

            if (valor != 0)
            {
                soma += valor;
                contNumeros++;
                if (valor%2 == 0)
                {
                    contPar++;
                }
            }
            else
            {
                Console.WriteLine("===");
            }
        } while (valor != 0);
        Console.WriteLine($@"
----------- Resultado -----------
Quantidade de Numeros Lidos: {contNumeros}
Quantidade de Numeros Pares Lidos: {contPar}
Soma de todos os Numeros: {soma}
---------------------------------");
        Console.ReadKey();
        Console.Clear();
    }

    {
        //Faça um algoritmo que imprima a tabuada de 1 a 10
        Console.WriteLine(@"========= Atividade 05 Revisao da Prova =========
- Um Programa que apresenta as tabuadas de 1 a 10...");
        String Resposta = "";
        int valor;
        Console.Write(@$"
* Insira um Valor inteiro de quantos valores deseja na tabuada(ex: 10 -> 1x0 até 1x10): ");
        valor = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < 11; i++)
        {
            for (int j = 0; j <= valor; j++)
            {
                Resposta += $@"| {i} x {j} = {(i*j)}|
";
            }
            Resposta += "-------------------\n";
        }
        Console.WriteLine($@"
----------- Resultado -----------
{Resposta}
---------------------------------");
        Console.ReadKey();
        Console.Clear();
    }

    {
        //Faça um algoritmo que calcule a média de salários de uma
        //empresa, pedindo ao usuário a quantidade de funcionários, o
        //nome e o salário de cada funcionário. Ao fim apresenta a média
        //dos salários, o salário mais alto e o salário mais baixo.
        Console.WriteLine(@"========= Atividade 06 Revisao da Prova =========
- Um Programa que apresenta a média dos salários dos funcionarios inseridos pelo usuario
além do salário mais alto e o salário mais baixo...");

        String nomeFunc;
        int quantFunc;
        double salario, maior=0,menor=0, soma=0, media=0;
        Console.Write("* Informe Quantos funcionários sua empresa possui: ");
        quantFunc = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("# Registro de Funcionarios");
        for (int i = 1; i <= quantFunc; i++)
        {
            Console.Write($"\n- Nome do {i}º Funcionario: ");
            nomeFunc = Console.ReadLine();
            Console.Write($"Salario do {i}º Funcionario: R$");
            salario = Convert.ToDouble(Console.ReadLine());

            soma += salario;

            if (i == 1)
            {
                menor = maior = salario;
            }
            else
            {
                if (menor > salario)
                {
                    menor = salario;
                }
                if (salario > maior)
                {
                    maior = salario;
                }
            }
        }
        media = soma / quantFunc;

        Console.WriteLine($@"
----------- Resultado -----------
média Salarial: R${media}
menor Salário: R${menor}
maior Salario: R${maior}
---------------------------------");
        Console.ReadKey();
        Console.Clear();
    }

    {
        //Escreva um algoritmo que você fez durante o semestre
        // Melhore o algoritimo do exercício anterior verificando se o
        //número inserido pelo usuario é zero, par ou impar

        //dados
        double nu;

        //entrada
        Console.WriteLine(@"Atividade da Apostila 4.7:
---- Verificar número (par/impar) ----");
        Console.Write("Digite um número para verificação: ");
        nu = Convert.ToDouble(Console.ReadLine());

        //processamento
        if (nu == 0)
        {
            Console.WriteLine("\n---- Resposta ----\n" +
                              "O número " + nu + " é\n" +
                              "um Número Neutro");
        }
        else if (nu % 2 == 0)
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
    }

    Console.ReadKey();
    Console.Clear();

    Console.WriteLine(@"Deseja Repetir A Prova Revisao?(sim/nao/s/n/yes/no/y/n)
R:. ");

    condicaoAtv = Console.ReadLine().ToUpper();
} while (condicaoAtv.Equals("SIM") || condicaoAtv.Equals("S") || condicaoAtv.Equals("Y") || condicaoAtv.Equals("YES"));