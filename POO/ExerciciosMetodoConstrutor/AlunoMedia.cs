namespace ExerciciosMetodoConstrutor
{
    public class MediaAluno
    {
        public string Nome;

        public double N1, N2, N3;

        public MediaAluno(double param1, double param2, double param3)
        {
            N1 = param1; //parametro param1 representa o valor N1 
            N2 = param2;
            N3 = param3;
        }

        public MediaAluno()
        {
            N1 = N2 = N3 = 0; //Atribuindo valor fico as 3 propriedades de uma vez
        }

        public void Media()
        {
            double media = (N1 + N2 + N3) / 3;

            Console.WriteLine($"A média do(a) aluno(a) {Nome} foi: {Media}");
        }
    }
}