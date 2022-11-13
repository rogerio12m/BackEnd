using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.Interfaces;
using System.Text.RegularExpressions;

namespace BackEnd.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string razaoSocial { get; set; }
        public string cnpj { get; set; }

        public bool ValidarCnpj(string parCnpj)
        {
            // 04.419.296/0001-30 - 18
            // 04419296000130 - 14

            if (Regex.IsMatch(parCnpj, @"^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$"))
            {
                // valida se tem o mil contra 0001
                if ( parCnpj.Length == 18 )
                {
                    if (parCnpj.Substring(11, 4) == "0001")
                    {
                        return true;
                    }
                } 
                else if( parCnpj.Length == 14)
                {
                    if (parCnpj.Substring(8, 4) == "0001")
                    {
                        return true;
                    }
                }

            }

            return false; 
        }
    }
}