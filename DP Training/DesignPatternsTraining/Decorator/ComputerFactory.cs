namespace FactoryDesignPattern
{
    class ComputerFactory
    {
        public static IComputer GetComputer(string PCType)
        {
            IComputer ObjectType = null;

            if (PCType.ToLower().Equals("high-end"))
            {
                ObjectType = new HighEndPc();
            }
            else if (PCType.ToLower().Equals("middle-end"))
            {
                ObjectType = new MiddleEndPc();
            }
            else if (PCType.ToLower().Equals("low-end"))
            {
                ObjectType = new LowEndPc();
            }
            return ObjectType;
        }
    }
}
