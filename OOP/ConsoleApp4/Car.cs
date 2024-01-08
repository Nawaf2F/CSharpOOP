using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Car
    {
        private int model;
        private string name;
        private string color;
        private static string directory = @"C:\Users\nawaf_zfuo4i8\source\repos\ConsoleApp4\data\";
        private static string fileName = "Cars.txt";
        // Properties
        private string plate;
        public string Plate { 
            get { return plate; } 
            set 
            { 
                plate = value; 
            } 
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string GetColor()
        {
            return color;
        }

        public void SetColor(string newColor)
        {
            color = newColor;
        }

        public int GetModel()
        {
            return model;
        }

        public void SetModel(int newModel)
        {
            model = newModel;
        }
        public Car(string  name, string newColor, int newModel,string plate)
        {
            Name = name;
            Plate = plate;
            model = newModel;
            color = newColor;

        }

        public Car()
        {
        }

        internal static void CheckCarExist()
        {
            string path = $"{directory}{fileName}";
            bool fileExist = File.Exists(path);

            if (fileExist)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("File Found");
                Console.ResetColor();
            }
            else
            {
                if (!Directory.Exists(directory)){
                    Directory.CreateDirectory(directory);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Directory is ready to save files");
                    Console.ResetColor();
                }
            }
        }

        internal static void SaveCars(List<Car> cars) {
            string path = $"{directory}{fileName}";
            StringBuilder sb = new StringBuilder();

            foreach (Car car in cars)
            {
                sb.Append($"Car: {car.Name}\t");
                sb.Append($"Plate: {car.Plate}\t");
                sb.Append($"Color: {car.GetColor()}\t");
                sb.Append($"Model: {car.GetModel()} \t");
                sb.Append(Environment.NewLine);

            }
            File.WriteAllText(path, sb.ToString());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Cars have been written in text file");
            Console.ResetColor();
        }

        internal static void LoadCars(List<Car> cars) {
            string path = $"{directory}{fileName}";

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                for(int i = 0; i < lines.Length; i++)
                    {
                    Console.WriteLine($"Car {i + 1}: {lines[i]}");
                }
                
            }
        }

    }
}
