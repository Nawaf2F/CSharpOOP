using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Manager : Employee
    {
        public Manager(string fName, string lName, int NOHW, DateTime birth, EmployeeType empType) : base(fName, lName, NOHW, birth, empType)
        {
        }

        public override void GiveBonus()
        {
            if(numOfHourWorked > 8)
            {
                Console.WriteLine($"\nManager {firstName} {lastName} has received 500$ as bonus!\n");
            }
            else
            {
                Console.WriteLine($"\nManager {firstName} {lastName} has received 250$ as bonus!\n");
            }
        }
    }
}
