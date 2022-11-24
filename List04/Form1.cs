namespace List04
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
            listBox1.Items.Clear();
            list.Clear();
            Random rnd = new Random();

            int n = int.Parse(textBox1.Text);

            for (int i = 0; i < n; i++)
            {
                list.Add(rnd.Next(-100, 101));
            }

          

            foreach (int cis in list)
            {
                listBox1.Items.Add(cis);
            }
           

            int indexMin = -1;
            int indexMax = -1;
            int min = 101;
            int max = -101; 

            for(int i =0; i < list.Count();i++)
            {
                int x = list[i];
                if(x<min)
                {
                    if(x%2!=0 && x%3 == 0)
                    {
                        min = x;
                        indexMin = i;
                    }
                }

                if (x > max)
                {
                    if (x % 2 == 0)
                    {
                        max = x;
                        indexMax = i;
                    }
                }
                


            }
            if(indexMin >= 0) list[indexMax] = min; 
            if(indexMax >= 0) list[indexMin] = max;
         
            listBox2.Items.Clear();
            foreach (int cis in list)
            {
                listBox2.Items.Add(cis);
            }











        }
    }
}