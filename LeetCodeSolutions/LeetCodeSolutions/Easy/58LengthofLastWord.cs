using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Easy
{
    internal class _58LengthofLastWord
    {
        public int LengthOfLastWord(string s)
        {
            s = s.Trim();
            Console.WriteLine("s :" + s);
            int lastIndex = s.LastIndexOf(' ');
            Console.WriteLine("lastIndex :" + lastIndex);

            return s.Length - lastIndex - 1;
        }
    }
}
