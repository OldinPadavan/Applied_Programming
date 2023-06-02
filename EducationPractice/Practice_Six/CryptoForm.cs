using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Practice_Six
{
    public partial class CryptroForm : Form
    {
        private static byte[] IV = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public CryptroForm() 
        { 
            InitializeComponent();
        }

 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        /// <summary>
        /// шифрование 
        /// </summary>
        /// <param name="plaintext"> текс для шифровки</param>
        /// <param name="Password"> Пароль</param>
        /// <param name="IV"> параметр шифрования IV</param>
        /// <returns></returns>
        private string Encrypt(string plaintext, string Password, byte[] IV)
        {
            byte[] Key = Encoding.UTF8.GetBytes(Password);
            AesManaged aes = new AesManaged();
            aes.Key = Key;
            aes.IV = IV;

            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream,aes.CreateEncryptor(), CryptoStreamMode.Write );
            byte[] InputBytes = Encoding.UTF8.GetBytes(plaintext);
            cryptoStream.Write(InputBytes,0,InputBytes.Length);
            cryptoStream.FlushFinalBlock();

            byte[] Encrypted = memoryStream.ToArray();
            return Convert.ToBase64String(Encrypted);
                    
        }
        /// <summary>
        /// расшифровка зашифрованного текста
        /// </summary>
        /// <param name="plaintext"></param>
        /// <param name="Password"></param>
        /// <param name="IV"></param>
        /// <returns></returns>
        private string Decrypt(string plaintext, string Password, byte[] IV)
        {
            byte[] Key = Encoding.UTF8.GetBytes(Password);


            AesManaged aes = new AesManaged();
            aes.Key = Key;
            aes.IV = IV;

            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write);
            byte[] InputBytes = Convert.FromBase64String(plaintext);
            cryptoStream.Write(InputBytes, 0, InputBytes.Length);
            cryptoStream.FlushFinalBlock();
            byte[] Decrypted = memoryStream.ToArray();
            return UTF8Encoding.UTF8.GetString(Decrypted, 0, Decrypted.Length);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = Encrypt(textBox1.Text, "5555555555555555", IV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            try
            {
                textBox2.Text = Decrypt(textBox2.Text, "5555555555555555", IV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
