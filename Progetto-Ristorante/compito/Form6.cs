using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compito
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("./menu.txt");
            string x = textBox1.Text;
            string n = null;
            string y = sr.ReadLine();
            while (y != null)
            {
                if (x == y.Split(';')[0])
                {
                    if(checkBox1.Checked == true)
                    {
                        n += textBox2.Text;
                    }
                    else
                    {
                        n += y.Split(';')[0];
                    }
                    n += ";";
                    if (checkBox2.Checked == true)
                    {
                        n += textBox3.Text;
                    }
                    else
                    {
                        n += y.Split(';')[1];
                    }
                    n += ";";
                    if (checkBox3.Checked == true)
                    {
                        n += textBox4.Text;
                    }
                    else
                    {
                        n += y.Split(';')[2];
                    }
                    n += ";";
                    if (checkBox4.Checked == true)
                    {
                        n += textBox5.Text;
                    }
                    else
                    {
                        n += y.Split(';')[3];
                    }
                    n += ";" + y.Split(';')[4];
                    
                }
                y = sr.ReadLine();
            }
            sr.Close();

            StreamReader sr1 = new StreamReader("./menu.txt");
            string stampatutto = null;
            y = "";
            while (y != null)
            {
                y = sr1.ReadLine();
                if (y != null)
                {
                    string z = y;
                    if (y.Split(';')[0] != textBox1.Text)
                    {
                        stampatutto += z;
                        stampatutto += "\n";
                    }
                    else
                    {
                        stampatutto += n;
                        stampatutto += "\n";
                    }
                }
            }
            sr1.Close();
            StreamWriter sw2 = new StreamWriter("./menu.txt");
            sw2.Write(stampatutto);
            sw2.Close();
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
        }
    }
}
