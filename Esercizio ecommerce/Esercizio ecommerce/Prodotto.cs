using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_ecommerce
{
    public class Carrello
    {
        private string _id;
        public string Id { get { return _id; } set { _id = value; } }

        public Carrello(string id)
        {
            Id = id;
        }

        public void Aggiungi(Prodotto p)
        {

        }
    }
}
