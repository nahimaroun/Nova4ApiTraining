using IteratorDesignPattern.IteratorData;

namespace IteratorDesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Build a collection
            ConcreteCollection collection = new ConcreteCollection();
            collection.AddEmployee(new Employee(21, "Anurag"));
            collection.AddEmployee(new Employee(34, "Pranaya"));
            collection.AddEmployee(new Employee(68, "Santosh"));
            collection.AddEmployee(new Employee(75, "Priyanka"));
            collection.AddEmployee(new Employee(100, "Abinash"));
            collection.AddEmployee(new Employee(121, "Preety"));

            // Create iterator
            Iterator iterator = collection.CreateIterator();
            //looping iterator      
            Console.WriteLine("Iterating over collection:");

            for (Employee emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
            {
                Console.WriteLine($"ID : {emp.Id} & Name : {emp.Name}");
            }
        }
    }
}

