namespace DecoratorDesignPattern
{
    public class MercedesCar : ICar
    {
        private string? CarName = "Mercedes C250";
        public string? CarBody { get; set; }
        public string? CarDoor { get; set; }
        public string? CarWheels { get; set; }
        public string? CarGlass { get; set; }
        public string? Engine { get; set; }
        public override string? ToString()
        {
            return "MercedesCar \n[CarName= " + CarName + ",\nCarBody= " + CarBody + ",\nCarDoor= " + CarDoor + ",\nCarWheels= "
                            + CarWheels + ",\nCarGlass= " + CarGlass + ",\nEngine= " + Engine + "]";
        }
        public ICar ManufactureCar()
        {
            CarBody = "carbon fiber material";
            CarDoor = "4 car doors";
            CarWheels = "6 car glasses";
            CarGlass = "4 continental wheels";
            return this;
        }
    }
}

