namespace Variables_Overview
{
    class Student
    {
        //Class-level variables (fields)
        public string name = "Kerim";
        public int age = 28;

        //Method to display student information
        public void DisplayStudentInfo()
        {
            //Implicitly typed variable
            var salary = 1000;
            //salary = "Thousand";

            //Method-level variable (local variable)
            string message = "This is a student information: ";
            Console.WriteLine(message);
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Student Age: " + age);

            if (age >= 18)
            {
                string result = "This student is an adult";
                Console.WriteLine(result);
            }
            //Console.WriteLine(result);
        }
        //Console.WriteLine(message);
    }
}