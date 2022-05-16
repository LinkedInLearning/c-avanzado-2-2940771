using System;
using System.Threading;
using System.Threading.Tasks;

namespace Avanzado2_3
{
    class Program
    {
        static async Task Main()
        {
            await TareaFecha();
        }

        public static async Task TareaFecha()
        {
            var ta = Task.Run(() =>
            {
                var msj = $"Tarea antecedente: {Task.CurrentId}";
                Console.WriteLine(msj);
                return DateTime.Now;
            });

            await ta.ContinueWith(a =>
            {
                var msj = $"Tarea continuacion: {Task.CurrentId}";
                Console.WriteLine(msj);
            });
        }
    }
}
