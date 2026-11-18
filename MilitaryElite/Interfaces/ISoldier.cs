namespace MilitaryElite.Interfaces;

public interface ISoldier
{
    //C# 12 - implementation uses init; + required 
    string Id { get; }
    string FirstName { get; }
    string LastName { get; }
}