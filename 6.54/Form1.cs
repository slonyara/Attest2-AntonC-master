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

namespace _6._54
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            double X, E;
            try
            {
                X = double.Parse(InputX.Text);
                E = double.Parse(InputE.Text);
                FormulsTools ft = new FormulsTools(X, E);
                OutputX1.Text = ft.Left().ToString();
                OutputX2.Text = ft.Right().ToString();
                OutputN.Text = ft.N.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка ввода", "ошибка");
            }
        }
    }
}
