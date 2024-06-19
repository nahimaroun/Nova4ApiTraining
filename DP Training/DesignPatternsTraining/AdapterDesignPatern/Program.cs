namespace AdapterDesignPattern
{
    //Client 
    //The Client is Incompatible with ThirdPartyBillingSystem 
    class Program
    {
        public static void Main(string[] args)
        {
            //Storing the Employees Data in a String Array
            string[,] employeesArray = new string[5, 4]
            {
                {"101","John","SE","1000"},
                {"102","Smith","SE","1300"},
                {"103","Dev","SSE","900"},
                {"104","Pam","SE","2500"},
                {"105","Sara","SSE","5000"}
            };

            //The EmployeeAdapter Makes it possible to work with Two Incompatible Interfaces
            Console.WriteLine("HR system passes employee string array to Adapter\n");
            ITarget target = new EmployeeAdapter();
            target.ProcessCompanySalary(employeesArray);
        }
    }
}