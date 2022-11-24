// calcule, para cada valor de salário Fornecido, os descontos relativos ao
// imposto de renda,
// à contribuição ao INSS e
// à mensalidade do plano de saúde,
// o algoritimo deve mostrar:
// valor total da folha de pagamento da empresa
// o salario liquido de cada funcionário
// o valor total do imposto de renda que a empresa deve recolher

string nome, cond= "S", resposta="";
double salarioBruto, SalarioLiquido=0, pagamento=0, impostoIR=0, impostoIN=0, impostoTT=0;

Console.WriteLine("--- Cadastrar Salarios dos Funcionários ---");

do
{
    Console.WriteLine("\nQual o nome do Funcionario?");
    Console.Write("R: ");
    nome = Console.ReadLine();
    Console.WriteLine("Qual o Salario do Funcionario?");
    Console.Write("R: ");
    salarioBruto = Convert.ToDouble(Console.ReadLine());

    SalarioLiquido = salarioBruto;
    pagamento += salarioBruto;

    //IRPF
    if (salarioBruto > 1903.98 && salarioBruto < 2826.66)
    {
        impostoIR += salarioBruto * 0.075;
        SalarioLiquido -= salarioBruto * 0.075;

    }
    else if (salarioBruto > 2826.65 && salarioBruto < 3751.05)
    {
        impostoIR += salarioBruto * 0.15;
        SalarioLiquido -= salarioBruto * 0.15;
    }else if (salarioBruto > 3751.05 && salarioBruto < 4664.68)
    {
        impostoIR += salarioBruto * 0.225;
        SalarioLiquido -= salarioBruto * 0.225;
    }else if (salarioBruto > 4664.68)
    {
        impostoIR += salarioBruto * 0.275;
        SalarioLiquido -= salarioBruto * 0.275;
    }

    //INSS
    if (salarioBruto < 1556.94)
    {
        impostoIN += SalarioLiquido * 0.08;
        SalarioLiquido -= SalarioLiquido * 0.08;

    }
    else if (salarioBruto > 1556.94 && salarioBruto < 2594.93)
    {
        impostoIN += SalarioLiquido * 0.09;
        SalarioLiquido -= SalarioLiquido * 09;
    }
    else if (salarioBruto > 2594.92 && salarioBruto < 5189.83)
    {
        impostoIN += SalarioLiquido * 0.11;
        SalarioLiquido -= SalarioLiquido * 0.11;
    }

    impostoTT += impostoIR + impostoIN; 
    resposta += $"\n# Ficha do Funcionario #\n" +
                $"- Nome: {nome}\n" +
                $"- Salário Bruto: R${salarioBruto}\n" +
                $"- IRPF: R${impostoIR.ToString("F")}\n"+
                $"- INSS: R${impostoIN.ToString("F")}\n"+
                $"- Salário Líquido: R${SalarioLiquido}\n";

    Console.WriteLine("\n\nDeseja Cadastrar novo salario?(sim/nao/s/n/yes/no/y/n)");
    Console.Write("R:. ");
    cond = Console.ReadLine().ToUpper();

} while (cond.Equals("SIM") || cond.Equals("S") || cond.Equals("Y") || cond.Equals("YES"));

Console.WriteLine("\n--------- Folha de Pagamento ---------\n" +
                  $"# Valor total da Folha de Pagamento: R${pagamento}" +
                  resposta+
                  $"# Valor total dos ímpostos de Renda que a Empresa deve recolher: R${impostoTT}");