using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GridViewLibrary;
using Library;
/*23.	Для двух переданных прямоугольных массивов целых чисел определить, можно ли второй массив наложить на первый таким образом, чтобы значения в ячейках совпадали.
Функция должна вернуть координаты ячейки первого массива, на который требуется поместить верхний левый угол второго массива

 *//
namespace _9._23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewUtils.InitGridForArr(FirstArray2, 40, false, false, false, true, true, false);
            DataGridViewUtils.InitGridForArr(SecondArray2, 40, false, false, false, true, true, false);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] FirstArr2 = DataGridViewUtils.GridToArray2<int>(FirstArray2);
                int[,] SecondArr2 = DataGridViewUtils.GridToArray2<int>(SecondArray2);
                Array2Tools a2t = new Array2Tools(FirstArr2);
                if (a2t.GetOverlayPoint(SecondArr2, out int Row, out int Column))
                {
                    labelOut.Text = "(" + Row + ";" + Column + ";)";
                    save.Enabled = true;
                }
                else
                {
                    labelOut.Text = "точка не существует";
                    save.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "eror");
            }
        }
        private void Open(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Array2FileTools array2File = new Array2FileTools(openFileDialog.FileName);
                    int[,] Arr2 = array2File.Read();
                    if (sender == open1)
                    {
                        DataGridViewUtils.Array2ToGrid(FirstArray2, Arr2);
                    }
                    else
                    {
                        DataGridViewUtils.Array2ToGrid(SecondArray2, Arr2);
                    }
                }
                catch (Exception ex )
                {
                    MessageBox.Show(ex.Message, "eror");
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Array2FileTools array2File = new Array2FileTools(saveFileDialog.FileName);
                    array2File.Write(labelOut.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "eror");
                }
            }
        }
    }
}
