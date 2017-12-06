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

namespace _7._23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeArrBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int[] Arr = ArrayConvert.StrToArray<int>(ArrInput.Text);
                int K = int.Parse(KInput.Text);
                ArrayTools At = new ArrayTools(Arr);
                int[] NewArr = At.GetNewArray(ArrayTools.param.less, K);
                LessArrOut.Text = ArrayConvert.ArrayToStr<int>(NewArr);
                NewArr = At.GetNewArray(ArrayTools.param.equal, K);
                EqualArrOut.Text = ArrayConvert.ArrayToStr<int>(NewArr);
                NewArr = At.GetNewArray(ArrayTools.param.more, K);
                MoreArrOut.Text = ArrayConvert.ArrayToStr<int>(NewArr);
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка ввода", "ошибка");
            }
        }
    }
}
