namespace Solid.Logic
{
    public class Product
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public string Size { get; set; }

        public Product(string name, string colour, string size)
        {
            Name = name;
            Colour = colour;
            Size = colour;
        }
    }
}
