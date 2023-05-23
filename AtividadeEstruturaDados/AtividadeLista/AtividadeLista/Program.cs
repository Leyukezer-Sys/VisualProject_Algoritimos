using System.Runtime.CompilerServices;
using System.Xml;
using static AtividadeLista.atividade1.Atividade1;

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
                              "+ 1 - Ativiadade 1");
                Console.Write("R: ");
                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        ListaFuncionario();
                        break;
                }

                Console.WriteLine("Deseja realizar outra atividade?");
                conf = Console.ReadLine().ToUpper();
            } while (conf.Equals("SIM") || conf.Equals("S"));
        }
    }
}