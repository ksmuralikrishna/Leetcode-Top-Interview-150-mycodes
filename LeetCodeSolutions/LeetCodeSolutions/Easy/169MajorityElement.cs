using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Easy
{
    internal class _169MajorityElement
    {
        public int MajorityElement(int[] nums)
        {
            int count = 0, candidate = 0;
            foreach (int num in nums)
            {
                if (count == 0)
                {
                    candidate = num;
                }
                if (num == candidate)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
            return candidate;
        }
    }
}
