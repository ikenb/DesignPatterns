namespace Solid.Logic.Interfaces
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }
}
