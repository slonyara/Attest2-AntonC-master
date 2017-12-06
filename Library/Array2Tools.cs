using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Array2Tools
    {
        public int[,] Arr2 { get; set; }
        public Array2Tools(int[,] Arr2)
        {
            this.Arr2 = Arr2;
        }
        private bool OverlayCheck(int[,] SecondArr2, int RowIndex, int ColumnIndex)
        {
            if(SecondArr2.GetLength(0) + RowIndex > Arr2.GetLength(0) || SecondArr2.GetLength(1) + ColumnIndex > Arr2.GetLength(1))
            {
                return false;
            }
            for (int i = 0; i < SecondArr2.GetLength(0); i++)
            {
                for (int j = 0; j < SecondArr2.GetLength(1); j++)
                {
                    if (SecondArr2[i,j] != Arr2[i+RowIndex,j+ColumnIndex])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool GetOverlayPoint(int[,] SecondArr2, out int Row, out int Column)
        {
            for (int i = 0; i < Arr2.GetLength(0) - SecondArr2.GetLength(0) + 1; i++)
            {
                for (int j = 0; j < Arr2.GetLength(1) - SecondArr2.GetLength(1) + 1; j++)
                {
                    if (OverlayCheck(SecondArr2, i, j))
                    {
                        Row = i;
                        Column = j;
                        return true;
                    }
                }
            }
            Row = 0; Column = 0;
            return false;
        }
        private void Swap2Rows(int[,] SecondArr2, int Row1, int Row2)
        {
            if (Row1 < SecondArr2.GetLength(0) && Row2 < SecondArr2.GetLength(0))
            {
                int temp = 0;
                for (int i = 0; i < SecondArr2.GetLength(1); i++)
                {
                    temp = SecondArr2[Row1, i];
                    SecondArr2[Row1, i] = SecondArr2[Row2, i];
                    SecondArr2[Row2, i] = temp;
                }
            }
        }
        private bool Row1MoreRow2(int[,] SecondArr2,int Row1, int Row2)
        {
            for (int i = 0; i < SecondArr2.GetLength(1); i++)
            {
                if (SecondArr2[Row1, i] > SecondArr2[Row2, i])
                {
                    return true;
                }
                if (SecondArr2[Row1, i] < SecondArr2[Row2, i])
                {
                    return false;
                }
            }
            return false;
        }
        public int[,] SortRows()
        {
            int[,] NewArr2 = (int[,])Arr2.Clone();
            for (int i = NewArr2.GetLength(0) - 1; i > 0 ; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Row1MoreRow2(NewArr2, j, j + 1)) 
                    {
                        Swap2Rows(NewArr2, j, j + 1);
                    }
                }
            }
            return NewArr2;
        }
    }
}
