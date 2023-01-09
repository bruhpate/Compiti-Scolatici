using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controllocarta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long code = 4716435917330099;
            CartaDiCredito carta = new CartaDiCredito(code);
            Console.WriteLine(carta.IsValid());
            carta.Generate();
        }
    }
}
