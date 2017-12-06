namespace _6._54
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
            this.label2 = new System.Windows.Forms.Label();
            this.InputX = new System.Windows.Forms.TextBox();
            this.InputE = new System.Windows.Forms.TextBox();
            this.Calc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OutputX1 = new System.Windows.Forms.Label();
            this.OutputX2 = new System.Windows.Forms.Label();
            this.OutputN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "x =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "e =";
            // 
            // InputX
            // 
            this.InputX.Location = new System.Drawing.Point(38, 13);
            this.InputX.Name = "InputX";
            this.InputX.Size = new System.Drawing.Size(234, 20);
            this.InputX.TabIndex = 2;
            // 
            // InputE
            // 
            this.InputE.Location = new System.Drawing.Point(38, 39);
            this.InputE.Name = "InputE";
            this.InputE.Size = new System.Drawing.Size(234, 20);
            this.InputE.TabIndex = 3;
            // 
            // Calc
            // 
            this.Calc.Location = new System.Drawing.Point(102, 65);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(75, 23);
            this.Calc.TabIndex = 4;
            this.Calc.Text = "посчитать";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "по левой формуле: x =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "по правой формуле: x=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "N=";
            // 
            // OutputX1
            // 
            this.OutputX1.AutoSize = true;
            this.OutputX1.Location = new System.Drawing.Point(133, 101);
            this.OutputX1.Name = "OutputX1";
            this.OutputX1.Size = new System.Drawing.Size(10, 13);
            this.OutputX1.TabIndex = 8;
            this.OutputX1.Text = " ";
            // 
            // OutputX2
            // 
            this.OutputX2.AutoSize = true;
            this.OutputX2.Location = new System.Drawing.Point(136, 118);
            this.OutputX2.Name = "OutputX2";
            this.OutputX2.Size = new System.Drawing.Size(10, 13);
            this.OutputX2.TabIndex = 9;
            this.OutputX2.Text = " ";
            // 
            // OutputN
            // 
            this.OutputN.AutoSize = true;
            this.OutputN.Location = new System.Drawing.Point(136, 131);
            this.OutputN.Name = "OutputN";
            this.OutputN.Size = new System.Drawing.Size(10, 13);
            this.OutputN.TabIndex = 10;
            this.OutputN.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.OutputN);
            this.Controls.Add(this.OutputX2);
            this.Controls.Add(this.OutputX1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Calc);
            this.Controls.Add(this.InputE);
            this.Controls.Add(this.InputX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "6.54";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputX;
        private System.Windows.Forms.TextBox InputE;
        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label OutputX1;
        private System.Windows.Forms.Label OutputX2;
        private System.Windows.Forms.Label OutputN;
    }
}

