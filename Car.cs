using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
   public class Car
    {
        public string CarBrand  { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Car()
        {
           CarBrand = "nothing yet";
           Model = "nothing yet";
           Price = 0.00M;

        }
        public Car(string a, string b, decimal c)
        {
            CarBrand = a;
            Model = b;
            Price = c;
        }
       override public string ToString()
        {
            return "Car Brand: " + CarBrand+ "," + " Model: " + Model +", " + "Price: $" + Price;
        }
    }
}
