namespace CompositeDesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The client code works with all of the components (Both Leaf and Composite) via the base interface i.e. IComponent.
            // IComponent means the class that implements the IComponent Interface
            //Creating Leaf Objects or you can say child objects
            IComponent hardDisk = new Leaf("Hard Disk", 100);
            IComponent ram = new Leaf("RAM", 150);
            IComponent cpu = new Leaf("CPU", 500);
            IComponent mouse = new Leaf("Mouse", 40);
            IComponent keyboard = new Leaf("Keyboard", 80);

            //Creating Composite Objects
            Composite motherBoard = new Composite("MotherBoard");
            Composite cabinet = new Composite("Cabinet");
            Composite peripherals = new Composite("Peripherals");
            Composite computer = new Composite("Computer");

            //Creating Tree Structure i.e. Adding Child Components inside the Composite Component

            //Adding CPU and RAM in Mother Board
            motherBoard.AddComponent(cpu);
            motherBoard.AddComponent(ram);

            //Adding Mother Board and Hard Disk in Cabinet
            cabinet.AddComponent(motherBoard);
            cabinet.AddComponent(hardDisk);

            //Adding Mouse and Keyboard in peripherals
            peripherals.AddComponent(mouse);
            peripherals.AddComponent(keyboard);

            //Adding Cabinet and Peripherals in Computer
            computer.AddComponent(cabinet);
            computer.AddComponent(peripherals);

            //To Display the Price of the Computer i.e. it will display the Price of all components
            Console.WriteLine("Price of Computer Composite Components:");
            computer.DisplayPrice();

            int totalPrice = computer.GetTotalPrice();
            Console.WriteLine($"\tTotal Price of Computer: {totalPrice:C}");

            //To display the Price of the Keyboard
            Console.WriteLine("\nPrice of Keyboard Child or Leaf Component:");
            keyboard.DisplayPrice();

            //To display the Price of the Cabinet
            Console.WriteLine("\nPrice of Cabinet Composite Component:");
            cabinet.DisplayPrice();

            //To Display the Price of the Cabinet i.e. it will display the Price of all components
            int totalPrice2 = cabinet.GetTotalPrice();
            Console.WriteLine($"\tTotal Price of cabinet: {totalPrice2:C}");
        }
    }
}