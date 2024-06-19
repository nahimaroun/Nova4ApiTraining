namespace CORDesignPattern.Teams
{
    public class TeamOne : HandlerBase
    {
        public TeamOne(HandlerBase nextHandler, ContextObject question) : base(nextHandler, question) { }

        public override void HandleRequest()
        {
            Console.WriteLine("Question : {0}", Question.Question);
            Console.WriteLine("*******************************************");

            Console.WriteLine("Wating for team one to respond");
            Thread.Sleep(5000);
            Console.WriteLine("\t no response from team one.....");

            NextTeam.HandleRequest();
        }
    }
}
