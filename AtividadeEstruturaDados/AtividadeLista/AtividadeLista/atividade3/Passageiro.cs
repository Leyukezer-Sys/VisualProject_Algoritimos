using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeLista.atividade3
{
    public class Passageiro
    {
        public string? nome, cpf, cidadeDestino;
        public int? Poltrona;
        public double valorPassagem;

        public Passageiro? prox;

        public double somarValorPassagens(double total, double valor)
        {
            total += valor;

            return total;
        }
    }
}
