using System;

namespace P03.DetailPrinter
{
    public class Employee : IEmployee
    {
        public Employee(string name)
        {
            this.Name = name;
        }
        public string Name { get; }
        public virtual string GetDetails()
        {
            return this.Name;
        }
    }
}