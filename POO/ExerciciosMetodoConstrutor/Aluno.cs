using System;

namespace ExercicioMetodoConstrutor
{
    public class Aluno
    {
      
        public string Nome;
        public double Nota;

        
        public Aluno()
        {
            Nome = "Sem nome";
            Nota = 0.0;

            Console.WriteLine(" Aluno ");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Nota: {Nota}");
        }

    
        public Aluno(string nome, double nota)
        {
            Nome = nome;
            Nota = nota;

            Console.WriteLine("Aluno");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Nota: {Nota}");
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Aluno: {Nome} | Nota: {Nota}");
        }
    }
}
