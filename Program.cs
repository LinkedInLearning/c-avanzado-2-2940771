using System;
using System.Collections.Generic;
using System.Linq;

namespace Avanzado2_1
{
    class Program
    {
        static void Main()
        {
            List<Curso> cursos = new List<Curso>()
            {
                new Curso
                {
                    Id = "ES-prog-001",
                    Titulo = "C# Esencial",
                    Descripcion = "Aprende lo básico e indispensable de C#",
                    Duracion = 5400,
                    Nivel = 1,
                },
                new Curso
                {
                    Id = "ES-prog-002",
                    Titulo = "C# Avanzado 1",
                    Descripcion = "Sube tu nivel con C# avanzado 1",
                    Duracion = 10800,
                    Nivel = 2,
                },
                new Curso
                {
                    Id = "ES-prog-003",
                    Titulo = "LINQ",
                    Descripcion = "Aprende LINQ de cero a experto",
                    Duracion = 18000,
                    Nivel = 2,
                },
                new Curso
                {
                    Id = "ES-prog-004",
                    Titulo = "Bases de Programación",
                    Descripcion = "Aprende sobre algoritmos, estructuras de datos y lenguajes de programación",
                    Duracion = 21600,
                    Nivel = 1,
                },
                new Curso
                {
                    Id = "EN-prog-020",
                    Titulo = "Secrets of Data Science",
                    Descripcion = "Learn the basics of  Data Science",
                    Duracion = 21600,
                    Nivel = 1,
                },
            };

            var cursoCorto = cursos.OrderByDescending(c => c.Duracion).FirstOrDefault();
            Console.WriteLine("curso mas corto {0}, dura {1} ms ", cursoCorto.Titulo, cursoCorto.Duracion);

            var cursosGruposNivel = cursos.Where(c => c.Id.Contains("ES"))
                .Select(c => new
                {
                    c.Id,
                    c.Titulo,
                    grupoNivel = c.Nivel
                }).GroupBy(c => c.grupoNivel);

           
        }
      
    }
}
