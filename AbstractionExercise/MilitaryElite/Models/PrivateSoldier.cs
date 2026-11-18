using System.Globalization;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Models;

public class PrivateSoldier : Soldier, IPrivateSoldier
{
    public PrivateSoldier(string id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName)
    {
        this.Salary = salary;
    }
    public decimal Salary { get; }

    public override string ToString() => $"{base.ToString()} Salary: {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
}
