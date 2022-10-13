using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Interfaces
{
    public interface IPessoaJuridica
    {
        bool ValidarCnpj(string parCnpj);
    }
}