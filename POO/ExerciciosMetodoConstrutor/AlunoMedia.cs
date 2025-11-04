using System;

namespace ExercicioMetodoConstrutor
{
    public class AlunoMedia
    {

        public string nome;
        
        public double N1, N2, N3;

        // 🔹 Construtor que define as notas como zero
        public AlunoMedia(string nome)
        {
            this.nome = nome;
            nota1 = 0.0;
            nota2 = 0.0;
            nota3 = 0.0;

            Console.WriteLine("Aluno (Notas Zeradas)");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Nota 1: {nota1}");
            Console.WriteLine($"Nota 2: {nota2}");
            Console.WriteLine($"Nota 3: {nota3}");
    
        }

        // 🔹 Construtor que recebe as três notas
        public AlunoMedia(string nome, double nota1, double nota2, double nota3)
        {
            this.nome = nome;
            this.N1 = nota1;
            this.N2 = nota2;
            this.N3 = nota3;

            Console.WriteLine("=== Aluno Criado ===");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Nota 1: {nota1}");
            Console.WriteLine($"Nota 2: {nota2}");
            Console.WriteLine($"Nota 3: {nota3}");
        
        }

        public void CalcularMedia()
        {
            double media = (N1 + N2 + N3) / 3;
            Console.WriteLine($"Aluno: {nome} | Média: {media:F2}");
        }
    }
}