namespace SingletonDesignPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Access the Singleton instance and set configuration settings
            ConfigurationManager configManager = ConfigurationManager.Instance;
            configManager.SetSetting("AppTitle", "Singleton Pattern Example");
            configManager.SetSetting("Version", "1.0.0");

            // Access the Singleton instance again from another part of the application
            ConfigurationManager anotherConfigManager = ConfigurationManager.Instance;
            Console.WriteLine("AppTitle: " + anotherConfigManager.GetSetting("AppTitle")); // Outputs: Singleton Pattern Example
            Console.WriteLine("Version: " + anotherConfigManager.GetSetting("Version"));   // Outputs: 1.0.0

            // Verify that both references point to the same instance
            Console.WriteLine(Object.ReferenceEquals(configManager, anotherConfigManager)); // Outputs: True
        }
    }
}

