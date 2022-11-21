using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio_ecommerce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Carrello[] carrello = new Carrello[10];
            Prodotto calzini = new Prodotto("1", "calzini", 7.50, "adidas", "fresh");
        }
    }

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

    public class Prodotto
    {
        private string _id;
        public string Id { get { return _id; } set { _id = value; } }

        private string _name;
        public string Name { get { return _name; } set { _name = value; } }

        private double _price;
        public double Price { get { return _price; } set { _price = value; } }

        private string _produttore;
        public string Produttore { get { return _produttore; } set { _produttore = value; } }

        private string _descrizione;
        public string Descrizione { get { return _descrizione; } set { _descrizione = value; } }

        public Prodotto(string ID, string NOME, double PREZZO, string PRODUTTORE, string DESCRIZIONE)
        {
            _id = ID;
            _name = NOME;
            _price = PREZZO;
            _produttore = PRODUTTORE;
            _descrizione = DESCRIZIONE;
        }



    }
}
