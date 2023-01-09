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
            long code = 4124242614081242;
            CartaDiCredito carta = new CartaDiCredito(code);
            Console.WriteLine("Metodo IsValid...");
            Console.WriteLine(carta.IsValid()); //va
            Console.WriteLine("Metodo GeneraNumeroValido...");
            Console.WriteLine(carta.GeneraNumeroValido()); //va
            Console.WriteLine("Metodo Confronta...");
            Console.WriteLine(carta.Confronta(0000000000000000));
            
        }
    }
}
