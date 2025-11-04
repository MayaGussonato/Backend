namespace ExercicioMetodoConstrutor
{
    public class Carro
    {
        public string Marca;
        public string Modelo;
        public int Ano;

       
        public Carro(string marca, string modelo, int ano)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;

            Console.WriteLine(" Dados do Carro ");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
        }

       
        public void Ligar()
        {
            Console.WriteLine($"{Marca} {Modelo} foi ligado.");
        }

        public void Acelerar()
        {
            Console.WriteLine($"{Marca} {Modelo} está acelerando!");
        }

        public void Frear()
        {
            Console.WriteLine($"{Marca} {Modelo} está freando!");
        }

        public void Desligar()
        {
            Console.WriteLine($"{Marca} {Modelo} foi desligado.");
        }
    }
}
