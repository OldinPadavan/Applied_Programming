namespace DemoClient
{
    public partial class Form1 : Form
    {
        private Random randomNumber;
        private OrderedQueuesListLibrary.OrderedLinkedList<int> demoList;
        public Form1 ( )
        {
            InitializeComponent();
            panelQueueCommands.Visible = false;
            randomNumber = new Random();
            demoList = new OrderedQueuesListLibrary.OrderedLinkedList<int>();
            demoList.Add(new OrderedQueuesListLibrary.Queue<int>());

        }

        private void buttonAddQueue_Click ( object sender, EventArgs e )
        {
            

        }

        private void buttonDeleteQueue_Click ( object sender, EventArgs e )
        {
           

        }

        private void buttonSetNumber_Click ( object sender, EventArgs e )
        {
            

        }

        private void buttonGetNumber_Click ( object sender, EventArgs e )
        {

        }



    }
}