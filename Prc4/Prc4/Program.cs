using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSumPalindrame
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] nums = new int[4] { 2, 15, 11, 7 };
            int target = 9;
            Console.WriteLine(TwoSum.twoSum(nums,target));
            Palindrame s = new Palindrame();
            Console.WriteLine(s.IsPalindrame("level"));
            Console.ReadKey();
        }
    }
}
