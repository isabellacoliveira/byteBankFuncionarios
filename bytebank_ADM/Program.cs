using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;

#region 
// agora temos que passar o tipo do funcionário 
// Funcionario pedro = new Funcionario("123456789", 2000);
// pedro.Nome = "Pedro malazartes";
// pedro.Cpf = "123456789";
// pedro.Salario = 2000;

// Console.WriteLine(pedro.Nome);
// Console.WriteLine(pedro.GetBonificacao());

// nova diretora 
// Diretor roberta = new Diretor("987654321");
// roberta.Nome = "Roberta Silva";
// roberta.Cpf = "987654321";
// roberta.Salario = 5000;

// recebe o salário inteiro 
// Console.WriteLine(roberta.Nome);
// Console.WriteLine(roberta.GetBonificacao());

// gerencia o número de bonificações 
// GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
// gerenciador.Registrar(pedro);
// gerenciador.Registrar(roberta);

// Console.WriteLine("Total de bonificações: " + gerenciador.TotalBonificacao);
// Console.WriteLine("Total de Funcionários: " + Funcionario.TotalDeFuncionarios);

// pedro.AumentarSalario();
// roberta.AumentarSalario(); 

// Console.WriteLine("O salário do Pedro é " + pedro.Salario); 
// Console.WriteLine("O salário do Roberta é " + roberta.Salario); 
#endregion

#region 
// void CalcularBonificacao()
// {
//     GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

//     Designer isabella = new Designer("1234456");
//     isabella.Nome = "Isabella Oliveira"; 

//     Diretor paula = new Diretor("098209123"); 
//     paula.Nome = "Paula Souza"; 

//     Auxiliar igor = new Auxiliar("123123"); 
//     igor.Nome = "Igor Dias"; 

//     GerenteDeContas camila = new GerenteDeContas("1871293"); 
//     camila.Nome = "Camila Oliveira"; 

//     gerenciador.Registrar(camila); 
//     gerenciador.Registrar(isabella); 
//     gerenciador.Registrar(igor); 
//     gerenciador.Registrar(paula); 

    // Console.WriteLine("Total de bonificação " + gerenciador.TotalBonificacao);

    // Funcionario pedro = new Funcionario("123123", 9000); 
// }
#endregion

UsarSistema(); 

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno(); 
    Diretor ingrid = new Diretor("238998314"); 
    ingrid.Nome = "Ingrid Guerra";
    ingrid.Senha = "123"; 

    GerenteDeContas ursula = new GerenteDeContas("2123123");
    ursula.Nome = "Ursula Alcântara"; 
    ursula.Senha = "321"; 

    // henrique e isa não possuem a classe autenticavel para logar no sistema
    // pois não são diretores ou gerentes de contas
    // Auxiliar henrique = new Auxiliar("198327"); 
    // henrique.Nome = "Henrique Paz"; 
    // henrique.Senha = "123"; 

    // Designer isa = new Designer("12312");
    // isa.Nome = "Isabella Oliveira"; 
    // isa.Senha = "1234"; 

    ParceiroComercial caio = new ParceiroComercial();
    caio.Senha = "123"; 

    sistema.Logar(ingrid, "123"); 
    sistema.Logar(ursula, "324");
    sistema.Logar(caio, "123");
    // sistema.Logar(henrique, "324");
    // sistema.Logar(isa, "324");
}


