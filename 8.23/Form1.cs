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

namespace _8._23
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
                List<int> list = ListCovert.StrToIntList(ListInput.Text);
                IntListTools intList = new IntListTools(list);
                List<int> NewList = intList.GetPopularEl();
                ListOut.Text = ListCovert.IntListToStr(NewList);
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка ввода", "ошибка");
            }
        }
    }
}
