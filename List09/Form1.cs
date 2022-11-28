using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Bitmap> obrazky = new List<Bitmap>();
        int index;




        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(Bitmap obrazek in imageList1.Images)
            {
                obrazky.Add(obrazek);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ověřit že v listobrazku jeste neco je
            // náhodný obrázek z list obrazku zobrazit v picturebox
            Random rnd = new Random();
            index = rnd.Next(0, imageList1.Images.Count);

            if(obrazky[index] != null)
            {
                pictureBox1.Image = obrazky[index];
            }
           




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //smazat obrazek v pictureboxu (null)
            //smazat obrázek v list obrázků
            pictureBox1.Image = null;
            obrazky.RemoveAt(index);
        }

    }
}
