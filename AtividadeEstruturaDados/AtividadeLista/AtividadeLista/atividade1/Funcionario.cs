using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AtividadeLista.atividade1
{
    public class Funcionario
    {
        public string? nome, cpf, matricula, profissao;
        public double? salario, salarioFinal;
        public double[]? vendaFunc;

        public Funcionario? prox;

        public double? Comissao(double[] valorVenda, double? salario)
        {
            double comissao = 0.0;
            double? salarioAtual = 0.0;

            for (int i = 0; i < valorVenda.Length; i++)
            {
                comissao += valorVenda[i] * 0.12;

            }

            salarioAtual = salario + comissao;

            return salarioAtual;
        }
    }
}
