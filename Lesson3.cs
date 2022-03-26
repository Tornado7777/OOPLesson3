using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson3
{
    internal class Lesson3
    {
        private string _str;
        public string Str { get { return _str; } set { _str = value; } }
        public string ReversString(string str)
        {
            char[] chars = str.ToCharArray();
            str = "";
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                str += chars[i];
            }
            return str;
        }
    }
}
