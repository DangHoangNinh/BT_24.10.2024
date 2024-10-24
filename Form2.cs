namespace FormDangnhap_21._10._2024
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            // Attach event handlers
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
        }

        // Event handler for adding a student (Đăng nhập)
        private void Button1_Click(object sender, EventArgs e)
        {
            // Add new student row
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
            {
                dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Please fill in all fields before adding a student.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for updating a student (Sửa)
        private void Button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index != -1)
            {
                // Update selected row
                dataGridView1.CurrentRow.Cells["MaSV"].Value = textBox1.Text;
                dataGridView1.CurrentRow.Cells["Ten"].Value = textBox2.Text;
                dataGridView1.CurrentRow.Cells["Lop"].Value = textBox3.Text;
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Please select a student record to update.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for deleting a student (Xóa)
        private void Button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index != -1)
            {
                // Remove selected row
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Please select a student record to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clear the text boxes after an operation
        private void ClearTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Handle changes in textBox1 if needed
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Handle label1 clicks if needed
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
