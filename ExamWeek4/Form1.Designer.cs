namespace ExamWeek4
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
            comboBox_dayInWeek = new ComboBox();
            comboBox_dayInMonth = new ComboBox();
            comboBox_Month = new ComboBox();
            comboBox_year = new ComboBox();
            button_calculate = new Button();
            SuspendLayout();
            // 
            // comboBox_dayInWeek
            // 
            comboBox_dayInWeek.FormattingEnabled = true;
            comboBox_dayInWeek.Location = new Point(545, 74);
            comboBox_dayInWeek.Name = "comboBox_dayInWeek";
            comboBox_dayInWeek.Size = new Size(121, 23);
            comboBox_dayInWeek.TabIndex = 0;
            // 
            // comboBox_dayInMonth
            // 
            comboBox_dayInMonth.FormattingEnabled = true;
            comboBox_dayInMonth.Location = new Point(401, 74);
            comboBox_dayInMonth.Name = "comboBox_dayInMonth";
            comboBox_dayInMonth.Size = new Size(121, 23);
            comboBox_dayInMonth.TabIndex = 0;
            // 
            // comboBox_Month
            // 
            comboBox_Month.FormattingEnabled = true;
            comboBox_Month.Location = new Point(257, 74);
            comboBox_Month.Name = "comboBox_Month";
            comboBox_Month.Size = new Size(121, 23);
            comboBox_Month.TabIndex = 0;
            // 
            // comboBox_year
            // 
            comboBox_year.FormattingEnabled = true;
            comboBox_year.Location = new Point(113, 74);
            comboBox_year.Name = "comboBox_year";
            comboBox_year.Size = new Size(121, 23);
            comboBox_year.TabIndex = 0;
            // 
            // button_calculate
            // 
            button_calculate.Location = new Point(282, 243);
            button_calculate.Name = "button_calculate";
            button_calculate.Size = new Size(221, 50);
            button_calculate.TabIndex = 1;
            button_calculate.Text = "חשב תאריך ושמור";
            button_calculate.UseVisualStyleBackColor = true;
            button_calculate.Click += button_calculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_calculate);
            Controls.Add(comboBox_year);
            Controls.Add(comboBox_Month);
            Controls.Add(comboBox_dayInMonth);
            Controls.Add(comboBox_dayInWeek);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox_dayInWeek;
        private ComboBox comboBox_dayInMonth;
        private ComboBox comboBox_Month;
        private ComboBox comboBox_year;
        private Button button_calculate;
    }
}
