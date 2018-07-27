using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace caSalesIT.Base
{
    class Pessoa : ICloneable
    {
        public String Nome { get;  set; }
        public String Endereco { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
        

        public virtual Double ObterIdade()
        {
            throw new NotImplementedException();
        }


        public object Clone()
        {
            return (Pessoa)this.MemberwiseClone();
        }

        
    }
}
