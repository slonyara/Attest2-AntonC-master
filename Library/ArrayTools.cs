using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ArrayTools
    {
        public enum param
        {
            less,
            more,
            equal
        }
        public int[] Arr { get; set; }
        public ArrayTools(int [] Arr)
        {
            this.Arr = Arr;
        }
        public int[] GetNewArray(param P, int K)
        {
            int[] NewArr = new int[Arr.Length];
            int NewArrCount = 0;
            int Elem = Arr[0];
            int ElemCount = 1;
            bool add = false;
            for (int i = 1; i <= Arr.Length; i++)
            {
                if (i == Arr.Length || Elem != Arr[i] )
                {
                    add = false;
                    switch (P)
                    {
                        case param.less:
                            if (ElemCount >= K)
                                add = true;
                            break;
                        case param.more:
                            if (ElemCount <= K)
                                add = true;
                            break;
                        case param.equal:
                            if (ElemCount != K)
                                add = true;
                            break;
                    }
                    if (add)
                    {
                        for (int j = 0; j < ElemCount; j++)
                        {
                            NewArr[NewArrCount++] = Elem;
                        }
                    }
                    else
                    {
                        NewArr[NewArrCount++] = 0;
                    }
                    if (i != Arr.Length)
                    {
                        Elem = Arr[i];
                        ElemCount = 1;
                    }
                }
                else
                {
                    ElemCount++;
                }
            }
            int[] FinalArr = new int[NewArrCount];
            Array.Copy(NewArr, FinalArr, NewArrCount);
            return FinalArr;
        }
        public int GetCountSumEl()
        {
            int Count = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                if(IsSumOF2(i))
                {
                    Count++;
                }
            }
            return Count;
        }
        bool IsSumOF2(int index)
        {
            for (int i = 0; i < Arr.Length - 1; i++)
            {
                for (int j = i+1; j < Arr.Length; j++)
                {
                    if (i != index && j != index)
                    {
                        if(Arr[index] == Arr[i]+Arr[j])
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
