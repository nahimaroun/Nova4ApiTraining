using AbstractFactoryTraining.Interfaces;

namespace AbstractFactoryTraining.Furniture
{
    public class ClassicTable : ITable
    {
        public void ShowStyle()
        {
            Console.WriteLine("This is a Classic Table.");
        }
    }
}
