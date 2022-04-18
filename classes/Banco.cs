using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBank.classes
{
       public abstract  class Banco
    {
        public Banco()
        {
            this.NomeBanco = "DigitalBank";
            this.CodigoBanco = "4568";
        }

        public string NomeBanco { get;  private set; }
        public string CodigoBanco { get; private set; }
    }
}
