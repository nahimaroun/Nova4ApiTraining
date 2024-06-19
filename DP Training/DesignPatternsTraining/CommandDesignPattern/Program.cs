namespace CommandDesignPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Command DP Demo\n");

            Invoker invoker = new Invoker();

            // Execute Start Command
            ICommand command = invoker.GetCommand("Start");
            command.Execute();

            // Execute Stop Commad
            command = invoker.GetCommand("Stop");
            command.Execute();
        }
    }
}
