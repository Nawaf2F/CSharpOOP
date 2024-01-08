using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal struct WorkTask
    {
        public string description;
        public int hours;

        public void peformTask()
        {
            Console.WriteLine($"\nTask {description} of {hours} has been peformed");
        }
    }
}
