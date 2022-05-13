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

            var cursosFiltro = cursos.Where(c => c.Duracion <= 18000 && c.Titulo.Contains("C#"))
                .OrderBy(c => c.Nivel)
                .Select(c => new
                {
                    titulo = c.Titulo,
                    nivel = c.Nivel,
                    tiempo = c.Duracion
                });

            cursosFiltro.ToList().ForEach(c => Console.WriteLine("titulo {0}\n nivel {1}\n tiempo {2}\n", c.titulo, c.nivel, c.tiempo));
        }
      
    }
}
