using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Library
{
    public class Array2FileTools
    {
        public string FileName { get; set; }
        public Array2FileTools(string FileName)
        {
            this.FileName = FileName;
        }
        public int[,] Read()
        {
            try
            {
                return Array2Convert.StrToArr2(File.ReadAllText(FileName));
            }
            catch (Exception)
            {
                throw new Exception("ошибка чтения");
            }
        }
        public void Write(int[,] Arr2)
        {
            try
            {
                File.WriteAllText(FileName, Array2Convert.Arr2ToStr(Arr2));
            }
            catch (Exception)
            {
                throw new Exception("ошибка записи");
            }
        }
        public void Write(string s)
        {
            try
            {
                File.WriteAllText(FileName, s);
            }
            catch (Exception)
            {
                throw new Exception("ошибка записи");
            }
        }
    }
}
