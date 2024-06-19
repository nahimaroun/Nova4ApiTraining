namespace CORDesignPattern.Teams
{
    public class TeamTwo : HandlerBase
    {
        public TeamTwo(HandlerBase nextHandler, ContextObject question) : base(nextHandler, question) { }

        public override void HandleRequest()
        {
            Console.WriteLine("Wating for team two to respond");

            Thread.Sleep(7000);

            Console.WriteLine("\t no response from team two.....");
            NextTeam.HandleRequest();
        }
    }
}
