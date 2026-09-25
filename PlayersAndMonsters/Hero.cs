namespace PlayersAndMonsters;

public class Hero
{
    private int _level;

    private string _username;

    public Hero(string username, int level)
    {
        Username = username;
        Level = level;
    }

    public string Username { get; set; }
    public int Level { get; set; }


    public override string ToString()

    {
        return $"Type: {GetType().Name} Username: {this.Username} Level: {Level}";
    }
}