using MilitaryElite.Enums;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Models;

public class Mission : IMission
{
    public Mission(string codeName, MissionState state)
    {
        CodeName = codeName;
        State = state;
    }

    public string CodeName { get; }
    public MissionState State { get; }

    public override string ToString() => $"Code Name: {CodeName} State: {State}";
}
