namespace List05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static bool JePrvocislo(int i)
        {
            bool jePrvocislo=true;
            if(i == 0)
            {
                jePrvocislo = false;
            }
            else if(i >= 3)
            {
                for(int j = 2; j <= i/2 && jePrvocislo; j++)
                {
                    if (i % j == 0) jePrvocislo = false;
                }

            }

            return jePrvocislo;

        }




        List<int> list = new List<int>();

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            list.Clear();
            Random rnd = new Random();

            int n = int.Parse(textBox1.Text);

            for (int i = 0; i < n; i++)
            {
                list.Add(rnd.Next(1, 101));
            }

            list.Sort();

            foreach (int cis in list)
            {
                listBox1.Items.Add(cis);
            }

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            for (int i = 0; i < list.Count(); i++)
            {
                if (JePrvocislo(list[i]))
                {
                    int x = list[i];
                    listBox2.Items.Add(x);
                }
            }

        }
    }
}