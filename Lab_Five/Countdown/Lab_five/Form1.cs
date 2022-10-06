using System.Timers;

namespace Lab_five
{
    public partial class GameForm : Form
    {
        private System.Windows.Forms.Timer timer;
        private List<int> showedImages = new List<int>();
        private List<int> answersList = new List<int>();
        private Random random = new Random();
        private Dictionary<int, string> ImagesDictionary = new Dictionary<int, string>()
        {
            {1, "�. ��������"},
            {2, "��������"},
            {3, "���������"},
            {4, "����������"},
            {5, "���������������"},
            {6, "��������"},
            {7, "��������"},
            {8, "�����������"}

        };
        private List<string> ImagesFileList = new List<string>()
        {
            {"G:\\����� ������ ����\\C# projects\\Lab_Five\\images\\A_Nevskogo.jpg"},
            {"G:\\����� ������ ����\\C# projects\\Lab_Five\\images\\Birzhevoy.jpg"},
            {"G:\\����� ������ ����\\C# projects\\Lab_Five\\images\\Bolsheohtinskij.jpg"},
            {"G:\\����� ������ ����\\C# projects\\Lab_Five\\images\\Dvortsoviy.jpg"},
            {"G:\\����� ������ ����\\C# projects\\Lab_Five\\images\\Ermitagniy.jpg"},
            {"G:\\����� ������ ����\\C# projects\\Lab_Five\\images\\Liteyniy.jpg"},
            {"G:\\����� ������ ����\\C# projects\\Lab_Five\\images\\Troitskiy.jpg"},
            {"G:\\����� ������ ����\\C# projects\\Lab_Five\\images\\Volodarskiy.jpg"}
        };
        private TimeSpan Countdown_time = TimeSpan.FromMinutes(3);
        

        public GameForm()
        {
            InitializeComponent();
            comboBox1.Enabled = false;
            
           
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer.Start();
            StartButton.Enabled = false;
            comboBox1.Enabled=true;
            ShowImages();
           



        }
        private void ShowImages()
        {
            int randomNumber = GetRandomNumber();
            this.imagesBox.Image = Image.FromFile(ImagesFileList[randomNumber]);
            CheckingResul(randomNumber);
            /*while (Countdown_time.TotalSeconds > 0)
            {
                if (showedImages.Count() == ImagesDictionary.Count())
                {
                    timer.Stop();
                    ShowResult();
                }

                int randomNumber = GetRandomNumber();
                this.imagesBox.Image = Image.FromFile(ImagesFileList[randomNumber]);
                CheckingResul(randomNumber);
            }*/


        }

        private int GetRandomNumber()
        {
            int randomNumber = random.Next(0, ImagesDictionary.Count());
            while (showedImages.Contains(randomNumber))
            {
                randomNumber = random.Next(0, ImagesDictionary.Count());
            }
            return randomNumber;
        }

        private void CheckingResul(int imagesId)
        {
            
            if (this.comboBox1.SelectedItem != null)
            {
                
                if (this.comboBox1.GetItemText(this.comboBox1.SelectedItem).Equals(ImagesDictionary[imagesId]))
                {
                    answersList.Add(1);
                    statusBox.Text = "���������!";
                }
                else
                {
                    answersList.Add(0);
                    statusBox.Text = "�� ���������!";
                }
            }
            showedImages.Add(imagesId);

        }

        private void ShowResult()
        {
            resultBox.Text = "���������� ���������� �������: " + answersList.Sum() + "/n" + "� ���������� ����������� �������: " 
                + answersList.Sum() * 10 / 100 + "%";
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

        private void showStatus()
        {
            
        }

    }
}