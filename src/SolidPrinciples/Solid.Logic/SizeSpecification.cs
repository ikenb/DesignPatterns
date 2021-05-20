using Solid.Logic.Interfaces;

namespace Solid.Logic
{
    class SizeSpecification : ISpecification<Product>
    {
        private string size;

        public SizeSpecification(string size)
        {
            this.size = size;
        }
        public bool IsSatisfied(Product t)
        {
            return t.Size == size;
        }
    }
}