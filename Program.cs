using System;

namespace Avanzado2_5
{
    class Program
    {
        static void Main()
        {
            var total = Divide(5, 0);
            Console.WriteLine(total);
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

    }
}
