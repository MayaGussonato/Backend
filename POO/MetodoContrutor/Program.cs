using MetodoConstrutor;

// Console.WriteLine();
// Console.WriteLine($"-- Pessoa --");
// Console.WriteLine();

// //P1 é uma variáel do tipo pessoa
// Pessoa P1 = new Pessoa("Mayara Gussonato", 17);

// // P1.Nome = "Sabryna Monalysa";
// // P1.Idade = 16;

// // Console.WriteLine($"Nome: {P1.Nome}");//Exibe o nome da pessoa que criei
// // Console.WriteLine($"Idade: {P1.Idade}"); //Exibe a idade da pessoa que criei
// // Console.WriteLine();

// // P1.Nome = "Luis oliva";
// P1.ExibirDados();

//Primeiro método construtor da class Pessoa3Sobrecargas
Pessoa3Sobrecargas PrimeiraPessoa = new Pessoa3Sobrecargas();

Console.WriteLine(@$"Primeira pessoa cadastrada:
                            Nome: {PrimeiraPessoa.Nome}
                            Idade: {PrimeiraPessoa.Idade}

");

//Segundo método construtor da class Pessoa3Sobrecargas
Pessoa3Sobrecargas SegundaPessoa = new Pessoa3Sobrecargas("sabryna monalysa");

Console.WriteLine(@$"Segunda pessoa cadastrada:
                            Nome: {SegundaPessoa.Nome}
                            Idade: {SegundaPessoa.Idade} 

");

//Terceiro método construtor da class Pessoa3Sobrecarga
Pessoa3Sobrecargas TerceiraPessoa = new Pessoa3Sobrecargas();
Console.WriteLine($"Digite seu nome: ");
TerceiraPessoa.Nome = Console.ReadLine();

Console.WriteLine($"Digite sua idade: ");
TerceiraPessoa.Idade = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine(@$"Terceira pessoa cadastrada:
                            Nome: {TerceiraPessoa.Nome}
                            Idade: {TerceiraPessoa.Idade} 

");
