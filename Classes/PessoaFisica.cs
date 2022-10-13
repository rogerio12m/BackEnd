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
        public DateTime dataNascimento { get; set; }

        public bool ValidarDataNascimento(string parDtNasc)
        {
            throw new NotImplementedException();
        }
    }
}