
namespace Exercicio02
{
    public class Contrato : IImprimivel
{
      public string Contratante = "";

      public string PrestadorDeServico = "";

      public string TextoClasulas = "";

      public Contrato(String contratante, string contradado, string txtClasulas)
        {
            Contratante = contratante;
            PrestadorDeServico = contradado;
            TextoClasulas = txtClasulas;
        }

      public void Imprimir()
    {
        Console.WriteLine($@"Características do contrato:
                             Contratante:{Contratante}
                             Contratodo:{PrestadorDeServico}
                             Clásulas do contrato;{TextoClasulas} 
        
        ");
    }

}


 }
