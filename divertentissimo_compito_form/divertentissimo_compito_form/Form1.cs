using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace divertentissimo_compito_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Scrittore scr = new Scrittore();
            scr.Utente = "suca";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class Scrittore
    {
        string _utente;
        string _testo;
        bool _b;
        bool _s;
        bool _i;
        Color _c;

        public string Utente
        {
            get { return _utente; }
            set { _utente = value; }
        }

        public bool b
        {
            get { return _b; }
            set { _b = value; }
        }

        public bool s
        {
            get { return _s; }
            set { _s = value; }
        }

        public bool i
        {
            get { return _i; }
            set { _i = value; }
        }

        public Color c
        {
            get { return _c; }
            set { _c = value; }
        }

    }

    public class Visualizzatore
    {
        bool _b;
        bool _s;
        bool _i;
        Color _c;

        
    }

}
