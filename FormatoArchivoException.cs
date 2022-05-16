using System;
using System.Collections.Generic;
using System.Text;

namespace Avanzado2_5
{
    class FormatoArchivoException : Exception
    {
        public FormatoArchivoException() { }
        public FormatoArchivoException(string mensaje)
            : base(String.Format("Formato de archivo incorrecto {0}", mensaje)) { }
    }
}
