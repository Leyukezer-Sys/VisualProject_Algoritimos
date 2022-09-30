//10% de desconto
//faça um algoritimo que, a partir do valor fornecido,
// calcule e exiba o preço atual e o preço com desconto

//dados
double valor_produto, vdesconto_produto;

//entrada
Console.WriteLine("---- Desconto no valor do Produto ----");
Console.Write("Digite o preço do produto: R$");
valor_produto = Convert.ToDouble(Console.ReadLine());

//processamento
vdesconto_produto = valor_produto - (valor_produto * 0.1);

//saida
Console.WriteLine("\n\n---- Desconto do Produto ----\n" +
                  "# Preço Inicial: R$" + valor_produto+ "\n" +
                  "# Preço com Desconto: R$" + vdesconto_produto);

Console.ReadKey();