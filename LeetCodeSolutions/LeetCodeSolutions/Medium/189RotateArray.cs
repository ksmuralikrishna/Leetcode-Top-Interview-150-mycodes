using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Easy
{
    internal class _189RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            int n = nums.Length;
            k %= n; // Handle cases where k > n

            Reverse(nums, 0, n - 1);      // Step 1: Reverse the entire array
            Reverse(nums, 0, k - 1);      // Step 2: Reverse the first k elements
            Reverse(nums, k, n - 1);      // Step 3: Reverse the remaining elements
        }

        private void Reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }
    }
}
