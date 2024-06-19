using DecoratorDesignPattern.Decorators;
namespace DecoratorDesignPattern
{
    public class PetrolCarDecorator : CarDecorator
    {
        public PetrolCarDecorator(ICar car) : base(car)
        {
        }

        public override ICar ManufactureCar()
        {
            car.ManufactureCar();
            AddEngine(car);
            return car;
        }

        public void AddEngine(ICar car)
        {
            if (car is MercedesCar Merc)
            {
                Merc.Engine = "Petrol Engine";
                Console.WriteLine("PetrolCarDecorator added Petrol Engine to the Car : " + car);
            }
        }
    }
}