namespace Herança
{
    class Moto : Veiculo
    {
        public string TipoCapacete;

        public override void MostrarInfo()
        {
            Console.WriteLine($"Moto - Marca: {Marca}, Modelo: {Modelo}, Capacete: {TipoCapacete}");
        }
    }
}
