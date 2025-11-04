namespace MetodoConstrutor
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }


        //Método Construtor de pessoa 
        /*Possuindo parâmetros, que representam os valores para suas propriedades,
        ou seja, estamos inicializando os valores para as propriedades nome
        e idade*/

        public Pessoa(string n, int i)
        {
            Nome = n;
            Idade = i;
        }
    }
}

