// See https://aka.ms/new-console-template for more information
using ClassesEstaticas;

Console.WriteLine("Bem vindo ao programa");
Console.WriteLine();

// Console.WriteLine($"Digite um número: ");
// float a = float.Parse(Console.ReadLine());
// Console.WriteLine($"Digite outro número");
// float b = float.Parse(Console.ReadLine());

// //uso da classe estatica de forma auxiliar
// float r = CalculosMatematicos.Somar(a, b);
// Console.WriteLine($"Soma: {r}");

// r = CalculosMatematicos.Subtrair(a, b);
// Console.WriteLine($"SUBTRACAO: {r}");

// r = CalculosMatematicos.Multiplicar(a, b);
// Console.WriteLine($"MULTIPLICACAO: {r}");

// r = CalculosMatematicos.Dividir(a, b);
// Console.WriteLine($"DIVISAO: {r}");

Console.WriteLine($"valor do PI é: {Math.PI}");
Console.WriteLine($"Potencia de 3 elevado a 2 é: {Math.Pow(3, 2)}");

/*solicitar ao usuario 2 numeros reais e informar qual
e o maior e qual e o menor dos numeros. Para isso voce deve
utilizar a classe Math, utilitaria do C#*/

Console.WriteLine($"Digite o primeiro numero: ");
float n1 = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite o segundo numero: ");
float n2 = float.Parse(Console.ReadLine());

if (n1== n2)
{
    System.Console.WriteLine($" Os dois numeros sao iguais");
}
else
{
   System.Console.WriteLine($@" O maior numero e: {Math.Max(n1, n2)}
                             o numero menor e: {Math.Min(n1, n2)}");
}