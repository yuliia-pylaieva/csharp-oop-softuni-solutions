namespace MilitaryElite.Interfaces;

public interface ICommando : ISpecializedSoldier
{
    IReadOnlyCollection<IMission> Missions { get; }
}