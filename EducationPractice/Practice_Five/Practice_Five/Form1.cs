using Microsoft.Win32;
using System.Drawing;

namespace Practice_Five
{
    public partial class Form1 : Form
    {

        public Form1 ( )
        {
            InitializeComponent();


        }

        private void buttonChangeColor_Click ( object sender, EventArgs e )
        {
            buttonChangeColor.BackColor = Color.DeepSkyBlue;
            buttonChangeTextSize.BackColor = Color.DeepSkyBlue;
            buttonChangeFormColor.BackColor = Color.DeepSkyBlue;
        }

        private void buttonChangeTextSize_Click ( object sender, EventArgs e )
        {
            buttonChangeColor.Font = new Font(buttonChangeColor.Font.Name, buttonChangeColor.Font.Size + 5, buttonChangeColor.Font.Style);
            buttonChangeTextSize.Font = new Font(buttonChangeTextSize.Font.Name, buttonChangeTextSize.Font.Size + 5, buttonChangeTextSize.Font.Style);
            buttonChangeFormColor.Font = new Font(buttonChangeFormColor.Font.Name, buttonChangeFormColor.Font.Size + 5, buttonChangeFormColor.Font.Style);
        }

        private void buttonChangeFormColor_Click ( object sender, EventArgs e )
        {
            this.BackColor = Color.DeepSkyBlue;
        }

        private void Form1_FormClosing ( object sender, FormClosingEventArgs e )
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey figure = currentUserKey.CreateSubKey(@"Software\Figure");
            figure.SetValue("FontSize",buttonChangeColor.Font.Size, RegistryValueKind.DWord);
            figure.SetValue("BackGroudColor", this.BackColor.ToArgb(), RegistryValueKind.DWord);
            figure.Close();


        }
    }
}