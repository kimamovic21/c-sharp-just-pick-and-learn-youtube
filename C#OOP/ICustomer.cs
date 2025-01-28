namespace Interfaces_Demo
{
    public interface ICustomer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; }
        public string Address { get; set; }

        public void UpdateContactInfo(string email, string phoneNumber);
        public string GetFullName();
        public int GetAge();
    }
}