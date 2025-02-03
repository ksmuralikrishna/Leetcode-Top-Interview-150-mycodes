// I chosed moores voting algorithm to find a solution.
// Algorith:-
// 1) make a number candidate key
// 2) Validate the key using point.

public class Solution {
    public int MajorityElement(int[] nums) {
        int count = 0, candidate = 0;

        foreach (int num in nums) {
            if (count == 0) {
                candidate = num;
            }
            if (num == candidate) {
                count++;
            } else {
                count--;
            }
        }

        return candidate;
    }
}
