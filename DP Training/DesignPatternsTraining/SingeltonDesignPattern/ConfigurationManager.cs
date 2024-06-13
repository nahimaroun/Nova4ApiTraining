public class ConfigurationManager
{
    // The single instance of the class
    private static ConfigurationManager? _instance;
    // Lock object to ensure thread safety during instance creation
    private static readonly object _lock = new object();

    // Private constructor to prevent instantiation from outside the class
    private ConfigurationManager()
    {
        // Initialize the configuration settings dictionary
        Settings = new Dictionary<string, string>();
    }

    // Public static property to provide global access to the single instance
    public static ConfigurationManager Instance
    {
        get
        {
            // Ensure thread safety with double-check locking pattern
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new ConfigurationManager();
                }
                return _instance;
            }
        }
    }

    // Dictionary to store configuration settings as key-value pairs
    public Dictionary<string, string> Settings { get; private set; }

    // Method to get a configuration setting by key
    public string GetSetting(string key)
    {
        // Return the setting value if the key exists, otherwise return null
        return Settings.ContainsKey(key) ? Settings[key] : null;
    }

    // Method to set a configuration setting
    public void SetSetting(string key, string value)
    {
        // Add or update the setting value in the dictionary
        Settings[key] = value;
    }
}