using MilitaryElite.Enums;

namespace MilitaryElite.Interfaces;

public interface IMission
{
    string CodeName { get; }
    MissionState State { get; }

}