namespace ShoppingSpree
{
    public class Product
    {
        public Product(string productName, decimal cost)
        {
            if (cost < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }

            if (string.IsNullOrWhiteSpace(productName))
            {
                throw new ArgumentException($"{nameof(Name)} cannot be empty");
            }

            Name = productName;
            Cost = cost;
        }

        public string Name { get; }
        public decimal Cost { get; }
    }
}