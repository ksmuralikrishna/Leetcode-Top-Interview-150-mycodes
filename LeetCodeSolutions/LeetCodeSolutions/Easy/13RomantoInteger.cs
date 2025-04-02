using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Easy
{
    internal class _13RomantoInteger
    {
        public int RomanToInt(string s)
        {
            var romanValues = new Dictionary<char, int>
        {
            {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
        };

            // Initialize the total with the value of the first character
            int previousValue = romanValues[s[0]];
            int total = previousValue;

            // Iterate through the string starting from the second character
            for (int i = 1; i < s.Length; i++)
            {
                int currentValue = romanValues[s[i]];

                // If the previous value is less than the current value, subtract the previous value
                if (previousValue < currentValue)
                {
                    total += currentValue - 2 * previousValue; // Adjust for the previous addition
                }
                else
                {
                    // Otherwise, add the current value
                    total += currentValue;
                }

                // Update the previous value
                previousValue = currentValue;
            }

            return total;
        }
    }
}
