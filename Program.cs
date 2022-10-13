using BackEnd.Classes;

PessoaFisica novaPessoaFisica = new PessoaFisica();

novaPessoaFisica.nome = "Rogério";
novaPessoaFisica.endereco = "Rua de Casa 123";
novaPessoaFisica.rendimento = 1000f;
novaPessoaFisica.cpf = "123456789-00";

Console.WriteLine($"Nome: {novaPessoaFisica.nome}");
Console.WriteLine($"Endereço: {novaPessoaFisica.endereco}");
Console.WriteLine($"CPF: {novaPessoaFisica.cpf}");
Console.WriteLine($"Rendimento: {novaPessoaFisica.rendimento}");




