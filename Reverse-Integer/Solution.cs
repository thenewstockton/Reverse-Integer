using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Integer
{
    public class Solution
    {
        public int Reverse(int x)
        {
            long y = x;
            long result = 0;
            bool isNegative = false;
            if (y < 0)
            {
                isNegative = true;
                y = -1 * y;
            }
            var longList = y.ToString().Select(digit => long.Parse(digit.ToString())).ToList();
            for (int i = 0; i < longList.Count; i++)
            {
                result += longList[i] * (int)Math.Pow(10, i);
            }
            return ConvertFromLongToInt(result * (isNegative ? -1 : 1));
        }

        private int ConvertFromLongToInt(long input)
        {
            try
            {
                return checked((int)input);
            }catch(OverflowException ex)
            {
                return 0;
            }
            
        }
    }
}
