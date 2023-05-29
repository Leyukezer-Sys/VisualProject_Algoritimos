using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeLista.atividade2
{
    internal class Atividade2
    {
        public static void ListaEleitor()
        {
            Eleitor aux = null, inicio = null, novo = null, lista = null;
            string cond = "";
            int contVotos = 0;
            int[] votoGov = new int[2];
            int[] votoDep = new int[2];
            do
            {
                Console.WriteLine("======= Gestão Eleitoral =======\n" +
                "Escolha sua opção:\n" +
                "+ 1 - Cadastrar Eleitor\n" +
                "+ 2 - Listar Eleitores Cadastrados\n" +
                "+ 3 - Buscar Eleitor\n" +
                "+ 4 - Mostrar Resultado da Eleição\n" +
                "+ 0 - Sair");
                Console.Write("R: ");

                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        novo = new Eleitor();
                        Console.WriteLine("Digite o Nome do Eleitor");
                        novo.nome = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do Eleitor");
                        novo.cpf = Console.ReadLine();
                        Console.WriteLine("Digite o Titulo do Eleitor");
                        novo.titulo = Console.ReadLine();
                        Console.WriteLine("Digite a Cidade do Eleitor");
                        novo.cidade = Console.ReadLine();
                        Console.WriteLine("Digite a Seção do Eleitor");
                        novo.seção = Console.ReadLine();
                        novo.carneVotação = novo.votar(votoGov,votoDep);
                        contVotos++;
                        Console.WriteLine($"!=== {novo.carneVotação} ===!");

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
                        break;
                    case 2:
                        aux = inicio;
                        while (aux != null)
                        {
                            Console.WriteLine($"\n\n===== Ficha do Eleitor {aux.nome} =====\n" +
                                $"*CPF: {aux.cpf}\n" +
                                $"*Titulo: {aux.titulo}\n" +
                                $"*seção: {aux.seção}\n" +
                                $"*Cidade: {aux.cidade}\n" +
                                $"--- {aux.carneVotação} ---");
                            aux = aux.prox;
                        }
                        break;
                    case 3:
                        string pesq = "";
                        Console.WriteLine("-- Pesquisar Eleitor por:\n" +
                            "1 - CPF do Eleitor\n" +
                            "2 - Titulo do Eleitor\n" +
                            "3 - CPF e Titulo do Eleitor");
                        Console.Write("R: ");
                        int ope = int.Parse(Console.ReadLine());
                        if (ope == 1)
                        {
                            Console.Write("Digite o CPF do Eleitor: ");
                            pesq = Console.ReadLine();
                            aux = inicio;
                            while (aux != null)
                            {
                                if (pesq.ToLower() == aux.cpf.ToLower())
                                {
                                    Console.WriteLine($"===== Ficha do Eleitor {aux.nome} =====\n" +
                                        $"*CPF: {aux.cpf}\n" +
                                        $"*Titulo: {aux.titulo}\n" +
                                        $"*seção: {aux.seção}\n" +
                                        $"*Cidade: {aux.cidade}\n" +
                                        $"--- {aux.carneVotação} ---");
                                }
                                aux = aux.prox;
                            }
                        }
                        if (ope == 2)
                        {
                            Console.Write("Digite o Titulo do Eleitor: ");
                            pesq = Console.ReadLine();
                            aux = inicio;
                            while (aux != null)
                            {
                                if (pesq.ToLower() == aux.titulo.ToLower())
                                {
                                    Console.WriteLine($"===== Ficha do Eleitor {aux.nome} =====\n" +
                                        $"*CPF: {aux.cpf}\n" +
                                        $"*Titulo: {aux.titulo}\n" +
                                        $"*seção: {aux.seção}\n" +
                                        $"*Cidade: {aux.cidade}\n" +
                                        $"--- {aux.carneVotação} ---");
                                }
                                aux = aux.prox;
                            }
                        }
                        if (ope == 3)
                        {
                            Console.Write("Digite o CPF do Eleitor: ");
                            pesq = Console.ReadLine();
                            Console.Write("Digite o Titulo do Eleitor: ");
                            string pesq2 = Console.ReadLine();

                            aux = inicio;
                            while (aux != null)
                            {
                                if (pesq.ToLower() == aux.cpf.ToLower() && pesq2.ToLower() == aux.titulo.ToLower())
                                {
                                    Console.WriteLine($"===== Ficha do Eleitor {aux.nome} =====\n" +
                                        $"*CPF: {aux.cpf}\n" +
                                        $"*Titulo: {aux.titulo}\n" +
                                        $"*seção: {aux.seção}\n" +
                                        $"*Cidade: {aux.cidade}\n" +
                                        $"--- {aux.carneVotação} ---");
                                }
                                aux = aux.prox;
                            }
                        }
                        break;
                    case 4:
                        
                            Console.WriteLine($"===== Resultado Eleição =====\n" +
                                     $"Total votos: {contVotos}\n" +
                                     $"---- Governo:\n" +
                                     $"LULA INÁCIO ALGUMA COISA: {votoGov[0].ToString()}\n" +
                                     $"BOLSONARO ALGUMA COISA: {votoGov[1].ToString()}\n" +
                                     $"---- Deputado Estadual:\n" +
                                     $"Laerte Gomes (PSD): {votoDep[0].ToString()}\n" +
                                     $"Ieda Chaves (União Brasil): {votoDep[1].ToString()}\n" +
                                     $"");
                       
                        break;

                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção Invalida! -- Press Key to return --");
                        Console.ReadKey();
                        Console.Clear();
                        ListaEleitor();
                        break;
                }
                Console.WriteLine("\nDeseja voltar ao menu inicial da atividade?");
                cond = Console.ReadLine().ToUpper();
            } while (cond == "S" || cond == "SIM") ;            
        }
    }
}
