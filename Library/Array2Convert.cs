using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Array2Convert
    {
        public static int[,] StrToArr2(string str)
        {
            try
            {
                string[] data = str.Split(new char[] { '\n','\r' }, StringSplitOptions.RemoveEmptyEntries);
                string[] temp = data[0].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                int[,] Arr2 = new int[data.Length, temp.Length];
                for (int i = 0; i < Arr2.GetLength(0); i++)
                {
                    temp = data[i].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < Arr2.GetLength(1); j++)
                    {
                        Arr2[i, j] = int.Parse(temp[j]);
                    }
                }
                return Arr2;
            }
            catch (Exception)
            {
                throw new Exception("введён непраильный массив");
            }
        }
        public static string Arr2ToStr(int[,] Arr2)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Arr2.GetLength(0); i++)
            {
                for (int j = 0; j < Arr2.GetLength(1); j++)
                {
                    sb.Append(Arr2[i, j]);
                    if (j != Arr2.GetLength(1) - 1)
                        sb.Append(' ');
                }
                if (i != Arr2.GetLength(0) - 1)
                    sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
