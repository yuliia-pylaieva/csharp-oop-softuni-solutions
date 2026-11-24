using Riding.Heroes;
using Riding.Interfaces;

namespace Riding.Factories;

public class PaladinFactory : IHeroFactory
{
    public IHero Create(string name) => new Paladin(name);
}
