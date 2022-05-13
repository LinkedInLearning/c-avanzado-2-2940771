using System;
using System.Threading;
using System.Threading.Tasks;

namespace Avanzado2_3
{
    class Program
    {
        static void Main()
        {
            //RUN
            var tr = Task.Run(() =>
            {
                Console.WriteLine("Tarea {0} se ejecuta en el hilo {1}",
                    Task.CurrentId, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(2000);
            });
            if (!tr.IsCompleted)
                tr.Wait();

            bool iniciarTarea = true;
            //Start
            var ts = new Task(() =>
            {
                Console.WriteLine("Tarea {0} se ejecuta en el hilo {1}",
                    Task.CurrentId, Thread.CurrentThread.ManagedThreadId);
            });
            if (iniciarTarea)
                ts.Start();

            //verificar estado
            if (ts.Status == TaskStatus.Running || ts.Status == TaskStatus.WaitingToRun)
                ts.Wait();

        }
    }
}
