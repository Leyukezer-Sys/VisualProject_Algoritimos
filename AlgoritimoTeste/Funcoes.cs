using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimoTeste
{
    public class Lista
    {
        static Animal aux = null, inicio = null, lista = null, novo = null;
        static int contSexMasc = 0, contSexFem = 0, contAnim = 0;
        static int[] feminino, masculino;
        public static void NovoAnimal()
        {
            string cond = "S";
            do
            {
                novo = new Animal();
                contAnim++;

                novo.codigo = contAnim;
                Console.WriteLine("=---------- Novo Animal ----------=");
                Console.Write("Digite qual a raça do Animal: ");
                novo.raca = Console.ReadLine();
                Console.Write("Digite qual a cor do Animal: ");
                novo.cor = Console.ReadLine();
                Console.Write("Digite uma descrição do Animal: ");
                novo.descricao = Console.ReadLine();
                Console.Write("Digite qual o sexo do Animal (F,M)(FEMEA, MACHO): ");
                novo.sexo = EscolhaSexo(Console.ReadLine().ToUpper());
                Console.Write("Digite qual a idade do Animal: ");
                novo.idade = int.Parse(Console.ReadLine());
                Console.Write("Digite qual o Peso do Animal (Kg): ");
                novo.peso = double.Parse(Console.ReadLine());

                novo.preco = novo.PrecoAnimal(novo.peso);

                EncadeamentoLista(novo);

                Console.WriteLine("\nDeseja cadastrar outro animal?");
                cond = Console.ReadLine().ToUpper();
            } while (cond == "S" || cond == "SIM");

        }

        static void EncadeamentoLista(Animal animal)
        {
            if (inicio == null)
            {
                inicio = animal;
                inicio.prox = null;
            }
            else
            {
                if (inicio.prox == null)
                {
                    lista = animal;
                    lista.prox = null;
                    inicio.prox = lista;
                }
                lista.prox = animal;
                lista = animal;
                lista.prox = null;
            }
        }
        static string EscolhaSexo(string sexo)
        {
            if (sexo == "F")
            {
                contSexFem++;
                sexo = "FEMEA";
            }
            else if (sexo == "M")
            {
                contSexMasc++;
                sexo = "MACHO";
            }
            else
            {
                if (sexo == "FEMEA")
                {
                    contSexFem++;
                }
                if (sexo == "MACHO")
                {
                    contSexMasc++;
                }
                else
                {
                    sexo = "Indefinido";
                }
            }
            return sexo;
        }

        public static void ListarAnimais()
        {
            aux = inicio;
            Console.WriteLine("=---------- Lista Animais ----------=");
            while (aux != null)
            {
                Console.WriteLine($"--- Animal {aux.codigo} ---\n" +
                    $"*Raça: {aux.raca}\n" +
                    $"*Cor: {aux.cor}\n" +
                    $"*Sexo: {aux.sexo}\n" +
                    $"*Idade: {aux.idade}\n" +
                    $"*Peso: {aux.peso} Kg\n" +
                    $"*Descriçãp: {aux.descricao}\n"+
                    $"*Preço: R$ {aux.preco}\n" +
                    $"-----");

                aux = aux.prox;
            }
            Console.WriteLine($"Total Animais Cadastrados: {contAnim}");
        }
        public static void ListarAnimais(int codigo,int cont)
        {
            aux = inicio;
            while (aux != null)
            {
                if (codigo == aux.codigo)
                {
                    Console.WriteLine($"--- Animal {aux.codigo} ---\n" +
                    $"*Raça: {aux.raca}\n" +
                    $"*Cor: {aux.cor}\n" +
                    $"*Sexo: {aux.sexo}\n" +
                    $"*Idade: {aux.idade}\n" +
                    $"*Peso: {aux.peso} Kg\n" +
                    $"*Descriçãp: {aux.descricao}\n" +
                    $"*Preço: R$ {aux.preco}\n" +
                    $"-----");
                }
                aux = aux.prox;
            }
        }
        public static void ListarAnimais(int? idade)
        {
            aux = inicio;
            while (aux != null)
            {
                if (idade == aux.idade)
                {
                    Console.WriteLine($"--- Animal {aux.codigo} ---\n" +
                    $"*Raça: {aux.raca}\n" +
                    $"*Cor: {aux.cor}\n" +
                    $"*Sexo: {aux.sexo}\n" +
                    $"*Idade: {aux.idade}\n" +
                    $"*Peso: {aux.peso} Kg\n" +
                    $"*Descriçãp: {aux.descricao}\n" +
                    $"*Preço: R$ {aux.preco}\n" +
                    $"-----");
                }
                aux = aux.prox;
            }
        }
        public static void ListarAnimais(string? raca)
        {
            aux = inicio;
            while (aux != null)
            {
                if (raca == aux.raca)
                {
                    Console.WriteLine($"--- Animal {aux.codigo} ---\n" +
                    $"*Raça: {aux.raca}\n" +
                    $"*Cor: {aux.cor}\n" +
                    $"*Sexo: {aux.sexo}\n" +
                    $"*Idade: {aux.idade}\n" +
                    $"*Peso: {aux.peso} Kg\n" +
                    $"*Descriçãp: {aux.descricao}\n" +
                    $"*Preço: R$ {aux.preco}\n" +
                    $"-----");
                }
                aux = aux.prox;
            }
        }public static void ListarAnimais(int? idade, string? raca)
        {
            aux = inicio;
            while (aux != null)
            {
                if (idade == aux.idade && raca == aux.raca)
                {
                    Console.WriteLine($"--- Animal {aux.codigo} ---\n" +
                    $"*Raça: {aux.raca}\n" +
                    $"*Cor: {aux.cor}\n" +
                    $"*Sexo: {aux.sexo}\n" +
                    $"*Idade: {aux.idade}\n" +
                    $"*Peso: {aux.peso} Kg\n" +
                    $"*Descriçãp: {aux.descricao}\n" +
                    "*Preço: "+aux.preco.ToString("C")+"\n"+
                    $"-----");
                }
                aux = aux.prox;
            }
        }
        public static void ListarAnimaisSexo(string sexo)
        {
            if (sexo == "F")
            {
                Console.WriteLine("=---------- Lista Animais Femea ----------=");
                SepararFeminino(inicio);
                for (int i = 0; i < feminino.Length; i++)
                {
                    ListarAnimais(feminino[i],i);
                }
                Console.WriteLine($"*Total Animais Femeas Cadastradas: {contSexFem}");
            }
            if (sexo == "M")
            {
                Console.WriteLine("=---------- Lista Animais Macho ----------=");
                SepararMasculino(inicio);
                for (int i = 0; i < masculino.Length; i++)
                {
                    ListarAnimais(masculino[i],i);
                }
                Console.WriteLine($"*Total Animais Machos Cadastrados: {contSexMasc}");
            }
        }
        public static void ListarAnimaisSexo()
        {
            ListarAnimaisSexo("F");
            Console.WriteLine("\n");
            ListarAnimaisSexo("M");
        }
        static void SepararFeminino(Animal lista)
        {
            feminino = new int[contSexFem];
            int cont = 0;
            while (lista != null)
            {
                if (lista.sexo == "FEMEA")
                {
                    feminino[cont] = lista.codigo;
                    cont++;
                }
                lista = lista.prox;
            }
        }
        static void SepararMasculino(Animal lista)
        {
            masculino = new int[contSexFem];
            int cont = 0;
            while (lista != null)
            {
                if (lista.sexo == "MACHO")
                {
                    masculino[cont] = lista.codigo;
                    cont++;
                }
                lista = lista.prox;
            }
        }
    }
}
