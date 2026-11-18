using System.Text;
using MilitaryElite.Enums;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Models;

public abstract class SpecializedSoldier : PrivateSoldier, ISpecializedSoldier
{
    protected SpecializedSoldier(string id, string firstName, string lastName, decimal salary, SoldierCorps corps) : base(id, firstName, lastName, salary)
    {
        this.Corps = corps;
    }

    public SoldierCorps Corps { get; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.Append($"Corps: {Corps.ToString()}");
        return sb.ToString();
    }
}
