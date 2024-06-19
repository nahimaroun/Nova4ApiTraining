using ObserverDesignPattern.ObserverData;


namespace ObserverDesignPattern
{
    // The ConcreteSubject class
    // The Subject have states and notifies all observers when the state changes.
    public class Subject : ISubject
    {
        // The List of Observer is going to store in the following collection object
        private List<IObserver> observers = new List<IObserver>();

        //The following properties are going to store the Product Information
        private string ProductName { get; set; }
        private int ProductPrice { get; set; }
        private string Availability { get; set; }

        // Initializing the Product information using the constructor
        public Subject(string productName, int productPrice, string availability)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            Availability = availability;
        }

        //The following Method is going to return the State of the Product
        public string GetAvailability()
        {
            return Availability;
        }

        //The following Method is going to set the State of the Product
        public void SetAvailability(string availability)
        {
            this.Availability = availability;
            Console.WriteLine("\nAvailability changed from Out of Stock to Available.\n");
            NotifyObservers();
        }

        // The observer will register with the Product using the following method
        public void RegisterObserver(IObserver observer)
        {
            Console.WriteLine("Observer Added : " + ((Observer)observer).UserName + ".\n");
            observers.Add(observer);
        }

        // The observer will unregister from the Product using the following method
        public void RemoveObserver(IObserver observer)
        {
            Console.WriteLine("Observer Removed : " + ((Observer)observer).UserName + ".");
            observers.Remove(observer);
        }

        // The following Method will be sent notifications to all observers
        public void NotifyObservers()
        {
            Console.WriteLine("The new " + ProductName + " is Now available for " + ProductPrice + "$, notifying all Registered users. ");

            Console.WriteLine();
            foreach (IObserver observer in observers)
            {
                //By Calling the Update method, we are sending notifications to observers
                observer.Update(Availability);
            }
        }
    }
}