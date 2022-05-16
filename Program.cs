using System;
using System.Threading;
using System.Threading.Tasks;

namespace Avanzado2_3
{
    class Program
    {
        static void Main()
        {
            Task<string> tr = Task.Run(() =>
            {
                var msj = $"Tarea {Task.CurrentId} " +
               $"se ejecuta en el hilo {Thread.CurrentThread.ManagedThreadId}";

                return msj;
            });
            var imprime = tr.Result;
            if (tr.IsCompleted)
                Console.WriteLine(imprime);
        }
    }
}
