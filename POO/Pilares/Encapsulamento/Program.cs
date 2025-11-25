using Encapsulamento;


// float dinheiro = 200;

// ContaBancaria contaMaya = new ContaBancaria();
// ContaBancaria contaSabry = new ContaBancaria(dinheiro);

// contaMaya.Depositar(dinheiro);

// System.Console.WriteLine($"Saldo da Maya R${contaMaya.GetSaldo()}");

// System.Console.WriteLine($"Saldo da Sabryna R${contaSabry.GetSaldo()}");

// contaMaya.Saque(180);
// Console.WriteLine($"Saldo apos saque da Maya R$ {contaMaya.GetSaldo()}")

/*Crie um programa em C# para representar um carro usando o conceito de encapsulamento, porém sem utilizar propriedades com get e set. Utilize somente atributos privados e métodos públicos para acessar e modificar os dados. Siga as instruções:

Crie uma classe chamada Carro.

Dentro da classe, crie três atributos privados:

marca (string)

modelo (string)

velocidadeAtual (int)

Crie métodos públicos para definir e obter a marca:

DefinirMarca(string valor)

ObterMarca()

Crie métodos públicos para definir e obter o modelo:

DefinirModelo(string valor)

ObterModelo()

Crie um método público para obter a velocidade atual:

ObterVelocidade()

Crie dois métodos públicos que alterem a velocidade do carro:

Acelerar(int valor): aumenta a velocidade.

Frear(int valor): diminui a velocidade, mas nunca pode ficar abaixo de zero.
*/




    
        Carro meuCarro = new Carro();

        meuCarro.DefinirMarca("Mercedez");
        meuCarro.DefinirModelo("G63");

        // Acelerando
        meuCarro.Acelerar(110);
        meuCarro.Acelerar(30);
        meuCarro.Frear(15);
        meuCarro.Frear(50); 
        // não deixa a velocidade ficar negativa

        Console.WriteLine(@$" DADOS DO CARRO 
             Marca: {meuCarro.ObterMarca()}
             Modelo: {meuCarro.ObterModelo()}
             Velocidade Atual: {meuCarro.ObterVelocidade()} km/h
        ");
       
    

