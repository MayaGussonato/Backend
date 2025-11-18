
namespace TheBasics
{
    public class Veiculo
    {
        public string Marca;

        public string Modelo;

        public void Ligar()
        {
            Console.WriteLine($"lingando veiculo");
        }

        
        public void Desligar()
        {
            Console.WriteLine($"deslingando veiculo");
        }
    }
}