using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class IntListTools
    {
        public List<int> list { get; set; }
        public IntListTools(List<int> list)
        {
            this.list = list;
        }
        public List<int> GetPopularEl()
        {
            List<int> ListCopy = new List<int>(list);
            //ListCopy.Sort();
            Sort(ListCopy);
            List<int> NewList = new List<int>();
            int Lenth = 0;
            int LenthTemp = 0;
            for (int i = 0; i < list.Count;)
            {
                LenthTemp = ListCopy.LastIndexOf(ListCopy[i]) - i + 1;
                if(LenthTemp > Lenth)
                {
                    NewList.Clear();
                    Lenth = LenthTemp;
                }
                if(LenthTemp == Lenth)
                {
                    NewList.Add(ListCopy[i]);
                }
                i += LenthTemp;
            }
            return NewList;
        }
        private void Sort(IList<int> list)
        {
            int temp = 0;
            for (int i = 1; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - i; j++)
                {
                    if(list[j]>list[j+1])
                    {
                        temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }
    }
}
