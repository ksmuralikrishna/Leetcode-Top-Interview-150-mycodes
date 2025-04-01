using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Medium
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length <= 2) return nums.Length; // If the array has 2 or fewer elements, return as is.

        int k = 2; // Start from index 2 since the first two elements can always remain.

        for (int i = 2; i < nums.Length; i++)
        {
            if (nums[i] != nums[k - 2])
            { // Check if current element is different from the element at k-2
                nums[k] = nums[i]; // Place the valid element in the correct position
                k++;
            }
        }

        return k;
    }
}
