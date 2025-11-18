//Retangulo
using Exercicio01;

Console.WriteLine($"Bem vindo ao programa calculos de gemetria : ");
Console.WriteLine();

Console.WriteLine($"Vamos calcular o Retangulo");

//altura e largura
Console.WriteLine($"Digite a largura do retangulo");
float l = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite a altura do retangulo");
float a = float.Parse(Console.ReadLine());

Retangulo retangulo = new Retangulo();
retangulo.Altura = a;
retangulo.Largura = l;
retangulo.CalcularArea();


Console.WriteLine();
Console.WriteLine($"Agora vamos calcular a area do circulo");

Console.WriteLine($"Informe o raio do circulo: ");
float r = float.Parse(Console.ReadLine());

Circulo circulo =  new Circulo();
circulo.Raio = r;
circulo.CalcularArea();

Console.WriteLine();
Console.WriteLine ($"Fim do programa");
Console.WriteLine();