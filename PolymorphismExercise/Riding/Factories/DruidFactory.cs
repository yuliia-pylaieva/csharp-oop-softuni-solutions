using Riding.Heroes;
using Riding.Interfaces;

namespace Riding.Factories;

public class DruidFactory : IHeroFactory
{
    public IHero Create(string name) => new Druid(name);
}
