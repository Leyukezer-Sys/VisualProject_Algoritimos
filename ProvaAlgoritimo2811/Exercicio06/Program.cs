// Faça um algoritmo que calcule a média de produtos de uma
//compra, pedindo ao usuário a quantidade de produtos, o nome e
//o valor de cada produto. Ao fim apresenta a média dos do valor
//dos produtos, o produto mais caro e o produto mais baixo.

string nomeProd, confirmacao="";
double valor, maior=0, menor=0,soma=0,cont=0, media;
int quant;

Console.WriteLine("Exercicio 06");

do
{
    Console.Write("\nDigite o Nome do Produto: ");
    nomeProd = Console.ReadLine();
    Console.Write("\nDigite o Valor do Produto: R$");
    valor =  Convert.ToDouble(Console.ReadLine());
    Console.Write("\nDigite a Quantidade de Produto: ");
    quant = Convert.ToInt32(Console.ReadLine());

    cont++;
    soma += (valor * quant);
    if (cont == 1)
    {
        menor = maior = valor;
    }
    else
    {
        if (menor> valor)
        {
            menor = valor;
        }
        if (maior < valor)
        {
            maior = valor;
        }
    }
    Console.WriteLine("\nDeseja adicionar um Novo Produto? (Sim/não/s/n)");
    Console.Write("R: ");
    confirmacao = Console.ReadLine().ToUpper();

} while (confirmacao.Equals("SIM")|| confirmacao.Equals("S"));

media = soma / cont;
Console.WriteLine(@$"
Resultado Final:
- A média dos valores: R${media}
- O produto mais caro: R${maior}
- O Preço mais baixo: R${menor}");