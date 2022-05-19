namespace Lab_Four
{
    public partial class Form1 : Form

    {
        Random random;
        MyArray myArray;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = (int)numericUpDown1.Value;
            dataGridView1.Width = dataGridView1.ColumnCount * 18 + 12;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].Name = i.ToString();
                dataGridView1.Columns[i].Width = 18;
            }
            
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
                    dataGridView1.Columns[i].Width = 18;
                }
            }
            dataGridView1.Width = dataGridView1.ColumnCount * 18 + 12;
           
        }

        private void SizeAllColumns(Object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCells);
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
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                myArray[i] = Convert.ToDouble(dataGridView1.Rows[0].Cells[i].Value);
            }
        }
    }
}