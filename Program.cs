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

            for(int i = 100; i >= 0; --i)
                Console.Write('X');
        }
        static void ImprimeConteo()
        {
            Console.WriteLine(Thread.CurrentThread.Name);
            for(int i=100; i>=0; --i)
            {
                Console.Write(i);
            }
        }
    }
}
