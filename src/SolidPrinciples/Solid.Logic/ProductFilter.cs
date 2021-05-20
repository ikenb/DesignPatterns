using Solid.Logic.Interfaces;
using System.Collections.Generic;

namespace Solid.Logic
{
    /// <summary>
    /// Open Closed Principle
    /// </summary>
    public class ProductFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var item in items)
            {
                if (spec.IsSatisfied(item))
                    yield return item;
            }
        }
    }
}
