
namespace Exercicio02
{
    public class Fatura : IImprimivel
    {   
        public string Devedor = "";

        public string Credor = "";

        public float Valor = 0;

        public int DiasDeAtraso = 0;

        private float Juros = 0.10f;
        
        //sobregarca do construtor -  obriga a passar os dados na criacao do objeto
        public Fatura( string dev, string cred, float valfat, int qtdAtraso )
        {
            Devedor = dev;
            Credor = cred;
            DiasDeAtraso = qtdAtraso;
            Valor = valfat;

        }

        public void Imprimir()

       
    {
         CalcularvalorDivida();

        Console.WriteLine($@"
        Credor: {Credor}
        Devedor: {Devedor}
        Dias de atraso: {DiasDeAtraso} dia(s)
        Valor: R${Valor:F2}
        Júros: R${(Juros * DiasDeAtraso):F2}
        Total com júros: R${Valor:F2}
        
        ");
    }

       public void CalcularvalorDivida()
        {
            if(DiasDeAtraso > 0 )
            {
              Valor = Valor + DiasDeAtraso * Juros;
            }
         
            if(DiasDeAtraso >= 5)
            {
                Console.WriteLine($"Divida encaminhada para SERASA!!");
            }
            
        }


    }
}