namespace _7._23
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ArrInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KInput = new System.Windows.Forms.TextBox();
            this.ChangeArrBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LessArrOut = new System.Windows.Forms.Label();
            this.EqualArrOut = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MoreArrOut = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "введите массив";
            // 
            // ArrInput
            // 
            this.ArrInput.Location = new System.Drawing.Point(16, 30);
            this.ArrInput.Name = "ArrInput";
            this.ArrInput.Size = new System.Drawing.Size(256, 20);
            this.ArrInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "K =";
            // 
            // KInput
            // 
            this.KInput.Location = new System.Drawing.Point(38, 56);
            this.KInput.Name = "KInput";
            this.KInput.Size = new System.Drawing.Size(234, 20);
            this.KInput.TabIndex = 3;
            // 
            // ChangeArrBtn
            // 
            this.ChangeArrBtn.Location = new System.Drawing.Point(82, 82);
            this.ChangeArrBtn.Name = "ChangeArrBtn";
            this.ChangeArrBtn.Size = new System.Drawing.Size(117, 23);
            this.ChangeArrBtn.TabIndex = 4;
            this.ChangeArrBtn.Text = "изменить массив";
            this.ChangeArrBtn.UseVisualStyleBackColor = true;
            this.ChangeArrBtn.Click += new System.EventHandler(this.ChangeArrBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Для серий меньших k по длинне:";
            // 
            // LessArrOut
            // 
            this.LessArrOut.AutoSize = true;
            this.LessArrOut.Location = new System.Drawing.Point(15, 118);
            this.LessArrOut.Name = "LessArrOut";
            this.LessArrOut.Size = new System.Drawing.Size(10, 13);
            this.LessArrOut.TabIndex = 6;
            this.LessArrOut.Text = " ";
            // 
            // EqualArrOut
            // 
            this.EqualArrOut.AutoSize = true;
            this.EqualArrOut.Location = new System.Drawing.Point(15, 154);
            this.EqualArrOut.Name = "EqualArrOut";
            this.EqualArrOut.Size = new System.Drawing.Size(10, 13);
            this.EqualArrOut.TabIndex = 8;
            this.EqualArrOut.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Для серий равных k по длинне:";
            // 
            // MoreArrOut
            // 
            this.MoreArrOut.AutoSize = true;
            this.MoreArrOut.Location = new System.Drawing.Point(15, 193);
            this.MoreArrOut.Name = "MoreArrOut";
            this.MoreArrOut.Size = new System.Drawing.Size(10, 13);
            this.MoreArrOut.TabIndex = 10;
            this.MoreArrOut.Text = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Для серий больших k по длинне:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.MoreArrOut);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EqualArrOut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LessArrOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChangeArrBtn);
            this.Controls.Add(this.KInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ArrInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "7.23";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ArrInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KInput;
        private System.Windows.Forms.Button ChangeArrBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LessArrOut;
        private System.Windows.Forms.Label EqualArrOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label MoreArrOut;
        private System.Windows.Forms.Label label8;
    }
}

