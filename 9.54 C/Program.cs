using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleLibrary;
using Library;

namespace _9._54_C
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Task();
            }
        }

        private static void Task()
        {
            int[,] Arr2 = ConsoleTools.InputArr2(true);
            Array2Tools array2Tools = new Array2Tools(Arr2);
            int[,] NewArr2 = array2Tools.SortRows();
            ConsoleTools.OutputArr2(NewArr2);
            Console.ReadKey();
        }
    }
}
