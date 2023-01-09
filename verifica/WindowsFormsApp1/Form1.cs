using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verifica
{
    public partial class Form1 : Form
    {
        Verifica v = new Verifica();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Aggiunta(object sender, EventArgs e)
        {
            try
            {
                v.Aggiunta(comboBox1.SelectedItem.ToString(), numericUpDown1.Value, textBox1.Text);
                MessageBox.Show("Verifica n° " + v.Counter + " aggiunta con successo:\n" + "Materia: " + comboBox1.SelectedItem.ToString() + "\n" + "Valutazione: " + numericUpDown1.Value + "\nData: " + textBox1.Text);
            }
            catch(Exception ex) { throw new Exception(ex.ToString()); }


        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Visualizzazione(object sender, EventArgs e)
        {
            for(int i = 0; i < v.Maxlenght; i++)
                listView1.Items.Add(v.Stringa(i));
                //boh da errora ma funziona se aggiungo
        }

        private void Media(object sender, EventArgs e)
        {
            label4.Text = v.Media(comboBox1.SelectedItem.ToString()).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt16(numericUpDown3.Value);
            try
            {
                comboBox3.SelectedItem = v.ModificaMateria(n);
                comboBox3.Enabled = true;
                textBox2.Text = v.ModificaData(n);
                textBox2.Enabled = true;
                numericUpDown2.Value = v.ModificaVoto(n);
                numericUpDown2.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            v.ImpostaMateria(comboBox3.SelectedItem.ToString(), Convert.ToInt16(numericUpDown3.Value));
            v.ImpostaData(textBox2.Text, Convert.ToInt16(numericUpDown3.Value));
            v.ImpostaVoto(numericUpDown2.Value, Convert.ToInt16(numericUpDown3.Value));
            numericUpDown2.Enabled = false;
            button5.Enabled = false;
            textBox2.Enabled = false;
            comboBox3.Enabled = false;
            button6.Enabled = false;
        }

        private void uela(object sender, EventArgs e)
        {
//spazzatura 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (v.EliminaVoto(Convert.ToInt16(numericUpDown3.Value)) == true)
            {
                MessageBox.Show("Voto eliminato");
            }
            numericUpDown2.Enabled = false;
            button5.Enabled = false;
            textBox2.Enabled = false;
            comboBox3.Enabled = false;
            button6.Enabled = false;
        }
    }
}