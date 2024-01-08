using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class1
    {
        public static int CalcYearWage(int monthly, int numOfMonthWorked)
        {
            if (numOfMonthWorked == 12) {
            return monthly * (numOfMonthWorked + 1);
            }
            return monthly * numOfMonthWorked;
        }

        public static int AddTwoNum(int a, int b) => a + b;
    }
}
