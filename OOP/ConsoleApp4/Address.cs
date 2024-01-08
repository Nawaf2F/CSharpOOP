using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Address
    {
        private string street;
        private string city;
        private string houseNumber;

        public string Street {  
            get { return street; } 
            set {  street = value; }
        }
        public string City {
            get { return city; } 
            set { city = value; } 
        }
        public string HouseNumber { 
            get {  return houseNumber; } 
            set {  houseNumber = value; } 
        }

        public Address(string street, string city, string houseNumber) {
            Street = street;
            City = city;
            HouseNumber = houseNumber;
        }

    }
}
