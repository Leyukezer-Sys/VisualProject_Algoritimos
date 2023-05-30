using System.Runtime.CompilerServices;
using System.Xml;
using static AtividadeLista.atividade1.Atividade1;
using static AtividadeLista.atividade2.Atividade2;
using static AtividadeLista.atividade3.Atividade3;

namespace AtividadeLista
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string conf = "";

            do
            {
                Console.WriteLine("Atividade Estrutura de Dados\n" +
                              "Escolha a Atividade:\n" +
                              "+ 1 - Atividade 1\n" +
                              "+ 2 - Atividade 2\n" +
                              "+ 3 - Atividade 3");
                Console.Write("R: ");
                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        ListaFuncionario();
                        break;
                    case 2:
                        ListaEleitor();
                        break;
                    case 3:
                        ListaPassageiros();
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }

                Console.WriteLine("Deseja realizar outra atividade?");
                conf = Console.ReadLine().ToUpper();
            } while (conf.Equals("SIM") || conf.Equals("S"));
        }
    }
}