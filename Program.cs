using System;
using System.Collections.Generic;
using System.Linq;

namespace Avanzado2_1
{
    public enum Area
    {
        Programacion,
        CSharp,
        JavaScript,
        InteligenciaNegocios,
        CienciaDatos
    }
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
                    Area = Area.CSharp
                },
                new Curso
                {
                    Id = "ES-prog-002",
                    Titulo = "C# Avanzado 1",
                    Descripcion = "Sube tu nivel con C# avanzado 1",
                    Duracion = 10800,
                    Nivel = 2,
                    Area = Area.CSharp
                },
                new Curso
                {
                    Id = "ES-prog-003",
                    Titulo = "LINQ",
                    Descripcion = "Aprende LINQ de cero a experto",
                    Duracion = 18000,
                    Nivel = 2,
                    Area = Area.CSharp
                },
                new Curso
                {
                    Id = "ES-prog-004",
                    Titulo = "Bases de Programación",
                    Descripcion = "Aprende sobre algoritmos, estructuras de datos y lenguajes de programación",
                    Duracion = 21600,
                    Nivel = 1,
                    Area = Area.Programacion
                },
                new Curso
                {
                    Id = "EN-prog-020",
                    Titulo = "Secrets of Data Science",
                    Descripcion = "Learn the basics of  Data Science",
                    Duracion = 21600,
                    Nivel = 1,
                    Area = Area.CienciaDatos
                },
            };
            var instructores = new List<Instructor>()
            {
                new Instructor()
                {
                    Nombre = "Noemi Leon",
                    Bio = "Lider de proyectos desarrollo de software",
                    Area = Area.CSharp
                },
                new Instructor()
                {
                    Nombre = "Danielle Simpson",
                    Bio = "Lead Manager",
                    Area = Area.CienciaDatos
                },
                new Instructor()
                {
                    Nombre = "Cristina Santos",
                    Bio = "Profesora de Tiempo Completo en Universidad",
                    Area = Area.InteligenciaNegocios
                },
            };

            var cursosPorInstructor = cursos.Where(c => c.Id.Contains("prog"))
                .Join(instructores,
                    c => c.Area,
                    i => i.Area,
                    (c, i) => new
                    {
                        c.Id,
                        c.Titulo,
                        c.Nivel,
                        instructor = i.Nombre
                    }
                ).GroupBy(ci => ci.instructor);
        }
    }
}
