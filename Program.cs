using BackEnd.Classes;
using System.Text.RegularExpressions;

Console.Clear();
Console.WriteLine(@$"
============================================
|    Bem vindo ao sistema de cadastro de   |
|        Pessoa Física e Jurídica          |
============================================
");

Utils.BarraCarregamento("Carregando");

string opcao;

// métodos dos objetos
PessoaFisica metodosPf = new PessoaFisica();
PessoaJuridica metodosPj = new PessoaJuridica();

// Começo dowhile

do
{

    Console.Clear();
    Console.WriteLine(@$"
=======================================
|    Escolha uma das opções abaixo    |
|-------------------------------------|
|        1 - Pessoa Física            |
|        2 - Pessoa Jurídica          |
|                                     |
|        0 - Sair                     |
=======================================
");

    Console.Write("Opção: ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1": // Pessoa Física 

            List<PessoaFisica> cadastroPf = new List<PessoaFisica>(); // Lista de PessoaFisica
            string opcaoPf;

            // Menu de Pessoa Física

            do
            {

                Console.Clear();
                Console.WriteLine(@$"
===========================================
|      Escolha uma das opções abaixo      |
|-----------------------------------------|
|       1 - Cadastrar Pessoa Física       |
|       2 - Listar Pessoa Física          |
|                                         |
|       0 - Voltar ao menu anterior       |
===========================================
");
                Console.Write("Escolha uma opção: ");
                opcaoPf = Console.ReadLine();

                switch (opcaoPf)
                {
                    case "1": // Cadastrar Pessoa Física

                        // ********************** CADASTRO *************************

                        //endereço de pessoa física
                        // Endereco endPf = new Endereco();
                        // Console.WriteLine($"Qual é o endereço?");
                        // endPf.logradouro = Console.ReadLine();
                        // Console.WriteLine("Qual é o número?");
                        // endPf.numero = int.Parse(Console.ReadLine());
                        // Console.WriteLine($"Endereço é comercial? S/N");
                        // string enderecoComercial = Console.ReadLine();

                        // if (enderecoComercial.ToUpper() == "S")
                        // {
                        //     endPf.comercial = true;
                        // }
                        // else
                        // {
                        //     endPf.comercial = false;
                        // }

                        //pessoa física
                        PessoaFisica novaPessoaFisica = new PessoaFisica();
                        novaPessoaFisica.PreencherDadosTeste();

                        //Cadastrar no TXT

                        using (StreamWriter arquivo = new StreamWriter($"./DadosPf/Rogerio.txt", append: true))
                        {
                            arquivo.WriteLine(@$"
Nome: {novaPessoaFisica.nome},
Endereço: {novaPessoaFisica.endereco.logradouro},
Número: {novaPessoaFisica.endereco.numero},
Endereço Comercial: {novaPessoaFisica.endereco.comercial},
CPF: {novaPessoaFisica.cpf},
Data Nascimento: {novaPessoaFisica.dataNascimento},
Maior de Idade: {metodosPf.ValidarDataNascimento(novaPessoaFisica.dataNascimento)},
Rendimento: R$ {novaPessoaFisica.rendimento},
Rendimento Líquido: R$ {metodosPf.PagarImposto(novaPessoaFisica.rendimento)}
                            ");
                            arquivo.Close();
                        }


                        // Console.WriteLine($"Digite o nome: ");
                        // novaPessoaFisica.nome = Console.ReadLine();
                        // Console.WriteLine($"Digite a data de nascimento - Ex: 20/09/1990");
                        // novaPessoaFisica.dataNascimento = Console.ReadLine();
                        // novaPessoaFisica.endereco = endPf;
                        // Console.WriteLine($"Informe seu rendimento: ");
                        // novaPessoaFisica.rendimento = float.Parse(Console.ReadLine());
                        // Console.WriteLine($"Informe seu CPF: ");
                        // novaPessoaFisica.cpf = Console.ReadLine();

                        cadastroPf.Add(novaPessoaFisica);

                        Utils.ParadaNoConsole("Pessoa Física cadastrada com sucesso!");
                        break;

                    case "2": // Listar Pessoa Física

                        // ********************** EXIBIÇÃO *************************

                        Console.WriteLine($"******* LISTAGEM DE PESSOA FÍSICA *******");

                        using (StreamReader arquivo = new StreamReader($"./DadosPf/Rogerio.txt"))
                        {
                            string linha;

                            while ((linha = arquivo.ReadLine()) != null)
                            {
                                Console.WriteLine($"{linha}");

                            }
                        }

                        Utils.ParadaNoConsole("Fim da listagem!");

                        // if (cadastroPf.Count > 0)
                        // {
                        //     foreach (var pf in cadastroPf)
                        //     {

                        //         Console.Clear();

                        //         //Exibindo dados da pessoa física         

                        //         //                                 Console.WriteLine(@$"
                        //         // Nome: {pf.nome}
                        //         // Endereço: {pf.endereco.logradouro}
                        //         // Número: {pf.endereco.numero}
                        //         // Endereço Comercial: {pf.endereco.comercial}
                        //         // CPF: {pf.cpf}
                        //         // Data Nascimento: {pf.dataNascimento}
                        //         // Maior de Idade: {metodosPf.ValidarDataNascimento(pf.dataNascimento)}
                        //         // Rendimento: R$ {pf.rendimento}
                        //         // Rendimento Líquido: R$ {metodosPf.PagarImposto(pf.rendimento)}
                        //         // ");
                        //         //pf.Imprimir();
                        //     }

                        // }
                        // else
                        // {
                        //     Utils.ParadaNoConsole("Lista Vazia!");
                        // }

                        break;

                    case "0": // Voltar ao menu principal
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opção inválida, por favor digite outra opção!");
                        Console.ResetColor();
                        Thread.Sleep(3000);
                        break;
                }

            } while (opcaoPf != "0");

            break;

        case "2": // Pessoa Jurídica 

            List<PessoaJuridica> cadastroPj = new List<PessoaJuridica>(); // Lista de PessoaJuridica
            string opcaoPj;

            // Menu de Pessoa Jurídica
            do
            {

                Console.Clear();
                Console.WriteLine(@$"
===========================================
|      Escolha uma das opções abaixo      |
|-----------------------------------------|
|       1 - Cadastrar Pessoa Jurídica     |
|       2 - Listar Pessoa Jurídica        |
|                                         |
|       0 - Voltar ao menu anterior       |
===========================================
");
                Console.Write("Escolha uma opção: ");
                opcaoPj = Console.ReadLine();

                switch (opcaoPj)
                {
                    case "1": // cadastrar pessoa jurídica

                        // ********************** CADASTRO *************************

                        // //endereço de pessoa jurídica
                        // Endereco endPj = new Endereco();
                        // endPj.logradouro = "Rua Niterói";
                        // endPj.numero = 180;
                        // endPj.comercial = true;

                        // PessoaJuridica novaPessoaJuridica = new PessoaJuridica();
                        // novaPessoaJuridica.nome = "Paulo Skaf";
                        // novaPessoaJuridica.endereco = endPj;
                        // novaPessoaJuridica.razaoSocial = "Serviço Nacional de Aprendizagem Industrial";
                        // // novaPessoaJuridica.cnpj = "70.469.056/0001-75";
                        // novaPessoaJuridica.cnpj = "70469056000175";
                        // novaPessoaJuridica.rendimento = 6000f;

                        // Pessoa Jurídica
                        PessoaJuridica novaPessoaJuridica = new PessoaJuridica();
                        novaPessoaJuridica.PreencherDadosTeste();

                        using (StreamWriter arquivo = new StreamWriter($"./DadosPj/Senai.txt", append: true))
                        {
                            arquivo.WriteLine(@$"
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
                            arquivo.Close();
                        }

                        cadastroPj.Add(novaPessoaJuridica);

                        Utils.ParadaNoConsole("Pessoa Jurídica cadastrada com sucesso!");

                        break;

                    case "2":

                        // ********************** EXIBIÇÃO *************************

                        //Exibindo dados da pessoa jurídica
                        Console.Clear();
                        Console.WriteLine($"******* LISTAGEM DE PESSOA JURÍDICA *******");

                        using (StreamReader arquivo = new StreamReader($"./DadosPj/Senai.txt"))
                        {
                            string linha;

                            while ((linha = arquivo.ReadLine()) != null)
                            {
                                Console.WriteLine($"{linha}");

                            }
                        }

                        Utils.ParadaNoConsole("Fim da listagem");

//                         foreach (var Pj in cadastroPj)
//                         {
//                             Console.WriteLine(@$"
// Razão Social: {Pj.razaoSocial}
// CNPJ: {Pj.cnpj}
// Representante: {Pj.nome}
// Endereço: {Pj.endereco.logradouro}
// Número: {Pj.endereco.numero}
// Endereço Comercial: {Pj.endereco.comercial}
// CNPJ Válido? {metodosPj.ValidarCnpj(Pj.cnpj)}
// Rendimento: R$ {Pj.rendimento}
// Rendimento Líquido: R$ {metodosPj.PagarImposto(Pj.rendimento)}
// ");

//                         }

                        break;

                    case "0": // Voltar ao menu principal
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opção inválida, por favor digite outra opção!");
                        Console.ResetColor();
                        Thread.Sleep(3000);
                        break;
                }

            } while (opcaoPj != "0");



            break;

        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar nosso sistema!");

            Utils.BarraCarregamento("Finalizando");

            break;

        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Opção inválida, por favor digite outra opção!");
            Console.ResetColor();
            Thread.Sleep(3000);

            break;
    }

} while (opcao != "0");



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








