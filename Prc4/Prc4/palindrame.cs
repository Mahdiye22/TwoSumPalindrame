using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSumPalindrame
{
    class Palindrame
    {
        public bool IsPalindrame(string a)
        {
            int right = a.Length - 1;
            for (int i = 0; i < right / 2; i++)
            {

                if (a[i] != a[right - i])
                {

                    return false;
                }
            }

            return true;
        }

    }
}
