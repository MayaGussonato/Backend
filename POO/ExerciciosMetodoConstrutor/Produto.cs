using System;

namespace ExercicioMetodoConstrutor
{
    public class Produto
    {
      
        public string Nome;
        
        public double Preco;

        public int Estoque;

     
        public Produto(string nome, double preco, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;

            Console.WriteLine("Produto");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preço: R${Preco:F2}");
            Console.WriteLine($"Estoque: {Estoque} unidades");
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Produto: {Nome} | Preço: R${Preco:F2} | Estoque: {Estoque} unidades");
        }
    }
}
