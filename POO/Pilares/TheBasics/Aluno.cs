
namespace TheBasics
{
    public class Aluno : Pessoa
    {
        //cria um construtor na classe aluno que recebe o endereco
        //chama o contrutor da classe mae (base) e repassa o 
        // endereco pra ela

        public Aluno(Endereco endereco) : base(endereco)
        {
        }

        public string RA;

        public float NotaFinal;

        public string Curso;
    }
}