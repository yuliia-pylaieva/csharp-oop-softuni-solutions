using System.Collections.ObjectModel;

namespace MilitaryElite.Interfaces;

public interface ILieutenantGeneral : IPrivateSoldier
{
    // NOTE: if we should use a different interface
    ReadOnlyCollection<ISoldier> Privates { get; }
}