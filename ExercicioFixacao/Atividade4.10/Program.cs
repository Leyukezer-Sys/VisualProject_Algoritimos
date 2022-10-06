// faça um algoritimo que leia o valor total de uma compra
// e calcule o valor do pagamento final de acordo com a opção escolhida,
// Se for pagamento parcelado, calcule tambem o valor da parcela.
//ao final, apresente o valor total e o valor das parcelas;

//dados
double preco = 0, pagamentofinal = 0;
int op = 0;
//entrada
Console.WriteLine("--- Formas de Pagamentos ---");
Console.Write("Valor do produto: R$");
preco = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Escolha sua forma de pagamento:\n" +
                  "# 101 - Pagamento à vista!\n" +
                  "# 202 - pagamento com 3 parcelas (aprox R$"+(preco/3)+")\n" +
                  "# 203 - pagamento com 5 parcelas (aprox R$"+(preco/5)+ " + 2% de Juros)\n" +
                  "# 204 - pagamento com 10 parcelas (aprox R$"+(preco/10)+ " + 8% de Juros)\n");
Console.Write("Sua escolha: ");
op = Convert.ToInt32(Console.ReadLine());

switch (op)
{
    case 101:
        pagamentofinal = preco - (preco * 0.05);
        Console.WriteLine("\n--- Cupom de Pagamento ---\n" +
                          "$ valor do produto: R$"+preco+"\n" +
                          "$ parcelas: 1xR$"+pagamentofinal+"\n" +
                          "--- Valor total: R$"+pagamentofinal+" ---");
        break;
    case 202:
        pagamentofinal = preco;
        Console.WriteLine("\n--- Cupom de Pagamento ---\n" +
                          "$ valor do produto: R$" + preco + "\n" +
                          "$ parcelas: 3xR$" + (pagamentofinal/3) + "\n" +
                          "--- Valor total: R$" + pagamentofinal + " ---");
        break;
    case 203:
        pagamentofinal = preco * (1+0.02*5);
        Console.WriteLine("\n--- Cupom de Pagamento ---\n" +
                          "$ valor do produto: R$" + preco + "\n" +
                          "$ parcelas: 5xR$" + (pagamentofinal / 5) + "\n" +
                          "--- Valor total: R$" + pagamentofinal + " ---");
        break;
    case 204:
        pagamentofinal = preco * (1+0.08*10);
        Console.WriteLine("\n--- Cupom de Pagamento ---\n" +
                          "$ valor do produto: R$" + preco + "\n" +
                          "$ parcelas: 10xR$" + (pagamentofinal / 10) + "\n" +
                          "--- Valor total: R$" + pagamentofinal + " ---");
        break;
    default:
        Console.WriteLine("Sua escolha é invalida!");
        break;
}

Console.ReadKey();