using AbstractFactoryTraining.Furniture;
using AbstractFactoryTraining.Interfaces;
using AbstractFactoryTrainingAbstractFactory;

namespace AbstractFactoryTraining.ConcreteFactory
{
    internal class ClassicFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ClassicChair();
        }

        public ITable CreateTable()
        {
            return new ClassicTable();
        }
    }
}
