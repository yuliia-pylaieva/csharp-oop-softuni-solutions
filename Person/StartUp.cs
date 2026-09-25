using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;


namespace Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int age = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());


            if (age < 0)

            {
                Console.WriteLine("Age must be positive!");
            }

            else if (age > 15)

            {
                Person person = new Person(name, age);

                Console.WriteLine(person);
            }

            else

            {
                Child child = Child.CreateInstance(name, age);

                Console.WriteLine(child);
            }
        }
    }
}