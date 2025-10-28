int opcao = -1;
        
        double[] saldos = new double[3];
        string[] cliente = new string[3];
int totalCliente = 0;
        
        



do
{
    Console.Clear();
    Console.WriteLine("==== MENU BANCO ====");
    Console.WriteLine();

    Console.WriteLine("1) Cadastrar Cliente");
    Console.WriteLine("2) Listar Clientes");
    Console.WriteLine("3) Sacar");
    Console.WriteLine("4) Transferir");
    Console.WriteLine("5) Depositar");
    Console.WriteLine("0) Sair");
    Console.Write("Digite uma opção: ");
    opcao = int.Parse(Console.ReadLine());


switch (opcao)
{
    case 0:
            Console.WriteLine($"Encerrando ...");
            Console.WriteLine($"Pressione <Enter> para encerrar ...");
            Console.ReadLine();//para o sistema e espera o usuário digitar Enter!!
            break;

        case 1:
            CadastrarCliente();
            Console.ReadLine();//para o sistema e espera o usuário digitar Enter!!

            break;

        case 2:
            ListarCliente();
            Console.ReadLine();//para o sistema e espera o usuário digitar Enter!!
            break;
        case 3:
            Sacar();
            Console.ReadLine();//para o sistema e espera o usuário digitar Enter!!
            break;
        case 4:
            Transferir();
            Console.ReadLine();//para o sistema e espera o usuário digitar Enter!!
            break;
        case 5:
            Depositar();
            Console.ReadLine();//para o sistema e espera o usuário digitar Enter!!
            break;

        default:
            Console.WriteLine($"opção Inválida, pressione <Enter> para continuar ...");
            Console.ReadLine();//para o sistema e espera o usuário digitar Enter!!
            break;
     //fim do switch
}


} while (opcao != 0);

void CadastrarCliente()
{
   if (totalCliente >= 3)
    {
        Console.WriteLine($"Não Limite de ocupação atingido");
        Console.WriteLine($"Pressione <Enter> para continuar ...");
        Console.ReadLine();
        return;
    }

    //pedir os dados para o usuário (nome, idade)
    Console.WriteLine($"Digite o nome do Cliente");
    string n = Console.ReadLine();//lê o console e guarda o valor digitado na variável temporária "n"


    // guardar/cadastrar no array
    cliente[totalCliente] = n;
    totalCliente++;

    Console.WriteLine($"Cliente cadastrado com sucesso");
    Console.WriteLine($"Há {totalCliente} Cliente(s) cadastrado(s) no sistema!");
    Console.WriteLine($"Pressione <Enter> para continuar");
    Console.ReadLine();//parar o sistema e esperar o usuário dar um <Enter>
}

    Console.WriteLine($"Pressione <Enter> para continuar ...");
    Console.ReadLine();//para o sistema e espera o usuário digitar Enter!!
            

void ListarCliente()
{
     Console.WriteLine();//pula uma linha
    Console.WriteLine($"Resultado: ");

    for (int i = 0; i < cliente.Length; i++)
    {
        Console.WriteLine($"    Nome: {cliente[i]} |  Saldo: R$ {saldos[i]} ");
        Console.WriteLine();//pula uma linha
    }

    Console.WriteLine($"Pressione <Enter> para continuar ...");
    Console.ReadLine();
            
}
void Transferir()
{
    Console.WriteLine($"Função em Desenvolvimento");
    Console.WriteLine($"Pressione <Enter> para continuar ...");
    Console.ReadLine();//para o sistema e espera o usuário digitar Enter!!
            
}
void Sacar()
{
    Console.WriteLine($"Função em Desenvolvimento");
    Console.WriteLine($"Pressione <Enter> para continuar ...");
    Console.ReadLine();//para o sistema e espera o usuário digitar Enter!!
            
}
void Depositar()
{
    int IdCliente = BuscarCliente();
    if (IdCliente == -1)
    {
        return;
    }

    Console.WriteLine($"Valor para depósito:");
    double valorDeposito = double.Parse(Console.ReadLine());
    saldos[IdCliente] += valorDeposito;
    
    Console.WriteLine($"Pressione <Enter> para continuar ...");
    Console.ReadLine();//para o sistema e espera o usuário digitar Enter!!

}
int BuscarCliente()
{
    ListarCliente();
    Console.Write($"Digite o número do cliente");
    int IdCliente = int.Parse(Console.ReadLine());

 if(IdCliente < 0 || IdCliente >= totalCliente)
    {
        Console.WriteLine($"Cliente não encontrado");
        return -1;
    }

    return 0;
}
