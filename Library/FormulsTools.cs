using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class FormulsTools
    {
        public double X { get; set; }
        public double E { get; set; }
        public int N { get; private set; } = 0;
        public FormulsTools(double X, double E)
        {
            this.X = X;
            this.E = E;
        }

        double GetElement(double Element, int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return Element * Math.Log(2) * X / (n - 1);
            }
        }
        public double Left()
        {
            return Math.Pow(2, X);
        }
        public double Right()
        {
            N = 0;
            double Element = 1;
            double sum = 0;
            while (Math.Abs(Element) > E)
            {
                Element = GetElement(Element, ++N);
                sum += Element;
            }
            return sum;
        }
    }
}