using AbstractFactoryTraining.Interfaces;

namespace AbstractFactoryTraining.Furniture
{
    public class ClassicChair : IChair
    {
        public void ShowStyle()
        {
            Console.WriteLine("This is a Classic chair.");
        }
    }
}
