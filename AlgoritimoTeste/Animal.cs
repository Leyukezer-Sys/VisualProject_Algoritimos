using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimoTeste
{
    public class Animal
    {
        public int codigo;
        public string? raca, cor, descricao, sexo;
        public int? idade;
        public double? peso;
        public double preco;

        public Animal? prox;

        public double PrecoAnimal(double? pes)
        {
            double preco = 0.00;
            double peso = (double)pes;
            int cont = 0, x = 0;

            for (int i = 0; i < peso; i++)
            {
                cont++;
                if (cont == 30)
                {
                    x++;
                    cont = 0;
                }
            }

            peso = peso - (x * 30);

            preco = (x * 220.00) + (peso * 220.00);

            return preco;
        }
    }
}