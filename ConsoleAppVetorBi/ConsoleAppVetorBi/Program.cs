int qtClientes = 0, qtProdutos = 0;
string[] nomeClientes;
int[] qtProdutos_Cliente;
string[][] nomeProduto;
double[][] valorProduto;

Console.Write("Quantidade de clientes: ");
qtClientes = int.Parse(Console.ReadLine());

nomeClientes = new string[qtClientes];
qtProdutos_Cliente = new int[qtClientes];
nomeProduto = new string[qtClientes][];
valorProduto = new double[qtClientes][];
Console.WriteLine("\n");

for (int i = 0; i < nomeClientes.Length; i++)
{
    Console.Write("$ Digite o Nome do Cliente: ");
    nomeClientes[i] = Console.ReadLine();
    Console.Write($"$ Quantidade de Produtos o(a) {nomeClientes[i]} comprará: ");
    qtProdutos = int.Parse(Console.ReadLine());

    qtProdutos_Cliente[i] = qtProdutos;
    nomeProduto[i] = new string[qtProdutos];
    valorProduto[i] = new double[qtProdutos];
    
    for (int j = 0; j < qtProdutos_Cliente[i]; j++)
    {
        Console.Write("\nNome do Produto: ");
        nomeProduto[i][j] = Console.ReadLine();
        Console.Write($"\nValor do(a) {nomeProduto[i][j]}: ");
        valorProduto[i][j] = double.Parse(Console.ReadLine());
    }
    Console.WriteLine("\n\n");
}

for (int i = 0; i < nomeClientes.Length; i++)
{
    double total = 0.0;
    Console.WriteLine("\n============= Recibo Compras =============\n" +
                     $"Cliente: {nomeClientes[i]}\n" +
                     $"-------- Carrinho de Compras --------");
    for (int j = 0; j < qtProdutos_Cliente[i]; j++)
    {
        total += valorProduto[i][j];
        Console.WriteLine($"{nomeProduto[i][j]}|{valorProduto[i][j].ToString("C")}");
    }
    Console.WriteLine("------------------------------------\n" +
                     $"Total da Compra: {total.ToString("C")}");
    Console.ReadKey();
}
