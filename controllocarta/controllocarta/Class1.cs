using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controllocarta
{
    public class CartaDiCredito
    {
        private long numeroCarta;

        public CartaDiCredito(long numeroCarta)
        {
            this.numeroCarta = numeroCarta;
        }

        public bool IsValid()
        {
            int somma = 0;
            for (int i = 0; i < 16; i++)
            {
                int cifra = (int)(numeroCarta % 10);
                numeroCarta /= 10;
                if (i % 2 == 0)
                {
                    cifra *= 2;
                    if (cifra > 9)
                    {
                        cifra = cifra / 10 + cifra % 10;
                    }
                }
                somma += cifra;
            }
            return somma % 10 == 0;
        }

        public long Generate()
        {
            Random random = new Random();
            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine(random.Next(0, 10));
            }
            return numeroCarta;
        }
    }

}
