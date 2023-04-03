using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6_2
{
    public class Biblioteca
    {
        public string DiaDaSemana(int n)
        {
            string dia = "";
            if (n == 0)
            {
                dia = "Domingo      ";
            }
            else
            if (n == 1)
            {
                dia = "Segunda-Feira";
            }
            else
            if (n == 2)
            {
                dia = "Terça-Feira  ";
            }
            else
            if (n == 3)
            {
                dia = "Quarta-Feira ";
            }
            else
            if (n == 4)
            {
                dia = "Quinta-Feira ";
            }
            else
            if (n == 5)
            {
                dia = "Sexta-Feira  ";
            }
            else
            if (n == 6)
            {
                dia = "Sábado       ";
            }
            else
            {
                dia = "Indefinido";
            }
            return dia;
        }
    }

}
