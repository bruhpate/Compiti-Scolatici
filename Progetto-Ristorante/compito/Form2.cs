using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compito
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string[] lista = new string[1000];
        string[] odioWindowsEMicrosoftEVisualStudio = new string[1000];
        private void Form2_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("./menu.txt"); ;
            string y = sr.ReadLine();
            int count = 0;
            while (y != null)
            {
                if (y.Split(';')[4] == "True")
                {
                    lista[count] = $"Nome: {y.Split(';')[0]}\tPrezzo: €{y.Split(';')[1]} \tIngredienti: {y.Split(';')[2]}\tPortata: {y.Split(';')[3]}";
                    listBox1.Items.Add(lista[count]);
                }
                y = sr.ReadLine();
                count++;
            }
            sr.Close();


            StreamReader sr1 = new StreamReader("./menu.txt"); ;
            y = "";
            count = 0;
            while (y != null)
            {
                y = sr1.ReadLine();
                if (y != null)
                {
                    if (y.Split(';')[4] == "True")
                    {
                        odioWindowsEMicrosoftEVisualStudio[count] = y;
                    }
                    count++;
                }
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = listBox1.SelectedItem.ToString();
            listBox2.Items.Add(x);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //sus
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            //sicao
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] w = new string[listBox2.Items.Count+1];
            for(int i = 0; i < listBox2.Items.Count; i++)
            {
                string x = listBox2.Items[i].ToString();
                for(int y =0;y < x.Length; y++)
                {
                    if (x[y] == '€')
                    {
                        for(int z = y; x[z] != ' '; z++)
                        {
                            w[i] += x[z];
                        }
                    }
                }
            }
            decimal[] PaoloCasablanca = new decimal[listBox2.Items.Count];
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                w[i] = w[i].Substring(1);
                PaoloCasablanca[i] = Convert.ToDecimal(w[i]);
            }
            label3.Text = "€" + Convert.ToString(PaoloCasablanca.Sum());
        }
    }
}
