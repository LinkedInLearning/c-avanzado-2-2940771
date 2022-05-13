using System;
using System.Threading;

namespace Avanzado2_3
{
    class Program
    {
        static void Main()
        {
            var e = new ManualResetEvent(false); //AutoResetEvent
            new Thread(() =>
            {
                Console.WriteLine("esperando..");
                e.WaitOne();
                e.Dispose();
                Console.WriteLine("signal recibida..");
            }).Start();
            Thread.Sleep(2000);
            e.Set();
            e.Reset();
        }
    }
}
