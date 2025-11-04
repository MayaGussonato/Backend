namespace ClassesEObjetos
{
    public class Garrafa
    {
        //Propriedades
        public string Marca;

        public string Capacidade;

        public string Cor;

        public string Tamanho;

        //Métodos
        public void Abrir()
        {
            Console.WriteLine($"Garrafa aberta");
        }

        public void Fechar()
        {
            Console.WriteLine($"Garrafa fechada");
        }

        public void Esvaziar()
        {
            Console.WriteLine($"Garrafa vazia");
        }

        public void Encher()
        {
            Console.WriteLine($"Garrafa cheia");
        }
    }
}