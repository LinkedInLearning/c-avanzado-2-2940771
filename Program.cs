using System;
using System.Threading;

namespace Avanzado2_3
{
    class Program
    {
        static void Main()
        {
            Thread tx = new Thread(ImprimeConteoX);
            tx.Priority = ThreadPriority.Highest;

            Thread to = new Thread(ImprimeConteoO);
            to.Priority = ThreadPriority.Lowest;

            tx.Start();
            to.Start();
        }
        static void ImprimeConteoX()
        {
            for (int i = 1000; i >= 0; --i)
                Console.Write("X");
            Console.WriteLine("\nFIN CONTEO X\n");
        }
        static void ImprimeConteoO()
        {
            for (int i = 1000; i >= 0; --i)
                Console.Write("O");
            Console.WriteLine("\nFIN CONTEO O\n");
        }

    }
}
