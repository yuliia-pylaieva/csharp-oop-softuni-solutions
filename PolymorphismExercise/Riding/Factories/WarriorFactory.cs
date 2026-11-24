using Riding.Heroes;
using Riding.Interfaces;

namespace Riding.Factories;

public class WarriorFactory : IHeroFactory
{
    public IHero Create(string name) => new Warrior(name);
}
