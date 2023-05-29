using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeLista.atividade2
{

    internal class Eleitor
    {
        public string? nome, cpf, titulo, cidade, seção, carneVotação;
        public Eleitor? prox;
        public string votar(int[] votoGov, int[] votoDep)
        {
            string resp = "";
            int voto = 0;
            Console.WriteLine("--- Urna Votação para Governo ---\n" +
                              "Escolha:\n" +
                              "1 - LULA INÁCIO ALGUMA COISA\n" +
                              "2 - BOLSONARO ALGUMA COISA");
            Console.Write("R:");
            voto = int.Parse(Console.ReadLine());
            if (voto == 1)
            {
                votoGov[0] += 1;
                resp += "Governo: LULA ¨L¨ |";
            }
            if (voto == 2)
            {
                votoGov[1] += 1;
                resp += "Governo: BOLSONARO $_$ |";
            }
            Console.WriteLine("--- Urna Votação para Deputado Estadual ---\n" +
                              "Escolha:\n" +
                              "1 - Laerte Gomes (PSD)\n" +
                              "2 - Ieda Chaves (União Brasil)");
            Console.Write("R:");
            voto = int.Parse(Console.ReadLine());
            if (voto == 1)
            {
                votoDep[0] += 1;
                resp += " Dep.E: Laerte Gomes (PSD)";
            }
            if (voto == 2)
            {
                votoDep[1] += 1;
                resp += " Dep.E: Ieda Chaves (União Brasil)";
            }

            return $"Seu voto foi para {resp}";
        }
    }
}
