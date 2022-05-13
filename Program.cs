using System;
using System.ComponentModel;

namespace Avanzado2_2
{
    class Program
    {
        static void Main()
        {
            var s = Suma(5, 5);
        }

        [Obsolete("Metodo obsoleto. Usar metodo Add en su lugar", false)]
        [Description("Suma los valores de los argumentos")]
        static int Suma(int A, int B)
        {
            return A + B;
        }
    }
}
