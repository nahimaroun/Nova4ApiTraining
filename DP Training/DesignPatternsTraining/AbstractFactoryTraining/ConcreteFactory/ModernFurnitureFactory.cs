﻿using AbstractFactoryTraining.AbstractFactory;
using AbstractFactoryTraining.Furniture;
using AbstractFactoryTraining.Interfaces;

namespace AbstractFactoryTraining.ConcreteFactory
{
    internal class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ITable CreateTable()
        {
            return new ModernTable();
        }
    }
}
