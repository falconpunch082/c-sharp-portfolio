using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Car
    {
        // Declaring variables
        private double fuelEfficiency;
        private double fuel;
        private double odometer;

        // Declaring constant
        private double COST_PER_LITRE = 1.85;

        // Constructor
        public Car(double efficiency)
        {
            this.fuelEfficiency = efficiency;
            this.fuel = 0;
            this.odometer = 0;
        }

        // Get methods
        public double getFuel()
        {
            return this.fuel;
        }

        public double getTotalMiles()
        {
            return this.odometer;
        }

        // Set method
        public void setTotalMiles(double miles)
        {
            this.odometer = miles;
        }

        public void addfuel(double litre)
        {
            // Add fuel to car
            this.fuel += litre;

            // Report how much it costs
            double cost = litre * COST_PER_LITRE;
            Console.WriteLine(cost.ToString("C") + " was just spent to fill up " + litre + " litre(s) of fuel.");
        }

        // Methods
        public void printFuelCost()
        {
            Console.WriteLine("The cost of fuel is " + COST_PER_LITRE.ToString("C") + " per litre.");
        }

        public void calcCost (double litre)
        {
            double cost = litre * COST_PER_LITRE;
            Console.WriteLine("To fill up " + litre + " litre(s) of fuel, you would have to spend " + cost.ToString("C") + ".");
        }

        public double convertToLitres(double gallon)
        {
            double result = gallon * 4.546;
            return Math.Round(result, 2);
        }

        public void drive(double miles)
        {
            // Add miles gained to odometer
            this.odometer += miles;

            // Calculate fuel cost
            // First determine how many gallons of fuel were used
            double gallonUsed = miles / this.fuelEfficiency;
            // Then convert gallons used to litres
            double litresUsed = convertToLitres(gallonUsed);
            // Calculate the value of fuel used
            double value = litresUsed * COST_PER_LITRE;
            // Finally, report
            Console.WriteLine("For driving " + miles + " miles, you have spent " + value.ToString("C") + " worth of fuel.");
        }
    }
}
