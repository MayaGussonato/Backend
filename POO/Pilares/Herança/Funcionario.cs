namespace Heranca
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBase;

        public virtual double CalcularSalario()
        {
            return SalarioBase;
        }
    }
}
