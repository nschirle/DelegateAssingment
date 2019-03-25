using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAssignment
{
    class FatorialNumbers
    {

        public double ComputeValue(int num)
        {
            if (num > 0)
            {
                int fact = 1;
                for (int i = 1; i <= num; i++)
                {
                    fact *= i;
                }
                return fact;
            }
            else
            {
                return -1;
            }
        }
    }
}
