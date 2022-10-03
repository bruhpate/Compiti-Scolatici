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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace compito
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Visible = false;
            form3.ShowDialog();
            this.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Visible = false;
            form5.ShowDialog();
            this.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("./menu.txt");;
            string y = sr.ReadLine();
            string stampa= null;
            while (y != null)
            {
                if(y.Split(';')[4] == "True")
                {
                    string n = $"Nome: {y.Split(';')[0]}\nPrezzo: {y.Split(';')[1]}\nIngredienti: {y.Split(';')[2]}\nPortata: {y.Split(';')[3]}";
                    stampa += n + "\n\n";
                }
                y = sr.ReadLine();
            }
            MessageBox.Show(stampa);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            this.Visible = false;
            form6.ShowDialog();
            this.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            this.Visible = false;
            form7.ShowDialog();
            this.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 form7 = new Form8();
            this.Visible = false;
            form7.ShowDialog();
            this.Visible = true;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
