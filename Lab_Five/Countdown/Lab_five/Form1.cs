using System.Timers;

namespace Lab_five
{
    public partial class GameForm : Form
    {
        private System.Windows.Forms.Timer timer;
        private List<int> showedImages = new List<int>();
        private List<int> answersList = new List<int>();
        private Dictionary<int, string> ImagesDictionary = new Dictionary<int, string>()
        {
            {1, "А. Невского"},
            {2, "Биржевой"},
            {3, "Дворцовый"},
            {4, "Эрмитажный"},
            {5, "Большеохтинский"},
            {6, "Литейный"},
            {7, "Троицкий"},
            {8, "Володарский"}

        };
        private List<string> ImagesFileList = new List<string>()
        {
            {"G:\\Учеба второй курс\\C# projects\\Lab_Five\\images\\A_Nevskogo.jpg"},
            {"G:\\Учеба второй курс\\C# projects\\Lab_Five\\images\\Birzhevoy.jpg"},
            {"G:\\Учеба второй курс\\C# projects\\Lab_Five\\images\\Bolsheohtinskij.jpg"},
            {"G:\\Учеба второй курс\\C# projects\\Lab_Five\\images\\Dvortsoviy.jpg"},
            {"G:\\Учеба второй курс\\C# projects\\Lab_Five\\images\\Ermitagniy.jpg"},
            {"G:\\Учеба второй курс\\C# projects\\Lab_Five\\images\\Liteyniy.jpg"},
            {"G:\\Учеба второй курс\\C# projects\\Lab_Five\\images\\Troitskiy.jpg"},
            {"G:\\Учеба второй курс\\C# projects\\Lab_Five\\images\\Volodarskiy.jpg"}
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
            comboBox1.Enabled=true;
            
           
        }
        private void ShowImages()
        {
            if(showedImages.Count() == ImagesDictionary.Count())
            {
                timer.Stop();
                ShowResult();
            }
            
            int randomNumber = GetRandomNumber();
            this.imagesBox.Image = Image.FromFile(ImagesFileList[randomNumber]);
            CheckingResul(randomNumber);

            
        }

        private int GetRandomNumber()
        {
            int randomNumber = new Random().Next(1, 9);
            if(showedImages.Contains(randomNumber))
            {
                return GetRandomNumber();
            } else
            {
                return randomNumber;
            }
        }

        private void CheckingResul(int imagesId)
        {
            string UserAnswer = comboBox1.SelectedItem.ToString();
            if (UserAnswer.Equals(ImagesDictionary[imagesId]))
            {
                answersList.Add(1);
                statusBox.Text = "Правильно!";

            }
            else
            {
                answersList.Add(0);
                statusBox.Text = "Не правильно!";
            }
            showedImages.Add(imagesId);

        }

        private void ShowResult()
        {
            resultBox.Text = "Количество правильных ответов: " + answersList.Sum() + "/n" + "В процентном соотношении угадано: " 
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
                ShowImages();
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