namespace IteratorDesignPattern.IteratorData
{
    public interface IAbstractIterator
    {
        // Iterator Interface
        // This is going to be an interface defining the operations for accessing and traversing elements in a sequence.
        interface IAbstractIterator
        {
            Employee First();
            Employee Next();
            bool IsCompleted { get; }
        }
    }
}
