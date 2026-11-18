using System.Text;
using MilitaryElite.Enums;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Models;

public class Commando : SpecializedSoldier, ICommando
{
    private readonly List<IMission> _missions;
    public Commando(string id, string firstName, string lastName, decimal salary, SoldierCorps corps) : base(id, firstName, lastName, salary, corps)
    {
        _missions = new List<IMission>();
        this.Missions = _missions.AsReadOnly();
    }

    public IReadOnlyCollection<IMission> Missions { get; }

    public void AddMission(IMission mission)
    {
        if (mission is null)
        {
            throw new ArgumentNullException(nameof(mission));
        }
        _missions.Add(mission);

    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        Helpers.PrepareMultilineOutput(sb, "Missions:", Missions);
        return sb.ToString();
    }
}
