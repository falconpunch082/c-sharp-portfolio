namespace Car
{
    class CarProgram
    {
        static void Main(String[] args)
        {
            // I got a new car with fuel efficiency of 27.35 mpg
            Car toyota = new Car(27.35);

            // Let's check the fuel first.
            Console.WriteLine("Fuel available: " + toyota.getFuel() + " litres");

            // Oof... no fuel... let's fill it up. Full tank!
            toyota.addfuel(50);

            // Let's check the fuel again.
            Console.WriteLine("Fuel available: " + toyota.getFuel() + " litres");

            // Let's check the odometer
            Console.WriteLine("Distance travelled: " + toyota.getTotalMiles());

            // I thought this was an used car though?
            toyota.setTotalMiles(100);

            // Oh, I didn't see the extra numbers. My bad.
            Console.WriteLine("Distance travelled: " + toyota.getTotalMiles());

            // How much would it cost to fill up half a tank?
            toyota.calcCost(25);

            // How much is 13 gallons in litres?
            Console.WriteLine("13 gallons is equal to " + toyota.convertToLitres(13) + " litres.");

            // Enough questions! Let's go on a ROADTRIP!
            toyota.drive(100);
        }
    }
}