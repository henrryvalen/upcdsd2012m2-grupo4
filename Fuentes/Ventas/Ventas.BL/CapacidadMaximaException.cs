using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//jose
namespace CapaDeNegocio
{
    public class CapacidadMaximaException : Exception
    {
        public CapacidadMaximaException()
            : base()
        {

        }

        public CapacidadMaximaException(String message)
            : base(message)
        {

        }

        public CapacidadMaximaException(String message, Exception excepcionAnidada)
            : base()
        {

        }
    }
}
