// Programa que calcula a média de 4 notas e mostra a situação do aluno

double nota1, nota2, nota3, nota4, media;

Console.WriteLine("------------------------------------------------------------");
Console.WriteLine("Cálculo da média do aluno");
Console.WriteLine("------------------------------------------------------------");

// Entrada das notas
Console.Write("Digite a 1ª nota: ");
nota1 = double.Parse(Console.ReadLine()!);

Console.Write("Digite a 2ª nota: ");
nota2 = double.Parse(Console.ReadLine()!);

Console.Write("Digite a 3ª nota: ");
nota3 = double.Parse(Console.ReadLine()!);

Console.Write("Digite a 4ª nota: ");
nota4 = double.Parse(Console.ReadLine()!);

// Cálculo da média
media = (nota1 + nota2 + nota3 + nota4) / 4;

// Exibe a média
Console.WriteLine($"\nA média do aluno é: {media:F2}");

// Verifica a situação
if (media >= 7.0)
{
    Console.WriteLine("Situação: APROVADO ");
}
else if (media >= 5.0)
{
    Console.WriteLine("Situação: RECUPERAÇÃO ");
}
else
{
    Console.WriteLine("Situação: REPROVADO ");
}
