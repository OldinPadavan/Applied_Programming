namespace Lab_five
{
    partial class GameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
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
        private void InitializeComponent()
        {
            this.StartButton = new System.Windows.Forms.Button();
            this.CountDown = new System.Windows.Forms.TextBox();
            this.imagesBox = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagesBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartButton.Location = new System.Drawing.Point(524, 121);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(264, 70);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Старт!";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // CountDown
            // 
            this.CountDown.Font = new System.Drawing.Font("Microsoft JhengHei", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CountDown.Location = new System.Drawing.Point(524, 24);
            this.CountDown.Multiline = true;
            this.CountDown.Name = "CountDown";
            this.CountDown.ReadOnly = true;
            this.CountDown.Size = new System.Drawing.Size(264, 82);
            this.CountDown.TabIndex = 2;
            this.CountDown.Text = "00:00";
            this.CountDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imagesBox
            // 
            this.imagesBox.Image = global::Lab_five.Properties.Resources.Birzhevoy;
            this.imagesBox.Location = new System.Drawing.Point(12, 12);
            this.imagesBox.Name = "imagesBox";
            this.imagesBox.Size = new System.Drawing.Size(480, 229);
            this.imagesBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagesBox.TabIndex = 3;
            this.imagesBox.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "А. Невского",
            "Биржевой",
            "Дворцовый",
            "Эрмитажный",
            "Большеохтинский",
            "Литейный",
            "Троицкий",
            "Володарский"});
            this.comboBox1.Location = new System.Drawing.Point(12, 247);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(280, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(331, 247);
            this.statusBox.Multiline = true;
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(161, 37);
            this.statusBox.TabIndex = 5;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(524, 269);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(264, 169);
            this.resultBox.TabIndex = 6;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.imagesBox);
            this.Controls.Add(this.CountDown);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagesBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button StartButton;
        private TextBox CountDown;
        private PictureBox imagesBox;
        private ComboBox comboBox1;
        private TextBox statusBox;
        private TextBox resultBox;
    }
}