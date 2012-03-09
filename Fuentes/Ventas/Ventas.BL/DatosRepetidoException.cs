using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaDeNegocio
{
    public class DatosRepetidoException : Exception
    {
        public DatosRepetidoException()
            : base()
        {

        }

        public DatosRepetidoException(String message)
            : base(message)
        {

        }

        public DatosRepetidoException(String message, Exception excepcionAnidada)
            : base()
        {

        }
    }
}
