using System;
using POO_Static.classes;

namespace POO_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Conversor.DolarParaReal(4f));
            Console.WriteLine(Conversor.RealParaDolar(50f));

            Console.WriteLine(Math.Pow(2,4));

            Console.WriteLine(Conversor.EuroParaReal(4f));
            Console.WriteLine(Conversor.RealParaEuro(50f));

            Pedido p = new Pedido();
            p.Testar();
        }
    }
}
