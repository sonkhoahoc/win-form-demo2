using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclareBUS
{
    public class Tool
    {
        public static string fillNumber(string str)
        {
            string result = "";
            foreach (char c in str)
            {
                if (c >= '0' && c <= '9')
                {
                    result = result + c;
                }
            }
            return result;
        }
    }
}
