namespace Employee
{
    class Employee
    {
        // Declaring variables
        private String name;
        private Double salary;

        // Constructor
        public Employee(string employeeName, double currentSalary)
        {
            this.name = employeeName;
            this.salary = currentSalary;
        }

        // Get methods
        public String getName()
        {
            return this.name;
        }

        public Double getSalary()
        {
            return this.salary;
        }

        // Methods
        public void raiseSalary(double percentage)
        {
            this.salary = this.salary + (this.salary*(percentage/100));
        }

        public double tax()
        {   
            if (this.salary < 0 & this.salary >= 18200)
            {
                return 0;
            } 
            else if (this.salary < 18201 & this.salary >= 37000)
            {
                return this.salary * 0.19;
            } 
            else if (this.salary < 37001 & this.salary >= 90000)
            {
                return 3572 + ((this.salary - 37000) * 0.325);
            }
            else if (this.salary < 90001 & this.salary >= 180000)
            {
                return 20797 + ((this.salary - 90000) * 0.37);
            } else
            {
                return 54096 + ((this.salary - 180000) * 0.45);
            }
        }
    }
}