using System.Text;

namespace ShoppingSpree;

public class Person
{
    private readonly List<Product> _products;
    private decimal _money;

    public Person(string name, decimal money)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException($"{nameof(Name)} cannot be empty");
        }

        Name = name;
        Money = money;
        this._products = new List<Product>();
        this.AllProducts = this._products.AsReadOnly(); // creates only one instance 
    }

    public string Name { get; }

    public decimal Money
    {
        get => this._money;
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException($"{nameof(Money)} cannot be negative");
            }

            this._money = value;
        }
    }

    private IReadOnlyCollection<Product> AllProducts { get; }

    //public IReadOnlyCollection<Product> AllProducts => this._products.AsReadOnly(); //creates instance every time you call asReadOnly()
    public bool Purchase(Product product)
    {
        if (product.Cost > this.Money)
        {
            return false;
        }

        this._products.Add(product);
        this.Money -= product.Cost;
        return true;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append(Name);
        stringBuilder.Append(" - ");
        stringBuilder.Append(AllProducts.Count == 0
            ? "Nothing bought"
            : string.Join(", ", AllProducts.Select(p => p.Name)));
        return stringBuilder.ToString();
    }
}