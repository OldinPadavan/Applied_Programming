namespace Lab_Five
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
            this.components = new System.ComponentModel.Container();
            this.picturesBox = new System.Windows.Forms.PictureBox();
            this.start_button = new System.Windows.Forms.Button();
            this.nameCitiesComboBox = new System.Windows.Forms.ComboBox();
            this.timerBox = new System.Windows.Forms.TextBox();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.numberOfTrialBox = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picturesBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picturesBox
            // 
            this.picturesBox.Location = new System.Drawing.Point(12, 12);
            this.picturesBox.Name = "picturesBox";
            this.picturesBox.Size = new System.Drawing.Size(584, 223);
            this.picturesBox.TabIndex = 0;
            this.picturesBox.TabStop = false;
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(602, 12);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(186, 74);
            this.start_button.TabIndex = 1;
            this.start_button.Text = "Старт!";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // nameCitiesComboBox
            // 
            this.nameCitiesComboBox.FormattingEnabled = true;
            this.nameCitiesComboBox.Items.AddRange(new object[] {
            "Биржевой",
            "Дворцовый",
            "Литейный",
            "Володарский",
            "Александра Невского"});
            this.nameCitiesComboBox.Location = new System.Drawing.Point(366, 251);
            this.nameCitiesComboBox.Name = "nameCitiesComboBox";
            this.nameCitiesComboBox.Size = new System.Drawing.Size(230, 23);
            this.nameCitiesComboBox.TabIndex = 2;
            // 
            // timerBox
            // 
            this.timerBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.timerBox.Font = new System.Drawing.Font("Segoe UI Historic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timerBox.ForeColor = System.Drawing.Color.SandyBrown;
            this.timerBox.Location = new System.Drawing.Point(602, 113);
            this.timerBox.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.timerBox.Multiline = true;
            this.timerBox.Name = "timerBox";
            this.timerBox.Size = new System.Drawing.Size(184, 69);
            this.timerBox.TabIndex = 3;
            this.timerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // answerBox
            // 
            this.answerBox.Location = new System.Drawing.Point(12, 251);
            this.answerBox.Multiline = true;
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(340, 77);
            this.answerBox.TabIndex = 4;
            // 
            // numberOfTrialBox
            // 
            this.numberOfTrialBox.Location = new System.Drawing.Point(602, 197);
            this.numberOfTrialBox.Multiline = true;
            this.numberOfTrialBox.Name = "numberOfTrialBox";
            this.numberOfTrialBox.Size = new System.Drawing.Size(186, 38);
            this.numberOfTrialBox.TabIndex = 5;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(602, 251);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(184, 58);
            this.resultBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.numberOfTrialBox);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.timerBox);
            this.Controls.Add(this.nameCitiesComboBox);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.picturesBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picturesBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picturesBox;
        private Button start_button;
        private ComboBox nameCitiesComboBox;
        private TextBox timerBox;
        private TextBox answerBox;
        private TextBox numberOfTrialBox;
        private TextBox resultBox;
        private System.Windows.Forms.Timer timer1;
    }
}