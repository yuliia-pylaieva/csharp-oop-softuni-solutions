using System.Text;
using System.Collections.ObjectModel;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Models;

public class LieutenantGeneral : PrivateSoldier, ILieutenantGeneral
{
    private readonly List<ISoldier> _soldiers;

    public LieutenantGeneral(string id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary)
    {
        _soldiers = new List<ISoldier>();
        this.Privates = _soldiers.AsReadOnly();
    }

    public ReadOnlyCollection<ISoldier> Privates { get; }

    public void AddPrivate(ISoldier soldier)
    {
        if (soldier is null) throw new ArgumentNullException(nameof(soldier));
        _soldiers.Add(soldier);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        Helpers.PrepareMultilineOutput(sb, "Privates:", Privates);
        return sb.ToString();
    }
}
