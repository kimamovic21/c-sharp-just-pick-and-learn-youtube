namespace Encapsulation
{
    internal class Employee
    {
        // Fields
        private string name;
        private int employeeId;
        private int salary;

        // Constructor
        public Employee(string name, int employeeId, int salary)
        {
            this.name = name;
            this.employeeId = employeeId;
            this.salary = salary;
        }

        // Properties to access and modify the fields
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int EmployeeId
        {
            get { return employeeId; }
        }

        public int Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0)
                    salary = value;
                else
                    Console.WriteLine("Salary cannot be negative");
            }
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"EmployeeId: {EmployeeId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }
}
