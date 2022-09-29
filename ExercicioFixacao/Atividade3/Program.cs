// calcule o valor da venda de um produto,
// exibindo uma saida contendo o código do produto,
// o nome, a quantidade comprada, o valor unitário,
// o valor total

//dados
int cod_produto = 0, quant_comprada=0;
string nome_produto = "Indeferido";
double valor_unitario=0, valor_total=0;

//Entrada
Console.WriteLine("--- Compra de Produto ---");
Console.Write("Codigo do Produto (ex 0303): ");
cod_produto = Convert.ToInt32(Console.ReadLine());
Console.Write("Nome do Produto: ");
nome_produto = Console.ReadLine();
Console.Write("Quantidade de Produto comprado: ");
quant_comprada = Convert.ToInt32(Console.ReadLine());
Console.Write("Valor do Produto: ");
valor_unitario = Convert.ToDouble(Console.ReadLine());

//processamento
valor_total = quant_comprada * valor_unitario;

//saida
Console.WriteLine("\n----- Cupom fiscal -----\n" +
                  "# Código Produto: "+cod_produto+"\n" +
                  "# Nome produto: "+nome_produto+"\n" +
                  "# Quantidade Comprada: "+quant_comprada+"\n" +
                  "# Valor unitário: R$"+ valor_unitario +"\n" +
                  "--- Valor Total: R$"+valor_total+" ---");


Console.ReadKey();