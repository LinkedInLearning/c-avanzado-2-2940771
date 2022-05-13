using System;
using System.Threading;

namespace Avanzado2_3
{
    class Program
    {
        static void Main()
        {
            new Thread(ImprimeConteo).Start();
        }
        static void ImprimeConteo()
        {
            try
            {
                Console.WriteLine(Thread.CurrentThread.Name);
                Thread.Sleep(1000);
                for (int i = 100; i >= 0; --i)
                    Console.Write(i);
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static void ImprimeConteo(int inicio)
        {
            for (int i = inicio; i >= 0; --i)
                Console.Write(i);
        }

    }
}
