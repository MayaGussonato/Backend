namespace ClassesEObjetos
{
    public class ProdutoComDesconto
    {
        public string Nome;
        public double Preco; 

        public void AplicarDesconto(double percentual)
        {
            // Calcula o valor do desconto
            double desconto = Preco * (percentual / 100);

            // Aplica o desconto
            Preco -= desconto;

            // Mostra o novo preço
            Console.WriteLine($"Novo preço do produto {Nome}: R$ {Preco:F2}");
        }
    }
}