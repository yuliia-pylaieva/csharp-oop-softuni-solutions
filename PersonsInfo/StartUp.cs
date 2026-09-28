using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace PersonsInfo
{
    public class StartUp
    {
        public static void Main()

            // {
            //
            //     var lines = int.Parse(Console.ReadLine());
            //
            //     var persons = new List<Person>();
            //
            //     for (int i = 0; i < lines; i++)
            //
            //     {
            //
            //         var cmdArgs = Console.ReadLine().Split();
            //
            //         var person = new Person(cmdArgs[0], cmdArgs[1],
            //
            //             int.Parse(cmdArgs[2]));
            //
            //         persons.Add(person);
            //
            //     }
            //     
            //     persons.OrderBy(p => p.FirstName)
            //
            //         .ThenBy(p => p.Age)
            //
            //         .ToList()
            //
            //         .ForEach(p => Console.WriteLine(p.ToString()));
            //
            // }
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();

                try
                {
                    var person = new Person(
                        cmdArgs[0],
                        cmdArgs[1],
                        int.Parse(cmdArgs[2]),
                        decimal.Parse(cmdArgs[3]));
                    persons.Add(person);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            var percentage = decimal.Parse(Console.ReadLine());
            persons.ForEach(person => person.IncreaseSalary(percentage));
            persons.ForEach(person => Console.WriteLine(person.ToString()));
        }
    }
}