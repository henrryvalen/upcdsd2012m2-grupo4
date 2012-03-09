using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaDeNegocio
{
    public class DescripcionRepetidaException : Exception
    {
        public DescripcionRepetidaException()
            : base()
        {
        }
        public DescripcionRepetidaException(string mensaje)
            : base(mensaje)
        {
        }
        public DescripcionRepetidaException(string mensaje, Exception excepcionAnidada)
            : base(mensaje, excepcionAnidada)
        {
        }
    }
}
