using DesignPatternsTraining.BuilderDesignPattern;


namespace BuilderDesignPattern
{

    class Program
    {
        //Builder implementation
        public static void Print(Computer computer)
        {
            Console.WriteLine("The " + computer.Name + "'s specs:");
            Console.WriteLine("CPU: " + computer.CPU);
            Console.WriteLine("RAM: " + computer.RAM);
            Console.WriteLine("HardDisk: " + computer.HardDisk);
            Console.WriteLine("\n");
        }

        //---------------------------------------------------------------------
        public static void Main(string[] args)
        {

            //Builder implementation

            var computer1 = new ComputerBuilder()
            .AddName("HP Omen")
            .AddCPU("Core i9 - 137000HX")
            .AddRAM("32 Gbs")
            .AddHardDisk("2 Terrabytes")
            .Build();

            Print(computer1);

            var computer2 = new ComputerBuilder()
            .AddName("Acer ROG")
            .AddCPU("Core i7 - 13620H")
            .AddRAM("16 Gbs")
            .AddHardDisk("1 Terrabyte")
            .Build();

            Print(computer2);

            //-----------------------------------------------------------------




        }
    }
}
