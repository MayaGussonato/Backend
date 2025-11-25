using System.Dynamic;
using System.Xml.Serialization;

namespace ENCAPSULAMENTO
{
    public class ContaBancaria
    {
       private  float Saldo;
    //Construtores
        public ContaBancaria()
        {
            Saldo = 0;
        }
       
        public ContaBancaria(float saldoInicial)
        {
            Saldo = saldoInicial;
        }

      //metodo publico que seta/configurs/guarda o saldo
        public void Depositar (float valor)
        {
            if (valor >= 0)
            {
                Saldo = valor;
                return;
            }
            Console.WriteLine($"Valor para deposito invalido");
            
        }


         //metodo público que retorna o Saldo
        public float GetSaldo()
        {
            return Saldo;
        }

        //crie o metodo publico sacar(float valor)
        public void Saque(float valor)
{
    if (valor > 0 && valor <= Saldo)
    {
        Saldo -= valor;
        Console.WriteLine("Saque realizado com sucesso!");
    }
    else
    {
        Console.WriteLine("Valor para saque inválido ou saldo insuficiente.");
    }
}

    }
}