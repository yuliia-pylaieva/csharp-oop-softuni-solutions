using System.Text;
using MilitaryElite.Enums;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Models;

public class Engineer : SpecializedSoldier, IEngineer
{
    private readonly List<IRepair> _repairs;
    public Engineer(string id, string firstName, string lastName, decimal salary, SoldierCorps corps) : base(id, firstName, lastName, salary, corps)
    {
        this._repairs = new List<IRepair>();
        this.Repairs = this._repairs.AsReadOnly();
    }

    public IReadOnlyCollection<IRepair> Repairs { get; }

    public void AddRepair(IRepair repair)
    {
        if (repair == null) throw new ArgumentNullException(nameof(repair));
        _repairs.Add(repair);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        Helpers.PrepareMultilineOutput(sb, "Repairs:", Repairs);
        return sb.ToString();
    }
}
