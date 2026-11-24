using Riding.Heroes;
using Riding.Interfaces;

namespace Riding.Factories;

public class RogueFactory : IHeroFactory
{
    public IHero Create(string name) => new Rogue(name);
}
