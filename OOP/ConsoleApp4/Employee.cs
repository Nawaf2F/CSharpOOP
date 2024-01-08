using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
  internal class Employee : IEmployee
    {
        public string firstName; 
        public string lastName;
        public string email;

        public int numOfHourWorked;
        public double wage;
        public double hourlyRate;

        public DateTime birthDay;

        public EmployeeType employeeType;

        private Address address;

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        //Constructer for creating new instance
        public Employee(string fName,string lName, int NOHW): this(fName, lName, NOHW, new DateTime(2023,7,22),EmployeeType.Manager) {

        }

        // Method overload: The same name but different parameter
        public Employee(string fName, string lName, int NOHW, DateTime birth, EmployeeType empType)
        {
            firstName = fName;
            lastName = lName;
            numOfHourWorked = NOHW;
            birthDay = birth;
            employeeType = empType;
        }

        public Employee(string fName, string lName, int NOHW, DateTime birth, EmployeeType empType, string street, string city, string HN)
        {
            firstName = fName;
            lastName = lName;
            numOfHourWorked = NOHW;
            birthDay = birth;
            employeeType = empType;
            //Compostion
            Address = new Address(street,city,HN);

        }
        public void peformWork()
        {
            numOfHourWorked++;
            Console.WriteLine($"{firstName} {lastName} has worked for {numOfHourWorked} hour(s)!");

        }

        public void details()
        {
            if(employeeType == EmployeeType.Manager)
            {
                Console.WriteLine($"Manager {firstName} {lastName}");
            }
            Console.WriteLine($"\nEmployee\nFirst Name: {firstName} \n" +
                $"Last Name: {lastName}\n" +
                $"Hour Worked: {numOfHourWorked} hour(s)!\n" +
                $"Date Of Birth: {birthDay}\n" +
                $"Employee Type: {employeeType}\n");
        }

        public virtual void GiveBonus()
        {
            Console.WriteLine($"\nEmployee {firstName} {lastName} has received 100$ as bonus!\n");
        }






    }
}
