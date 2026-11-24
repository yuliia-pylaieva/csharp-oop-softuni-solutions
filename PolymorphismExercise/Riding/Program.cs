using Riding.Factories;
using Riding.Heroes;
using Riding.Interfaces;

namespace Riding;

public class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, IHeroFactory> factories = GetFactories();
        List<IHero> heroes = new List<IHero>();

        int number = int.Parse(Console.ReadLine());

        while (heroes.Count < number)
        {
            string name = Console.ReadLine();
            string type = Console.ReadLine();

            if (!factories.ContainsKey(type)) Console.WriteLine("Invalid hero!");
            else
            {
                IHero hero = factories[type].Create(name);
                heroes.Add(hero);
            }
        }
        int bossPower = int.Parse(Console.ReadLine());
        

        int heroesPower = 0;
        foreach (IHero hero in heroes)
        {
            Console.WriteLine(hero.CastAbility());
            heroesPower += hero.Power;
        }
        Console.WriteLine(heroesPower >= bossPower ? $"Victory!" : $"Defeat...");
    }
    private static Dictionary<string, IHeroFactory> GetFactories() => new Dictionary<string, IHeroFactory>()
    {
        [nameof(Druid)] = new DruidFactory(),
        [nameof(Paladin)] = new PaladinFactory(),
        [nameof(Rogue)] = new RogueFactory(),
        [nameof(Warrior)] = new WarriorFactory()
    };
}
