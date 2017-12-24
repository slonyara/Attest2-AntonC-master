using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;
/*54.	Вводится массив целых чисел. Найти количество элементов в массиве, которые можно получить сложением любых 2-х других элементов массива. Для массива { 1, 0, 2, 4, 3, 10, 8, 2, 3 } правильным ответом будет 6 (2[2] = 0[1] + 2[7], 4[3] = 2[2] + 2[7], 3[4] = 1[0] + 2[2], 10[5] = 2[2] + 8[6], 2[7] = 0[1] + 2[2], 3[8] = 1[0] + 2[2]).
 **/
namespace _7._54
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int[] Arr = ArrayConvert.StrToArray<int>(ArrInput.Text);
                ArrayTools At = new ArrayTools(Arr);
                CountOut.Text = At.GetCountSumEl().ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка ввода", "ошибка");
            }
        }
    }
}
