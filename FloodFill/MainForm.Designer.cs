namespace FloodFill
{
    partial class MainForm
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
            pictureBox = new PictureBox();
            colorDialog = new ColorDialog();
            comboBox = new ComboBox();
            label = new Label();
            button = new Button();
            labelForButton = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(33, 79);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(323, 204);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.MouseClick += pictureBox_MouseClick;
            // 
            // comboBox
            // 
            comboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "Заливка с затравкой", "Построчное сканирование" });
            comboBox.Location = new Point(64, 33);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(258, 29);
            comboBox.TabIndex = 1;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(97, 9);
            label.Name = "label";
            label.Size = new Size(195, 21);
            label.TabIndex = 2;
            label.Text = "Выберите способ заливки";
            // 
            // button
            // 
            button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button.Location = new Point(281, 298);
            button.Name = "button";
            button.Size = new Size(87, 36);
            button.TabIndex = 3;
            button.Text = "Очистить";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // labelForButton
            // 
            labelForButton.AutoSize = true;
            labelForButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelForButton.Location = new Point(33, 292);
            labelForButton.Name = "labelForButton";
            labelForButton.Size = new Size(224, 42);
            labelForButton.TabIndex = 4;
            labelForButton.Text = "Если хотите очистить фигуру, \r\nнажмите на кнопку";
            labelForButton.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 346);
            Controls.Add(labelForButton);
            Controls.Add(button);
            Controls.Add(label);
            Controls.Add(comboBox);
            Controls.Add(pictureBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainForm";
            Text = "Заливка фигуры";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private ColorDialog colorDialog;
        private ComboBox comboBox;
        private Label label;
        private Button button;
        private Label labelForButton;
    }
}