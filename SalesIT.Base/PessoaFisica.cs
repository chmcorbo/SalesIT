using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clSalesIT.Base
{
    public class PessoaFisica : Pessoa
    {
        public String CPF { get; set; }
        public string RG { get; set; }
        public DateTime Data_Nascimento { get; set; }

        public virtual Double ObterIdade()
        {
            return (DateTime.Now.Date-Data_Nascimento.Date).TotalDays;
        }
    }
}
