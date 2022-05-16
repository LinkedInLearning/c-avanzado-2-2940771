using System;
using System.IO;

namespace Avanzado2_5
{
    class Program
    {
        static void Main()
        {
            var total = Divide(5, 2);
            Console.WriteLine(total);

            GuardarResultado(total.ToString());


        }
        static double Divide (int divisor, int dividendo)
        {
            var res = 0;
            try
            {
                res = divisor / dividendo;
            }catch(DivideByZeroException ex)
            {
                //guardar el error
                Console.WriteLine(ex);
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return res;
        }
        static void GuardarResultado(string resultado)
        {
            string ruta = @"C:\temporal55\resultadoB.txt";
            try
            {
                using (StreamWriter sw = File.AppendText(ruta))
                {
                    sw.WriteLine(resultado + "\n");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error leyendo archivo {0}. Mensaje = {1}",
                    ruta, e.Message);
            }
            finally
            {
                if (!File.Exists(ruta))
                {
                    using StreamWriter sw = File.CreateText(ruta);
                    File.AppendText($"Ha ocurrido un error, en {DateTime.Now}")
                }
            }
        }

    }
}
