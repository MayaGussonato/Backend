Console.clear();
Console.Writeline($"Digite seu nome");
string nome = Console.Readline();
Console.Writeline($"Digite seu sobrenome")
string sobrenome = Console.Readline();


Console.Writeline($"ok, {nome}! Agora vamos dar as boas vindas a voce!!");


Console.Writeline($"Por favor escolha um opcao abaixo");
Console.Writeline($"1- Saudar com nome");
Console.Writeline($"2 - Saudar com Sobrenome");
Console.Writeline($"3 - Saudar com nome e sobrenome");
Console.Writeline($"0 - apenas saudacao generica");

Console.clear();

int opcao = 0;
switch (opcao)
{
    case 0:
     SaudacaoGenerica();
       break;
    default:
       break;

    case 1:
      SaudarComNome(nome);
      break;
    default:
      break;

    case 2:
     SaudarComSobrenome(sobrenome);
      break;
    default:
      break;

      case 3:
      string nomeCompleto = DevolveNomeCompleto (nome, sobrenome);
      Console.Writeline($" Seja bem vindo {nomeCompleto}");

}


//funcao que escreve a saudacao personalizada
void SaudacaoGenerica()
{
    Console.Writeline($"Ola, seja bem vindo ao nosso programa, tenha um otimo dia :)");
    
}

//Recebe um nome e escreve uma saudacao personalizada 
void SaudarComNome(string nomeRecebido)
{
    Console.Writeline($"Seja bem vindo, {nomeRecebido}");
}

//recebe um nome e escreve a saudacao personalizada
void SaudarComSobrenome (string sobrenomeRecebido)
{
    Console.Writeline($"Olá seja bem vindo {sobrenomeRecebido}");.0
    
}

//Recebe dois parametros e devolve um texto - recebenome e sobrenome e devolve o nome completo
void DevolveNomeCompleto(string nomeRecebido, string sobrenomeRecebido)
{
    return $"{nomeRecebido} {sobrenomeRecebido}";
}