
using System.Reflection.Metadata;

namespace Exercicio02
{
  public class Relatorio : IImprimivel
{  
    public string Nome;

    public string textoRelatorio = "";

    public Relatorio(string responsavel, String txtRelatorio)
        {
            Nome = responsavel;
            textoRelatorio = txtRelatorio;
        }

        public void Imprimir()
    {
        Console.WriteLine($"Imprimindo a Fatura do(a) {Nome}....");
        Console.WriteLine(textoRelatorio);
        Console.WriteLine($"--");

    }

}

}