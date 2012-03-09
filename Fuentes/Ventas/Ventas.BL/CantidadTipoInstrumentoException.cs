using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaDeNegocio
{
    public class CantidadTipoInstrumentoException:Exception
    {
        public CantidadTipoInstrumentoException() : base()
        {
        
        }

        public CantidadTipoInstrumentoException(String message)
            : base(message)
        {

        }

        public CantidadTipoInstrumentoException(String message, Exception excepcionAnidada)
            : base()
        {

        }
    }
}
