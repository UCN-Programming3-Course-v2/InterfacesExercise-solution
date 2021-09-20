using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercise
{
    public class House : IInvestment
    {
        public string Address { get; set; }
        public int SquareMeters { get; set; }
        public int SquareMeterPrice { get; set; }
        public string Condition { get; set; }
        public string Description { get; set; }
        public House(string address, int squareMeters, int squareMeterPrice, string condition, string description)
        {
            Address = address;
            SquareMeters = squareMeters;
            SquareMeterPrice = squareMeterPrice;
            Condition = condition;
            Description = description;
        }
        public int PriceCalculate()
        {
            int foundPrice = SquareMeters * SquareMeterPrice;
            return foundPrice;
        }
        public string InvestSummary()
        {
            string summ = "House: " + Address + Environment.NewLine + "Area = " + SquareMeters;
            return summ;
        }
    }
}
