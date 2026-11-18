using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;


namespace PersonsInfo;

public class Person
{
    private const int DefaultAge = 30;
    private string _firstName;
    private string _lastName;
    private int _age;
    private decimal _salary;

    public Person(string firstName, string lastName, int age, decimal salary)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Salary = salary;
    }

    public string FirstName
    {
        get => _firstName;
        private set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
            {
                throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
            }
            _firstName = value;
        }
    }

    public string LastName
    {
        get => _lastName;
        private set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
            {
                throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
            }

            _lastName = value;
        }
    }

    public int Age
    {
        get => _age;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            }

            _age = value;
        }
    }

    public decimal Salary
    {
        get => _salary;
        private set
        {
            if (value < 650)
            {
                throw new ArgumentException("Salary cannot be less than 650 leva!");
            }

            _salary = value;
        }
    }

    public override string ToString()
        => $"{FirstName} {LastName} receives {Salary:f2} leva.";

    public void IncreaseSalary(decimal percentage)
    {
        decimal actualPercentage = GetActualPercentage(percentage);
        this.Salary += this.Salary * actualPercentage / 100;
    }

    private decimal GetActualPercentage(decimal percentage)
        => Age < DefaultAge ? percentage / 2 : percentage;
}