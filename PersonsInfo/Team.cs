namespace PersonsInfo;

public class Team
{
    private string _name;
    private readonly List<Person> _firstTeam;
    private readonly List<Person> _reservedTeam;

    public Team(string name)
    {
        if(string.IsNullOrWhiteSpace(name))
            throw new ArgumentNullException(nameof(name));
        _name = name;
        _firstTeam = new List<Person>();
        _reservedTeam = new List<Person>();
    }

    public IReadOnlyCollection<Person> FirstTeam => _firstTeam.AsReadOnly();
    
    public IReadOnlyCollection<Person> ReservedTeam => _reservedTeam.AsReadOnly();
  

    public void AddPlayer(Person player)
    {
        if (player.Age < 40)
        {
            _firstTeam.Add(player);
        }
        else
        {
            _reservedTeam.Add(player);
        }
    }

    public override string ToString() => 
        $"First team has {FirstTeam.Count} players." +
        $"{Environment.NewLine}Reserve team has {ReservedTeam.Count} players.";
}



