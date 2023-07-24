using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSumPalindrame
{
    class TwoSum
    {
        public static int[] twoSum(int[] nums, int target)
        {
            int n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((nums[i] + nums[j]) == target)
                    {
                        Console.WriteLine($"Two sum= [{i},{j}]");
                    }
                }
            }
            return null;
        }
    }
}
