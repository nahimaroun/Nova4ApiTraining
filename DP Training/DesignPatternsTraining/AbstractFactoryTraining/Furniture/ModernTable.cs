using AbstractFactoryTraining.Interfaces;

namespace AbstractFactoryTraining.Furniture
{
    public class ModernTable : ITable
    {
        public void ShowStyle()
        {
            Console.WriteLine("This is a modern table.");
        }
    }

}
