using Riding.Interfaces;

namespace Riding.Heroes;

public abstract class BaseHero : IHero
{
    protected BaseHero(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public abstract int Power { get; }
    public abstract string CastAbility();
    protected string CastHealingAbility() => $"{this.GetType().Name} - {this.Name} healed for {this.Power}";
    protected string CastHittingAbility() => $"{this.GetType().Name} - {this.Name} hit for {this.Power} damage";
    
}