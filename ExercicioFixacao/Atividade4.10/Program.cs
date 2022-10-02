// faça um algoritimo que leia o valor total de uma compra
// e calcule o valor do pagamento final de acordo com a opção escolhida,
// Se for pagamento parcelado, calcule tambem o valor da parcela.
//ao final, apresente o valor total e o valor das parcelas;

//dados
double preco = 0, pagamentofinal = 0;

//entrada
Console.WriteLine("--- Formas de Pagamentos ---");
Console.Write("Valor do produto: R$");
preco = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Escolha sua forma de pagamento:" +
                  "# 101 - Pagamento à vista!" +
                  "# 202 - pagamento com 3 parcelas (aprox R$"+(preco/3)+")" +
                  "# 203 - pagamento com 5 parcelas (aprox R$"+(preco/5)+ " + 2% de Juros)" +
                  "# 204 - pagamento com 10 parcelas (aprox R$"+(preco/10)+ " + 8% de Juros)");