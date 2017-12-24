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

namespace _6._23
{
    public partial class Form1 : Form
    {
        /*
         * В заданной строке установить пробелы вместо символов, номера позиций которых при делении на 4 дают в остатке 3
         * */
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inp = Input.Text;
            StrTools st = new StrTools(inp);
            Output.Text = st.GetNewStr();
        }
    }
}
