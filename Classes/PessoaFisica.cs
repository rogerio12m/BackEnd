using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.Interfaces;

namespace BackEnd.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string cpf { get; set; }
        public string dataNascimento { get; set; }

        // Para rendimentos até R$1.500,00 - isento(desconto 0)
        // Para rendimentos entre R$1.501,00 e R$5.000,00 - desconto de 3%
        // Para rendimentos acima de R$5.000,01 - desconto de 5%

        public override float PagarImposto(float parRendimento)
        {
            if (parRendimento <= 1500)
            {
                return parRendimento; //não tem desconto
            }
            else if (parRendimento >= 1501 && parRendimento <= 5000)
            {
                return parRendimento - (parRendimento / 100) * 3; //desconta 3% do rendimento
            }

            return parRendimento - (parRendimento / 100) * 5; //desconta 5% do rendimento

        }



        public bool ValidarDataNascimento(string parDtNasc)
        {

            DateTime dataConvertida;

            if (DateTime.TryParse(parDtNasc, out dataConvertida))
            {
                DateTime dataAtual = DateTime.Today;
                double anos = (dataAtual - dataConvertida).TotalDays / 365;
                // Console.WriteLine($"Data Convertida: {dataConvertida}");              
                // Console.WriteLine($"Data Atual: {dataAtual}");
                // Console.WriteLine($"Anos Convertidos: {anos}");

                if (anos >= 18)
                {
                    return true;
                }
            }

            return false;
        }

        public void PreencherDadosTeste()
        {
            Endereco endPf = new Endereco();
            endPf.logradouro = "Rua de casa";
            endPf.numero = 123;
            endPf.comercial = false;

            this.nome = "Rogério";
            this.cpf = "12345678900";
            this.dataNascimento = "02/05/2004";
            this.rendimento = 1929.98f;
            this.endereco = endPf;
        }

        public void Imprimir()
        {
             Console.WriteLine(@$"
Nome: {this.nome}
Endereço: {this.endereco.logradouro}
Número: {this.endereco.numero}
Endereço Comercial: {this.endereco.comercial}
CPF: {this.cpf}
Data Nascimento: {this.dataNascimento}
Maior de Idade: {this.ValidarDataNascimento(this.dataNascimento)}
Rendimento: R$ {this.rendimento}
Rendimento Líquido: R$ {this.PagarImposto(this.rendimento)}
");
        }
    }
}