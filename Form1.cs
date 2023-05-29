using System.Windows.Forms;

namespace FilteringApp
{
    public partial class Form1 : Form
    {
        private List<string> allItems=new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addNums();
        }
        private void addNums()
        {
            for (int i = 0; i <= 500; i++)
            {
                allItems.Add(string.Format("I{0}",i.ToString("000000")));
                listBox1.Items.Add(string.Format("I{0}",i.ToString("000000")));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            TextBox txtSearch = (TextBox)sender;
            foreach (string itm in allItems)
            {
                if (itm.Contains(txtSearch.Text)) 
                {
                    listBox1.Items.Add(itm);
                }
            }
        }
    }
}