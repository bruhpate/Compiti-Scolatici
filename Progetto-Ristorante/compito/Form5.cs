using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compito
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("./menu.txt");
            string x = textBox1.Text;
            string y = sr.ReadLine();
            while(y != null)
            {
                string nome = y.Split(';')[0];
                if(nome == x && y.Split(';')[4] == "True")
                {
                    string n = $"Nome: {y.Split(';')[0]}\nPrezzo: {y.Split(';')[1]}\nIngredienti: {y.Split(';')[2]}\nPortata: {y.Split(';')[3]}";
                    MessageBox.Show(n);
                }
                y = sr.ReadLine();
            }
            sr.Close();
            
        }
    }
}
