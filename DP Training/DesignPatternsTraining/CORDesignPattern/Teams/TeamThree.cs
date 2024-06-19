namespace CORDesignPattern.Teams
{
    public class TeamThree : HandlerBase
    {
        public TeamThree(HandlerBase nextHandler, ContextObject question) : base(nextHandler, question) { }

        public override void HandleRequest()
        {
            Console.WriteLine("Wating for team three to respond");
            Thread.Sleep(3000);
            Console.WriteLine("\t no response from team three as well .....");
        }
    }
}
