using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploListas
{
    public class Aluno
    {
        //1º Criar classe
        //2º mudar para 'public class' o 'internal class'
        //3º Colocar os atributos
        public string? nome, cpf;
        public double[]? notas;
        public double media;
        //4º criar o ponteiro, mesmo nome da classe no tipo da variavel
        public Aluno prox;
    }
}
