using System;

namespace Avanzado2_2
{
    class Program
    {
        private enum Moneda
        {
            MXN,
            EUR,
            USD
        }
        static void Main()
        {
            decimal ConvertirMoneda(decimal cantidad, Moneda inicial, Moneda final) =>
                 (inicial, final) switch
                 {
                     (Moneda.EUR, Moneda.MXN) => (cantidad * 21.27m),
                     (Moneda.MXN, Moneda.EUR) => (cantidad * 0.047m),
                     _ => throw new Exception("Combinacion no definida")
                 };

            var total = ConvertirMoneda(500m, Moneda.MXN, Moneda.EUR);
            Console.WriteLine("total : " + total.ToString());
        }
    }
}
