namespace BridgeDesignPattern
{
    internal class SendingMethods
    {
        public class WebService : IBridgeComponents
        {
            public void Send(string MessageType)
            {
                Console.WriteLine("Sending " + MessageType + " Using web service.");
            }
        }

        public class ThirdPartyApi : IBridgeComponents
        {
            public void Send(string MessageType)
            {
                Console.WriteLine("Sending " + MessageType + " Using Third Party Api.");
            }
        }
    }
}
