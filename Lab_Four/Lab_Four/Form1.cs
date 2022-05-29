namespace Lab_Four
{
    public partial class Form1 : Form

    {
        Random random;
        MyArray myArray;
        public Form1()
        {   
            random = new Random();
            InitializeComponent();
            dataGridView1.ColumnCount = (int)numericUpDown1.Value;
            dataGridView1.Width = dataGridView1.ColumnCount * 22 + 12;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].Name = i.ToString();
                dataGridView1.Columns[i].Width = 22;
            }
            dataGridView1.Rows.Add();
          

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int n = dataGridView1.ColumnCount - (int)numericUpDown1.Value;

            dataGridView1.ColumnCount = (int)numericUpDown1.Value;

            if (n < 0)
            {
                for (int i = dataGridView1.ColumnCount + n; i < dataGridView1.ColumnCount; i++)
                {
                    dataGridView1.Columns[i].Name = i.ToString();
                    dataGridView1.Columns[i].Width = 22;
                    if (auto_input.Checked)
                    {
                        dataGridView1.Rows[0].Cells[i].Value = random.Next() % 10;
                    }
                
                }
            }
            dataGridView1.Width = dataGridView1.ColumnCount * 22 + 12;
           
        }

       

        private void auto_input_CheckedChanged(object sender, EventArgs e)
        {
            random = new Random();
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = random.Next() % 10;
            }
            
        }

        private void manual_input_CheckedChanged(object sender, EventArgs e)
        {
            double[] myArray = new double[dataGridView1.ColumnCount];

            
        }

        private void calculatingButton_Click(object sender, EventArgs e)
        {
            double[] array = new double[dataGridView1.ColumnCount];
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                array[i] = Convert.ToDouble(dataGridView1.Rows[0].Cells[i].Value);
            }

            myArray = new MyArray(array);
            string str = myArray.ReturnSequenceSum().ToString();
            textBox1.Text = str;
            
        }

        private void manual_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(manual_input_KeyPress);
            if (true) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(manual_input_KeyPress);
                }
            }
        }

        private void auto_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}