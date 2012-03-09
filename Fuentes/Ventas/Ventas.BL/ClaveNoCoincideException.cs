using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaDeNegocio
{
    public class ClaveNoCoincideException : Exception
    {
        public ClaveNoCoincideException()
            : base()
        {

        }

        public ClaveNoCoincideException(String message)
            : base(message)
        {

        }

        public ClaveNoCoincideException(String message, Exception excepcionAnidada)
            : base()
        {

        }
    }
}
