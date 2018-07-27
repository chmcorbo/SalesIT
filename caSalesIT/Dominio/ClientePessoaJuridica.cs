using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using caSalesIT.Base;


namespace caSalesIT.Dominio
{
    class ClientePessoaJuridica : PessoaJuridica
    {
        public Int32 Codigo { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
