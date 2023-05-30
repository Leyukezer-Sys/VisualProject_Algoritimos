using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeLista.atividade3
{
    internal class Atividade3
    {
        public static void ListaPassageiros()
        {
            Passageiro aux = null, inicio = null, novo = null, lista = null;
            int contPassagens = 0;
            double totalPassagens = 0.0;
            int[] poltronas = new int[0];
            string cond = "";
            do
            {
                Console.WriteLine("===== Reserva de passageiros =====\n" +
                "Escolha sua Opção:\n" +
                "1 - Novo Passageiro\n" +
                "2 - Listar os Passageiros\n" +
                "3 - Gerar os Assentos  (Exibir poltronas em ordem crescente)\n" +
                "4 - Exibir Valor total das Passagens");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        do
                        {
                            novo = new Passageiro();
                            contPassagens++;

                            Console.Write("*Digite o nome do Passageiro: ");
                            novo.nome = Console.ReadLine();
                            Console.Write("*Digite o cpf do Passageiro: ");
                            novo.cpf = Console.ReadLine();
                            Console.Write("*Digite a Cidade de Destino do Passageiro: ");
                            novo.cidadeDestino = Console.ReadLine();
                            Console.Write("*Digite a poltrona do Passageiro: ");
                            novo.Poltrona = int.Parse(Console.ReadLine());
                            Console.Write("*Digite o valor da passagem do Passageiro: ");
                            novo.valorPassagem = double.Parse(Console.ReadLine());
                            novo.somarValorPassagens(totalPassagens, novo.valorPassagem);

                            if (inicio == null)
                            {
                                inicio = novo;
                                inicio.prox = null;
                            }
                            else
                            {
                                if (inicio.prox == null)
                                {
                                    lista = novo;
                                    lista.prox = null;
                                    inicio.prox = lista;
                                }
                                lista.prox = novo;
                                lista = novo;
                                lista.prox = null;
                            }
                            Console.WriteLine("\nDeseja Cadastrar Outro?");
                            cond = Console.ReadLine().ToUpper();
                        } while (cond == "S" || cond == "SIM");

                        break;
                    case 2:
                        aux = inicio;

                        while (aux != null)
                        {
                            Console.WriteLine("--- Ficha Passageiro ---\n" +
                                $"Nome: {aux.nome.ToUpper()}\n" +
                                $"CPF: {aux.cpf.ToUpper()}\n" +
                                $"Cidade Destino: {aux.cidadeDestino.ToLower()}\n" +
                                $"Valor Passagem: {aux.valorPassagem.ToString("C")}\n" +
                                $"Poltrona: {aux.Poltrona}\n" +
                                $"---======---");


                            aux = aux.prox;
                        }
                        break;
                    case 3:
                        gerarAssento(contPassagens, inicio);
                        for (int i = 0; i < poltronas.Length; i++)
                        {
                            buscarPoltrona(poltronas[i]);
                        }
                        break;
                    case 4:
                        Console.WriteLine("\nValor Total Obtido com as vendas de passagns\n" +
                            $"--- {totalPassagens.ToString("C")} ---");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!!");
                        break;
                }


                void gerarAssento(int quant, Passageiro listaP)
                {
                    int contador = 0;
                    poltronas = new int[quant];
                    while (listaP != null)
                    {
                        poltronas[contador] = (int)listaP.Poltrona;

                        contador++;
                        listaP = listaP.prox;
                    }
                    Array.Sort(poltronas);
                }

                void buscarPoltrona(int poltrona)
                {
                    aux = inicio;

                    while (aux != null)
                    {
                        if (poltrona == aux.Poltrona)
                        {
                            Console.WriteLine($"--- {poltrona}ª Poltrona ---\n" +
                                $"Nome: {aux.nome.ToUpper()}\n" +
                                $"CPF: {aux.cpf.ToUpper()}\n" +
                                $"Cidade Destino: {aux.cidadeDestino.ToLower()}\n" +
                                $"------");
                        }
                        aux = aux.prox;
                    }
                }

                Console.WriteLine("\nDeseja Retornar ao Menu?");
                cond = Console.ReadLine().ToUpper();
                if (cond == "S" || cond == "SIM")
                {
                    Console.Clear();
                }
            } while (cond == "S" || cond == "SIM");
            
        }
    }
}
