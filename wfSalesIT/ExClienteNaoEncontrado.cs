using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfSalesIT.Excepcoes
{
    public class ExClienteNaoEncontrado : Exception
    {
        public ExClienteNaoEncontrado(String pMensagem)
            : base(pMensagem)
        {
            
        }

    }
}
