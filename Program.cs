using BackEnd.Classes;

//endereço de pessoa física
Endereco endPf = new Endereco();
    endPf.logradouro = "Rua de Casa";
    endPf.numero = 123;
    endPf.comercial = false;

//pessoa física
PessoaFisica novaPessoaFisica = new PessoaFisica();

    novaPessoaFisica.nome = "Rogério";
    novaPessoaFisica.endereco = endPf;
    novaPessoaFisica.rendimento = 1000f;
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
    novaPessoaJuridica.cnpj = "70.469.056/0001-75";
    novaPessoaJuridica.rendimento = 100000f;

Console.Clear();

//Exibindo dados da pessoa física
Console.WriteLine($"******* PESSOA FÍSICA *******");
Console.WriteLine();

Console.WriteLine($"Nome: {novaPessoaFisica.nome}");
Console.WriteLine($"Endereço: {novaPessoaFisica.endereco.logradouro}");
Console.WriteLine($"Número: {novaPessoaFisica.endereco.numero}");
Console.WriteLine($"Endereço Comercial: {novaPessoaFisica.endereco.comercial}");
Console.WriteLine($"CPF: {novaPessoaFisica.cpf}");
Console.WriteLine($"Rendimento: R$ {novaPessoaFisica.rendimento}");
Console.WriteLine("Maior de Idade:" + novaPessoaFisica.ValidarDataNascimento("02/05/2004"));

//Exibindo dados da pessoa jurídica
// Console.WriteLine($"******* PESSOA JURÍDICA *******");
// Console.WriteLine();

// Console.WriteLine($"Razão Social: {novaPessoaJuridica.razaoSocial}");
// Console.WriteLine($"CNPJ: {novaPessoaJuridica.cnpj}");
// Console.WriteLine($"Representante: {novaPessoaJuridica.nome}");
// Console.WriteLine($"Endereço: {novaPessoaJuridica.endereco.logradouro}");
// Console.WriteLine($"Número: {novaPessoaJuridica.endereco.numero}");
// Console.WriteLine($"Endereço Comercial: {novaPessoaJuridica.endereco.comercial}");
// Console.WriteLine($"Rendimento: R$ {novaPessoaJuridica.rendimento}");






