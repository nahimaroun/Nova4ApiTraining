namespace FacadeDesignPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            //The Client will use the Facade Interface instead of the Subsystems
            Order order = new Order();
            order.PlaceOrder();
        }
    }
}