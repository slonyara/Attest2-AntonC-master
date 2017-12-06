namespace _8._23
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
            this.ListInput = new System.Windows.Forms.TextBox();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.ListOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "введите список ";
            // 
            // ListInput
            // 
            this.ListInput.Location = new System.Drawing.Point(16, 29);
            this.ListInput.Name = "ListInput";
            this.ListInput.Size = new System.Drawing.Size(256, 20);
            this.ListInput.TabIndex = 1;
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(16, 56);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(256, 23);
            this.CalcBtn.TabIndex = 2;
            this.CalcBtn.Text = "найти самые частые элементы";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // ListOut
            // 
            this.ListOut.AutoSize = true;
            this.ListOut.Location = new System.Drawing.Point(16, 86);
            this.ListOut.Name = "ListOut";
            this.ListOut.Size = new System.Drawing.Size(10, 13);
            this.ListOut.TabIndex = 3;
            this.ListOut.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ListOut);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.ListInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "8.23";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ListInput;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.Label ListOut;
    }
}

