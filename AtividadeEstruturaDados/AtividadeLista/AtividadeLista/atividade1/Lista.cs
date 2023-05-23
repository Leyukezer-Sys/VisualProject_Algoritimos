namespace AtividadeLista.atividade1
{
    public class Atividade1
    {
        public static void ListaFuncionario()
        {
            Funcionario aux = null, novo = null, inicio = null, lista = null;
            string cond = "";
            do
            {
                Console.WriteLine("========== Gerenciamento Funcionarios ==========\n" +
                "- Escolha sua opção:\n" +
                "+ 1 - Cadastrar Funcionario\n" +
                "+ 2 - Listar Funcionarios Cadastrados\n" +
                "+ 3 - Buscar Funcionario\n");
                Console.Write("R: ");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("====");
                            novo = new Funcionario();
                            Console.Write("Digite o Nome do Funcionario: ");
                            novo.nome = Console.ReadLine();
                            Console.Write("Digite o CPF do Funcionario: ");
                            novo.cpf = Console.ReadLine();
                            Console.Write("Digite o Matricula do Funcionario: ");
                            novo.matricula = Console.ReadLine();
                            Console.Write("Digite a profissão do Funcionario: ");
                            novo.profissao = Console.ReadLine();
                            Console.Write("Digite o Salário Mensal do Funcionario: ");
                            novo.salario = double.Parse(Console.ReadLine());
                            Console.Write("Quantas Vendas foram Realizadas pelo Funcionario: ");
                            int quant = int.Parse(Console.ReadLine());
                            novo.vendaFunc = new double[quant];
                            for (int i = 0; i < quant; i++)
                            {
                                Console.Write(@$"    Digite o Valor da {i + 1}ª Venda: ");
                                novo.vendaFunc[i] = double.Parse(Console.ReadLine());
                            }

                            novo.salarioFinal = novo.Comissao(novo.vendaFunc, novo.salario);


                            //MANIPULAÇÃO DE LISTA
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
                            Console.WriteLine("\nDeseja Adicionar outro Funcionario?");
                            cond = Console.ReadLine().ToUpper();
                            
                        } while (cond.Equals("SIM") || cond.Equals("S"));
                        

                        break;

                    case 2:
                        aux = inicio;
                        while (aux != null)
                        {
                            Console.WriteLine($"===== Ficha do Funcionario {aux.nome} =====\n" +
                                $"*CPF: {aux.cpf}\n" +
                                $"*Matricula: {aux.matricula}\n" +
                                $"*Profissão: {aux.profissao}\n" +
                                $"*Salario do Funcionario: R$ {aux.salario}\n" +
                                $"*Salario Total do Mês: R$ {aux.salarioFinal}");

                            aux = aux.prox;
                        }
                        break;
                    case 3:
                        Console.WriteLine("======== Pesquisa ========");
                        Console.WriteLine("Escolha qual pesquisa deseja realizar:\n" +
                            "1 - Consultar por Matricula\n" +
                            "2 - Consultar por CPF\n" +
                            "3 - Consultar por Matricula e CPF");
                        Console.Write("R: ");
                        int ope = int.Parse( Console.ReadLine() );
                        switch (ope)
                        {
                            case 1:
                                {
                                    Console.Write("\nDigite a Matricula do Funcionaro: ");
                                    string pesq = Console.ReadLine();

                                    aux = inicio;
                                    while (aux != null)
                                    {
                                        if (aux.matricula.ToLower() == pesq.ToLower())
                                        {
                                            Console.WriteLine($"===== Resultado Pesquisa =====\n" +
                                            $"*Nome: {aux.nome}\n" +
                                            $"*CPF: {aux.cpf}\n" +
                                            $"*Matricula: {aux.matricula}\n" +
                                            $"*Profissão: {aux.profissao}\n" +
                                            $"*Salario do Funcionario: R$ {aux.salario}\n" +
                                            $"*Salario Total do Mês: R$ {aux.salarioFinal}");
                                        }
                                        aux = aux.prox;
                                    }
                                }
                                break;
                            case 2:
                                {
                                    Console.Write("\nDigite o CPF do Funcionaro: ");
                                    string pesq = Console.ReadLine();

                                    aux = inicio;
                                    while (aux != null)
                                    {
                                        if (aux.cpf.ToLower() == pesq.ToLower())
                                        {
                                            Console.WriteLine($"===== Resultado Pesquisa =====\n" +
                                            $"*Nome: {aux.nome}\n" +
                                            $"*CPF: {aux.cpf}\n" +
                                            $"*Matricula: {aux.matricula}\n" +
                                            $"*Profissão: {aux.profissao}\n" +
                                            $"*Salario Mensal: R$ {aux.salario}\n" +
                                            $"*Salario Total do Mês: R$ {aux.salarioFinal}");
                                        }
                                        aux = aux.prox;
                                    }
                                }
                                break;
                            case 3:
                                {
                                    Console.Write("\nDigite a Matricula do Funcionaro: ");
                                    string pesqMat = Console.ReadLine();
                                    Console.Write("Digite o CPF do Funcionaro: ");
                                    string pesqCPF = Console.ReadLine();

                                    aux = inicio;
                                    while (aux != null)
                                    {
                                        if (aux.matricula.ToLower() == pesqMat.ToLower()|| aux.cpf.ToLower() == pesqCPF.ToLower())
                                        {
                                            Console.WriteLine($"===== Resultado Pesquisa =====\n" +
                                            $"*Nome: {aux.nome}\n" +
                                            $"*CPF: {aux.cpf}\n" +
                                            $"*Matricula: {aux.matricula}\n" +
                                            $"*Profissão: {aux.profissao}\n" +
                                            $"*Salario Mensal: R$ {aux.salario}\n" +
                                            $"*Salario Total do Mês: R$ {aux.salarioFinal}");
                                        }
                                        aux = aux.prox;
                                    }
                                }
                                break;
                        }
                        break;
                }

                Console.WriteLine("Deseja retornar ao Menu da Atividade?");
                cond = Console.ReadLine().ToUpper();
                if (cond == "SIM" || cond.Equals("S"))
                {
                    Console.Clear();
                }

            } while (cond.Equals("SIM") || cond.Equals("S"));            
        }
    }
}