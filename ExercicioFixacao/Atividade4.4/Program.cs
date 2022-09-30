//calcule o salario reajustado de um funcionario, exibindo como resultado
//seu nome, o valor do salário atual e o valor do salário reajustado

//dados
string nome;
double salario_atual, salario_final;

//entrada
Console.WriteLine("---- Reajuste de Salário ----");
Console.Write("Digite o nome do Funcionario: ");
nome = Console.ReadLine();
Console.Write("Digite o Salário Atual do Funcionario: R$");
salario_atual = Convert.ToDouble(Console.ReadLine());

//processamento

salario_final = salario_atual * 1.0875;

//saida
Console.WriteLine("\n\n------ Loreite do Funcionario ------\n" +
                  "#Nome do Funcionario: "+nome+"\n" +
                  "#Salario mensal: R$"+salario_atual+"\n" +
                  "## Salario Reajustado: R$"+salario_final);

Console.ReadKey();