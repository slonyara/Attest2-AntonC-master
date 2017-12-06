using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class StrTools
    {
        public string Str { get; set; }
        public StrTools(string Str)
        {
            this.Str = Str;
        }
        public string GetNewStr()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Str.Length; i++)
            {
                if (i % 4 == 2)
                    sb.Append(' ');
                else
                    sb.Append(Str[i]);
            }
            return sb.ToString();
        }
    }
}
