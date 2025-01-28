namespace Interfaces_Demo
{
    public class Customer : ICustomer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; }
        public string Address { get; set; }

        public Customer(
            int id,
            string firstName,
            string lastName,
            string email,
            string phoneNumber,
            DateTime dateOfBirth,
            string address
        )
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
            Address = address;
        }

        public int GetAge()
        {
            var today = DateTime.Today;
            var age = today.Year - DateOfBirth.Year;
            if (DateOfBirth.Date > today.AddYears(-age)) age--;
            return age;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public void UpdateContactInfo(string email, string phoneNumber)
        {
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public void PrintCustomerDetails()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {GetFullName()}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Phone: {PhoneNumber}");
            Console.WriteLine($"Age: {GetAge()}");
            Console.WriteLine($"Address: {Address}");
        }
    }
}