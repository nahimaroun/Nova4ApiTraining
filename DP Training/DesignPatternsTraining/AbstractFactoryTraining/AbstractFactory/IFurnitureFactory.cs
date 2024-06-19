using AbstractFactoryTraining.Interfaces;

namespace AbstractFactoryTrainingAbstractFactory
{
    internal interface IFurnitureFactory
    {
        IChair CreateChair();
        ITable CreateTable();
    }
}
