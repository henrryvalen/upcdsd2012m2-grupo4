using System;

namespace CapaDeNegocio
{
    public class EntidadRepetidaException : Exception
    {
        public EntidadRepetidaException()
            : base()
        {
        }
        public EntidadRepetidaException(string mensaje)
            : base(mensaje)
        {
        }
        public EntidadRepetidaException(string mensaje, Exception excepcionAnidada)
            : base(mensaje, excepcionAnidada)
        {
        }
    }
}
