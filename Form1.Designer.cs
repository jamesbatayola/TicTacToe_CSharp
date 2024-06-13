namespace TicTacToe
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            userLabel = new Label();
            aiLabel = new Label();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = Color.Black;
            btn1.Location = new Point(10, 58);
            btn1.Name = "btn1";
            btn1.Size = new Size(107, 99);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.ForeColor = Color.Black;
            btn2.Location = new Point(123, 58);
            btn2.Name = "btn2";
            btn2.Size = new Size(107, 99);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.ForeColor = Color.Black;
            btn3.Location = new Point(236, 58);
            btn3.Name = "btn3";
            btn3.Size = new Size(107, 99);
            btn3.TabIndex = 2;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.ForeColor = Color.Black;
            btn4.Location = new Point(10, 163);
            btn4.Name = "btn4";
            btn4.Size = new Size(107, 99);
            btn4.TabIndex = 3;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.ForeColor = Color.Black;
            btn5.Location = new Point(123, 163);
            btn5.Name = "btn5";
            btn5.Size = new Size(107, 99);
            btn5.TabIndex = 4;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.ForeColor = Color.Black;
            btn6.Location = new Point(236, 163);
            btn6.Name = "btn6";
            btn6.Size = new Size(107, 99);
            btn6.TabIndex = 5;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.ForeColor = Color.Black;
            btn7.Location = new Point(10, 268);
            btn7.Name = "btn7";
            btn7.Size = new Size(107, 99);
            btn7.TabIndex = 6;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.ForeColor = Color.Black;
            btn8.Location = new Point(123, 268);
            btn8.Name = "btn8";
            btn8.Size = new Size(107, 99);
            btn8.TabIndex = 7;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.ForeColor = Color.Black;
            btn9.Location = new Point(236, 268);
            btn9.Name = "btn9";
            btn9.Size = new Size(107, 99);
            btn9.TabIndex = 8;
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // userLabel
            // 
            userLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userLabel.ImageAlign = ContentAlignment.MiddleRight;
            userLabel.Location = new Point(10, 9);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(107, 33);
            userLabel.TabIndex = 9;
            userLabel.Text = "user = ";
            userLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // aiLabel
            // 
            aiLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aiLabel.ForeColor = SystemColors.ControlText;
            aiLabel.ImageAlign = ContentAlignment.MiddleRight;
            aiLabel.Location = new Point(249, 9);
            aiLabel.Name = "aiLabel";
            aiLabel.Size = new Size(85, 33);
            aiLabel.TabIndex = 10;
            aiLabel.Text = "ai =";
            aiLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(355, 375);
            Controls.Add(aiLabel);
            Controls.Add(userLabel);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "TicTacToe";
            ResumeLayout(false);
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Label userLabel;
        private Label aiLabel;
    }
}
