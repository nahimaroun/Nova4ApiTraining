using IteratorDesignPattern.IteratorData;

namespace IteratorDesignPattern
{
    // Aggregate Interface
    public interface IAbstractCollection
    {
        // The following Method is going to Return an Iterator object.
        Iterator CreateIterator();
    }
}