using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using ConsoleLibrary;

namespace _9._23_C
{
    class Program
    {
        static string GetString(int Row, int Column)
        {
            return "(" + Row + ";" + Column + ";)";
        }
        static void Main(string[] args)
        {
            while(true)
            {
                Task();
            }
        }

        private static void Task()
        {
            Console.WriteLine("первый массив");
            int[,] FirstArr2 = ConsoleTools.InputArr2(false);
            Console.WriteLine("второй массив");
            int[,] SecondArr2 = ConsoleTools.InputArr2(false);
            Array2Tools array2Tools = new Array2Tools(FirstArr2);
            array2Tools.GetOverlayPoint(SecondArr2, out int Row, out int Column);
            ConsoleTools.OutputStr(GetString(Row, Column));
            Console.ReadKey();
        }
    }
}
