using System;

namespace Avanzado2_2
{
    class Program
    {
        public class Peticion
        {
            internal int Puerto { get; set; }
            internal string Metodo { get; set; }
            internal string TipoDeContenido { get; set; }
        }
        static void Main()
        {
            object miNombre = "Noemi";

            if (miNombre is string { Length: 5})
                Console.WriteLine("El nombre {0} tiene 5 caracteres",
                    (string)miNombre);

            bool ProcesarPeticion(Peticion pet) => pet switch
            {
                { TipoDeContenido: "image/*", Metodo: "GET" } => true,
                { Puerto: 8080, Metodo: string { Length: 2 } } => true,
                { TipoDeContenido: "image/*", Metodo: "POST" } when pet.Puerto.ToString().Length <= 4 => true,
                { Metodo: "PUT", Puerto: 3000, TipoDeContenido: string ct } => ct.EndsWith("*"),
                _ => false
            };
        }
    }
}
