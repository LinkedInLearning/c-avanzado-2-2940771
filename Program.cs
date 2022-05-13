using System;
using System.Threading;

namespace Avanzado2_3
{
    class Program
    {
        static void Main()
        {
            Thread t = new Thread(ImprimeConteo);
            t.Name = "CONTEO";
            t.Start();
            //var termino = t.Join(1000);

            Console.WriteLine("fin hilo principal");
        }
        static void ImprimeConteo()
        {
            Console.WriteLine(Thread.CurrentThread.Name);
            Thread.Sleep(1000);
            for(int i=100; i>=0; --i)
                Console.Write(i);
            
        }
    }
}
