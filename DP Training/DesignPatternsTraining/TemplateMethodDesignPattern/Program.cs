namespace TemplateMethodDesignPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            HouseTemplate houseTemplate1 = new ConcreteHouse();
            HouseTemplate houseTemplate2 = new WoodenHouse();

            Console.WriteLine("Build a Concrete House\n");
            //Call the Template Method to Build the Concrete House
            houseTemplate1.BuildHouse();

            Console.WriteLine("\n-------------------------\n");

            Console.WriteLine("Build a Wooden House\n");
            //Call the Template Method to Build the Wooden House
            houseTemplate2.BuildHouse();
        }
    }
}
