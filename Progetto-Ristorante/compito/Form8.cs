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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr1 = new StreamReader("./menu.txt");
            string stampatutto = null;
            string y = "";
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
                        string sep = ";";
                        stampatutto += y.Split(';')[0] + sep + y.Split(';')[1] + sep + y.Split(';')[2] + sep + y.Split(';')[3] + sep + "True" + "\n";
                    }
                }
            }
            sr1.Close();
            File.WriteAllText("./menu.txt", stampatutto);
            this.Close();
        }
    }
}
