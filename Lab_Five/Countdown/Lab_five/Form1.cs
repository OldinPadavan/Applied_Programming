using System.Timers;

namespace Lab_five
{
    public partial class GameForm : Form
    {
        private System.Windows.Forms.Timer timer;
        private List<int> showedImages = new List<int>();
        private List<int> answersList = new List<int>();
        private Random random = new Random();
        private int CurrentImgID;
        private Dictionary<int, string> ImagesDictionary = new Dictionary<int, string>()
        {
            {0, "А. Невского"},
            {1, "Биржевой"},
            {2, "Дворцовый"},
            {3, "Эрмитажный"},
            {4, "Большеохтинский"},
            {5, "Литейный"},
            {6, "Троицкий"},
            {7, "Володарский"}

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
            StartButton.Enabled = false;
            ShowImages();
           



        }
        private void ShowImages()
        {

            while(showedImages.Count < ImagesDictionary.Count || Countdown_time.TotalSeconds != 0) {
                CurrentImgID = GetRandomNumber();
                imagesBox.Image = Image.FromFile(ImagesFileList[CurrentImgID]);
                ChoouseAnswerAndCompare();
            }
            ShowResult();
    
        }
        //need to solve problem with generation random number and accses to directoryImglist(what's different between capacity and count)
        private int GetRandomNumber()
        {
            int GeneratedRandomNumber = random.Next(0, 8);
            if (showedImages.Contains(GeneratedRandomNumber))
            {
                GetRandomNumber();
            }
            showedImages.Add(GeneratedRandomNumber);
            return GeneratedRandomNumber;
            
        }

        private void ChoouseAnswerAndCompare()
        {
            comboBox1.Enabled = true;
            string Answer;
            if (comboBox1.SelectedItem != null)
            {
                Answer = comboBox1.SelectedItem.ToString();
            } else
            {
                Answer = "defoult";
            }

            if (Answer.Equals(ImagesDictionary[CurrentImgID]))
            {
                answersList.Add(1);
                statusBox.Text = "Правильно";
            } else
            {
                answersList.Add(0);
                statusBox.Text = "Не правильно";
            }
            showedImages.Add(CurrentImgID);

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
                CountDown.Text = Countdown_time.ToString("mm\\:ss");
                Countdown_time = Countdown_time.Subtract(TimeSpan.FromSeconds(1));
            } else
            {
                timer.Stop();
                ShowResult();
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