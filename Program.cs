using System;
using System.ComponentModel;

namespace Avanzado2_2
{
    class Program
    {
        [Obsolete]
        [Description]
        public class Peticion
        {
            internal int Puerto { get; set; }
            internal string Metodo { get; set; }
            internal string TipoDeContenido { get; set; }
        }
        static void Main()
        {
            
        }
    }
}
