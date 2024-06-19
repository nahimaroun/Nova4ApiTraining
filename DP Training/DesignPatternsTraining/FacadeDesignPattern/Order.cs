namespace FacadeDesignPattern
{
    // The Facade class provides a simple interface to the complex logic of one
    // or several subsystems. The Facade delegates the client requests to the
    // appropriate objects within the subsystem. 
    public class Order
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Place Order Started");

            //Get the Product Details
            Product product = new Product();
            product.GetProductDetails();

            //Make the Payment
            Payment payment = new Payment();
            payment.MakePayment();

            //Send the Invoice
            Invoice invoice = new Invoice();
            invoice.Sendinvoice();

            Console.WriteLine("Order Placed Successfully");
        }
    }
}