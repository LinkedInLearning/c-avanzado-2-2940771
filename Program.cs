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
            var paisesLargos = paisesUE.Where(p => p.Length > 6).OrderBy(p => p);
            Imprimir("paises en orden", paisesLargos);

            var paisMasLargo = paisesUE.Where(p => p.Length > 6).OrderByDescending(p => p.Length).First();
            Console.WriteLine("pais mas largo");
            Console.WriteLine(paisMasLargo);

            var paisesLargosB =
                from p in paisesUE
                where p.Length > 6
                orderby p
                select p;
            Imprimir("paises en orden - consulta", paisesLargosB);


        }
        static void Imprimir(string titulo, IEnumerable<string> ie)
        {
            Console.WriteLine(titulo);
            ie.ToList().ForEach(p => Console.WriteLine(p));
        }
    }
}
