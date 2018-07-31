using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clSalesIT.Base
{
    public class PessoaJuridica : Pessoa
    {
        public String CNPJ { get; set; }
        public String InscricaoEstadual { get; set; }
        public DateTime DataContratoSocial { get; set; }

        public override Double ObterIdade()
        {
            return (DateTime.Now.Date - DataContratoSocial.Date).TotalDays;
        }
    }

}
