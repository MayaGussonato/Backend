
namespace Exercicio01
{
    class Retangulo : IForma
{
    public double Largura;
    public double Altura;

    public void CalcularArea()
    {
       Console.WriteLine ($"A Area do retangulo e ={Largura* Altura}");
    }
}

}