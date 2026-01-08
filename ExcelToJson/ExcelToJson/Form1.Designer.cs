namespace ExcelToJson
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
            button1 = new Button();
            button2 = new Button();
            checkedListBox1 = new CheckedListBox();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(647, 385);
            button1.Name = "button1";
            button1.Size = new Size(142, 40);
            button1.TabIndex = 0;
            button1.Text = "Build";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(647, 347);
            button2.Name = "button2";
            button2.Size = new Size(142, 32);
            button2.TabIndex = 1;
            button2.Text = "새로고침";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(647, 13);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(142, 328);
            checkedListBox1.TabIndex = 2;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(23, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 412);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(569, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 15);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 4;
            label1.Text = "Excel path";
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(16, 213);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(569, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(16, 273);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(569, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(16, 153);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(569, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(16, 93);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(569, 23);
            textBox5.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 75);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 10;
            label2.Text = "Client json";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 135);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 11;
            label3.Text = "Client source";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 195);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 12;
            label4.Text = "Server json";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 255);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 13;
            label5.Text = "Server source";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 439);
            Controls.Add(panel1);
            Controls.Add(checkedListBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private CheckedListBox checkedListBox1;
        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
