namespace _9._23
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
            this.FirstArray2 = new System.Windows.Forms.DataGridView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.open1 = new System.Windows.Forms.ToolStripMenuItem();
            this.open2 = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.SecondArray2 = new System.Windows.Forms.DataGridView();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.labelOut = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.FirstArray2)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondArray2)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstArray2
            // 
            this.FirstArray2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FirstArray2.Location = new System.Drawing.Point(12, 27);
            this.FirstArray2.Name = "FirstArray2";
            this.FirstArray2.Size = new System.Drawing.Size(270, 156);
            this.FirstArray2.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(584, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open1,
            this.open2,
            this.save});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "файл";
            // 
            // open1
            // 
            this.open1.Name = "open1";
            this.open1.Size = new System.Drawing.Size(181, 22);
            this.open1.Text = "открыть 1 матрицу";
            this.open1.Click += new System.EventHandler(this.Open);
            // 
            // open2
            // 
            this.open2.Name = "open2";
            this.open2.Size = new System.Drawing.Size(181, 22);
            this.open2.Text = "открыть 2 матрицу ";
            this.open2.Click += new System.EventHandler(this.Open);
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(181, 22);
            this.save.Text = "сохранить ответ ";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // SecondArray2
            // 
            this.SecondArray2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SecondArray2.Location = new System.Drawing.Point(302, 27);
            this.SecondArray2.Name = "SecondArray2";
            this.SecondArray2.Size = new System.Drawing.Size(270, 156);
            this.SecondArray2.TabIndex = 2;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(37, 211);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(132, 38);
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.Text = "найти точку наложения ";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // labelOut
            // 
            this.labelOut.AutoSize = true;
            this.labelOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOut.Location = new System.Drawing.Point(230, 216);
            this.labelOut.Name = "labelOut";
            this.labelOut.Size = new System.Drawing.Size(15, 24);
            this.labelOut.TabIndex = 4;
            this.labelOut.Text = " ";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*\"";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.labelOut);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SecondArray2);
            this.Controls.Add(this.FirstArray2);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "9.23";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FirstArray2)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondArray2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FirstArray2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.DataGridView SecondArray2;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label labelOut;
        private System.Windows.Forms.ToolStripMenuItem open1;
        private System.Windows.Forms.ToolStripMenuItem open2;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

