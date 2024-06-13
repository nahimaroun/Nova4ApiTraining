using AbstractFactoryTraining.Interfaces;

namespace AbstractFactoryTraining.AbstractFactory
{
    internal interface IFurnitureFactory
    {
        IChair CreateChair();
        ITable CreateTable();
    }
}
