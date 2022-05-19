namespace Lab_Three
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
            this.NamePrLabel = new System.Windows.Forms.Label();
            this.AmountPrlabel = new System.Windows.Forms.Label();
            this.BuyPricePrlabe = new System.Windows.Forms.Label();
            this.NameProduxtTextBox = new System.Windows.Forms.TextBox();
            this.AmountProducttextBox = new System.Windows.Forms.TextBox();
            this.BuyingPriceProducttextBox = new System.Windows.Forms.TextBox();
            this.SellPricePrlabel = new System.Windows.Forms.Label();
            this.ProductTypecomboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TypePrlabel = new System.Windows.Forms.Label();
            this.SellingPriceProducttextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NamePrLabel
            // 
            this.NamePrLabel.AutoSize = true;
            this.NamePrLabel.Location = new System.Drawing.Point(39, 28);
            this.NamePrLabel.Name = "NamePrLabel";
            this.NamePrLabel.Size = new System.Drawing.Size(99, 15);
            this.NamePrLabel.TabIndex = 0;
            this.NamePrLabel.Text = "Название товара";
            // 
            // AmountPrlabel
            // 
            this.AmountPrlabel.AutoSize = true;
            this.AmountPrlabel.Location = new System.Drawing.Point(38, 105);
            this.AmountPrlabel.Name = "AmountPrlabel";
            this.AmountPrlabel.Size = new System.Drawing.Size(72, 15);
            this.AmountPrlabel.TabIndex = 1;
            this.AmountPrlabel.Text = "Количество";
            // 
            // BuyPricePrlabe
            // 
            this.BuyPricePrlabe.AutoSize = true;
            this.BuyPricePrlabe.Location = new System.Drawing.Point(37, 175);
            this.BuyPricePrlabe.Name = "BuyPricePrlabe";
            this.BuyPricePrlabe.Size = new System.Drawing.Size(133, 15);
            this.BuyPricePrlabe.TabIndex = 2;
            this.BuyPricePrlabe.Text = "Закупочная стоимость";
            // 
            // NameProduxtTextBox
            // 
            this.NameProduxtTextBox.Location = new System.Drawing.Point(39, 56);
            this.NameProduxtTextBox.Name = "NameProduxtTextBox";
            this.NameProduxtTextBox.Size = new System.Drawing.Size(121, 23);
            this.NameProduxtTextBox.TabIndex = 3;
            this.NameProduxtTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.NameProduxtTextBox.Leave += new System.EventHandler(this.Form1_Leave);
            // 
            // AmountProducttextBox
            // 
            this.AmountProducttextBox.Location = new System.Drawing.Point(38, 123);
            this.AmountProducttextBox.Name = "AmountProducttextBox";
            this.AmountProducttextBox.Size = new System.Drawing.Size(122, 23);
            this.AmountProducttextBox.TabIndex = 4;
            this.AmountProducttextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountProducttextBox_KeyPress);
            this.AmountProducttextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.AmountProducttextBox.Leave += new System.EventHandler(this.Form1_Leave);

            // 
            // BuyingPriceProducttextBox
            // 
            this.BuyingPriceProducttextBox.Location = new System.Drawing.Point(39, 203);
            this.BuyingPriceProducttextBox.Name = "BuyingPriceProducttextBox";
            this.BuyingPriceProducttextBox.Size = new System.Drawing.Size(121, 23);
            this.BuyingPriceProducttextBox.TabIndex = 5;
            this.BuyingPriceProducttextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BuyingPriceProducttextBox_KeyPress);
            this.BuyingPriceProducttextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.BuyingPriceProducttextBox.Leave += new System.EventHandler(this.Form1_Leave);
            // 
            // SellPricePrlabel
            // 
            this.SellPricePrlabel.AutoSize = true;
            this.SellPricePrlabel.Location = new System.Drawing.Point(38, 251);
            this.SellPricePrlabel.Name = "SellPricePrlabel";
            this.SellPricePrlabel.Size = new System.Drawing.Size(103, 15);
            this.SellPricePrlabel.TabIndex = 6;
            this.SellPricePrlabel.Text = "Цена реализации";
            // 
            // ProductTypecomboBox
            // 
            this.ProductTypecomboBox.FormattingEnabled = true;
            this.ProductTypecomboBox.Items.AddRange(new object[] {
            "Food",
            "Hardware",
            "Medical_supplie",
            "Tool",
            "Unknown"});
            this.ProductTypecomboBox.Location = new System.Drawing.Point(38, 353);
            this.ProductTypecomboBox.Name = "ProductTypecomboBox";
            this.ProductTypecomboBox.Size = new System.Drawing.Size(121, 23);
            this.ProductTypecomboBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(37, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Добавить товар";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 467);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Очистить поле";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(259, 56);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(728, 434);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // TypePrlabel
            // 
            this.TypePrlabel.AutoSize = true;
            this.TypePrlabel.Location = new System.Drawing.Point(37, 321);
            this.TypePrlabel.Name = "TypePrlabel";
            this.TypePrlabel.Size = new System.Drawing.Size(67, 15);
            this.TypePrlabel.TabIndex = 11;
            this.TypePrlabel.Text = "Тип товара";
            // 
            // SellingPriceProducttextBox
            // 
            this.SellingPriceProducttextBox.Location = new System.Drawing.Point(37, 282);
            this.SellingPriceProducttextBox.Name = "SellingPriceProducttextBox";
            this.SellingPriceProducttextBox.Size = new System.Drawing.Size(122, 23);
            this.SellingPriceProducttextBox.TabIndex = 12;
            this.SellingPriceProducttextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SellingPriceProducttextBox_KeyPress);
            this.SellingPriceProducttextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.SellingPriceProducttextBox.Leave += new System.EventHandler(this.Form1_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 520);
            this.Controls.Add(this.SellingPriceProducttextBox);
            this.Controls.Add(this.TypePrlabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProductTypecomboBox);
            this.Controls.Add(this.SellPricePrlabel);
            this.Controls.Add(this.BuyingPriceProducttextBox);
            this.Controls.Add(this.AmountProducttextBox);
            this.Controls.Add(this.NameProduxtTextBox);
            this.Controls.Add(this.BuyPricePrlabe);
            this.Controls.Add(this.AmountPrlabel);
            this.Controls.Add(this.NamePrLabel);
            this.Name = "Form1";
            this.Text = "Storage Control";
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NamePrLabel;
        private Label AmountPrlabel;
        private Label BuyPricePrlabe;
        private TextBox NameProduxtTextBox;
        private TextBox AmountProducttextBox;
        private TextBox BuyingPriceProducttextBox;
        private Label SellPricePrlabel;
        private ComboBox ProductTypecomboBox;
        private Button button1;
        private Button button2;
        private RichTextBox richTextBox1;
        private Label TypePrlabel;
        private TextBox SellingPriceProducttextBox;
    }
}