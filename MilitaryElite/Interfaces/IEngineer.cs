namespace MilitaryElite.Interfaces;

public interface IEngineer : ISpecializedSoldier
{
    IReadOnlyCollection<IRepair> Repairs { get; }
}