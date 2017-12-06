using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ListCovert
    {
        public static List<int> StrToIntList(string str)
        {
            List<int> list = new List<int>();
            string[] data = str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < data.Length; i++)
            {
                list.Add(int.Parse(data[i]));
            }
            return list;
        }
        public static string IntListToStr(IList<int> list)
        {
            return string.Join(", ", list);
        }
    }
}
