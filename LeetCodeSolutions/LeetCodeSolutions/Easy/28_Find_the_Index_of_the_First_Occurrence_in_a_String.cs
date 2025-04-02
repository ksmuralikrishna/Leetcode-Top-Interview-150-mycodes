using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Easy
{
    internal class _28_Find_the_Index_of_the_First_Occurrence_in_a_String
    {
        public class Solution
        {
            public int StrStr(string haystack, string needle)
            {
                return haystack.IndexOf(needle);
            }
        }
    }
}
