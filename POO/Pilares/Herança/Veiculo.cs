namespace Herança
{
    class Veiculo
    {
        public string Marca;
        public string Modelo;

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}");
        }
    }
}
