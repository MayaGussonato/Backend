namespace Encapsulamento
{
    public class Carro
    {
        private string Marca;
        private string Modelo;
        private int velocidadeAtual;

        // Métodos para Marca
        public void DefinirMarca(string marca)
        {
            Marca = marca;
        }

        public string ObterMarca()
        {
            return Marca;
        }

        // Métodos para Modelo
        public void DefinirModelo(string modelo)
        {
            Modelo = modelo;
        }

        public string ObterModelo()
        {
            return Modelo;
        }

        // Método para obter velocidade atual
        public int ObterVelocidade()
        {
            return velocidadeAtual;
        }

        // Métodos para acelerar e frear
        public void Acelerar(int velo)
        {
            velocidadeAtual += velo;
        }

        public void Frear(int velo)
        {
            velocidadeAtual -= velo;

            if (velocidadeAtual < 0)
            {
                velocidadeAtual = 0;
            }
        }
    }
}
