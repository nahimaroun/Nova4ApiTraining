using AbstractFactoryTraining.Interfaces;

namespace AbstractFactoryTraining.Furniture
{
    public class ModernChair : IChair
    {
        public void ShowStyle()
        {
            Console.WriteLine("This is a modern chair.");
        }
    }
}