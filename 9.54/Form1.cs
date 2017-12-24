using GridViewLibrary;
using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*54.	Дана действительная квадратная матрица N×N. Требуется переставить строки матрицы по возрастанию первых элементов строк. 
 **/
namespace _9._54
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Array2FileTools array2File = new Array2FileTools(openFileDialog.FileName);
                    int[,] Arr2 = array2File.Read();
                    DataGridViewUtils.Array2ToGrid(Array2, Arr2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "eror");
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Array2FileTools array2File = new Array2FileTools(saveFileDialog.FileName);
                    array2File.Write(DataGridViewUtils.GridToArray2<int>(Array2));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "eror");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewUtils.InitGridForArr(Array2, 40, false, false, false, false, true, true);
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "eror");
            }
            int[,] Arr2 = DataGridViewUtils.GridToArray2<int>(Array2);
            Array2Tools array2Tools = new Array2Tools(Arr2);
            int[,] NewArr2 = array2Tools.SortRows();
            DataGridViewUtils.Array2ToGrid(Array2, NewArr2);
        }
    }
}
