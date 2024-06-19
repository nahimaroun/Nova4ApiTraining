using System.Reflection;
namespace MainConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var examples = new Dictionary<string, Dictionary<string, string>>
            {
                {
                    "Creational Patterns", new Dictionary<string, string>
                    {
                        { "1", "SingletonDesignPattern.dll" },
                        { "2", "FactoryDesignPattern.dll" },
                        { "3", "AbstractFactoryTraining.dll" },
                        { "4", "PrototypeDesignPattern.dll" },
                        { "5", "BuilderDesignPattern.dll" }
                    }
                },
                {
                    "Structural Patterns", new Dictionary<string, string>
                    {
                        { "1", "AdapterDesignPattern.dll" },
                        { "2", "BridgeDesignPattern.dll" },
                        { "3", "CompositeDesignPattern.dll" },
                        { "4", "DecoratorDesignPattern.dll" },
                        { "5", "FacadeDesignPattern.dll" }
                    }
                },
                {
                    "Behavioral Patterns", new Dictionary<string, string>
                    {
                        { "1", "CORDesignPattern.dll" },
                        { "2", "CommandDesignPattern.dll" },
                        { "3", "IteratorDesignPattern.dll" },
                        { "4", "ObserverDesignPattern.dll" },
                        { "5", "TemplateMethodDesignPattern.dll" }
                    }
                }
            };
            while (true)
            {
                Console.WriteLine("\nSelect a design pattern category to run:");
                int categoryIndex = 1;
                foreach (var category in examples.Keys)
                {
                    Console.WriteLine($"{categoryIndex}. {category}");
                    categoryIndex++;
                }
                Console.WriteLine("0. Exit");

                Console.Write("Input: ");
                string? categoryChoice = Console.ReadLine();

                if (int.TryParse(categoryChoice, out int categoryNum) && categoryNum > 0 && categoryNum <= examples.Count)
                {
                    string selectedCategory = new List<string>(examples.Keys)[categoryNum - 1];
                    ChooseExample(examples[selectedCategory], selectedCategory);
                }
                else if (categoryChoice == "0")
                {
                    Console.WriteLine("Exiting program.");
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
        }
        static void ChooseExample(Dictionary<string, string> examples, string category)
        {
            while (true)
            {
                Console.WriteLine($"\nSelect a {category.ToLower()} example to run:");
                foreach (var e in examples)
                {
                    Console.WriteLine($"{e.Key}. {Path.GetFileNameWithoutExtension(e.Value)}");
                }
                Console.WriteLine("0. Exit to main menu");

                Console.Write("Input: ");
                string? choice = Console.ReadLine();

                if (examples.ContainsKey(choice))
                {
                    Console.WriteLine("\nSTART================================================================>");
                    RunExample(examples[choice]);
                    Console.WriteLine("<=================================================================STOP\n");
                }
                else if (choice == "0")
                {
                    return; // Exit to main menu
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
        }
        static void RunExample(string assemblyPath)
        {
            try
            {
                // Load the assembly
                Assembly assembly = Assembly.LoadFrom(assemblyPath);
                // Find the Program type (assuming Program.cs is the main entry point)
                string assemblyName = Path.GetFileNameWithoutExtension(assemblyPath);
                Type programType = assembly.GetType($"{assemblyName}.Program");

                if (programType == null)
                {
                    Console.WriteLine($"Type Program not found in assembly {assemblyName}.");
                    return;
                }
                // Get the Main method (assuming it is a public static void Main(string[] args) method)
                MethodInfo mainMethod = programType.GetMethod("Main", BindingFlags.Public | BindingFlags.Static, null, new[] { typeof(string[]) }, null);

                if (mainMethod == null)
                {
                    Console.WriteLine($"Main method not found in type Program in assembly {assemblyName}.");
                    return;
                }
                // Invoke the Main method with the empty arguments array
                mainMethod.Invoke(null, new object[] { new string[] { } });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error running {assemblyPath}: {ex.Message}");
            }
        }
    }
}