using System;
using System.Collections;
using System.Collections.Generic;

namespace InterfacesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate House and Boat objects
            House house1 = new("abc", 200, 10000, "Good", "A fine house in the country");
            House house2 = new("Dabc", 100, 50000, "Bad", "A trashy house in the city");

            Boat boat1 = new(30, 10000, "Good", "seasick generator", 1990);
            Boat boat2 = new(10, 1000, "Good", "Bathtub", 2006);

            // Add objects to an ArrayList
            ArrayList list1 = new()
            {
                house1,
                house2,
                boat1,
                boat2
            };

            int price = 0;
            string invSummary = null;

            // Loop through object and run either Boat or House methods
            // Use is operator and Type Casting
            foreach (object obj in list1)
            {
                if (obj is Boat boat)
                {
                    price = boat.CalculatePrice();
                    invSummary = boat.InvestSummary();

                }
                else if (obj is House house)
                {
                    price = house.PriceCalculate();
                    invSummary = house.InvestSummary();
                }
                Console.WriteLine(invSummary);
                Console.WriteLine($"Price: {price}");
            }

            // After the implementation of the IInvestment interface, you can rewrite the
            // code above like this:

            List<IInvestment> investments = new List<IInvestment>
            {
                house1,house2, boat1, boat2
            };

            foreach (IInvestment obj in investments)
            {
                Console.WriteLine(obj.InvestSummary());
                Console.WriteLine($"Price: {obj.PriceCalculate()}");
            }
        }
    }
}
