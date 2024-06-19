namespace PrototypeDesignPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Creating an Instance of Permanent Employee Class
            Employee emp1 = new PermanentEmployee()
            {
                Name = "Anurag",
                Department = "IT",
                Type = "Permanent",
                Salary = 125000
            };

            //Creating a Clone of the above Permanent Employee
            Employee emp2 = emp1.GetClone();

            // Changing the Name and Department Property Value of emp2 instance, 
            // will not change the Name and Department Property Value of the emp1 instance
            emp2.Name = "Pranaya";
            emp2.Department = "HR";

            emp1.ShowDetails();
            Console.WriteLine("Cloned: Name And Department Value Changed");
            emp2.ShowDetails();
        }
    }
}