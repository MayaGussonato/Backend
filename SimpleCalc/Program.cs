string nome;
int numero1;
int numero2;

/*pedir os nomes pro usuario*/
Console.WriteLine("Digite seu nome");
nome = Console.ReadLine(); /*Pede o nome do usuario*/


/*pedir os dois numeros*/
Console.WriteLine("Digite o primeiro número");
numero1 = int.Parse(Console.ReadLine());/*converte o texto em número*/
Console.WriteLine("Digite o segundo número");
numero2 = int.Parse(Console.ReadLine());/*converte o texto em número*/

/*somar os dois numeros*/
int soma = numero1 + numero2;

/*exibir nome e a soma*/
Console.WriteLine(nome); /*exibe o nome do usuario*/
Console.WriteLine(soma); /*exibe a soma*/


