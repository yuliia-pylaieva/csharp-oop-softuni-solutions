using System;
using System.Collections.Generic;

namespace P03.DetailPrinter
{
    public static class Program
    {
        private static void Main()
        {

            IList<Employee> employees = new List<Employee>();
            employees.Add(new Manager("Joe Doe", new List<string>() { "CV", "Report" }));
            employees.Add(new Employee("George"));

            DetailsPrinter detailsPrinter = new(employees);
            detailsPrinter.PrintDetails();
        }
    }
}
