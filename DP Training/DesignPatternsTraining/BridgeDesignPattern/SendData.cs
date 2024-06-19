namespace BridgeDesignPattern
{
    public abstract class SendData
    {
        public IBridgeComponents? _iBridgeComponents;
        public abstract void Send();
    }

    public class SendEmail : SendData
    {
        public override void Send()
        {
            //Use the Bridge to send Email
            _iBridgeComponents.Send("Email");
        }
    }

    public class SendSMS : SendData
    {
        public override void Send()
        {
            //Use the Bridge to send SMS
            _iBridgeComponents.Send("SMS");
        }
    }
}
