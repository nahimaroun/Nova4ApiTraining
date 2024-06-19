namespace DecoratorDesignPattern;

class Program
{
    public static void Main(string[] args)
    {
        //Create an instance of Concrete Component car
        ICar Mercedes1 = new MercedesCar();
        //Calling the ManufactureCar method will create the car without an engine
        Mercedes1.ManufactureCar();
        Console.WriteLine(Mercedes1 + "\n");

        //Adding Diesel Engine to the car
        //Create an instance DieselCarDecorator class and 
        //pass existing car as an argument to the Constructor which we want to decorate
        DieselCarDecorator carWithDieselEngine = new DieselCarDecorator(Mercedes1);

        //Calling the ManufactureCar method on the carWithDieselEngine object will add Diesel Engine to the car  
        carWithDieselEngine.ManufactureCar();

        Console.WriteLine();
        //The Process is the same for adding Petrol Engine to the existing Car
        ICar Mercedes2 = new MercedesCar();
        PetrolCarDecorator carWithPetrolEngine = new PetrolCarDecorator(Mercedes2);
        carWithPetrolEngine.ManufactureCar();

    }
}