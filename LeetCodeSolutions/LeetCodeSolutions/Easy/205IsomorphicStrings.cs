using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Easy 
{
    public class Solution
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length == 0 && t.Length == 0) return false;

            var Dic = new Dictionary<char, char>();
            var mappedChar = new HashSet<char>();
            
            for(int i=0; i < s.Length; i++)
            {
                if (Dic.ContainsKey(s[i]))
                {
                    if (Dic[s[i]] != t[i]) return false;
                }
                else
                {
                    if (mappedChar.Contains(t[i])) return false;
                    mappedChar.Add(t[i]);
                    Dic[s[i]] = t[i]; 
                }

            }
            return true;
            
            
        }
    }

}
