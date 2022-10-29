using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Helpers.Extentions
{
    public static class Calculate
    {
        public static int CalculateFactorial(this int num)
        {
            int result = 1;
            if (num == 0)
               return 1;           
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    result *= i;
                }

                return result;
            }
        }
    }
}
