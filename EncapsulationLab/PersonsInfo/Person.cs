using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace PersonsInfo;

public class Person
{
    private int _age;
    private string _firstName;
    private string _lastName;
    private decimal _salary;

    
    public Person(string firstName, string lastName, int age, decimal salary)
    {
        Age = age;
        FirstName = firstName;
        LastName = lastName;
        Salary = salary;
    }

    public string FirstName
    {
        get => _firstName;
        private set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
            _firstName = value;
        }
    }
    
    public string LastName
    {
        get => _lastName;
        private set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");

            _lastName = value;
        }
    }

    public int Age
    {
        get => _age;
        private set
        {
            if (value < 1) 
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            _age = value;
        }
    }

    public decimal Salary
    {
        get => _salary;
        private set
        {
            if (value < 650) 
                throw new ArgumentException("Salary cannot be less than 650 leva!");

            _salary = value;
        }
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} receives {Salary:f2} leva.";
    }


    public void IncreaseSalary(decimal percentage)
    {
        if (Age < 30) 
            percentage /= 2;

        Salary += Salary * percentage / 100;
    }

    // private decimal GetActualPercentage(decimal percentage)
    //     => Age < DefaultAge ? percentage / 2 : percentage;
}