using System.Timers;

namespace Lab_five
{
    public partial class GameForm : Form
    {
        private System.Windows.Forms.Timer timer;
        TimeSpan Countdown_time = TimeSpan.FromMinutes(3);
        private string[] allFiles = Directory.GetFiles(@"G:\Учеба второй курс\C# projects\Lab_Five\images");
        private List<string> imagesName = new List<string>();
        public GameForm()
        {
            InitializeComponent();
            foreach (string name in allFiles)
            {
                imagesName.Add(System.IO.Path.GetFileNameWithoutExtension(name));
            }


        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer.Start();
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
    }
}