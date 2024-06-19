namespace CommandDesignPattern
{
    public interface ICommand
    {
        string Name { get; }
        void Execute();
    }

    public class StartCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("I am executing StartCommand");
            Thread.Sleep(3500);
            Console.WriteLine("Start Command Done!");
        }
        public string Name
        {
            get { return "Start"; }
        }
    }

    public class StopCommand : ICommand
    {
        public void Execute()
        {

            Console.WriteLine("I am executing StopCommand");
            Thread.Sleep(2000);
            Console.WriteLine("Stop Command Done!");
        }
        public string Name
        {
            get { return "Stop"; }
        }
    }
}