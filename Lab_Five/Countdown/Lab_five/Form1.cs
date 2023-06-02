using System.Timers;

namespace Lab_five
{
    public partial class GameForm : Form
    {
        private System.Windows.Forms.Timer timer;
        private List<int> showedImages = new List<int>();
        private List<int> answersList = new List<int>();
        Random random = new Random();
        private int CurrentImgID;
        public EventHandler ChoosedAnswerInCombobox;
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
        private Dictionary<int, string> ImagesFileList = new Dictionary<int, string>()
        {
            {0, "G:\\Учеба второй курс\\C# projects\\Lab_Five\\images\\A_Nevskogo.jpg"},
            {1, "G:\\Учеба второй курс\\C# projects\\Lab_Five\\images\\Birzhevoy.jpg"},
            {2, "G:\\Учеба второй курс\\C# projects\\Lab_Five\\images\\Bolsheohtinskij.jpg"},
            {3, "G:\\Учеба второй курс\\C# projects\\Lab_Five\\images\\Dvortsoviy.jpg"},
            {4, "G:\\Учеба второй курс\\C# projects\\Lab_Five\\images\\Ermitagniy.jpg"},
            {5, "G:\\Учеба второй курс\\C# projects\\Lab_Five\\images\\Liteyniy.jpg"},
            {6, "G:\\Учеба второй курс\\C# projects\\Lab_Five\\images\\Troitskiy.jpg"},
            {7, "G:\\Учеба второй курс\\C# projects\\Lab_Five\\images\\Volodarskiy.jpg"}
        };
        private TimeSpan Countdown_time = TimeSpan.FromMinutes(3);
        private List<int> KeysList;





        public GameForm ( )
        {
            InitializeComponent();
            var ShuffleDic = (Dictionary<int, string>)ImagesFileList.OrderBy(x => random.Next());
            KeysList = ShuffleDic.Keys.ToList();
            comboBox1.Enabled = false;
        }

        private void StartButton_Click ( object sender, EventArgs e )
        {
            timer.Start();
            StartButton.Enabled = false;
            CurrentImgID = KeysList.First();
            imagesBox.Image = Image.FromFile(ImagesFileList[CurrentImgID]);
        }
        private void showNextImage ( )
        {
            if (showedImages.Count < ImagesDictionary.Count || Countdown_time.TotalSeconds != 0)
            {
                CurrentImgID = KeysList.
                imagesBox.Image = Image.FromFile(ImagesFileList[CurrentImgID]);
            }
            else 
            {
                ShowResult();
            }
            

        }

        private void ChoouseAnswerAndCompare (string inputAnswer)
        {
            
                if (inputAnswer.Equals(ImagesDictionary[CurrentImgID]))
                {
                    answersList.Add(1);
                    statusBox.Text = "Правильно!";
                }
                else
                {
                    answersList.Add(0);
                    statusBox.Text = "Не правильно!";
                }
     
            showedImages.Add(CurrentImgID);
            showNextImage();


        }




        private void ShowResult ( )
        {
            resultBox.Text = "Количество правильных ответов: " + answersList.Sum() + "\r\n" + "В процентном соотношении угадано: "
                + answersList.Sum() * 10 / 100 + "%";
        }


        private void GameForm_Load ( object sender, EventArgs e )
        {
            timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000;

        }

        private void timer_Tick ( object sender, EventArgs e )
        {
            if (Countdown_time.TotalSeconds >= 0)
            {
                CountDown.Text = Countdown_time.ToString("mm\\:ss");
                Countdown_time = Countdown_time.Subtract(TimeSpan.FromSeconds(1));
            }
            else
            {
                timer.Stop();
                ShowResult();
            }

        }



        private void GameForm_FormClosing ( object sender, FormClosingEventArgs e )
        {
            timer.Stop();
            Application.DoEvents();
        }

        private void showStatus ( )
        {

        }

        private void comboBox1_SelectedIndexChanged ( object sender, EventArgs e )
        {
            ComboBox cmb = (ComboBox) sender;
            string Answer = cmb.Text;
            ChoouseAnswerAndCompare(Answer);
        }
    }
}