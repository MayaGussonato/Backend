// faca um programa que solicite ao usuario um numero de repeticoes "x". para cada
// repeticao solicite dois numeros e imprima qual e o maior deles

int n = 0, contador = 0;

Console.WriteLine("Digite o numero de repeticao");
n = int.Parse(Console.ReadLine());

while(contador < n )
{
  Console.WriteLine("Digite o primeiro numero:");
  n1 = int.Parse(Console.ReadLine());

   Console.WriteLine("Digite o segundo numero:");
  n2 = int.Parse(Console.ReadLine());

  if(n1 > n2 )
  {
    
    Console.WriteLine($"O numero {n1} e maior que o numero {n2}");
    
  } else if ( n1 < n2 )

  {
    Console.WriteLine($"O numero {n2} e maior que o numero {n1}");
  } else
{
    Console.WriteLine($"O numero sao iguais {n1} = {n2}");
}



  contador++

}