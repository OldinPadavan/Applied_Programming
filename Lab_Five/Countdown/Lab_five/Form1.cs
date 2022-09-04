using System.Timers;

namespace Lab_five
{
    public partial class GameForm : Form
    {
        private System.Windows.Forms.Timer timer;
        TimeSpan Countdown_time = TimeSpan.FromMinutes(3);

        public GameForm()
        {
            InitializeComponent();
            comboBox1.Enabled = false;
           
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer.Start();
            comboBox1.Enabled=true;
           
        }


        private void GameForm_Load(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000;
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Countdown_time.TotalSeconds >= 0)
            {              
                CountDown.Text = Countdown_time.ToString("mm\\:ss");
                Countdown_time = Countdown_time.Subtract(TimeSpan.FromSeconds(1));
            } else
            {
                timer.Stop();
            }

        }



        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            Application.DoEvents();
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            
            
           
            
        }

        

        private void showStatus()
        {
            
        }

    }
}