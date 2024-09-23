namespace MobileProgram
{
    class MobileProgram
    {
        static void Main(string[] args)
        {
            // Creating new Mobile object named jimMobile
            Console.WriteLine("Jim gets a new phone! Yay!");
            Mobile jimMobile = new Mobile("Monthly", "Samsung Galaxy S6", "07712223344");

            // Reporting status of jimMobile
            Console.WriteLine("Account type: " + jimMobile.getAccType() + "\nMobile number: " + jimMobile.getNumber() 
                + "\nDevice: " + jimMobile.getDevice() + "\nBalance: " + jimMobile.getBalance());
            Console.ReadLine();

            // Setting new parameters on jimMobile
            Console.WriteLine("Assigning new parameters...");
            jimMobile.setAccType("PAYG");
            jimMobile.setDevice("iPhone 6S");
            jimMobile.setNumber("07713334466");
            jimMobile.setBalance(15.50);
            Console.ReadLine();

            // Reporting status again
            Console.WriteLine("Account type: " + jimMobile.getAccType() + "\nMobile number: " + jimMobile.getNumber()
                + "\nDevice: " + jimMobile.getDevice() + "\nBalance: " + jimMobile.getBalance());
            Console.ReadLine();

            // jimMobile is being used...
            Console.WriteLine("Phone in use...");
            jimMobile.addCredit(10.0);
            jimMobile.makeCall(5);
            jimMobile.sendText(2);
            Console.ReadLine();

            // Reporting status again
            Console.WriteLine("Account type: " + jimMobile.getAccType() + "\nMobile number: " + jimMobile.getNumber()
                + "\nDevice: " + jimMobile.getDevice() + "\nBalance: " + jimMobile.getBalance());
            Console.ReadLine();

            // Creating new Mobile object named mariaMobile
            Console.WriteLine("Maria gets a new phone! Yay!");
            Mobile mariaMobile = new Mobile("Monthly", "Samsung Galaxy S21", "07712223345");

            // Reporting status again
            Console.WriteLine("Account type: " + mariaMobile.getAccType() + "\nMobile number: " + mariaMobile.getNumber()
                + "\nDevice: " + mariaMobile.getDevice() + "\nBalance: " + mariaMobile.getBalance());
            Console.ReadLine();

            // jimMobile is being used...
            Console.WriteLine("Phone in use...");
            mariaMobile.addCredit(20.0);
            mariaMobile.makeCall(30);
            mariaMobile.sendText(2);
            mariaMobile.sendText(5);
            Console.ReadLine();

            // Reporting status again
            Console.WriteLine("Account type: " + mariaMobile.getAccType() + "\nMobile number: " + mariaMobile.getNumber()
                + "\nDevice: " + mariaMobile.getDevice() + "\nBalance: " + mariaMobile.getBalance());
            Console.ReadLine();
        }
    }
}