namespace _7._54
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
            this.ArrInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CountOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ArrInput
            // 
            this.ArrInput.Location = new System.Drawing.Point(15, 26);
            this.ArrInput.Name = "ArrInput";
            this.ArrInput.Size = new System.Drawing.Size(314, 20);
            this.ArrInput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "введите массив";
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(84, 52);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(186, 41);
            this.CalcBtn.TabIndex = 4;
            this.CalcBtn.Text = "посчитать количество элементов удволетворяющих условию";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "количество элементов удволетворяющих условию:";
            // 
            // CountOut
            // 
            this.CountOut.AutoSize = true;
            this.CountOut.Location = new System.Drawing.Point(288, 100);
            this.CountOut.Name = "CountOut";
            this.CountOut.Size = new System.Drawing.Size(10, 13);
            this.CountOut.TabIndex = 6;
            this.CountOut.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 234);
            this.Controls.Add(this.CountOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.ArrInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "7.54";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ArrInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CountOut;
    }
}

