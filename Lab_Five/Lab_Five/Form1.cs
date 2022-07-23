using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Lab_Five
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        int timerCounter = 0;
        Random random = new Random();
        int rnd;
        public Form1()
        {
            InitializeComponent();
            nameCitiesComboBox.Enabled = false;
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            
            timer.Interval = (1000); // 45 mins
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            nameCitiesComboBox.Enabled = true;
            rnd = random.Next() % 100 + 1;
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            if (timerCounter < 180)
            {
                this.timerBox.Text = (180 - (++timerCounter)).ToString();
            }
            else
            {
                this.timerBox.Text = "stop";
                timer.Stop();
            }
        }

       
    }
}