namespace AffineTransformation
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
            panel1 = new Panel();
            label8 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label7 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(165, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 212);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(65, 125);
            label8.Name = "label8";
            label8.Size = new Size(223, 30);
            label8.TabIndex = 14;
            label8.Text = "При вводе нецелых чисел необходимо\r\n записывать их с помощью ,\r\n";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.Location = new Point(257, 174);
            button3.Name = "button3";
            button3.Size = new Size(78, 33);
            button3.TabIndex = 13;
            button3.Text = "Сделать";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(135, 174);
            button2.Name = "button2";
            button2.Size = new Size(78, 33);
            button2.TabIndex = 12;
            button2.Text = "Сделать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(14, 174);
            button1.Name = "button1";
            button1.Size = new Size(78, 33);
            button1.TabIndex = 1;
            button1.Text = "Сделать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(236, 83);
            label7.Name = "label7";
            label7.Size = new Size(40, 21);
            label7.TabIndex = 11;
            label7.Text = "по y";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(282, 80);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(63, 29);
            textBox5.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(237, 48);
            label6.Name = "label6";
            label6.Size = new Size(39, 21);
            label6.TabIndex = 9;
            label6.Text = "по x";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(282, 45);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(63, 29);
            textBox4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(119, 83);
            label5.Name = "label5";
            label5.Size = new Size(40, 21);
            label5.TabIndex = 7;
            label5.Text = "по y";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 48);
            label4.Name = "label4";
            label4.Size = new Size(39, 21);
            label4.TabIndex = 6;
            label4.Text = "по x";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(165, 80);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(63, 29);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(165, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(63, 29);
            textBox2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 12);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 4;
            label3.Text = "Движение";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 42);
            label2.TabIndex = 3;
            label2.Text = "Сжатие\r\n(растяжение)";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 29);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 42);
            label1.TabIndex = 1;
            label1.Text = "Угол \r\nповорота";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 230);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(660, 350);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 592);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Аффинные преобразования";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label7;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox4;
        private Label label5;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button2;
        private Label label8;
    }
}