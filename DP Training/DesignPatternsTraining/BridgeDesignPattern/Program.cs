namespace BridgeDesignPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SendData _sendData = new SendEmail();
            SendData _sendData2 = new SendSMS();

            //set webService as reference for sending Email
            _sendData._iBridgeComponents = new SendingMethods.WebService();
            _sendData.Send();

            //set Third party api as reference for sending Email
            _sendData._iBridgeComponents = new SendingMethods.ThirdPartyApi();
            _sendData.Send();

            Console.WriteLine("\n");

            //set webService as reference for sending SMS
            _sendData2._iBridgeComponents = new SendingMethods.WebService();
            _sendData2.Send();

            //set Third party api as reference for sending SMS
            _sendData2._iBridgeComponents = new SendingMethods.ThirdPartyApi();
            _sendData2.Send();
        }

    }
}
