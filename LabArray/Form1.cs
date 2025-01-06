namespace LabArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] products = { "�����", "�����", "⫴�", "����Ѵ��", "���", "�������" };

            checkedListBox1.Items.AddRange(products);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                return;
            }

            foreach (string item in checkedListBox1.CheckedItems)
            {
                if (listBox1.FindStringExact(item) == -1)
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count == 0)
            {
                return;
            }
            while (listBox1.SelectedIndex!=-1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}