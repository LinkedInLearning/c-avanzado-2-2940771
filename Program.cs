using System;

namespace Avanzado2_2
{
    class Program
    {
        static void Main()
        {
            object miNombre = 22;
            if (miNombre is string)
                Console.WriteLine("El nombre {0} tiene {1} caracteres",
                    (string)miNombre, ((string)miNombre).Length);

            if (miNombre is string mn)
                Console.WriteLine("El nombre {0} tiene {1} caracteres",
                    mn, mn.Length);

        }
    }
}
