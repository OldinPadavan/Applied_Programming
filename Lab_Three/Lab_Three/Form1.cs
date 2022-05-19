namespace Lab_Three
{
    public partial class Form1 : Form
    {
        Storage storage;
        Product product;
        public Form1()
        {
            InitializeComponent();
            storage = new Storage();
            
            
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
           
           String name = NameProduxtTextBox.Text;
           String productType = ProductTypecomboBox.Text;
           int count = Int32.Parse(AmountProducttextBox.Text);
           double BuyingPrice = Double.Parse(BuyingPriceProducttextBox.Text);
           double SellingPrice = Double.Parse(SellingPriceProducttextBox.Text);
           product = new Product(name, productType, count, BuyingPrice, SellingPrice);
           storage.AddProduct(product);
           richTextBox1.Text += product.ToString() + "\n";

            NameProduxtTextBox.Clear();
            AmountProducttextBox.Clear();
            BuyingPriceProducttextBox.Clear();
            SellingPriceProducttextBox.Clear();

        }


        private void AmountProducttextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BuyingPriceProducttextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void SellingPriceProducttextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NameProduxtTextBox.Clear();
            AmountProducttextBox.Clear();
            BuyingPriceProducttextBox.Clear();
            SellingPriceProducttextBox.Clear();

        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            if (
                   string.IsNullOrEmpty(NameProduxtTextBox.Text)
                   ||
                   string.IsNullOrEmpty(AmountProducttextBox.Text)
                   ||
                   string.IsNullOrEmpty(BuyingPriceProducttextBox.Text)
                   ||
                   string.IsNullOrEmpty(SellingPriceProducttextBox.Text)
               )
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }
        

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (
                   string.IsNullOrEmpty(NameProduxtTextBox.Text)
                   ||
                   string.IsNullOrEmpty(AmountProducttextBox.Text)
                   ||
                   string.IsNullOrEmpty(BuyingPriceProducttextBox.Text)
                   ||
                   string.IsNullOrEmpty(SellingPriceProducttextBox.Text)
               )
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }
    }
}