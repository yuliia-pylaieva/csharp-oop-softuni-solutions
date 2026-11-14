// See https://aka.ms/new-console-template for more information

namespace ShoppingSpree
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var peopleMap = new Dictionary<string, Person>();
            var peopleInOrder = new List<Person>();
            var productsMap = new Dictionary<string, Product>();
            try
            {
                var peopleInfo = ReadRequiredLine().Split(';',
                    StringSplitOptions.RemoveEmptyEntries);

                foreach (var person in peopleInfo)
                {
                    var currentPersonInfo = person.Split('=');
                    var currentPerson = new Person(currentPersonInfo[0], decimal.Parse(currentPersonInfo[1]));
                    peopleMap[currentPerson.Name] = currentPerson;
                    peopleInOrder.Add(currentPerson);
                }

                var productsInfo = ReadRequiredLine().Split(';',
                    StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in productsInfo)
                {
                    var currentProductInfo = item.Split('=');
                    var currentProduct = new Product(currentProductInfo[0], decimal.Parse(currentProductInfo[1]));
                    productsMap[currentProduct.Name] = currentProduct;
                }
                // Console.WriteLine(ReferenceEquals(person.AllProducts,person.AllProducts));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            while (Console.ReadLine() is { } command && command != "END")
            {
                string[] data = command.Split();
                Person person = peopleMap[data[0]];
                Product product = productsMap[data[1]];

                Console.WriteLine(person.Purchase(product)
                    ? $"{person.Name} bought {product.Name}"
                    : $"{person.Name} can't afford {product.Name}");
            }

            foreach (var person in peopleInOrder)
            {
                Console.WriteLine(person);
            }
        }

        private static string ReadRequiredLine() =>
            Console.ReadLine() ?? throw new InvalidOperationException("Unexpected end of input.");
    }
}