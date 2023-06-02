using Microsoft.Win32;
using System.Drawing;

namespace Practice_Five
{
    public partial class Form1 : Form
    {

        public Form1 ( )
        {
            InitializeComponent();
            RegistryKey currentKey = Registry.CurrentUser;
            RegistryKey key = currentKey.OpenSubKey(@"Software\PracticeFive");
            if (key != null)
            {
                Int32 a = Convert.ToInt32(key?.GetValue("FontSize"));
                Int32 b = Convert.ToInt32(key?.GetValue("BackGroudColor"));
                buttonChangeColor.Font = new Font(buttonChangeColor.Font.Name, a, buttonChangeColor.Font.Style);
                buttonChangeTextSize.Font = new Font(buttonChangeTextSize.Font.Name, a, buttonChangeTextSize.Font.Style);
                buttonChangeFormColor.Font = new Font(buttonChangeFormColor.Font.Name, a, buttonChangeFormColor.Font.Style);

                buttonChangeColor.BackColor = Color.FromArgb(b);
                buttonChangeTextSize.BackColor = Color.FromArgb(b);
                buttonChangeFormColor.BackColor = Color.FromArgb(b);
                key.Close();

            }



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
            RegistryKey key = currentUserKey.CreateSubKey(@"Software\PracticeFive");
            key.SetValue("FontSize",buttonChangeColor.Font.Size, RegistryValueKind.DWord);
            key.SetValue("BackGroudColor", this.BackColor.ToArgb(), RegistryValueKind.DWord);
            key.Close();
        }
    }
}