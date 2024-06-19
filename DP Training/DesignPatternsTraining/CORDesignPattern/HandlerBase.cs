namespace CORDesignPattern
{
    public abstract class HandlerBase
    {
        public HandlerBase NextTeam { get; private set; }
        public ContextObject Question { get; private set; }

        public HandlerBase(HandlerBase nextHandler, ContextObject question)
        {
            NextTeam = nextHandler;
            Question = question;
        }

        public abstract void HandleRequest();
    }
}
