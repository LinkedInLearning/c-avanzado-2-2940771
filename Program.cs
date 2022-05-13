using System;
using System.Collections.Generic;
using System.Linq;

namespace Avanzado2_1
{
    class Program
    {
        static void Main()
        {
            var paisesUE = new List<string>() { "España", "Austria", "Italia", "Alemania", "Dinamarca", "Suecia", "Finlandia" };
            var paisesUEL = new List<string>();
            foreach(var p in paisesUE)
            {
                if (p.Length > 6)
                    paisesUEL.Add(p);
            }

            var paisesUELLinq = paisesUE.Where(p => p.Length > 6);
            Console.WriteLine("sintaxis métodos");
            paisesUELLinq.ToList().ForEach(p => Console.WriteLine(p));

            var paisesUELinqB =
                from p in paisesUE
                where p.Length > 6
                select p;
            Console.WriteLine("sintaxis consultas");
            paisesUELinqB.ToList().ForEach(p => Console.WriteLine(p));
        }
    }
}
