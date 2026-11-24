namespace Riding.Heroes;

public class Rogue: BaseHero
{
    public Rogue(string name) : base(name)
    {
    }

    public override int Power => 80;
    public override string CastAbility() => CastHittingAbility();
}