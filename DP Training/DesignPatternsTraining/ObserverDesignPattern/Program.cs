using ObserverDesignPattern.ObserverData;

namespace ObserverDesignPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Create a Product with Out of Stock Status
            Subject Iphone15 = new Subject("Iphone 15 SmartPhone", 840, "Out Of Stock");

            //User Nahi will be created and the user1 object will be registered to the subject
            Observer user1 = new Observer("Nahi");
            user1.AddSubscriber(Iphone15);

            //User Elie will be created and the user1 object will be registered to the subject
            Observer user2 = new Observer("Fahed");
            user2.AddSubscriber(Iphone15);

            //User Chewich will be created and the user3 object will be registered to the subject
            Observer user3 = new Observer("Bahae");
            user3.AddSubscriber(Iphone15);

            Console.WriteLine("Iphone 15 current state : " + Iphone15.GetAvailability());
            Console.WriteLine();

            user3.RemoveSubscriber(Iphone15);

            // Now the product is available
            Iphone15.SetAvailability("Available");

        }
    }
}
