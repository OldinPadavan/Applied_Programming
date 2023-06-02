namespace Lab_Six
{
    partial class HexConvertForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            this.input_textTextBox = new System.Windows.Forms.RichTextBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.result_textTextBox = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonSave = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // input_textTextBox
            // 
            this.input_textTextBox.Location = new System.Drawing.Point(2, 68);
            this.input_textTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.input_textTextBox.Name = "input_textTextBox";
            this.input_textTextBox.Size = new System.Drawing.Size(917, 204);
            this.input_textTextBox.TabIndex = 0;
            this.input_textTextBox.Text = "";
            this.input_textTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(14, 14);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(88, 27);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // result_textTextBox
            // 
            this.result_textTextBox.FormattingEnabled = true;
            this.result_textTextBox.ItemHeight = 15;
            this.result_textTextBox.Location = new System.Drawing.Point(2, 295);
            this.result_textTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.result_textTextBox.Name = "result_textTextBox";
            this.result_textTextBox.Size = new System.Drawing.Size(917, 199);
            this.result_textTextBox.TabIndex = 4;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(121, 14);
            this.buttonConvert.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(115, 27);
            this.buttonConvert.TabIndex = 6;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(262, 14);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(88, 27);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // HexConvertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.result_textTextBox);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.input_textTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "HexConvertForm";
            this.Text = "HexConvertor";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox input_textTextBox;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox result_textTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonSave;
    }
}