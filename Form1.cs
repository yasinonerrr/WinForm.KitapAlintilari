namespace WinForm.KitapAlintilari
{
    public partial class Form1 : Form
    {
        private Book selectedBook = null;
        public Form1()
        {

            InitializeComponent();
            Refresh();

        }

        public void Refresh()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = DataStore.Books;
            listBox1.DisplayMember = "Description";
            listBox1.ValueMember = "Id";
        }



        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {


                var addedBook = new Book();
                addedBook.Description = richTextBox1.Text;

                var lastBook = DataStore.Books[DataStore.Books.Count - 1];
                addedBook.Id = lastBook.Id + 1;


                DataStore.Books.Add(addedBook);

                Refresh();


                richTextBox1.Text = string.Empty;
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                selectedBook = (Book)listBox1.SelectedItem;
                richTextBox1.Text = selectedBook.Description;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DataStore.Books.Remove(selectedBook);
            selectedBook = null;
            richTextBox1.Text = string.Empty;
            Refresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                selectedBook.Description = richTextBox1.Text;

                Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En kýsa zamanda görüþmek üzere :)");
            Application.Exit();
        }
    }
}