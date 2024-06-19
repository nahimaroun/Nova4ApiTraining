
using AbstractFactoryTraining.ConcreteFactory;
using AbstractFactoryTraining.Interfaces;
using AbstractFactoryTrainingAbstractFactory;

namespace AbstractFactoryTraining
{
    class Program
    {
        // Client class that uses the factory to create and use furniture products
        public class Client
        {
            private readonly IChair _chair;
            private readonly ITable _table;

            // Constructor that accepts an IFurnitureFactory and uses it to create chair and table objects
            public Client(IFurnitureFactory factory)
            {
                _chair = factory.CreateChair();
                _table = factory.CreateTable();
            }

            // Method to demonstrate the usage of the created chair and table
            public void Run()
            {
                _chair.ShowStyle();
                _table.ShowStyle();
            }
        }


        public static void Main(string[] args)
        {
            // Create an instance of ModernFurnitureFactory
            IFurnitureFactory modernFactory = new ModernFurnitureFactory();
            // Create a client and pass the modern factory to it
            Client Client1 = new Client(modernFactory);
            // Run the client's operations
            Client1.Run();

            IFurnitureFactory ClassicFactory = new ClassicFurnitureFactory();
            Client Client2 = new Client(ClassicFactory);
            Client2.Run();
        }
    }

}

