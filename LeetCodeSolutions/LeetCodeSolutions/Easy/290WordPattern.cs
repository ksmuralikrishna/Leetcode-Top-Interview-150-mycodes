using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Easy
{
    public class WordPattern
    {
        public bool fnWordPattern(string pattern, string s)
        {
            string[] words = s.Split(' ');
            if (words.Length != pattern.Length) return false;
            var Dic = new Dictionary<char, string>();
            var MappedPattern = new HashSet<string>();
            for(int i = 0; i < pattern.Length; i++)
            {
                char character = pattern[i];
                if (Dic.ContainsKey(pattern[i]))
                {
                    if (Dic[pattern[i]] != words[i]) return false;
                }
                else
                {
                    if (MappedPattern.Contains(words[i])) return false;
                    MappedPattern.Add(words[i]);
                    Dic[pattern[i]] = words[i];
                }
            }
            
            return true;
        }
    }
}
