using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaDeNegocio
{
    public class DatosInsuficientesException : Exception
    {
        public DatosInsuficientesException() : base()
        {
        
        }

        public DatosInsuficientesException(String message)
            : base(message)
        {

        }

        public DatosInsuficientesException(String message, Exception excepcionAnidada)
            : base()
        {

        }

    }
}
