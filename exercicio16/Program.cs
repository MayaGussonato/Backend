string cargo;
double salario, salario2 = 0;

// Cargo
Console.Write("Digite o cargo do funcionário Producao, Administrativo, Diretoria: ");

cargo = Console.ReadLine();

// Salário
Console.Write("Digite o salário atual: R$ ");
salario = double.Parse(Console.ReadLine());

// Reajuste
if (cargo == "producao")
{
    salario2 = salario * 1.065;
}
else if (cargo == "administrativo")
{
    salario2 = salario * 1.075;
}
else if (cargo == "diretoria") 
{
    salario2 = salario * 1.12;
}
else
{
    salario2 = salario;
    Console.WriteLine("cargor invalido, sem direito a reajuste");
}

Console.WriteLine($"Seu novo salario e : {salario2}");