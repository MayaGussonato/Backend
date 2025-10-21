/*pedir o nome do usuário, dois números e mostrar a soma dos numeros no final*/

using System.Reflection;

string nome;
int numero1, numero2;

//pedir os dados
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("digite seu nome");
nome = Console.ReadLine();
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine();

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("digite o primeiro numero");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine();

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("digite o segundo numero");
numero2 = int.Parse(Console.ReadLine());
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine();

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("o maior numero é");

int soma = numero1 + numero2;

if (numero1 > numero2)
{
    Console.WriteLine(numero1);
}
else
{
    Console.WriteLine(numero2);
}
    
Console.WriteLine("----------------------------------------------------------------");

if (numero1 == numero2)
{
    Console.WriteLine("Os números são iguais!");
}