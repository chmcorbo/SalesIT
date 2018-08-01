using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clSalesIT.Base;


namespace clSalesIT.Model
{
    public class ClientePessoaJuridica : PessoaJuridica
    {
        public Int32 Codigo { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
