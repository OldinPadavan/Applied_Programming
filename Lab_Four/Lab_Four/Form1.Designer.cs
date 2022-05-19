namespace Lab_Four
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.auto_input = new System.Windows.Forms.RadioButton();
            this.manual_input = new System.Windows.Forms.RadioButton();
            this.inputType = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.calculatingButton = new System.Windows.Forms.Button();
            this.ArrayLength = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 314);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 96);
            this.textBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.auto_input);
            this.panel1.Controls.Add(this.manual_input);
            this.panel1.Location = new System.Drawing.Point(208, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 85);
            this.panel1.TabIndex = 1;
            // 
            // auto_input
            // 
            this.auto_input.AutoSize = true;
            this.auto_input.Location = new System.Drawing.Point(14, 37);
            this.auto_input.Name = "auto_input";
            this.auto_input.Size = new System.Drawing.Size(145, 19);
            this.auto_input.TabIndex = 1;
            this.auto_input.TabStop = true;
            this.auto_input.Text = "Автоматический ввод";
            this.auto_input.UseVisualStyleBackColor = true;
            this.auto_input.CheckedChanged += new System.EventHandler(this.auto_input_CheckedChanged);
            // 
            // manual_input
            // 
            this.manual_input.AutoSize = true;
            this.manual_input.Location = new System.Drawing.Point(14, 12);
            this.manual_input.Name = "manual_input";
            this.manual_input.Size = new System.Drawing.Size(94, 19);
            this.manual_input.TabIndex = 0;
            this.manual_input.TabStop = true;
            this.manual_input.Text = "Ручной ввод";
            this.manual_input.UseVisualStyleBackColor = true;
            this.manual_input.CheckedChanged += new System.EventHandler(this.manual_input_CheckedChanged);
            // 
            // inputType
            // 
            this.inputType.AutoSize = true;
            this.inputType.Location = new System.Drawing.Point(208, 15);
            this.inputType.Name = "inputType";
            this.inputType.Size = new System.Drawing.Size(79, 15);
            this.inputType.TabIndex = 2;
            this.inputType.Text = "Режим ввода";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(11, 41);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(144, 23);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // calculatingButton
            // 
            this.calculatingButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.calculatingButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculatingButton.Location = new System.Drawing.Point(532, 33);
            this.calculatingButton.Name = "calculatingButton";
            this.calculatingButton.Size = new System.Drawing.Size(195, 85);
            this.calculatingButton.TabIndex = 4;
            this.calculatingButton.Text = "Вычислить";
            this.calculatingButton.UseVisualStyleBackColor = false;
            // 
            // ArrayLength
            // 
            this.ArrayLength.AutoSize = true;
            this.ArrayLength.Location = new System.Drawing.Point(12, 15);
            this.ArrayLength.Name = "ArrayLength";
            this.ArrayLength.Size = new System.Drawing.Size(98, 15);
            this.ArrayLength.TabIndex = 5;
            this.ArrayLength.Text = "Длинна массива";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(11, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 79);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ArrayLength);
            this.Controls.Add(this.calculatingButton);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.inputType);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Array";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Panel panel1;
        private RadioButton auto_input;
        private RadioButton manual_input;
        private Label inputType;
        private NumericUpDown numericUpDown1;
        private Button calculatingButton;
        private Label ArrayLength;
        private DataGridView dataGridView1;
    }
}