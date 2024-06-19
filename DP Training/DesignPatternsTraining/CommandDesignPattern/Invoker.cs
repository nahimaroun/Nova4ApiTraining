namespace CommandDesignPattern
{
    public class Invoker
    {
        ICommand cmd = null;
        public ICommand GetCommand(string action)
        {
            switch (action)
            {
                case "Start":
                    cmd = new StartCommand();
                    break;
                case "Stop":
                    cmd = new StopCommand();
                    break;
                default:
                    break;
            }
            return cmd;
        }
    }
}
