
using System.Text;

namespace Lab_Six
{
    public partial class HexConvertForm : Form
    {
        string fileName = "";
        public HexConvertForm ( )
        {
            InitializeComponent();
        }

        private void buttonOpen_Click ( object sender, EventArgs e )
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                fileName = openFileDialog1.FileName;
                StreamReader s = new StreamReader(openFileDialog1.FileName, Encoding.GetEncoding(1251));
                input_textTextBox.Text = s.ReadToEnd();
                s.Close();
            }
        }

        private void richTextBox1_TextChanged ( object sender, EventArgs e )
        {
            toolStripStatusLabel2.Text = input_textTextBox.Text.Length.ToString();
            toolStripStatusLabel4.Text = input_textTextBox.Text.Split().Count<string>().ToString();
        }

        private void buttonConvert_Click ( object sender, EventArgs e )
        {
            if(input_textTextBox.Lines.Length > 0)
            {
                foreach (string line in input_textTextBox.Lines) {
                    try
                    {
                        int DecValue = Convert.ToInt32(line, 16);
                        result_textTextBox.Items.Add(DecValue);
                    }catch(FormatException)
                    {
                        result_textTextBox.Items.Add("_");
                    }
                }
            }
        }

        private void buttonSave_Click ( object sender, EventArgs e )
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";
            sfd.FileName = "new file name";
            sfd.Title = "Save Text File";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (StreamWriter bw = new StreamWriter(File.Create(sfd.FileName)))
                {
                    List<string> lines = new List<string>();
                    foreach (var line in result_textTextBox.Items)
                    {
                        lines.Add(line.ToString());
                    }
                    foreach (string addedline in lines)
                    {
                        bw.WriteLine(addedline);
                        
                  
                    }
                    
                    bw.Dispose();
                }
                    
                }
                
            }
           
        }
 }