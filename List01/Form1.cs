using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> list = new List<int>();

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            
            int n = int.Parse(textBox1.Text);

            for (int i = 0; i < n; i++)
            {
                list.Add(rnd.Next(-5, 11));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
           
            foreach (int cis in list)
            {
                listBox1.Items.Add(cis);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int min = Int32.MaxValue;
            int max = Int32.MinValue;
           
            if(radioButton1.Checked)
            {

                for (int i = 0; i < list.Count(); i++)
                {
                    int x = list[i];
                    if (x > max)
                    {
                        max = x;
                  

                    }
                    if(x < min)
                    {
                        min = x;
                       
                    }

                }

                int posledniMax = list.LastIndexOf(max);
                list.Remove(posledniMax);
                    
               
            }

            else
            {
                int posledniMin = list.LastIndexOf(min);
                list.Remove(posledniMin);


            }
        }
    }
}
