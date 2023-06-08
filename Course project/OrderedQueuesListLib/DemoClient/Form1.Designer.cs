namespace DemoClient
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxOrderNumber = new System.Windows.Forms.TextBox();
            this.buttonAddQueue = new System.Windows.Forms.Button();
            this.buttonDeleteQueue = new System.Windows.Forms.Button();
            this.panelQueueCommands = new System.Windows.Forms.Panel();
            this.buttonGetNumber = new System.Windows.Forms.Button();
            this.buttonSetNumber = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelQueueCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // 
            // textBoxOrderNumber
            // 
            this.textBoxOrderNumber.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxOrderNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxOrderNumber.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxOrderNumber.Location = new System.Drawing.Point(579, 12);
            this.textBoxOrderNumber.Multiline = true;
            this.textBoxOrderNumber.Name = "textBoxOrderNumber";
            this.textBoxOrderNumber.ReadOnly = true;
            this.textBoxOrderNumber.Size = new System.Drawing.Size(199, 91);
            this.textBoxOrderNumber.TabIndex = 1;
            this.textBoxOrderNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonAddQueue
            // 
            this.buttonAddQueue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddQueue.Location = new System.Drawing.Point(579, 109);
            this.buttonAddQueue.Name = "buttonAddQueue";
            this.buttonAddQueue.Size = new System.Drawing.Size(199, 55);
            this.buttonAddQueue.TabIndex = 2;
            this.buttonAddQueue.Text = "Добавить очередь";
            this.buttonAddQueue.UseVisualStyleBackColor = true;
            this.buttonAddQueue.Click += new System.EventHandler(this.buttonAddQueue_Click);
            // 
            // buttonDeleteQueue
            // 
            this.buttonDeleteQueue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteQueue.Location = new System.Drawing.Point(579, 170);
            this.buttonDeleteQueue.Name = "buttonDeleteQueue";
            this.buttonDeleteQueue.Size = new System.Drawing.Size(199, 55);
            this.buttonDeleteQueue.TabIndex = 3;
            this.buttonDeleteQueue.Text = "Удалить очередь";
            this.buttonDeleteQueue.UseVisualStyleBackColor = true;
            this.buttonDeleteQueue.Click += new System.EventHandler(this.buttonDeleteQueue_Click);
            // 
            // panelQueueCommands
            // 
            this.panelQueueCommands.Controls.Add(this.buttonGetNumber);
            this.panelQueueCommands.Controls.Add(this.buttonSetNumber);
            this.panelQueueCommands.Location = new System.Drawing.Point(579, 240);
            this.panelQueueCommands.Name = "panelQueueCommands";
            this.panelQueueCommands.Size = new System.Drawing.Size(200, 198);
            this.panelQueueCommands.TabIndex = 4;
            // 
            // buttonGetNumber
            // 
            this.buttonGetNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGetNumber.Location = new System.Drawing.Point(18, 78);
            this.buttonGetNumber.Name = "buttonGetNumber";
            this.buttonGetNumber.Size = new System.Drawing.Size(164, 42);
            this.buttonGetNumber.TabIndex = 1;
            this.buttonGetNumber.Text = "Вызвать номерок";
            this.buttonGetNumber.UseVisualStyleBackColor = true;
            this.buttonGetNumber.Click += new System.EventHandler(this.buttonGetNumber_Click);
            // 
            // buttonSetNumber
            // 
            this.buttonSetNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSetNumber.Location = new System.Drawing.Point(18, 18);
            this.buttonSetNumber.Name = "buttonSetNumber";
            this.buttonSetNumber.Size = new System.Drawing.Size(164, 42);
            this.buttonSetNumber.TabIndex = 0;
            this.buttonSetNumber.Text = "Выдать номерок";
            this.buttonSetNumber.UseVisualStyleBackColor = true;
            this.buttonSetNumber.Click += new System.EventHandler(this.buttonSetNumber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelQueueCommands);
            this.Controls.Add(this.buttonDeleteQueue);
            this.Controls.Add(this.buttonAddQueue);
            this.Controls.Add(this.textBoxOrderNumber);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelQueueCommands.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBoxOrderNumber;
        private Button buttonAddQueue;
        private Button buttonDeleteQueue;
        private Panel panelQueueCommands;
        private Button buttonGetNumber;
        private Button buttonSetNumber;
    }
}