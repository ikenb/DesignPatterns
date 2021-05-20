using Solid.Logic.Interfaces;

namespace Solid.Logic
{
    public class ColourSpecification : ISpecification<Product>
    {
        private string colour;

        public ColourSpecification(string colour)
        {
            this.colour = colour;
        }
        public bool IsSatisfied(Product t)
        {
            return t.Colour == colour;
        }
    }
}
