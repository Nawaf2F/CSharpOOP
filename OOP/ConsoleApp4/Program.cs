using ConsoleApp4;
using System.Text;

internal class Program
{

    public static int AddTwo(int x, int y)
    {
        int z = x + y;
        return z;
    }
    private static void Main(string[] args)
    {
        /*Console.WriteLine("Hello, World!");
        Console.WriteLine("Enter your name: ");
        String name = Console.ReadLine();
        Console.WriteLine("Hello " + name);
        */

        // --------------------------- Types ---------------------------
        /*
        int age = 23;
        int month = 6, day = 22;
        double rating = 99.75;
        bool isActive = true;
        string firstName = "Nawaf";
        Console.WriteLine(firstName);

        int a, b, c, d;
        a = 3;
        b = 10;
        c = a++;

        d = a + b * c;

        Console.WriteLine(d);
        */

        // --------------------------- Types ---------------------------
        /*
         char myChar = 'a';

        char upperCase = char.ToUpper(myChar);
        Console.WriteLine(upperCase);

        bool isDigit = char.IsDigit(myChar);
        Console.WriteLine(isDigit);

        DateTime dt = new DateTime(2023, 6, 22);
        Console.WriteLine(dt);
        */

        // --------------------------- Parsing & Typing ---------------------------
        /*
                //Explicit Typing
                int a = 123;
                //Implicit Typing 
                var b = 567;


                Console.WriteLine("Enter a first value:");
                string stringValue1 = Console.ReadLine();
                Console.WriteLine("Enter a second value:");
                string stringValue2 = Console.ReadLine();

                int intValue1 = int.Parse(stringValue1);
                int intValue2 = int.Parse(stringValue2);

                int sum = intValue1 + intValue2;
                Console.WriteLine(sum);

                int studentAge = 21;
                bool validAge = (studentAge >= 18) && (studentAge <= 70);
                Console.WriteLine($"student age {studentAge}, is he valid? {validAge}");
        */

        // --------------------------- Cases & Switch ---------------------------
        /*
        string selected;
        do
        {
            Console.WriteLine("Choose an action: \n");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Delete Employee");
            Console.WriteLine("3. Update Employee");
            Console.WriteLine("4. Show Employee");
            Console.WriteLine("5. Exit");

            selected = Console.ReadLine();

            switch (selected)
            {
                case "1":
                    Console.WriteLine("You added an employee");
                    break;

                case "2":
                    Console.WriteLine("You deleted");
                    break;

                case "3":
                    Console.WriteLine("You updated");
                    break;

                case "4":
                    Console.WriteLine("You showed");
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

        } while (selected != "5"); */

        // --------------------------- Employee Objects ---------------------------

        /* 
         int num = Class1.AddTwoNum(5, 7);
         Console.WriteLine(num);

         int yearlyWage = Class1.CalcYearWage(2000, 12);
         Console.WriteLine(yearlyWage); 

        /*
        #region Employee Objects
        Employee employee1 = new Employee("Nawaf","Fahad",8);
        Console.WriteLine(employee1.lastName);
        employee1.peformWork();

        Employee employee2 = new Employee("Ahmed", "Mohssen", 7, new DateTime(2006, 7, 6), EmployeeType.Research);
        employee2.details();

        Employee employee3 = new("Rema", "Turki", 6);
        employee3.details();
        #endregion

        StringBuilder sb = new StringBuilder();
        sb.Append("Employee");
        sb.AppendLine("John");
        sb.AppendLine("Mike");
        sb.AppendLine("Fahad");
        string list = sb.ToString();
        Console.WriteLine(list);

        WorkTask task;
        task.description = "Baking pies";
        task.hours = 3;
        task.peformTask();
        */

        // --------------------------- Arrays ---------------------------
        /*
        Console.WriteLine("How many ID's you want to register? ");

        int length = int.Parse(Console.ReadLine());

        int[] Emp = new int[length];

        for (int i = 0; i < length; i++)
        {
            Console.WriteLine($"Enter Employee ID {i + 1}:  ");
            int id = int.Parse(Console.ReadLine());
            Emp[i] = id;
        }

        for (int i = 0;i < Emp.Length; i++)
        {
            Console.WriteLine($"ID: {i + 1}\t Employee: {Emp[i]}");
        }
        */

        /*
        Employee Maha = new Employee("Maha", "Abdullah",7,new DateTime(1997,5,12), EmployeeType.Research);
        Employee Nasser = new Employee("Nasser", "Fahad", 10, new DateTime(1987, 8, 22), EmployeeType.Manager);
        Employee Jamal = new Employee("Jamal", "Turki", 8, new DateTime(2000, 6, 22), EmployeeType.Sales);

        Employee[] employees = new Employee[] {Maha, Nasser, Jamal};

        foreach (Employee e in employees)
        {
            e.details();
        }
        */

        /*
        //Array Array.Sort() .CopyTo()

        int[] ID = [1, 4, 8, 3, 21, 4];

        Console.WriteLine("Before Sorting:\n");
        foreach (int i in ID)
        {
            Console.WriteLine(i);
        }
        Array.Sort(ID);
        Console.WriteLine("After Sorting:\n");
        foreach (int i in ID)
        {
            Console.WriteLine(i);
        }
        */

        // --------------------------- Lists ---------------------------
        //Lists are flexible you dont have to specify the size
        /*
        List<int> listOfInt = new List<int>();
        listOfInt.Add(1);   
        listOfInt.Add(2);
        listOfInt.Add(3);

        listOfInt.Remove(2);

        if (listOfInt.Contains(1))
        {
            Console.WriteLine("We have found 1");
        }

        int currentNum = listOfInt.Count;

        var listToArray = listOfInt.ToArray();
        */

        // --------------------------- Object-Oriented ---------------------------
        // Encapsulation (Private & Public) on Class Car
        Car malibu = new Car();
        malibu.Plate = "4005 N E D";
        malibu.Name = "Malibu";
        malibu.SetColor("blue");
        malibu.SetModel(2019);
        Console.WriteLine($"Car info:\n" +
            $"Car Plate: {malibu.Plate}\n" +
            $"Car Company: {malibu.Name}\n" +
            $"Car Color: {malibu.GetColor()}\n" +
            $"Car Model: {malibu.GetModel()}\n");

        //Inherietence (Base & Derived Class)
        //Example (Manager is derived class)-  public class Manager : Employee{ }
        //Derived class cannot access private on the base class
        //Protected access modifier are only public for the derived class

        Manager Khalid = new Manager("Khalid","Ahmed",7, new DateTime(2000,6,22), EmployeeType.Manager);
        Khalid.details(); // Manager derives from employee

        // Is-A Relation - Manager is Employee
        Employee Ahmed = new Manager("Ahmed", "Sami",10, new DateTime(1995,4,20), EmployeeType.Manager);
        Ahmed.details(); //You can use Employee Function but not Managers
         
        //Has-A Relation - Employee Has an Address

        Employee Naif = new Employee("Naif","Fahad",10,new DateTime(1994,9,14), EmployeeType.Research,"Street No.330","Riyadh","12/A");
        string naifStreet = Naif.Address.Street;
        Console.WriteLine(naifStreet); //This relation is called compostion 

        // Polymorphism (virtual & override)

        /* override a base class method with another implementation
         if class Employee has GiveBonus() method
         and we have override the GiveBonus() in manager class
         the GiveBonus() on manager class will be used */

        List<Employee> employees = new List<Employee>();
        employees.Add(Ahmed);
        employees.Add(Naif);
        employees.Add(Khalid);

        foreach (Employee employee in employees)
        {
            employee.details();
            employee.GiveBonus();
        }

        //Interfaces

        /* It's like signing a contract, when you implement an interface
         you should follow and create the classes in the interface 
        to make sure that these method will be initiated on the class*/

        IEmployee e1 = new Manager("Emad","Dami",13,new DateTime(1980,3,20), EmployeeType.Manager);
        e1.details(); //Can be used in ploymorphic way

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("**************** Welcome *********");

        Console.ForegroundColor= ConsoleColor.White;

        // Directory & File (Read & Write)
        /*
        Car.CheckCarExist();

        Car mazda = new Car("Mazda", "White", 2009, "3215 B A S");
        Car taurus = new Car("Taurus", "green", 2022, "7382 W I N");

        List<Car> cars = new List<Car>();
        cars.Add(malibu);
        cars.Add(mazda);
        cars.Add(taurus);

        Car.SaveCars(cars);
        Car.LoadCars(cars); */

        //Error Handling
        // The app will not crash if the input was wrong
        try
        {
            Console.WriteLine("Enter a number to divide on (Don't enter 0):\t");
            string a = Console.ReadLine();
            int num = int.Parse(a);

            int ans = 10 / num;

            
        }
        catch (FormatException fex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(fex.Message);
            Console.WriteLine(fex.StackTrace);
            //Console.ResetColor();

        }
        catch(DivideByZeroException dbze)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(dbze.Message);
            //Console.ResetColor();
        }
        finally
        {
            // This block will always be executed
            Console.ResetColor();
        }
       















    }
}