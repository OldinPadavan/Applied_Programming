namespace Lab_Three
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Your blood will be mine";
            this.BackColor = Color.WhiteSmoke;
            this.Width = 650;
            this.Height = 450;
            this.StartPosition = FormStartPosition.CenterScreen;
            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button helloButton = new Button();
            helloButton.BackColor = Color.LightGreen;
            helloButton.ForeColor = Color.DarkGray;
            helloButton.Location = new Point(10, 10);
            helloButton.Text = "Hello";
            this.Controls.Add(helloButton);
        }
    }
}