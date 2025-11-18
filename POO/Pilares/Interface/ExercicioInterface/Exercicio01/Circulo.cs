
using System.IO.Pipes;

namespace Exercicio01
{
   class Circulo : IForma
{
    public double Raio;

    private float PI = 3.14f;

    public void CalcularArea()
    {
        Console.WriteLine($"A area do circulo é {PI * Raio * Raio}");
    }
}
}