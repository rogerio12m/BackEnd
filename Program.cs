using BackEnd.Classes;
using System.Text.RegularExpressions;


// métodos dos objetos
PessoaFisica metodosPf = new PessoaFisica();
PessoaJuridica metodosPj = new PessoaJuridica();

// ********************** CADASTRO *************************

//endereço de pessoa física
Endereco endPf = new Endereco();
    endPf.logradouro = "Rua de Casa";
    endPf.numero = 123;
    endPf.comercial = false;

//pessoa física
PessoaFisica novaPessoaFisica = new PessoaFisica();
    Console.WriteLine($"Digite o nome:");
    novaPessoaFisica.nome = Console.ReadLine();
    novaPessoaFisica.dataNascimento = "02/05/2004";
    novaPessoaFisica.endereco = endPf;
    novaPessoaFisica.rendimento = 1600f;
    novaPessoaFisica.cpf = "123456789-00";

//endereço de pessoa jurídica
Endereco endPj = new Endereco();
    endPj.logradouro = "Rua Niterói";
    endPj.numero = 180;
    endPj.comercial = true;

PessoaJuridica novaPessoaJuridica = new PessoaJuridica();  
    novaPessoaJuridica.nome = "Paulo Skaf";
    novaPessoaJuridica.endereco = endPj;
    novaPessoaJuridica.razaoSocial = "Serviço Nacional de Aprendizagem Industrial";
    // novaPessoaJuridica.cnpj = "70.469.056/0001-75";
    novaPessoaJuridica.cnpj = "70469056000175";
    novaPessoaJuridica.rendimento = 6000f;

    
// ********************** EXIBIÇÃO *************************    

Console.Clear();

//Exibindo dados da pessoa física
Console.WriteLine($"******* PESSOA FÍSICA *******");
Console.WriteLine();

Console.WriteLine(@$"
Nome: {novaPessoaFisica.nome}
Endereço: {novaPessoaFisica.endereco.logradouro}
Número: {novaPessoaFisica.endereco.numero}
Endereço Comercial: {novaPessoaFisica.endereco.comercial}
CPF: {novaPessoaFisica.cpf}
Data Nascimento: {novaPessoaFisica.dataNascimento}
Maior de Idade: {metodosPf.ValidarDataNascimento(novaPessoaFisica.dataNascimento)}
Rendimento: R$ {novaPessoaFisica.rendimento}
Rendimento Líquido: R$ {metodosPf.PagarImposto(novaPessoaFisica.rendimento)}
");

Console.WriteLine();

//Exibindo dados da pessoa jurídica
Console.WriteLine($"******* PESSOA JURÍDICA *******");
Console.WriteLine();

Console.WriteLine(@$"
Razão Social: {novaPessoaJuridica.razaoSocial}
CNPJ: {novaPessoaJuridica.cnpj}
Representante: {novaPessoaJuridica.nome}
Endereço: {novaPessoaJuridica.endereco.logradouro}
Número: {novaPessoaJuridica.endereco.numero}
Endereço Comercial: {novaPessoaJuridica.endereco.comercial}
CNPJ Válido? {metodosPj.ValidarCnpj(novaPessoaJuridica.cnpj)}
Rendimento: R$ {novaPessoaJuridica.rendimento}
Rendimento Líquido: R$ {metodosPj.PagarImposto(novaPessoaJuridica.rendimento)}
");


// *********************TESTES DE APRENDIZAGEM**************************


// *********************SUBSTRING**************************
//  0123456789...
// string nome = "Rogério Moreira da Silva";

// System.Console.WriteLine(nome.Length);
// System.Console.WriteLine(nome.Substring(8));
// System.Console.WriteLine(nome.Substring(0, 7));

// System.Console.WriteLine(nome.IndexOf("Moreira"));

// Console.WriteLine(@$"
//     Nome completo: {nome}
//     Sobrenome: {nome.Substring(nome.IndexOf("Moreira"))}
// ");


// ********************* REGEX ************************
// string data = "26/10/2022";
// bool dataValida = Regex.IsMatch(data, @"^\d{2}/\d{2}/\d{4}$");

// Console.WriteLine(dataValida);








