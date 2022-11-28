using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        List<char> pismena = new List<char>();

        private void button1_Click(object sender, EventArgs e)
        {
            pismena.Clear();
            //vyrobí list charů
          
            for(int i = 0; i < textBox1.Text.Length; i++)
            {
                char znak = textBox1.Text[i];
                pismena.Add(znak);
            }


            //kontrolni zobrazeni
            listBox1.Items.Clear();
            // *** cyklem foreach ***
            foreach (char znak in pismena)
            {
                listBox1.Items.Add(znak);
            }
            // konec kontrolního zobrazení




            //zpristupni tlacitka
            foreach (Control control in this.Controls)
            {
                if(control is Button)
                {
                    control.Enabled = true;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(button2.Text);

            MessageBox.Show((sender as Button).Text);
            (sender as Button).Enabled = false;

            for(int i = 0; i < pismena.Count;i++)
            {
                if (pismena[i] == char.Parse((sender as Button).Text))
                {
                    pismena.RemoveAt(i);
                }
            }
            Vypis();
        }

        private void Vypis()
        {
            textBox1.Text = String.Empty;
            foreach( char znak in pismena)
            {
                textBox1.Text += znak;
            }
        }
    }
}
