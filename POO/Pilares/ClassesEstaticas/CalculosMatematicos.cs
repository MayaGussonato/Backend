using ClassesEstaticas;

namespace ClassesEstaticas
{
    public class CalculosMatematicos
    {
        //Operacoes Matematicas simples
        //visibilidade tipoDeRetorno nome(parametros) {corpo}

        public static float Somar (float a, float b )
        {
            return a + b;
        }
 
 
     //criar as outras 3 operacoes
     //nao se esqueca que nao existe 
     //divisao por zero, entao na divisao faca a validacao 

        // Subtração
        public static float Subtrair(float a, float b)
        {
            return a - b;
        }

        // Multiplicação
        public static float Multiplicar(float a, float b)
        {
            return a * b;
        }

        // Divisão com validação de zero
        public static float Dividir(float a, float b)
        {
            if (b == 0)
            {
                Console.WriteLine("ERRO: Não existe divisão por zero!");
                return 0; 
            }

            return a / b;
        }
    }
}



    


