namespace AbstractionLab

{
    public static class Program
    {
        static void Main(string[] args)
        {
            // Client
            IOrderable waiter = new Waiter();
            IOrderable cook = new Cook();
            cook.Order("Lasagna Bolognese");
            waiter.Order("Lasagna Bolognese");

            // Management 
            IEmployee waiter2 = new Waiter();
            waiter2.Name = "Ivan";
            waiter2.Age = 25;
            waiter2.Salary = 3500;
            IEmployee cook2 = new Cook();
            cook2.Name = "Gosho";
            cook2.Age = 50;
            cook2.Salary = 4000;

            List<IEmployee> workers = new List<IEmployee>();
            workers.Add(waiter2);
            workers.Add(cook2);
            foreach (var worker in workers)
            {
                Console.WriteLine(worker.Name);
                Console.WriteLine(worker.Age);
                Console.WriteLine(worker.Salary);
            }

            List<IOrderable> list = new List<IOrderable>();
            list.Add(waiter);
            list.Add(cook);
            foreach (var item in list)
            {
                item.Order("food");
            }

            List<IEmployee> list2 = new List<IEmployee>();
            list2 = list2.OrderBy(e => e.Name, StringComparer.OrdinalIgnoreCase).ThenBy(e => e.Age).ToList();
        }
    }
}