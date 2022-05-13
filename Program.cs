using System;
using System.ComponentModel;
using System.Reflection;

namespace Avanzado2_2
{
    class Program
    {
        static void Main()
        {
            var s = Suma(5, 5);
        }
        [DatosDesarrollo("3A")]
        static int Suma(int A, int B)
        {
            MethodBase metodo = MethodBase.GetCurrentMethod();
            DatosDesarrolloAttribute attr = (DatosDesarrolloAttribute)metodo.
                GetCustomAttributes(typeof(DatosDesarrolloAttribute), true)[0];
            return A + B;
        }
    }
}
