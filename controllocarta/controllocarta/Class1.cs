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
        public CartaDiCredito()
        {

        }
        public CartaDiCredito (CartaDiCredito a) : this(a.numeroCarta)
        {

        }
        public CartaDiCredito Clone()
        {
            return new CartaDiCredito(this);
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
        public long GeneraNumeroValido()
        {
            long numeroCarta = 0;
            long backup = this.numeroCarta;
            this.numeroCarta = 1;
            while (!this.IsValid())
            {
                numeroCarta = (long)(new Random().NextDouble() * 10000000000000000);
                this.numeroCarta = numeroCarta;
            }
            this.numeroCarta = backup;
            return numeroCarta;
        }
        public int Confronta(long numeroCarta1)
        {
            int count = 0;
            for (int i = 0; i < 16; i++)
            {
                int cifra1 = (int)(numeroCarta1 % 10);
                int cifra2 = (int)(this.numeroCarta % 10);
                numeroCarta1 /= 10;
                this.numeroCarta /= 10;
                if (cifra1 == cifra2)
                {
                    count++;
                }
            }
            return count;
        }
        public string Stringa()
        {
            return Convert.ToString(this.numeroCarta);
        }
    }
}
