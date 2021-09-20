using System;

namespace InterfacesExercise
{
    public class Boat : IInvestment
    {
        public int Length { get; set; }
        public int MeterPrice { get; set; }

        public string Condition { get; set; }
        public string Description { get; set; }
        public int RegYear { get; set; }
        public Boat(int length, int meterPrice, string condition, string description, int regYear)
        {
            Length = length;
            MeterPrice = meterPrice;
            Condition = condition;
            Description = description;
            RegYear = regYear;
        }
        public int CalculatePrice()
        {
            int foundPrice = Length * MeterPrice;
            return foundPrice;
        }
        public string InvestSummary()
        {
            string summ = "Boat: " + Description + Environment.NewLine + "Length " + Length;
            return summ;
        }

        // After you implement the interface call the CalculatePrice method from this one, 
        // rather that rename CalculatePrice to PriceCalculate. You dont know if there is
        // code that uses the Boat type directly.
        public int PriceCalculate()
        {
            return CalculatePrice();
        }
    }
}
