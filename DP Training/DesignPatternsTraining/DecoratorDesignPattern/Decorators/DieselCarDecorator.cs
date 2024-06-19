using DecoratorDesignPattern.Decorators;
namespace DecoratorDesignPattern
{
    //The following Concrete Decorator class will add Petrol Engine to the Existing Car
    public class DieselCarDecorator : CarDecorator
    {
        //Pass the existing car object while creating the Instance of PetrolCarDecorator class
        //Also pass the same existing pizza object to the base class constructor 
        //i.e. CarDecorator abstract class constructor
        public DieselCarDecorator(ICar car) : base(car)
        {
        }

        //Overriding the ManufactureCar method to add Petrol Engine
        public override ICar ManufactureCar()
        {
            //First Call the Concrete Components ManufactureCar Method 
            car.ManufactureCar();
            //Then Add a Petrol Engine by calling the AddEngine Method
            AddEngine(car);
            return car;
        }

        public void AddEngine(ICar car)
        {
            if (car is MercedesCar Merc)
            {
                Merc.Engine = "Diesel Engine";
                Console.WriteLine("DieselCarDecorator added Diesel Engine to the Car : " + car);
            }
        }
    }
}