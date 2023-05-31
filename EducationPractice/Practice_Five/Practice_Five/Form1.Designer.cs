namespace Practice_Five
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BackColor = Color.FromArgb(c);
            this.buttonChangeColor = new System.Windows.Forms.Button();
            this.buttonChangeTextSize = new System.Windows.Forms.Button();
            this.buttonChangeFormColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(26, 17);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(526, 411);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // buttonChangeColor
            // 
            this.buttonChangeColor.Location = new System.Drawing.Point(558, 17);
            this.buttonChangeColor.Name = "buttonChangeColor";
            this.buttonChangeColor.Size = new System.Drawing.Size(230, 56);
            this.buttonChangeColor.TabIndex = 1;
            this.buttonChangeColor.Text = "Change color";
            this.buttonChangeColor.UseVisualStyleBackColor = true;
            this.buttonChangeColor.Click += new System.EventHandler(this.buttonChangeColor_Click);
            // 
            // buttonChangeTextSize
            // 
            this.buttonChangeTextSize.Location = new System.Drawing.Point(558, 79);
            this.buttonChangeTextSize.Name = "buttonChangeTextSize";
            this.buttonChangeTextSize.Size = new System.Drawing.Size(230, 49);
            this.buttonChangeTextSize.TabIndex = 2;
            this.buttonChangeTextSize.Text = "Change Text Size";
            this.buttonChangeTextSize.UseVisualStyleBackColor = true;
            this.buttonChangeTextSize.Click += new System.EventHandler(this.buttonChangeTextSize_Click);
            // 
            // buttonChangeFormColor
            // 
            this.buttonChangeFormColor.Location = new System.Drawing.Point(558, 134);
            this.buttonChangeFormColor.Name = "buttonChangeFormColor";
            this.buttonChangeFormColor.Size = new System.Drawing.Size(230, 52);
            this.buttonChangeFormColor.TabIndex = 3;
            this.buttonChangeFormColor.Text = "Change Form color";
            this.buttonChangeFormColor.UseVisualStyleBackColor = true;
            this.buttonChangeFormColor.Click += new System.EventHandler(this.buttonChangeFormColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonChangeFormColor);
            this.Controls.Add(this.buttonChangeTextSize);
            this.Controls.Add(this.buttonChangeColor);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox richTextBox1;
        private Button buttonChangeColor;
        private Button buttonChangeTextSize;
        private Button buttonChangeFormColor;
    }
}