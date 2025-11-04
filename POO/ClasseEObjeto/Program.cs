// using ClassesEObjetos;

// Console.WriteLine($"-- Personalização de Garrafa --")
// Console.WriteLine($"Digite o seu nome: ");
// string nome = Console.ReadLine();

// Console.WriteLine($"Digite as informações solicitadas abaixo: ");
// Console.WriteLine();

// Garrafa g1 = new Garrafa();
// Console.WriteLine($"Digite a marca da garrafa: ");
// g1.Marca = Console.ReadLine();

// Console.WriteLine($"Digite a capacidade da garrafa (ex: 2 L/1,5 L): ");
// g1.Capacidade = Console.ReadLine();

// Console.WriteLine($"Digite a cor da garrafa: ");
// g1.Cor = Console.ReadLine();

// Console.WriteLine($"Digite o tamanho da garrafa (ex: Grande/Média/Pequena): ");
// g1.Tamanho =  Console.ReadLine();

// Console.WriteLine();
// Console.WriteLine($"{nome} abaixo estão as características de sua garrafa: ");
// Console.WriteLine();

// Console.WriteLine($"Marca: {g1.Marca}");
// Console.WriteLine($"Capacidade: {g1.Capacidade}");
// Console.WriteLine($"Cor: {g1.Cor}");
// Console.WriteLine($"Tamanho: {g1.Tamanho}");
// Console.WriteLine();
// Console.WriteLine($"---");
// Console.WriteLine();

// using ClassesEObjetos;

// Console.WriteLine("-- Agência Bancária --");
// Console.Write("Digite o nome do titular: ");
// string nomeT = Console.ReadLine();

// AgenciaBancaria conta = new AgenciaBancaria(nomeT);

// Console.WriteLine();
// Console.WriteLine($"Seja bem-vindo(a), {conta.Titular}!");
// Console.WriteLine($"Saldo inicial: R$ {conta.Saldo:F2}");
// Console.WriteLine();

// // Loop do menu principal
// int opcao = 0;
// do
// {
//     Console.WriteLine("\n--- Menu ---");
//     Console.WriteLine("1. Depositar");
//     Console.WriteLine("2. Sacar");
//     Console.WriteLine("0. Sair");
//     Console.Write("Escolha uma opção: ");
//     opcao = int.Parse(Console.ReadLine());

//     Console.WriteLine();

//     switch (opcao)
//     {
//         case 1:
//             Console.Write("Digite o valor do depósito: R$ ");
//             double deposito = Convert.ToDouble(Console.ReadLine());
//             conta.Depositar(deposito);
//             break;

//         case 2:
//             Console.Write("Digite o valor do saque: R$ ");
//             double saque = Convert.ToDouble(Console.ReadLine());
//             conta.Sacar(saque);
//             break;

//         case 0:
//             Console.WriteLine("Encerrando...");
//             break;

//         default:
//             Console.WriteLine("Opção inválida! Escolha uma das opções acima.");
//             break;
//     }

// } while (opcao != 0);

using ClassesEObjetos;

Console.WriteLine("-- Produto com Desconto --");

ProdutoComDesconto produto = new ProdutoComDesconto();

Console.WriteLine($"Digite o nome do produto: ");
produto.Produto = Console.ReadLine();

Console.WriteLine($"Digite o preço do produto: ");
produto.Preco = Console.ReadLine();

Console.WriteLine($"Preço original do produto: R$ {produto.Preco:F2}");
produto.AplicarDesconto(10); // aplica 10% de desconto

Console.WriteLine($"O novo preço do produto {produto.Nome} é: R$ {produto.Preco:F2}");
Console.WriteLine();
